using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animedcare.Data.Models
{
    public interface IBaseEntity
    {
        string CreatedBy { get; set; }
        DateTime CreatedOnUtc { get; set; }
        string? UpdatedBy { get; set; }
        DateTime? UpdatedOnUtc { get; set; }
    }
    public class BaseEntity<TId> : IBaseEntity
    {
        [Key]
        public TId Id { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOnUtc { get; set; }
        public string? UpdatedBy { get; set; }
        public DateTime? UpdatedOnUtc { get; set; }
    }
}
