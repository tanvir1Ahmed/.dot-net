using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Animedcare.Data.Models;

namespace Animedcare.Data.Employees
{
    public class Employee : BaseEntity<int>
    {
        public string EnglishName { get; set; }
        public string BanglaName { get; set; }
        public string Gender { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string BirthCertificateNumber { get; set; }
        public string NIDNumber { get; set; }
        public string TINNumber { get; set; }
        public string BloodGroup { get; set; }
        public string Religion { get; set; }
        public string MaritalStatus { get; set; }
        public string CurrentDesignation { get; set; } // current designation
        public int? CurrentDepartment { get; set; } // current designation
        public DateTime JoiningDate { get; set; }
        public DateTime? ConfirmationDate { get; set; }
        public DateTime? ResignationDate { get; set; }
        public string Nationality { get; set; }
        public string EmployeeCode { get; set; }
        public int? CurrentSupervisorId { get; set; } //current supervisor
        public bool? IsDirectSupervisor { get; set; } // true = direct supervisor, false = sub supervisor

        [ForeignKey("ApplicationUser")]
        public string AspNetUserId { get; set; }
        public ApplicationUser ApplicationUser { get; set; }
    }
}
