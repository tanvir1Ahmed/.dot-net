using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Animedcare.Data.Paginations;

namespace Animedcare.Data.Employees
{
    public class EmployeeListViewModel
    {
        public List<UserDto> Data { get; set; }
        public int TotalPages { get; set; }
        public PaginationRequest PaginationRequest { get; set; }
    }

    public class UserDto
    {
        public int Id { get; set; }

        public string EnglishName { get; set; }

        public DateTime? DateOfBirth { get; set; }

        public string Email { get; set; }
        public string EmployeeCode { get; set; }

        public string ContactNumber { get; set; }

        public string Status { get; set; }

        public DateTime? JoinedDate { get; set; }

        public int EmployeeId { get; set; }

        public DateTime? ResignationDate { get; set; }
    }
}
