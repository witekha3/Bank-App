using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_App.Classes
{
    class Client : User
    {
        public string AccountNumber { get; set; }
        public decimal Balance { get; set; }

        public Client() : base()
        {
            AccountNumber = "";
            Balance = 100.0M;
        }

        public Client(string accountNumber, string login, string password, string email, bool isAdmin, string name,
            string surname, DateTime dateOfBirth, string city, string zipCode, string pesel, string phoneNumber) 
            : base(login, password, email, isAdmin, name, surname, dateOfBirth, city, zipCode, pesel, phoneNumber)
        {
            AccountNumber = accountNumber;
            Balance = 100.0M;
        }

        public Client(string login, string password, string email)  : base(login, password, email)
        {
            AccountNumber = "";
            Balance = 100.0M;
        }

    }
}
