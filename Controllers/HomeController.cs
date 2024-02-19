using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TaskWebApplication.Db_Conn;
using TaskWebApplication.Models;

namespace TaskWebApplication.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _db;



        public HomeController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {

            var res = _db.Employees.ToList();
            return View(res);
        }
        [HttpGet]
        public IActionResult AddEmp()
        {
            var model = new Employee()
            {
                DOJ = DateTime.Now

            };
            return View(model);

        }
        [HttpPost]
        public IActionResult AddEmp(Employee obj)
        {
            if (obj.Emp_Id == 0)
            {
                _db.Employees.Add(obj);
                _db.SaveChanges();
            }
            else
            {
                _db.Employees.Update(obj);
                _db.SaveChanges();
            }
            return RedirectToAction("Index");

        }

        public IActionResult Edit(int Id)
        {

            var resdata = _db.Employees.Where(a => a.Emp_Id == Id).First();


            return View("AddEmp", resdata);
        }

        public IActionResult Details(int Id)
        {
            var resdata = _db.Employees.Where(a => a.Emp_Id == Id).ToList();


            return View("Details", resdata);
        }

        public IActionResult Delete(int Id)
        {
            var resdata = _db.Employees.Where(a => a.Emp_Id == Id).First();
            _db.Employees.Remove(resdata);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}