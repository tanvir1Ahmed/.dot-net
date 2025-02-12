using System.Threading.Tasks;
using Animedcare.Data.Paginations;
using Animedcare.Service.EmployeesService;
using Microsoft.AspNetCore.Mvc;

namespace Animedcare.Web.Controllers
{
    public class HumanResourceController : Controller
    {
        private readonly IEmployeeService _employeeService;

        public HumanResourceController(IEmployeeService employeeService)
        {
            this._employeeService = employeeService;
        }
        [HttpGet]
        public async Task<IActionResult> EmployeeList([FromQuery] PaginationRequest paginationRequest)
        {
            var employeeList = await _employeeService.GetAllEmployees(paginationRequest);
            return View(employeeList);
        }
    }
}
