using API.ModelsRepository;
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
        private readonly AppIdentityDbContext appIdentityDbContext;
        private readonly ILogger logger;

        public UserRepository(AppIdentityDbContext appIdentityDbContext, ILogger logger)
        {
            this.appIdentityDbContext = appIdentityDbContext;
            this.logger = logger;
        }

        public async Task<User> Create(User entity)
        {
            try
            {
                var result = await appIdentityDbContext.Users.AddAsync(entity);
                await appIdentityDbContext.SaveChangesAsync();
                return result.Entity;
            }
            catch (Exception ex)
            {
                this.logger.LogError(ex, "An error occurred while create user entity in database.");
                throw new Exception();
            }
        }

        public async Task<ICollection<User>> Read()
        {
            try
            {
                return await appIdentityDbContext.Users.ToListAsync();
            }
            catch (Exception ex)
            {
                this.logger.LogError(ex, "An error occurred while read all users entity from database.");
                throw new Exception();
            }
        }

        public async Task<User> Read(Guid id)
        {
            try
            {
                return await appIdentityDbContext.Users.SingleOrDefaultAsync(e => e.Id == id);
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "An error occurred while read user entity by id  from database.");
                throw new Exception();
            }
        }

        public async Task<ICollection<User>> Read(IDictionary<string, object> parameters)
        {
            try
            {
                //ToDo check this behavior
                var users = appIdentityDbContext.Users;
                foreach ((string key, object value) in parameters)
                {
                    users.Where(e => e.GetType().GetProperty(key).GetValue(e) == value);

                }
                return users.ToList();

            }
            catch (Exception)
            {

                throw;
            }

        }

        public Task<User> Update(User entity)
        {
            throw new NotImplementedException();
        }

        public Task<User> Update(Guid quid, object parameters)
        {
            throw new NotImplementedException();
        }

        public async Task Delete()
        {
            try
            {
                foreach (var entity in appIdentityDbContext.Users)
                {
                    appIdentityDbContext.Users.Remove(entity);
                }
                await appIdentityDbContext.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                this.logger.LogError(ex, "An error occurred while deleting all users in database.");
                throw new Exception();
            }
        }

        public async Task Delete(User entity)
        {
            try
            {
                appIdentityDbContext.Users.Remove(entity);
                await appIdentityDbContext.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                this.logger.LogError(ex, "An error occurred while deleting user in database.");
                throw new Exception();
            }
        }

        public async Task Delete(Guid id)
        {
            try
            {
                var entity = await appIdentityDbContext.Users
                    .FirstOrDefaultAsync(e => e.Id == id);

                if (entity != null)
                {
                    appIdentityDbContext.Users.Remove(entity);
                    await appIdentityDbContext.SaveChangesAsync();
                }

            }
            catch (Exception ex)
            {
                this.logger.LogError(ex, "An error occurred while deleting user by guid in database.");
                throw new Exception();
            }
        }

    }
}
