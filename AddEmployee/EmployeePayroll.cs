using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO.NET
{
    public class EmployeePayroll
    {
        public int Id { get; set; }
        public string Name { get; set; }  
        public double Salary { get; set; }
        public DateTime StartDate { get; set; }
        public char Gender { get; set; }
        public long PhoneNumber { get; set; }
        public string Department { get; set; }
        public string Address { get; set; }
        public double BasicSalary { get; set; }
        public double Deductions { get; set; }
        public double TaxablePay { get; set; }
        public double IncomeTax { get; set; }
        public double NetPay { get; set; }

    }
}
