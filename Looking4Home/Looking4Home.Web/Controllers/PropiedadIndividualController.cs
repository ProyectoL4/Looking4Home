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
    public class PropiedadIndividualController : Controller
    {
        ProductosBL _productosBL;

        public PropiedadIndividualController()
        {
            _productosBL = new ProductosBL();
        }

        // GET: PropiedadIndividual
        public ActionResult Index()
        {

            var buscar = Request.QueryString["q"];

            if (string.IsNullOrEmpty(buscar))
            {
                return View();
            }

            var resultados = _productosBL.ObtenerProductosIndividuales(buscar).AsQueryable();

            //PAGINACION
            var factory = new PageSourceFactory
            {

                MaxItemsPerPage = 10, // maximo elementos por pagina
                DefaultItemsPerPage = 9 // elementos por pagina
            };

            var model = new SearchModel()
            {
                SearchText = buscar,
            };

            var source = factory.CreateSource(resultados, model);

            //FIN

            ViewBag.adminWebsiteUrl =
                    ConfigurationManager.AppSettings["adminWebsiteUrl"];

            return View(source);
        }
    }
}