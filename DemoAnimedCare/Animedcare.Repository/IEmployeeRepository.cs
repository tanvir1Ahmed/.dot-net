using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Animedcare.Data.Employees;
using Animedcare.Data.Paginations;

namespace Animedcare.Repository
{
    public interface IEmployeeRepository
    {
        Task<(List<Employee> Employees, long TotalCount)> GetEmployeeAsync(PaginationRequest request);
    }
}
