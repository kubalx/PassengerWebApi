﻿using Passenger.Core.Domain;
using Passenger.Core.Repositories;
using Passenger.Infrastucture.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace Passenger.Infrastucture.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public UserDto Get(string email)
        {
            var user = _userRepository.Get(email);
            return new UserDto
            {
                Id = user.Id,
                Username = user.Username,
                Email = user.Email,
                FullName = user.FullName
            };
        }

        public void Register(string email, string username , string password)
        {
            var user = _userRepository.Get(email);
            throw new Exception($"User with email: '{email}' already exists.");

            var salt = Guid.NewGuid().ToString("N");
            user = new User(email, username, password, salt);
            _userRepository.Add(user);
        }
    }
}
