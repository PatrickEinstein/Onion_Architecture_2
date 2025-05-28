using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Onion.Domain.Entities;
using Onion.Domain.Pure_Interfaces.IRepositories;
using Onion.Infrastrucure.Configurations;

namespace Onion.Infrastrucure.Repositories
{
    public class UserRepository:IUserRepository
    {
        private readonly OnionDbContext dbcontext;

        public UserRepository(OnionDbContext dbcontext)
        {
            this.dbcontext = dbcontext;
        }


        public async Task<bool> CreateUser(UserEntity user)
        {
           await dbcontext.AddAsync(user);
            return true;
        }
    }
}