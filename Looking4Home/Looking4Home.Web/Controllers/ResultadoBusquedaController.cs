using Lookig4Home.Web.Models;
using Looking4Home.BL;
using Pagination;
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
        public ActionResult Index()
        {
            var buscar = Request.QueryString["q"];

            if (string.IsNullOrEmpty(buscar))
            {
                return View();
            }

            var resultados = _productosBL.ObtenerProductos(buscar).AsQueryable();

            //PAGINACION
            //var listadeProductos = _productosBL.ObtenerProductosActivos().AsQueryable();  // Marcar como AsQueryable

            var factory = new PageSourceFactory
            {

                MaxItemsPerPage = 10, // maximo elementos por pagina
                DefaultItemsPerPage = 9 // elementos por pagina
            };

            var source = factory.CreateSource(resultados);
            
            //FIN

            ViewBag.adminWebsiteUrl =
                    ConfigurationManager.AppSettings["adminWebsiteUrl"];

            return View(source);
        }
    }
}