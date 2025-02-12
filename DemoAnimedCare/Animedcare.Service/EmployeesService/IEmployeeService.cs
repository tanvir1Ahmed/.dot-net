using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Animedcare.Data.Employees;
using Animedcare.Data.Paginations;

namespace Animedcare.Service.EmployeesService
{
    public interface IEmployeeService
    {
        Task<EmployeeListViewModel> GetAllEmployees(PaginationRequest request);
    }
}
