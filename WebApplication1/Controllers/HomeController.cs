using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using System.Collections.Generic;
using System.Linq;
using WebApplication1.Entities;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public string Index()
        {
            return "Hello from Index action";
        }

        public ViewResult Index2()
        {
            return View();
        }

        public ViewResult Employees()
        {
            List<Employee> employees = new List<Employee>
            {
                new Employee
                {
                    Id=1,
                     CityId=1,
                      Firstname="Elvin",
                       Lastname="Camalzade"
                },
                new Employee
                {
                    Id=2,
                     CityId=1,
                      Firstname="Leyla",
                       Lastname="Mammadova"
                },
                new Employee
                {
                    Id=3,
                     CityId=2,
                      Firstname="Tural",
                       Lastname="Aliyev"
                },
            };

            List<string> cities = new List<string> { "Baku", "Bern", "Stockholm" };


            var viewModel = new EmployeeListViewModel { Cities = cities, Employees = employees };

            //var list = (new List<Employee>(), new List<string>());
            //list.Item1 = employees;
            //list.Item2 = cities;

            return View(viewModel);
        }


        public IActionResult Index4()
        {
            return Ok();
        }


        public IActionResult Index5()
        {
            return NotFound();
        }
        public IActionResult Index6()
        {
            return BadRequest();
        }

        public RedirectResult Index7()
        {
            return Redirect("/home/index");
        }
        public IActionResult Index8()
        {
            return RedirectToAction("employees");
        }
        public IActionResult Index9()
        {
            var routeValue = new RouteValueDictionary
          (new { action = "Employees", controller = "Home" });
            return RedirectToRoute(routeValue);
        }

        public JsonResult GetJson()
        {
            List<Employee> employees = new List<Employee>
            {
                new Employee
                {
                    Id=1,
                     CityId=1,
                      Firstname="Elvin",
                       Lastname="Camalzade"
                },
                new Employee
                {
                    Id=2,
                     CityId=1,
                      Firstname="Leyla",
                       Lastname="Mammadova"
                },
                new Employee
                {
                    Id=3,
                     CityId=2,
                      Firstname="Tural",
                       Lastname="Aliyev"
                },
            };
            return Json(employees);
        }



        public JsonResult Index10(string key, int id = -1)
        {
            List<Employee> employees = new List<Employee>
            {
                new Employee
                {
                    Id=1,
                     CityId=1,
                      Firstname="Elvin",
                       Lastname="Camalzade"
                },
                new Employee
                {
                    Id=2,
                     CityId=1,
                      Firstname="Leyla",
                       Lastname="Mammadova"
                },
                new Employee
                {
                    Id=3,
                     CityId=2,
                      Firstname="Tural",
                       Lastname="Aliyev"
                },
            };
            if (id == -1)
            {
                var data = employees.Where(e => e.Firstname.Contains(key));
                return Json(data);
            }
            else
            {
                var data = employees.FirstOrDefault(e => e.Id == id);
                return Json(data);
            }
        }



        public IActionResult EmployeeForm()
        {
            return View();
        }

        public string RouteData(int id)
        {
            return id.ToString();
        }


    }//https://elvincamalzade.com/home/index
}
