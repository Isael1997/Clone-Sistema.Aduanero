using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Sistema_Aduanero.Models;

namespace Sistema_Aduanero.Controllers
{
    public class EmpleadosController : Controller
    {
        private DataBAse db = new DataBAse(); 

        // GET: Empleados
        public IActionResult Index()
        {
            var employ = db.Empleados.ToList();

            return View(employ);
        }
        public IActionResult Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }
            Empleados employ = db.Empleados.Find(id);

            if (employ == null)
            {
                return NotFound();
            }

            return View(employ);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind("Nombre,Apellidos,Cedula,Usuario,Contraseña, Cargo, Estatus")] Empleados employ)
        {
            if (ModelState.IsValid)
            {
                db.Empleados.Add(employ);
                db.SaveChanges();
                return RedirectToAction("Prueba");
            }

            return View(employ);
        }


        // GET: Home/Edit/5
        public ActionResult Edit(String id)
        {
            if (id == null)
            {
                return NotFound();
            }
            Empleados employ = db.Empleados.Find(id);

            if (employ == null)
            {
                return NotFound();
            }
            return View(employ);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind("Nombre,Apellidos,Cedula,Usuario,Contraseña, Cargo, Estatus")] Empleados employ)
        {
            if (ModelState.IsValid)
            {
                db.Entry(employ).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(employ);
        }


        // GET: Home/Delete/5
        public ActionResult Delete(String id)
        {
            if (id == null)
            {
                return NotFound();
            }
            Empleados employ = db.Empleados.Find(id);

            if (employ == null)
            {
                return NotFound();
            }
            return View(employ);
        }

        // POST: Home/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            Empleados employ = db.Empleados.Find(id);
            db.Empleados.Remove(employ);
            db.SaveChanges();
            return RedirectToAction("Prueba");
        }
    }
}
