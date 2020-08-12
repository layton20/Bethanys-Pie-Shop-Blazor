using BethanysPieShopHRM.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace BethanysPieShopHRM.Services
{
    public class EmployeeDataService : IEmployeeDataService
    {
        private readonly HttpClient __HttpClient;

        public EmployeeDataService(HttpClient httpClient)
        {
            __HttpClient = httpClient ?? throw new ArgumentNullException(nameof(httpClient));
        }

        public Task<Employee> AddEmployee(Employee employee)
        {
            throw new NotImplementedException();
        }

        public Task DeletEmployee(int epmloyeeId)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Employee>> GetAllEmployees()
        {
            return await JsonSerializer.DeserializeAsync<IEnumerable<Employee>>(
                await __HttpClient.GetStreamAsync($"api/employee"), new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
        }

        public async Task<Employee> GetEmployeeDetails(int employeeId)
        {
            return await JsonSerializer.DeserializeAsync<Employee>(
                await __HttpClient.GetStreamAsync($"api/employee/{employeeId}"), new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
        }

        public Task UpdateEpmloyee(Employee employee)
        {
            throw new NotImplementedException();
        }
    }
}
