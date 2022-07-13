using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Passenger.Core.Domain
{
    public class User
    {
        private static readonly Regex NameRegex = new Regex("^[A-Z][a-zA-Z]*$");
        public Guid Id { get; protected set; }
        public string Email { get; protected set; }
        public string Password { get; protected set; }
        public string Salt { get; protected set; }
        public string Username { get; protected set; }
        public string FullName { get; protected set; }
        public DateTime CreatedAt { get; protected set; }
        public DateTime UpdatedAt { get; protected set; }
    
        protected User()
        {

        }
        public User(string email, string username, string password, string salt)
        {
            Id = Guid.NewGuid();
            Email = email.ToLowerInvariant();
            Username = username;
            Password = password;
            Salt = salt;
            CreatedAt = DateTime.UtcNow;
        }
        public void SetUsername(string username)
        {
            if (!NameRegex.IsMatch(username))
            {
                throw new Exception("Username is invalid.");
            }
            Username = username.ToLowerInvariant();
            UpdatedAt = DateTime.UtcNow;
        }
        public void SetEmail(string email)
        {
            if (!NameRegex.IsMatch(email))
            {
                throw new Exception("Email is invalid.");
            }
            Email = Email.ToLowerInvariant();
            UpdatedAt = DateTime.UtcNow;
        }

        public void SetPassword(string password)
        {
            if (string.IsNullOrWhiteSpace(password))
                throw new Exception("Password can not be empty.");
            if (password.Length < 4)
                throw new Exception("Password must contain at least 4 characters.");
            if (password.Length < 4)
                throw new Exception("Password can not contain more than 100 characters.");
            if (Password == password)
                throw new Exception("Password can not be empty.");
        }

    }
}
