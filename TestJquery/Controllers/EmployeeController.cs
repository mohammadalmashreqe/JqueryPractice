using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestJquery.Models;

namespace TestJquery.Controllers
{
    public class EmployeeController : Controller
    {
        public static List<Employee> data = new List<Employee>();
        static EmployeeController()
        {
            Employee e = new Employee
            {
                ID = 1,
                Age = 20,
                Name = "mohammad"

            };
            data.Add(e);
            e = new Employee
            {
                ID = 2,
                Age = 22,
                Name = "ahmad"

            };
            data.Add(e);
            e = new Employee
            {
                ID = 3,
                Age = 22,
                Name = "sameer"

            };
            data.Add(e);

        }

        [HttpGet]
        public JsonResult GetEmployeeByAge(int age)
        {
            if (age != 0)
            {
                var result = from emp in data
                             where emp.Age == age
                             select emp;
                return Json(result.ToList<Employee>(), JsonRequestBehavior.AllowGet);
            }
            else
                return Json(data, JsonRequestBehavior.AllowGet);






        }
        // GET: Employee
        public ActionResult Index()
        {
            return View(data);
        }

        // GET: Employee/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Employee/Create
        public ActionResult Create()
        {

            return View();
        }

        // POST: Employee/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Employee/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Employee/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Employee/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Employee/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
