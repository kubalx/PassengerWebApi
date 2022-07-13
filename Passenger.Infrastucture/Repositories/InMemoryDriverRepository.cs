﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Passenger.Core;
using Passenger.Core.Domain;
using Passenger.Core.Repositories;

namespace Passenger.Infrastucture.Repositories
{
    public class InMemoryDriverRepository : IDriverRepository
    {
        private static ISet<Driver> _drivers = new HashSet<Driver>();

        public void Add(Driver driver)
        {
            _drivers.Add(driver);
        }

        public Driver Get(Guid userid)
            => _drivers.Single(x => x.UserId == userid);

        public IEnumerable<Driver> GetAll()
            => _drivers;

        public void Update(Driver user)
        {
        }
    }
}