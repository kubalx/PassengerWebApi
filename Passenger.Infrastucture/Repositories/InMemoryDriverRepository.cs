using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Passenger.Core;
using Passenger.Core.Domain;
using Passenger.Core.Repositories;

namespace Passenger.Infrastucture.Repositories
{
    public class InMemoryDriverRepository : IDriverRepository
    {
        private static ISet<Driver> _drivers = new HashSet<Driver>();

        public async Task<Driver> GetAsync(Guid userid)
            => _drivers.Single(x => x.UserId == userid);

        public async Task AddAsync(Driver driver)
        {
            _drivers.Add(driver);
            await Task.CompletedTask;
        }

        public async Task<IEnumerable<Driver>> GetAllAsync()
            => await Task.FromResult(_drivers);

        public async Task UpdateAsync(Driver user)
        {
            await Task.CompletedTask;
        }
    }
}
