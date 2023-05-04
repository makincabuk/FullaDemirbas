using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Employee
    {
        [Key]
        public int EmployeeId { get; set; }
        [StringLength(100)]
        public string Employeename { get; set; }
        [StringLength(100)]
        public string EmployeeSurName { get; set; }
        [StringLength(1000)]
        public string EmployeeImage { get; set; }
        [StringLength(100)]
        public string EmployeeMail { get; set; }
        [StringLength(100)]
        public string EmployeePassword { get; set; }
        public ICollection<Content> contents { get; set; }
        public ICollection<Heading> headings { get; set; }
    }
}
