using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Models
{
    public class EmployeeType
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int EmployeeTypeID { get; set; }
        public string EmployeeDiscription { get; set; }
    }
}
