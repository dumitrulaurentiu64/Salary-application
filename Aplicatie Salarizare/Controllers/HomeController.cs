using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Aplicatie_Salarizare.Models;

namespace Aplicatie_Salarizare.Controllers
{
 
    public class HomeController : Controller
    {
        private readonly IEmployeesRepository _repository;
        public HomeController(IEmployeesRepository repository)
        {
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
        public IActionResult Percentages()
        {
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
        [Route("calculate")]
        public IActionResult Calculate()
        {
            if (Request.Headers["X-Requested-With"] == "XMLHttpRequest")
            {
                Console.WriteLine("I was here");
                return PartialView();
            }
            return View();
        }
        [Route("update")]
        public IActionResult Update()
        {
            var employees = _repository.GetEmployees();
            if (Request.Headers["X-Requested-With"] == "XMLHttpRequest")
            {
                Console.WriteLine("I was here");
                return PartialView(employees);
            }
            return View(employees);
        }

        public IActionResult UpdateEmployee(int id, string lastname, string surname, int base_salary,
             int increase, int gross_prizes, int deductions)
        {
            var employees = _repository.updateEmployee(id, lastname, surname, base_salary,
                increase, gross_prizes, deductions);
            if (Request.Headers["X-Requested-With"] == "XMLHttpRequest")
            {
                return RedirectToAction("Update", "Home");
            }
            return RedirectToAction("Update", "Home");
        }

        public IActionResult Remove(int id)
        {
            _repository.removeEmployee(id);
            return RedirectToAction("Index", "Home");
        }

        public IActionResult Delete(string lastname, string surname)
        {
            IEnumerable<Employee> employees = Enumerable.Empty<Employee>();

            if (lastname != null && surname != null) { 
                employees = _repository.GetEmployee(lastname, surname);
            }
            if(employees.Count() != 0)
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

