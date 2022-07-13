using Passenger.Core.Domain;
using Passenger.Core.Repositories;
using Passenger.Infrastucture.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace Passenger.Infrastucture.Services
{
    public class DriverService : IDriverService
    {
        private readonly IDriverRepository _driverRepository;
        public DriverService(IDriverRepository driverRepository)
        {
            _driverRepository = driverRepository;
        }

        public DriverDto Get(Guid userId)
        {
            var user = _driverRepository.Get(userId);
            return new DriverDto { };
        }
    }
}
