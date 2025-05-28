using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Onion.Application.DTOs;

namespace Onion.Application.Service_Interfaces
{
    public interface IUserService
    {
        Task<CreateUserDTO> CreateUser(CreateUserDTO usertocreate);
    }
}