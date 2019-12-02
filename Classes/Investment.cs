﻿using Bank_App.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_App.Classes
{
    class Investment
    {
        public int Id { get; set; }
        public InvestmentTypes InvestmentType { get; set; }
        public decimal Value { get; set; }
        public DateTime Duration { get; set; }
        public double Interest { get; set; }

        public Investment()
        {
            Id = 0;
            InvestmentType = InvestmentTypes.NOT_DEFINED;
            Value = 0.0M;
            Duration = new DateTime(0, 0, 360);
            Interest = 0.0;
        }
        public Investment(int id, InvestmentTypes investmentType, decimal value, DateTime duration, double interest)
        {
            Id = id;
            InvestmentType = investmentType;
            Value = value;
            Duration = duration;
            Interest = interest;
        }
    }
}
