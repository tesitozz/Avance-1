using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using waSEMANA077.Models;

namespace waSEMANA077.Controllers
{
    public class CategoriaController : Controller
    {
        // GET: Categoria
        public ActionResult Nuevo(Categoria obj)
        {
            ViewBag.IdCategoria = obj.idCategoria;
            ViewBag.NombreCategoria = obj.NombreCategoria;
            ViewBag.Descripcion = obj.Descripcion;
            DaoCategoria dao = new DaoCategoria();
            if (dao.Insertar(obj))
            {
                ViewBag.mensaje = "Categoria Insertada Con Exitos";
            }
            else
            {
                ViewBag.mensaje = "Error al insertar la categoria";
            }
            return View();
        }

        public ActionResult Create(Categoria obj)
        {
            ViewBag.IdCategoria = obj.idCategoria;
            ViewBag.NombreCategoria = obj.NombreCategoria;
            ViewBag.Descripcion = obj.Descripcion;
            DaoCategoria dao = new DaoCategoria();
            if (dao.Insertar(obj))
                ViewBag.mensaje = "Categoria Insertada Con Exitos";
            
            return View(obj);
        }
    }
}