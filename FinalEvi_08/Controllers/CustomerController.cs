using FinalEvi_08.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace FinalEvi_08.Controllers
{
    public class CustomerController : Controller
    {
        private readonly ApplicationDbContext _context;
        public CustomerController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var emp =
           _context.CustomerInfo.FromSqlRaw($"sp_GetAllCustomer").AsEnumerable().ToList();
            return View(emp);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(CustomerInfo custo)
        {
            if (ModelState.IsValid)
            {
                string forCreate = $"sp_CreateCustomer { custo.CustoName},{ custo.CustoAddress},{ custo.PhoneNo},{ custo.Age},{ custo.Salary},'{custo.DateOfB}'";
              _context.Database.ExecuteSqlRaw(forCreate);
                return RedirectToAction("Index");
            }
            return View(custo);
        }
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var custo = _context.CustomerInfo.FromSqlRaw($"sp_GetByIdCustomer { id}").AsEnumerable().FirstOrDefault();
            if (custo == null)
            {
                return NotFound();
            }
            return View(custo);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(CustomerInfo custo)
        {
            if (ModelState.IsValid)
            {
                string forUpdate =$"sp_UpdateCustomer'{custo.Id}','{custo.CustoName}', '{custo.CustoAddress}' ,'{custo.PhoneNo}', '{custo.Age}','{custo.Salary }','{custo.DateOfB}'";
                _context.Database.ExecuteSqlRaw(forUpdate);
              return RedirectToAction("Index");
            }
             return View(custo);
        }
            public IActionResult Details(int? id)
            {
                if (id == null)
                {
                    return NotFound();
                }
                var custo = _context.CustomerInfo.FirstOrDefault(x => x.Id == id);
                return View(custo);
            }
            public IActionResult Delete(int? id)
            {
                if (id == null)
                {
                    return NotFound();
                }
                var custo = _context.CustomerInfo.FromSqlRaw($"sp_GetByIdCustomer {id} ").AsEnumerable().FirstOrDefault();
               return View(custo);
            }
            [HttpPost]
            [ValidateAntiForgeryToken]
            public IActionResult Delete(CustomerInfo custo)
            {
                if (ModelState.IsValid)
                {
                    _context.Database.ExecuteSqlRaw($"sp_DeleteCustomer {custo.Id}");
                    _context.SaveChanges();
                    return RedirectToAction("Index");
                }
                return View();
            }
            public IActionResult CustomerStats()
            {
                //count
                int cusCount = _context.CustomerInfo.Count();
                ViewBag.Count = cusCount;
                //average
                double avgAge = (double)_context.CustomerInfo.Average(a => a.Age);
                ViewBag.AvgAge = avgAge;
                //min
                int minAge = (int)_context.CustomerInfo.Min(a => a.Age);
                ViewBag.MinAge = minAge;
                //max
                int maxAge = (int)_context.CustomerInfo.Max(a => a.Age);
                ViewBag.MaxAge = maxAge;
                //sum
                decimal totalSalary = (decimal)_context.CustomerInfo.Sum(a => a.Salary);
                ViewBag.SumSalary = totalSalary;
                return View();
            }
    }
}
