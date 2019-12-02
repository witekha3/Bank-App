using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_App.Classes
{
    class Admin : User
    {
        public Admin(string login, string password, string email) : base(login, password, email)
        {

        }
    }
}
