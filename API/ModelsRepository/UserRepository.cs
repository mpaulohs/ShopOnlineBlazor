using API.ModelsRepository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using ShopOnlinePWA.API.Migrations.AppIdentityDb;
using ShopOnlinePWA.Library.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopOnlinePWA.API.ModelsRepository
{
    public class UserRepository : IEntityRepository<User>
    {
        private readonly AppIdentityDbContext _context;
        private readonly ILogger _logger;

        public UserRepository(AppIdentityDbContext _context, ILogger _logger)
        {
            this._context = _context;
            this._logger = _logger;
        }

        public async Task<ActionResult<User>> Create(User entity)
        {
            try
            {
                var result = await _context.Users.AddAsync(entity);
                await _context.SaveChangesAsync();
                return result.Entity;
            }
            catch (Exception ex)
            {
                this._logger.LogError(ex, "An error occurred while create user entity in database.");
                throw new Exception();
            }
        }

        public async Task<ActionResult<IEnumerable<User>>> Read()
        {
            try
            {
                return await _context.Users.ToListAsync();
            }
            catch (Exception ex)
            {
                this._logger.LogError(ex, "An error occurred while read all users entity from database.");
                throw new Exception();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns>User if fidn and null if not find</returns>
        /// <exception cref="Exception"></exception>
        public async Task<ActionResult<User>> Read(Guid id)
        {
            try
            {
                return await _context.Users.FindAsync(id);

            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An error occurred while read user entity by id  from database.");
                throw new Exception();
            }
        }

        public Task<ActionResult<IEnumerable<User>>> Read(IEnumerable<ShopOnlinePWA.Library.Helpers.RequestHelper<Object, Object>> requestHelpers)
        {
            throw new Exception();
            //try
            //{
            //    //ToDo Create Universal functon
            //    //property
            //    //operator (egual, lte, gte)
            //    //value
            //    int offset = 0;
            //    int limit = 0;
            //    string filters = String.Empty;
            //    string sortings = String.Empty;
            //    string searchs = String.Empty;

            //    //ToDo check this behavior
            //    var users = _context.Users;
            //    foreach ((string key, object value) in parameters)
            //    {
            //        //users.Where(e => e.GetType().GetProperty(key).GetValue(e) == value);

            //    }
            //    return users.ToList();

            //}
            //catch (Exception)
            //{

            //    throw;
            //}

        }

        public async Task<ActionResult<User>> Update(User entity)
        {


            var updatedEntity = await _context.Users.FirstOrDefaultAsync(e => e.Id == entity.Id);
            if (updatedEntity == null)
            {
                //ToDo Bad Request
                return null;
            }

            _context.Entry(entity).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
                //ToDo Check
                return entity;
            }
            catch (DbUpdateConcurrencyException ex)
            {

                if (!EntityExists(entity.Id))
                {
                    //ToDo NotFound
                    return null;
                }
                else
                {
                    this._logger.LogError(ex, "An error occurred while create user entity in database.");
                    throw;
                }
            }


        }


        //public async Task<ActionResult<User>> Update(Guid id, IDictionary<string, object> parameters)
        //{
        //    try
        //    {
        //        var updatedEntity = await _context.Users.FirstOrDefaultAsync(e => e.Id == id);
        //        if (updatedEntity != null)
        //        {
        //            var entityType = updatedEntity.GetType();

        //            foreach (var parameter in parameters)
        //            {
        //                var property = entityType.GetProperty(parameter.Key, System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Instance);
        //                var field = entityType.GetField(parameter.Key, System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Instance);

        //                if (property != null && property.CanWrite)
        //                {
        //                    property.SetValue(updatedEntity, parameter.Value, null);
        //                }
        //                else if (field != null)
        //                {
        //                    field.SetValue(updatedEntity, parameter.Value);
        //                }
        //            }
        //            await _context.SaveChangesAsync();

        //            return updatedEntity;
        //        }
        //        else
        //        {
        //            return null;
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        this._logger.LogError(ex, "An error occurred while create user entity in database.");
        //        throw new Exception();
        //    }
        //}


        public async Task<ActionResult<User>> Update(Guid id, User entity)
        {
            if (id != entity.Id)
            {
                //ToDo BadRequest();
                return null; 
            }


            _context.Attach(entity);


            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EntityExists(id))
                {
                    //ToDo NotFound()
                    return null;
                }
                else
                {
                    throw;
                }
            }

            //ToDo NoContent()
            return null;
        }

        public async Task<ActionResult> Delete()
        {
            try
            {
                foreach (var entity in _context.Users)
                {
                    _context.Users.Remove(entity);
                }
                await _context.SaveChangesAsync();
                //ToDo Change to normal ActionResult
                return new EmptyResult();
            }
            catch (Exception ex)
            {
                this._logger.LogError(ex, "An error occurred while deleting all users in database.");
                throw new Exception();
            }
        }

        public async Task<ActionResult> Delete(User entity)
        {
            try
            {
                _context.Users.Remove(entity);
                await _context.SaveChangesAsync();
                //ToDo Check return value
                return new EmptyResult();
            }
            catch (Exception ex)
            {
                this._logger.LogError(ex, "An error occurred while deleting user in database.");
                throw new Exception();
            }
        }

        public async Task<ActionResult> Delete(Guid id)
        {
            try
            {
                var entity = await _context.Users
                    .FirstOrDefaultAsync(e => e.Id == id);

                if (entity != null)
                {
                    _context.Users.Remove(entity);
                    await _context.SaveChangesAsync();
                    //ToDo Check return value
                    return new EmptyResult();
                }
                return new EmptyResult();

            }
            catch (Exception ex)
            {
                this._logger.LogError(ex, "An error occurred while deleting user by guid in database.");
                throw new Exception();
            }
        }

        private bool EntityExists(Guid id)
        {
            return _context.Users.Any(e => e.Id == id);
        }
    }
}
