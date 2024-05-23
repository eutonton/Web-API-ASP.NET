using Microsoft.AspNetCore.Http;

namespace PrimeiraAPI.Application.ViewModel
{
    public class EmployeeViewModel
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public IFormFile Photo { get; set; }
    }
}
