using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Animedcare.Data.Employees;
using Animedcare.Data.Paginations;
using Microsoft.EntityFrameworkCore;

namespace Animedcare.Repository
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly AppDbContext _dbContext;

        public EmployeeRepository(AppDbContext dbContext)
        {
            this._dbContext = dbContext;
        }
        public async Task<(List<Employee> Employees, long TotalCount)> GetEmployeeAsync(PaginationRequest request)
        {
            var employeesQuery = _dbContext.Employees.Include(x => x.ApplicationUser).AsNoTracking().AsQueryable();

            if (!string.IsNullOrWhiteSpace(request.Search))
            {
                var searchTerm = request.Search.ToLower();
                employeesQuery = employeesQuery.Where(p =>
                    p.EnglishName.ToLower().Contains(searchTerm) ||
                    p.ApplicationUser.PhoneNumber.ToLower().Contains(searchTerm) ||
                    p.ApplicationUser.Email.ToLower().Contains(searchTerm) ||
                    p.EmployeeCode.ToLower().Contains(searchTerm)
                );
            }
            var totalCount = await employeesQuery.CountAsync();

            var employees = await employeesQuery
                                .Skip((request.PageNumber - 1) * request.PageSize)
                                .Take(request.PageSize)
                                .ToListAsync();
            return (employees, totalCount);
        }
    }
}
