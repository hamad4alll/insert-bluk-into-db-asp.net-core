using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using BlukInsertcore.Models;
using EFCore.BulkExtensions;

namespace BlukInsertcore.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplictionDbContext _db;

        public HomeController(ILogger<HomeController> logger,ApplictionDbContext db)
        {
            _logger = logger;
            _db = db;
        }
        public IActionResult Index()
        {
            var totalTb = _db.Employees.Count();
            ViewBag.totalTb = totalTb;
        //  List<Employee> employee = new List<Employee>();
       //  employee = InsertRecord();
       //  _db.BulkInsert(employee);
            return View();
        }
        [HttpPost]
        public IActionResult Save()
        {
            List<Employee> employee = new List<Employee>();
            employee = InsertRecord();
            _db.BulkInsert(employee);
            //  _db.SaveChanges();
            return RedirectToAction("Index");

        }
        public static List<Employee> InsertRecord()
        {
            List<Employee> list = new List<Employee>();
            for (int i = 0; i < 10; i++)
            {
                list.Add(new Employee()
                {
                    Name = "Employee_" + i,
                    Department = "Department_" + i,
                    City = "City_" + i
                });
            }
            return list;
        }




    }
}
