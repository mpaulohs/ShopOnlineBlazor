using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Shared.Models;
using Shared.Services.Repository;
using Shared.Services.Request.Filter;
using Shared.Services.Request.OrderBy;
using Shared.Services.Request.Search;
namespace Api.Data;
public class RepositoryBase<TEntity, TKey, TDbContext> :
 IDisposable,
 IRepository<TEntity, TKey>
 where TEntity : class, IApplicationEntity<TKey>
 where TDbContext : DbContext
 where TKey : IEquatable<TKey>
{
    public RepositoryBase(IMapper mapper, TDbContext context, ILogger<TEntity> logger)
    {
        _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        _context = context ?? throw new ArgumentNullException(nameof(context));
        _logger = logger ?? throw new ArgumentNullException(nameof(logger));
    }
    protected IMapper _mapper { get; private set; }
    protected TDbContext _context { get; private set; }
    protected ILogger<TEntity> _logger { get; private set; }
    protected IQueryable<TEntity> _entities { get { return _context.Set<TEntity>(); } }
    public bool AutoSaveChanges { get; set; } = true;
    private bool _disposed;
    protected void ThrowIfDisposed()
    {
        if (_disposed)
        {
            throw new ObjectDisposedException(GetType().Name);
        }
    }
    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }
    protected virtual void Dispose(bool disposing)
    {
        if (_disposed)
        {
            return;
        }
        if (disposing)
        {
            _disposed = true;
        }
    }
    protected virtual async Task<bool> SaveChanges(CancellationToken cancellationToken)
    {
        if (AutoSaveChanges)
        {
            await _context.SaveChangesAsync(cancellationToken);
            return true;
        }
        return false;
    }
    public virtual async Task<TKey> CreateAsync(TEntity entity, CancellationToken cancellationToken = default)
    {
        cancellationToken.ThrowIfCancellationRequested();
        ThrowIfDisposed();
        if (entity == null)
        {
            //ToDo: Change results to Action results /return StatusCode
            _logger.LogError("An exception on {0}", System.Reflection.MethodBase.GetCurrentMethod()?.Name);
            throw new ArgumentNullException(nameof(entity));
        }
        //Change properyes before Creating
        entity.Id = default;
        entity.CreatedAt = DateTime.Now;
        entity.UpdatedAt = default;
        var result = await _context.AddAsync(entity, cancellationToken);
        try
        {
            await SaveChanges(cancellationToken);
        }
        catch (Exception exception)
        {
            _logger.LogError("An exception on {0}", System.Reflection.MethodBase.GetCurrentMethod()?.Name);
            throw new Exception(exception.Message, exception);
        }
        return result.Entity.Id;
    }
    public virtual async Task<TEntity> GetByIdAsync(TKey id, CancellationToken cancellationToken = default)
    {
        cancellationToken.ThrowIfCancellationRequested();
        ThrowIfDisposed();
        return await _entities.AsNoTracking().SingleOrDefaultAsync(e => e.Id.Equals(id), cancellationToken);
    }
    public virtual async Task<bool> UpdateAsync(TKey id, TEntity newEntity, CancellationToken cancellationToken = default)
    {
        cancellationToken.ThrowIfCancellationRequested();
        ThrowIfDisposed();
        if (newEntity == null)
        {
            _logger.LogError("An exception on {0}", System.Reflection.MethodBase.GetCurrentMethod()?.Name);
            throw new ArgumentNullException(nameof(newEntity));
        }
        var origEntity = await GetByIdAsync(id, cancellationToken);
        if (origEntity == null)
        {
            _logger.LogError("An exception on {0}", System.Reflection.MethodBase.GetCurrentMethod()?.Name);
            throw new NullReferenceException(nameof(origEntity));
        }
        if (newEntity.ConcurrencyStamp != origEntity.ConcurrencyStamp)
        {
            _logger.LogInformation("Can't change {0} to {1}.\nThe original was changed before", origEntity, newEntity);
            throw new Exception("The entity was changed by another request. Place update your data");
        }
        //ToDo: Check about paralel changed models
        //Context.Attach(origEntity);
        newEntity.Id = id;
        newEntity.CreatedAt = origEntity.CreatedAt;
        newEntity.UpdatedAt = DateTime.Now;
        newEntity.ConcurrencyStamp = Guid.NewGuid().ToString();
        try
        {
            _context.Update(newEntity);
            return await SaveChanges(cancellationToken);
        }
        catch (Exception exception)
        {
            _logger.LogError("An exception on {0}", System.Reflection.MethodBase.GetCurrentMethod()?.Name);
            throw new Exception(exception.Message, exception);
        }
    }
    public virtual async Task<bool> UpdatePartyalAsync(TKey id, JsonPatchDocument entity, CancellationToken cancellationToken = default)
    {
        cancellationToken.ThrowIfCancellationRequested();
        ThrowIfDisposed();
        if (entity == null)
        {
            _logger.LogError("An exception on {0}", System.Reflection.MethodBase.GetCurrentMethod()?.Name);
            throw new ArgumentNullException(nameof(entity));
        }
        var origEntity = await GetByIdAsync(id, cancellationToken);
        if (origEntity == null)
        {
            _logger.LogError("An exception on {0}", System.Reflection.MethodBase.GetCurrentMethod()?.Name);
            throw new NullReferenceException(nameof(origEntity));
        }
        try
        {
            _context.Attach(origEntity);
            entity.ApplyTo(origEntity);
            origEntity.UpdatedAt = DateTime.Now;
            origEntity.Id = id;
            return await SaveChanges(cancellationToken);
        }
        catch (Exception exception)
        {
            _logger.LogError("An exception on {0}", System.Reflection.MethodBase.GetCurrentMethod()?.Name);
            throw new Exception(exception.Message, exception);
        }
    }
    public virtual async Task<bool> DeleteAllAsync(CancellationToken cancellationToken = default)
    {
        cancellationToken.ThrowIfCancellationRequested();
        ThrowIfDisposed();
        var entityes = _entities;
        foreach (var entity in entityes)
        {
            _context.Remove(entity);
        }
        try
        {
            return await SaveChanges(cancellationToken);
        }
        catch (Exception exception)
        {
            _logger.LogError("An exception on {0}", System.Reflection.MethodBase.GetCurrentMethod()?.Name);
            throw new Exception(exception.Message, exception);
        }
    }
    public virtual async Task<bool> DeleteAsync(TKey id, CancellationToken cancellationToken = default)
    {
        try
        {
            cancellationToken.ThrowIfCancellationRequested();
            ThrowIfDisposed();
            var entity = await GetByIdAsync(id, cancellationToken);
            if (entity == default)
            {
                _logger.LogError("An exception on {0}", System.Reflection.MethodBase.GetCurrentMethod()?.Name);
                throw new ArgumentNullException(nameof(entity));
            }
            //ToDo check if this is correct way
            _context.Remove<TEntity>(entity);
            return await SaveChanges(cancellationToken);
        }
        catch (System.Exception)
        {
            return false;
        }
    }
    public async Task<(IEnumerable<TOut>, int)>? GetAsync<TOut>(
    string search = default,
    string filter = default,
    string orderBy = default,
    int take = default,
    int skip = default,
    CancellationToken cancellationToken = default)
    {
        cancellationToken.ThrowIfCancellationRequested();
        ThrowIfDisposed();
        //Get all entities wisout skip and take
        //ToDo optimize function
        var all = Get(search, filter, orderBy, cancellationToken: cancellationToken);
        int count = all.Count();
        if (count == 0)
        {
            return (null, 0);
        }
        var entities = Get(search, filter, orderBy, take, skip, cancellationToken);
        var result = await _mapper.ProjectTo<TOut>(entities).ToListAsync<TOut>();
        return (result, count);
    }
    public async Task<IEnumerable<TEntity>>? GetAsync(
    string search = default,
    string filter = default,
    string orderBy = default,
    int take = default,
    int skip = default,
    CancellationToken cancellationToken = default)
    {
        cancellationToken.ThrowIfCancellationRequested();
        ThrowIfDisposed();
        var entities = Get(search, filter, orderBy, take, skip, cancellationToken);
        return await entities.ToListAsync<TEntity>();
    }
    private IQueryable<TEntity> Get(
    string search = default,
    string filter = default,
    string orderBy = default,
    int take = default,
    int skip = default,
    CancellationToken cancellationToken = default)
    {
        cancellationToken.ThrowIfCancellationRequested();
        ThrowIfDisposed();
        var entities = _entities;
        //Search
        if (search != default)
        {
            entities = entities.Search(search);
        }
        //Filter
        if (filter != default)
        {
            entities = entities.FilterByRules(filter);
        }
        //Sort
        if (orderBy != default)
        {
            entities = entities.OrderByPropertyOrField(orderBy);
        }
        //Skip
        if (skip != default)
        {
            entities = entities.Skip<TEntity>(skip);
        }
        //Take
        if (take != default)
        {
            entities = entities.Take<TEntity>(take);
        }
        return entities;

    }
}