using System;
using System.Collections.Generic;
using System.Text;

namespace Passenger.Core.Domain
{
    public class PassengerNode
    {
        public Node Node { get; protected set; }
        public Passenger Passanger { get; protected set; }
    }
}
