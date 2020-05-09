using Lookig4Home.Web.Models;
using Looking4Home.BL;
using Looking4Home.Web.ViewModel;
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

            List<Busqueda> ItemList = new List<Busqueda>();
            ItemList.Add(new Busqueda { ItemID = 1, Idtext = "buy", Nombre = "Compra", IsCheck = true});
            ItemList.Add(new Busqueda { ItemID = 2, Idtext = "rent", Nombre = "Renta", IsCheck = false });
            ItemList.Add(new Busqueda { ItemID = 3, Idtext = "property", Nombre = "Precio", IsCheck = false });
            ItemList.Add(new Busqueda { ItemID = 4, Idtext = "agents", Nombre = "Vendedores", IsCheck = false });

            ViewBag.ItemList = ItemList;

            ViewBag.adminWebsiteUrl =
                ConfigurationManager.AppSettings["adminWebsiteUrl"];

            ViewBag.listaVendedores = listaVendedores;


            return View(listadeProductos);
        }

        [HttpPost]
        public ActionResult Index(string buscar)
        {
            var productosBL = new ProductosBL();
            var listadeProductos = productosBL.ObtenerProductosActivos();

            var vendedoresBL = new VendedoresBL();
            var listaVendedores = vendedoresBL.ObtenerVendedoresActivos();
           
            if (string.IsNullOrEmpty(buscar))
            {
                List<Busqueda> ItemList2 = new List<Busqueda>();
                ItemList2.Add(new Busqueda { ItemID = 1, Idtext = "buy", Nombre = "Compra", IsCheck = true });
                ItemList2.Add(new Busqueda { ItemID = 2, Idtext = "rent", Nombre = "Renta", IsCheck = false });
                ItemList2.Add(new Busqueda { ItemID = 3, Idtext = "property", Nombre = "Precio", IsCheck = false });
                ItemList2.Add(new Busqueda { ItemID = 4, Idtext = "agents", Nombre = "Vendedores", IsCheck = false });

                ViewBag.adminWebsiteUrl =
                    ConfigurationManager.AppSettings["adminWebsiteUrl"];

                ViewBag.ItemList = ItemList2;

                ViewBag.listaVendedores = listaVendedores;

                return View(listadeProductos);
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

        [HttpPost]
        public ActionResult SaveList(string ItemList)
        {
            //string[] arr = ItemList.Split(',');

            //foreach(var id in arr)
            //{

            //    var currentId = id;

            //}

            //return Json("", JsonRequestBehavior.AllowGet);
            // http://localhost:51123/ResultadoBusqueda/?q=casa
            return RedirectToAction("Index", "ResultadoBusqueda", new { w = ItemList});
        }
    }
}