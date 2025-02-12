using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Animedcare.Data.Employees;
using Animedcare.Data.Paginations;
using Animedcare.Repository;

namespace Animedcare.Service.EmployeesService
{
    public class EmployeeService :IEmployeeService
    {
        private readonly IEmployeeRepository _employeeRepository;

        public EmployeeService(IEmployeeRepository employeeRepository)
        {
            this._employeeRepository = employeeRepository;
        }
        public async Task<EmployeeListViewModel> GetAllEmployees(PaginationRequest request)
        {
            var employees = await _employeeRepository.GetEmployeeAsync(request);
            int totalPages = (int)Math.Ceiling((double)employees.TotalCount / request.PageSize);
            var userList = new List<UserDto>();
            foreach (var employee in employees.Employees)
            {
                var employeeListModel = new UserDto
                {
                    Id = employee.Id,
                    EnglishName = employee.EnglishName,
                    DateOfBirth = employee.DateOfBirth?.ToLocalTime(),
                    JoinedDate = employee.JoiningDate.ToLocalTime(),
                    Email = employee.ApplicationUser.Email,
                    EmployeeCode = employee.EmployeeCode,
                    ContactNumber = employee.ApplicationUser.PhoneNumber,
                    Status = employee.ApplicationUser.IsActive ?? true ? "Active" : "Inactive",
                    ResignationDate = employee.ResignationDate?.ToLocalTime()
                };
                userList.Add(employeeListModel);
            }

            var employeeList = new EmployeeListViewModel()
            {
                Data = userList,
                TotalPages = totalPages,
                PaginationRequest = request
            };

            return employeeList;
        }
    }
}
