using Passenger.Infrastucture.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace Passenger.Infrastucture.Services
{
    public interface IUserService
    {
        UserDto Get(string email);
        void Register(string email, string username, string password);
    }
}
