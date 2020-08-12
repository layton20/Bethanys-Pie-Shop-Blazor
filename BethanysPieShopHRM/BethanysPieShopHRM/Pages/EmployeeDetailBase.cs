using BethanysPieShopHRM.Services;
using BethanysPieShopHRM.Shared;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace BethanysPieShopHRM.Pages
{
    public class EmployeeDetailBase : ComponentBase
    {
        [Inject]
        public IEmployeeDataService __EmployeeDataService { get; set; }
        [Parameter]
        public string EmployeeId { get; set; }

        public Employee Employee { get; set; }

        protected async override Task OnInitializedAsync()
        {
            Employee = await __EmployeeDataService.GetEmployeeDetails(int.Parse(EmployeeId));
        }
    }
}
