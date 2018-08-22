using crudDatosPersonales.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace crudDatosPersonales.Controllers
{
    public class datosController : Controller
    {
        datosPersonalesContext obj = new datosPersonalesContext();
        // GET: datos
        public ActionResult Index()
        {
            var lista = obj.datosPersonales.ToList();
            return View(lista);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(datosPersonales datosp)
        {
            if (ModelState.IsValid)
            {
                obj.datosPersonales.Add(datosp);
                obj.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(datosp);
        }
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return Content("<center><font color='blue' size='10'><h1>ERROR 404.</h1></font></center>");
            }
            var registro = obj.datosPersonales.Find(id);
            return View(registro);
        }

        public ActionResult Delete(int? id )
        {
            if (id == null)
            {
                return Content("<center><font color='blue' size='10'><h1>ERROR 404.</h1></font></center>");
            }
            var registro = obj.datosPersonales.Find(id);
            return View(registro);
        }
        [HttpPost]
        public ActionResult Delete(int id,datosPersonales datos)
        {
            var eliminar = obj.datosPersonales.Find(id);
            obj.datosPersonales.Remove(eliminar);
            obj.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return Content("<center><font color='red' size='10'><h1>ERROR 404.</h1></font></center>");
            }
            var registro = obj.datosPersonales.Find(id);
            return View(registro);
            
        }
        [HttpPost]
        public ActionResult Edit(datosPersonales datos)
        {
            obj.Entry(datos).State = System.Data.Entity.EntityState.Modified;
            obj.SaveChanges();
            return RedirectToAction("Index");

        }
    }

   
}