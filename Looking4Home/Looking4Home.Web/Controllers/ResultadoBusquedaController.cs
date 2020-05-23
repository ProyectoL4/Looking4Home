using Lookig4Home.Web.Models;
using Looking4Home.BL;
using Looking4Home.Web.ViewModel;
using Pagination;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web.Mvc;

namespace Looking4Home.Web.Controllers
{
    public class ResultadoBusquedaController : Controller
    {
        ProductosBL _productosBL;

        public ResultadoBusquedaController()
        {
            _productosBL = new ProductosBL();
        }

        // GET: ResultadoBusqueda
        public ActionResult Index(SearchModel model)
        {
            var buscar = Request.QueryString["q"];

            var etiqueta = Request.QueryString["w"];

            if (string.IsNullOrEmpty(buscar))
            {
                return View();
            }

            List<Busqueda> ItemList = new List<Busqueda>();
            ItemList.Add(new Busqueda { ItemID = 1, Idtext = "buy", Nombre = "Venta", IsCheck = true });
            ItemList.Add(new Busqueda { ItemID = 2, Idtext = "rent", Nombre = "Renta", IsCheck = false });
            ItemList.Add(new Busqueda { ItemID = 3, Idtext = "property", Nombre = "Precio", IsCheck = false });
            ItemList.Add(new Busqueda { ItemID = 4, Idtext = "agents", Nombre = "Vendedores", IsCheck = false });

            ViewBag.ItemList = ItemList;

            var resultados = _productosBL.ObtenerProductos(buscar, etiqueta).AsQueryable(); //ORIGINAL
            //var resultados = _productosBL.ObtenerProductosActivos().AsQueryable();

            //PAGINACION
            var factory = new PageSourceFactory
            {

                MaxItemsPerPage = 10, // maximo elementos por pagina
                DefaultItemsPerPage = 8 // elementos por pagina
            };


            var source = factory.CreateSource(resultados, model);

            ViewBag.adminWebsiteUrl =
                    ConfigurationManager.AppSettings["adminWebsiteUrl"];

            return View(source);
        }
    }
}