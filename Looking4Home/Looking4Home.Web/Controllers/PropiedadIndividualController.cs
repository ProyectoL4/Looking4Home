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

            List<Busqueda> ItemList = new List<Busqueda>();
            ItemList.Add(new Busqueda { ItemID = 1, Idtext = "buy", Nombre = "Venta", IsCheck = true });
            ItemList.Add(new Busqueda { ItemID = 2, Idtext = "rent", Nombre = "Renta", IsCheck = false });
            ItemList.Add(new Busqueda { ItemID = 3, Idtext = "property", Nombre = "Precio", IsCheck = false });
            ItemList.Add(new Busqueda { ItemID = 4, Idtext = "agents", Nombre = "Vendedores", IsCheck = false });

            ViewBag.ItemList = ItemList;

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