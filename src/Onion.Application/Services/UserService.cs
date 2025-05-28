using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Onion.Application.DTOs;
using Onion.Application.Service_Interfaces;
using Onion.Domain.Entities;
using Onion.Domain.Pure_Interfaces.IRepositories;

namespace Onion.Application.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository userRepository;

        public UserService(IUserRepository userRepository)
        {
            this.userRepository = userRepository;
        }

        public async Task<CreateUserDTO> CreateUser (CreateUserDTO usertocreate)
        {
            CreateUserDTO user = new CreateUserDTO();

            UserEntity userEntity = new UserEntity
            {
                first_name = usertocreate.first_name,
                last_name = usertocreate.last_name
            };

            await userRepository.CreateUser(userEntity);
            return user;
       }
    }
}