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

            var etiqueta = Request.QueryString["w"];

            if (string.IsNullOrEmpty(buscar))
            {
                return View();
            }

            var resultados = _productosBL.ObtenerProductos(buscar, etiqueta).AsQueryable(); //ORIGINAL
            //var resultados = _productosBL.ObtenerProductosActivos().AsQueryable();

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

            //EXTRA
            //var searchText = model.SearchText;
            //if (!string.IsNullOrWhiteSpace(searchText)) resultados
            //     = resultados.Where(c => c.Descripcion.ToLower().Contains(searchText)); // Buscar en descripcion de la categoria

            var source = factory.CreateSource(resultados, model);
            //FIN

            ViewBag.adminWebsiteUrl =
                    ConfigurationManager.AppSettings["adminWebsiteUrl"];

            return View(source);
        }
    }
}