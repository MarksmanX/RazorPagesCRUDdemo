using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPagesDemoApp.Data;
using RazorPagesDemoApp.Models.Domain;
using RazorPagesDemoApp.Models.ViewModels;
using System.ComponentModel.DataAnnotations;

namespace RazorPagesDemoApp.Pages.Employees
{
    public class AddModel : PageModel
    {
        private readonly RazorPagesDemoDbContext dbContext;

        public AddModel(RazorPagesDemoDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        [BindProperty]
        public AddEmployeeViewModel AddEmployeeRequest { get; set; }
        public void OnGet()
        {

        }

        public void OnPost()
        {
            //Convert ViewModel to DomainModel
            var employeeDomainModel = new Employee
            {
                Name = AddEmployeeRequest.Name,
                Email = AddEmployeeRequest.Email,
                Salary = AddEmployeeRequest.Salary,
                DateOfBirth = AddEmployeeRequest.DateOfBirth,
                Department = AddEmployeeRequest.Department
            };

            dbContext.Employees.Add(employeeDomainModel);
            dbContext.SaveChanges();

            ViewData["Message"] = "Employee Created Successfully!";
        }
    }
}
