using EmpCrudCoreMvc.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmpCrudCoreMvc.Controllers
{
    public class EmpController : Controller
    {
        private readonly ApplicationDbContext _db;

        public EmpController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult List()
        {
            var res = _db.Employee.ToList();
            return View(res);
        }

       
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult>  Create(NewEmpClass model)
        {
            if(ModelState.IsValid)
            {
                _db.Add(model);
                await _db.SaveChangesAsync();
                return RedirectToAction("List");
            }
            return View(model);
        }

        public async Task<IActionResult> Edit(int? id)
        {
            if(id==null)
            {
                return RedirectToAction("List");
            }
            var res = await _db.Employee.FindAsync(id);
            return View(res);           
        }

        [HttpPost]
        public async Task<IActionResult> Edit(NewEmpClass model)
        {
            if(ModelState.IsValid)
            {
                _db.Update(model);
                await _db.SaveChangesAsync();
                return RedirectToAction("List");
            }
            return View(model);
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("List");
            }
            var res = await _db.Employee.FindAsync(id);
            return View(res);
        }


        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("List");
            }
            var res = await _db.Employee.FindAsync(id);
            return View(res);
        }

        [HttpPost]
        public async Task<IActionResult> Delete(int id)
        {            
            var res = await _db.Employee.FindAsync(id);
            _db.Employee.Remove(res);
            await _db.SaveChangesAsync();
            return RedirectToAction("List");
        }

    }
}
