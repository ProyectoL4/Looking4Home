using Looking4Home.BL;
using Looking4Home.Web.ViewModel;
using System.Collections.Generic;
using System.Configuration;
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
            ItemList.Add(new Busqueda { ItemID = 1, Idtext = "buy", Nombre = "Venta", IsCheck = true });
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
        public ActionResult Index(string buscar, string ItemList)
        {

            var productosBL = new ProductosBL();
            var listadeProductos = productosBL.ObtenerProductosActivos();

            var vendedoresBL = new VendedoresBL();
            var listaVendedores = vendedoresBL.ObtenerVendedoresActivos();

            if (string.IsNullOrEmpty(buscar))
            {
                List<Busqueda> ItemList2 = new List<Busqueda>();
                ItemList2.Add(new Busqueda { ItemID = 1, Idtext = "buy", Nombre = "Venta", IsCheck = true });
                ItemList2.Add(new Busqueda { ItemID = 2, Idtext = "rent", Nombre = "Renta", IsCheck = false });
                ItemList2.Add(new Busqueda { ItemID = 3, Idtext = "property", Nombre = "Precio", IsCheck = false });
                ItemList2.Add(new Busqueda { ItemID = 4, Idtext = "agents", Nombre = "Vendedores", IsCheck = false });

                ViewBag.ItemList = ItemList2;

                ViewBag.adminWebsiteUrl =
                    ConfigurationManager.AppSettings["adminWebsiteUrl"];

                ViewBag.listaVendedores = listaVendedores;


                return View(listadeProductos);
            }

            return RedirectToAction("Index", "ResultadoBusqueda", new { q = buscar, w = ItemList });
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