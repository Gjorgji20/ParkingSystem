﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingSystem.ParkingSys
{
    public class Company
    {
        public string CompanyName { get; set; }
        public int EmployeeNumbers { get; set; }
        public int FoundationYear { get; set; }

        public Company()
        {

        }

        public Company(string companyName, int employeeNumbers, int foundationYear)
        {
            CompanyName = companyName;
            EmployeeNumbers = employeeNumbers;
            FoundationYear = foundationYear;
        }
    }
}
