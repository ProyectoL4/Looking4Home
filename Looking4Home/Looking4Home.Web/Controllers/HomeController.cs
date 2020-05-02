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
            return View();
        }


        //GET: Buscar
        public ActionResult Buscar(SearchModel model)
        {
            var productosBL = new ProductosBL();
            var listadeProductos = productosBL.ObtenerProductosActivos().AsQueryable();  // Marcar como AsQueryable

            var factory = new PageSourceFactory
            {

                MaxItemsPerPage = 10, // maximo elementos por pagina
                DefaultItemsPerPage = 9 // elementos por pagina
            };

            var searchText = model.SearchText;
            if (!string.IsNullOrWhiteSpace(searchText)) listadeProductos
                    = listadeProductos.Where(c => c.Descripcion.ToLower().Contains(searchText)); // Buscar en descripcion de la categoria

            var source = factory.CreateSource(listadeProductos, model);

            ViewBag.adminWebsiteUrl =
                ConfigurationManager.AppSettings["adminWebsiteUrl"];

            return View(source);

        }

    }
}