using Lookig4Home.Web.Models;
using Looking4Home.BL;
using Pagination;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Looking4Home.Web.Controllers
{
    public class HomeController : Controller
    {

        // GET: Home
        public ActionResult Index()
        {
            var productosBL = new ProductosBL();
            var listadeProductos = productosBL.ObtenerProductosActivos();

            var vendedoresBL = new VendedoresBL();
            var listaVendedores = vendedoresBL.ObtenerVendedoresActivos();

            ViewBag.adminWebsiteUrl =
                ConfigurationManager.AppSettings["adminWebsiteUrl"];

            ViewBag.listaVendedores = listaVendedores;


            return View(listadeProductos);
        }


        [HttpPost]
        public ActionResult Index(string buscar)
        {
            
            if (string.IsNullOrEmpty(buscar))
            {
                return View();
            }

            // q es query, no quise poner buscar = buscar para que no haya confusion
            // este q es parte de la url, por ejemplo
            // http://localhost:51123/ResultadoBusqueda/?q=casa
            return RedirectToAction("Index", "ResultadoBusqueda", new { q = buscar });
        }

        [HttpPost]
        public ActionResult Index2(string buscar)
        {

            if (string.IsNullOrEmpty(buscar))
            {
                return View();
            }

            // q es query, no quise poner buscar = buscar para que no haya confusion
            // este q es parte de la url, por ejemplo
            // http://localhost:51123/ResultadoBusqueda/?q=casa
            return RedirectToAction("Index", "PropiedadIndividual", new { q = buscar });
        }

    }
}