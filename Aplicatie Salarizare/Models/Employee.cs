using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Aplicatie_Salarizare.Models
{
    public class Employee
    {
        public Int32 Id { get; set; }
        public string Lastname { get; set; }
        public string Surname { get; set; }
        public string Position { get; set; }
        public Int32 Base_Salary { get; set; }
        public Int32 Increase { get; set; }
        public Int32 Gross_Prizes { get; set; }
        public Int32 Gross_Total { get; set; }
        public Int32 Taxable_Gross { get; set; }
        public Int32 CAS { get; set; }
        public Int32 CASS { get; set; }
        public Int32 Tax { get; set; }
        public Int32 Deductions { get; set; }
        public Int32 Net_Salary { get; set; }
    }
}
