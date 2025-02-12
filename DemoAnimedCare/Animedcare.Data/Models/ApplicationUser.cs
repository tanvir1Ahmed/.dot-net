using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace Animedcare.Data.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        [NotMapped]
        public string TempPassword { get; set; }
        [NotMapped]
        public override string Id { get; set; }
        [DataType(DataType.Date)]
        public DateTime? DOB { get; set; }
        public string Gender { get; set; }
        public string EmployeeCode { get; set; }
        public bool? IsActive { get; set; }
        public string Occupation { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public DateTime JoiningDate { get; set; }
        public string EmergencyContactName { get; set; }
        public string EmergencyContactNumber { get; set; }
        public string EmergencyContactRelationship { get; set; }
        public List<Pet> Pets { get; set; }

        [NotMapped]
        public double BookingAmount { get; set; }

        [NotMapped]
        public double CancellationFee { get; set; }
    }
}
