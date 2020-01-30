using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Models
{
    public class Employee
    {
        public Employee(string First, string Last)
        {
            this.First = First;
            this.Last = Last;
        }
        public Employee() { }
        [Required]
        public int Id { get; set; }
        [Required]
        [RegularExpression(@"^[A-Za-z]*$", ErrorMessage = "Must only contain letters")]
        public string First { get; set; }
        [Required]
        [RegularExpression(@"^[A-Za-z]*$", ErrorMessage = "Must only contain letters")]
        public string Last { get; set; }
        [Required]
        [RegularExpression(@"^[0-9]*$", ErrorMessage = "Must only contain numbers")]
        public int Month { get; set; }
        [Required]
        [RegularExpression(@"[0-9]*$", ErrorMessage = "Must only contain numbers")]
        public int Year { get; set; }
        [Display(Name = "Employee Type")]
        public int EmployeeTypeID { get; set; }
        [ForeignKey("EmployeeTypeID")]
        [DisplayName("Employee Type")]
        public EmployeeType EmployeeType { get; set; }
        private int CalculatePayment;
        [DisplayName("Calculate Payment")]
        public virtual int _CalculatePayment
        {
            get
            {
                return 20000 + 500 * Year;
            }
            set
            {
                CalculatePayment = value;
            }
        }
        private string EmployeeCode;
        [DisplayName("Employee Code")]
        public virtual String _EmployeeCode
        {
            get
            {
                return "EMP" + First.Substring(0, 2) + Last.Substring(0, 2) + Year.ToString();
            }
            set
            {
                EmployeeCode = value;
            }
        }
        public String FullName
        {
            get
            {
                return Last + ", " + First;
            }
        }
    }
}
