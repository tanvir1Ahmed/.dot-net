using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animedcare.Data.Models
{
    public class Pet
    {
        public string Id { get; set; }
        [Required]
        public string Name { get; set; }
        public DateTime? DateOfBith { get; set; }
        public bool IsActive { get; set; } = true;
        public string Species { get; set; }
        public string Gender { get; set; }

        [ForeignKey("ApplicationUser")]
        public string UserId { get; set; }
        public virtual ApplicationUser User { get; set; }
    }
}
