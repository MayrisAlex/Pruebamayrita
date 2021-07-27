using CrudExamenn.Data;
using CrudExamenn.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrudExamenn.Controllers
{
    public class CuentaController : Controller
    {
        private readonly ApplicationDbContext _applicationDbContext;

        public CuentaController(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }
        
        public IActionResult Index()
        {
            List<ClaseCuenta> cuenta = new List<ClaseCuenta>();
            cuenta = _applicationDbContext.Cuenta.ToList();
     
            return View(cuenta);

        }
        public IActionResult Create()
        {
            return View();

        }
        [HttpPost]
        public IActionResult Create(ClaseCuenta cuenta)
        {
            try
            {
                _applicationDbContext.Add(cuenta);
                _applicationDbContext.SaveChanges();
            }
            catch (Exception)
            {

                return View(cuenta);

            }
            return RedirectToAction("Index");

        }

        public IActionResult Edit (int id)
        {
            if (id == 0)
                return RedirectToAction("Index");
            ClaseCuenta cuenta = _applicationDbContext.Cuenta.Where(y => y.numero == id).FirstOrDefault();



        }




    }
}
