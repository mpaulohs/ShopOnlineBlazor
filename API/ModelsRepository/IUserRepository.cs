using ShopOnlinePWA.Library.Catalogs;
using ShopOnlinePWA.Library.Identity;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace API.ModelsRepository
{
    public interface IUserRepository
    {
        public Task<User> Create(User appUser);
        public Task<List<User>> GetAll();
        public Task<User> Update(Guid id, User appUser);
        public Task<bool> Delete(Guid guid);
        public Task<User> GetById(Guid id);
        public Task<User> GetByName(string name);
        public Task<User> GetByEmail(string email);
    }
}
            

