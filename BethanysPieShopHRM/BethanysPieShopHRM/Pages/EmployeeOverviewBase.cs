using BethanysPieShopHRM.Services;
using BethanysPieShopHRM.Shared;
using Microsoft.AspNetCore.Components;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BethanysPieShopHRM.Pages
{
    public class EmployeeOverviewBase : ComponentBase
    {
        [Inject]
        public IEmployeeDataService __EmployeeDataService { get; set; }
        public IEnumerable<Employee> Employees { get; set; }

        protected async override Task OnInitializedAsync()
        {
            Employees = (await __EmployeeDataService.GetAllEmployees()).ToList();
        }

    }
}
