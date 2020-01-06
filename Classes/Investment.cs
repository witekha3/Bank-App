using Bank_App.Enums;
using Bank_App.Forms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank_App.Classes
{
    class Investment
    {
        public int Id { get; private set; }
        public InvestmentTypes InvestmentType { get; private set; }
        public decimal Value { get; private set; }
        public DateTime Start { get; set; }
        public DateTime Duration { get; private set; }
        public DateTime Finish { get; set; }
        public double Interest { get; private set; }

        public Investment()
        {
            Id = 0;
            InvestmentType = InvestmentTypes.NOT_DEFINED;
            Value = 0.0M;
            Start = DateTime.Now.Date;
            Finish = DateTime.Now.Date;
            Duration = new DateTime(0, 0, 360);
            Interest = 0.0;
        }
        public Investment(int id, InvestmentTypes investmentType, decimal value, DateTime start, DateTime duration, DateTime finish, double interest)
        {
            Id = id;
            InvestmentType = investmentType;
            Value = value;
            Start = start;
            Finish = finish;
            Duration = duration;
            Interest = interest;
        }
       
    }
}
