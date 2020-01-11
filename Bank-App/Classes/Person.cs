using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_App.Classes
{
    public class Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string City { get; set; }
        public string ZipCode { get; set; }
        public string Pesel { get; set; }
        public string PhoneNumber { get; set; }

        public Person()
        {
            Name = "";
            Surname = "";
            DateOfBirth = DateTime.Now;
            City = "";
            ZipCode = "";
            Pesel = "";
            PhoneNumber = "";
        }

        public Person(string name, string surname, DateTime dateOfBirth, string city, string zipCode, string pesel, string phonenumber)
        {
            Name = name;
            Surname = surname;
            DateOfBirth = dateOfBirth;
            City = city;
            ZipCode = zipCode;
            Pesel = pesel;
            PhoneNumber = phonenumber;
        }


    }
}
