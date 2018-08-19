using System;
using System.Collections.Generic;
using System.Text;

namespace DataLayer.Models
{
    public class User
    {
        public bool IsAdmin { get; }
        public string Login { get; }
        public string Password { get; }
        public Guid UserId { get; }

        public User(bool isAdmin, string login, string password, Guid userId)
        {
            IsAdmin = isAdmin;
            Login = login;
            Password = password;
            UserId = userId;
        }
    }
}
