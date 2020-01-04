using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_App.Classes
{
    class User : Person
    {
        public string Login { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public bool IsAdmin { get; set; }

        public User() : base()
        {
            Login = "";
            Password = "";
            Email = "";
            IsAdmin = false;
        }

        public User(string login, string password, string email, bool isAdmin, string name, string surname,
            DateTime dateOfBirth, string city, string zipCode, string pesel, string phoneNumber) 
            : base(name, surname, dateOfBirth, city, zipCode, pesel, phoneNumber)
        {
            Login = login;
            Password = password;
            Email = email;
            IsAdmin = isAdmin;
        }

        public User(string login, string password, string email)
            : base()
        {
            Login = login;
            Password = password;
            Email = email;
            IsAdmin = false;
        }
    }
}
