using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Passenger.Core.Domain
{
    public class Node
    {
        private static readonly Regex NameRegex = new Regex("^[A-Z][a-zA-Z]*$");
        public string Address { get; protected set; }
        public double Longidute { get; protected set; }
        public double Latitude { get; protected set; }
        public DateTime UpdatedAt { get; protected set; }
        protected Node()
        {

        }

        protected Node(string address, double longitude, double latitude)
        {
            SetAdress(address);
            SetLongitude(longitude);
            SetLatitude(latitude);
        }

        public void SetLatitude(double latitude)
        {
            if (Latitude == latitude)
            {
                return;
            }

            Latitude = latitude;
            UpdatedAt = DateTime.UtcNow;
        }

        public void SetLongitude(double longitude)
        {
            if (Longidute == longitude)
            {
                return;
            }

            Longidute = longitude;
            UpdatedAt = DateTime.UtcNow;
        }

        public void SetAdress(string address)
        {
            if (!NameRegex.IsMatch(address))
            {
                throw new Exception("Adress is invalid");
            }
            Address = address;
            UpdatedAt = DateTime.UtcNow;
        }

        public static Node Create(string address, double longitude, double latitude)
            => new Node(address, longitude, latitude);
    }
}
