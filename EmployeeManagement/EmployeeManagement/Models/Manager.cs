using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Models
{
    public class Manager : Employee
    {
        public Manager (string First, string Last) : base(First, Last) { }
        public Manager () : base() { }

        private int CalculatePayment;
        public override int _CalculatePayment
        {
            get
            {
                return 20000 + 1000 * Year;
            }
            set
            {
                CalculatePayment = value;
            }
        }
        private string EmployeeCode;
        public override String _EmployeeCode
        {
            get
            {
                return "MNG" +"-"+ First.Substring(0, 2) + "-" + Last.Substring(0, 2) + "-" + Year.ToString();
            }
            set
            {
                EmployeeCode = value;
            }
        }
    }
}
