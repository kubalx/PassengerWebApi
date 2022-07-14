using Passenger.Infrastucture.DTO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Passenger.Infrastucture.Services
{
    public interface IDriverService
    {
        Task<DriverDto> GetAsync(Guid userId);
    }
}
