using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using waSEMANA077.Models;

namespace waSEMANA077.Controllers
{
    public class ObreroController : Controller
    {
        // GET: Obrero
        public ActionResult Nuevo(Obrero obj)
        {
            ViewBag.id=obj.id_obrero;
            ViewBag.nombre=obj.nombre;
            ViewBag.apellido=obj.apellido;
            ViewBag.dni=obj.dni;
            ViewBag.genero=obj.genero;
            ViewBag.sueldo=obj.sueldo;
            ViewBag.fecha_naci=obj.fecha_naci;
            DaoObrero dao = new DaoObrero();
            if(dao.Insertar(obj))
            {
                ViewBag.mensaje = "Obrero agregado exitosamente";

            }
            else
            {
                ViewBag.mensaje = "Error al registrar Obrero";
            }
                    
            return View();
        }
    }
}