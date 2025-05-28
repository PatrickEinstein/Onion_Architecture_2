using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Onion.Domain.Entities;

namespace Onion.Domain.Pure_Interfaces.IRepositories
{
    public interface IUserRepository
    {
        Task<bool> CreateUser(UserEntity user);
    }
}