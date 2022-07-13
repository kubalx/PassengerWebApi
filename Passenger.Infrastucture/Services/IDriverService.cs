using Passenger.Infrastucture.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace Passenger.Infrastucture.Services
{
    public interface IDriverService
    {
        DriverDto Get(Guid userId);
    }
}
