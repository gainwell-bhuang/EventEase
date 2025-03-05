using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EventEase.Services
{
    public class UserSessionService
    {
        private string? _userName;
        private string? _userEmail;

        public bool IsUserLoggedIn => !string.IsNullOrEmpty(_userEmail);

        public void SetUser(string name, string email)
        {
            _userName = name;
            _userEmail = email;
        }

        public (string? Name, string? Email) GetUser() => (_userName, _userEmail);
    }
}