using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Aplicatie_Salarizare.Models;
using Microsoft.AspNetCore.Hosting;
using AspNetCore.Reporting;
using System.Data;

namespace Aplicatie_Salarizare.Controllers
{
 
    public class HomeController : Controller
    {
        private readonly IWebHostEnvironment _webHostEnvironment;
        private readonly IEmployeesRepository _repository;
        public HomeController(IEmployeesRepository repository, IWebHostEnvironment webHostEnvironment)
        {
            _webHostEnvironment = webHostEnvironment;
            System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);
            _repository = repository;
        }

        public IActionResult Index()
        {
            var employees = _repository.GetEmployees();

            if (Request.Headers["X-Requested-With"] == "XMLHttpRequest")
            {
                Console.WriteLine("I was here");
                return PartialView(employees);
            }

            return View(employees);
        }
        [Route("privacy")]
        public IActionResult Privacy()
        {
            if (Request.Headers["X-Requested-With"] == "XMLHttpRequest")
            {
                Console.WriteLine("I was here");
                return PartialView();
            }
            return View();
        }

        [HttpGet, Route("insert")]
        public IActionResult Insert()
        {
            if (Request.Headers["X-Requested-With"] == "XMLHttpRequest")
            {
                Console.WriteLine("I was here");
                return PartialView();
            }
            return View();
        }

        [HttpPost, Route("insert")]
        public IActionResult Insert(Employee employee)
        {
            _repository.AddEmployee(employee);
            return RedirectToAction("Index", "Home");
        }

        [Route("percentages")]
        public IActionResult Percentages(string password)
        {
            Taxes tax = _repository.getTaxes();
            if (tax.password == password)
            {
                if (Request.Headers["X-Requested-With"] == "XMLHttpRequest")
                {
                    Console.WriteLine("I was here");
                    return PartialView(tax);
                }
                return View(tax);
            }
            if (Request.Headers["X-Requested-With"] == "XMLHttpRequest")
            {
                Console.WriteLine("I was here");
                return PartialView();
            }
            return View();
        }

        [Route("reports")]
        public IActionResult Reports()
        {
            if (Request.Headers["X-Requested-With"] == "XMLHttpRequest")
            {
                Console.WriteLine("I was here");
                return PartialView();
            }
            return View();
        }
        public IActionResult EmployeesReport()
        {
            var dt = new DataTable();
            dt = _repository.GetEmployeeList();

            string mimetype = "";
            int extension = 1;
            var path = $"{this._webHostEnvironment.WebRootPath}\\Reports\\rptEmployees.rdlc";

            Dictionary<string, string> parameters = new Dictionary<string, string>();
            LocalReport localReport = new LocalReport(path);
            localReport.AddDataSource("dsEmployees", dt);
            var result = localReport.Execute(RenderType.Pdf, extension, parameters, mimetype);

            return File(result.MainStream, "application/pdf");
        }
        public IActionResult Flyer(string surname)
        {
            var dt = new DataTable();

            if (surname != null)
            {
                dt = _repository.GetEmployeeBySurname(surname);
            }

            string mimetype = "";
            int extension = 1;
            var path = $"{this._webHostEnvironment.WebRootPath}\\Reports\\rptEmployeesFlyers.rdlc";

            Dictionary<string, string> parameters = new Dictionary<string, string>();
            LocalReport localReport = new LocalReport(path);
            localReport.AddDataSource("dsEmployees", dt);
            var result = localReport.Execute(RenderType.Pdf, extension, parameters, mimetype);

            return File(result.MainStream, "application/pdf");
        }
        public IActionResult AllFlyers()
        {
            var dt = new DataTable();
            dt = _repository.GetEmployeeList();

            string mimetype = "";
            int extension = 1;
            var path = $"{this._webHostEnvironment.WebRootPath}\\Reports\\rptEmployeesFlyers.rdlc";

            Dictionary<string, string> parameters = new Dictionary<string, string>();
            LocalReport localReport = new LocalReport(path);
            localReport.AddDataSource("dsEmployees", dt);
            var result = localReport.Execute(RenderType.Pdf, extension, parameters, mimetype);

            return File(result.MainStream, "application/pdf");
        }

        [Route("update")]
        public IActionResult Update()
        {
            var employees = _repository.GetEmployees();
            if (Request.Headers["X-Requested-With"] == "XMLHttpRequest")
            {
                return PartialView(employees);
            }
            return View(employees);
        }

        public IActionResult UpdateEmployee(int id, string lastname, string surname, int base_salary,
             int increase = -1, int gross_prizes = -1, int deductions = -1)
        {
            _repository.updateEmployee(id, lastname, surname, base_salary,
                increase, gross_prizes, deductions);
            if (Request.Headers["X-Requested-With"] == "XMLHttpRequest")
            {
                return RedirectToAction("Update", "Home");
            }
            return RedirectToAction("Update", "Home");
        }

        public IActionResult ChangeTaxes(int cas, int cass, int tax)
        {
            _repository.updateTaxes(cas, cass, tax);
            if (Request.Headers["X-Requested-With"] == "XMLHttpRequest")
            {
                return RedirectToAction("Index", "Home");
            }
            return RedirectToAction("Index", "Home");
        }

        public IActionResult Remove(int id)
        {
            _repository.removeEmployee(id);
            return RedirectToAction("Index", "Home");
        }

        public IActionResult Delete(string lastname, string surname, bool notFirst)
        {
            IEnumerable<Employee> employees = Enumerable.Empty<Employee>();

            if (lastname != null && surname != null) {
                employees = _repository.GetEmployeeByLastnameAndSurname(lastname, surname);
            }
            if (lastname != null)
            {
                employees = _repository.GetEmployeeByLastname(lastname);
            }



            if (employees.Count() == 0 && notFirst) 
            {
                List<Employee> employeesList = new List<Employee>();
                var emp = new Employee();
                emp.Lastname = "UserNotFound";
                employeesList.Add(emp);
                employees = employeesList;
                if (Request.Headers["X-Requested-With"] == "XMLHttpRequest")
                {
                    return PartialView(employees);
                }
                return View(employees);
            }
            else if (employees.Count() != 0)
            {
                if (Request.Headers["X-Requested-With"] == "XMLHttpRequest")
                {
                    return PartialView(employees);
                }
                return View(employees);
            }

            if (Request.Headers["X-Requested-With"] == "XMLHttpRequest")
            {
                return PartialView();
            }
            return View();
        }


        [Route("error")]
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            if (Request.Headers["X-Requested-With"] == "XMLHttpRequest")
            {
                Console.WriteLine("I was here");
                return PartialView();
            }
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

    }
}

