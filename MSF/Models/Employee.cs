using MSF.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace MSF.Models
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public EmployeeType EmployeeType { get; set; }
        public string Name { get; set; }
    }
}
