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
    public class VistaServiciosRentaController : Controller
    {
        //// GET: VistaServiciosRenta
        //public ActionResult Index()
        //{
        //    var productosBL = new ProductosBL();
        //    var listadeProductos = productosBL.ObtenerProductosActivos();

        //    ViewBag.adminWebsiteUrl =
        //        ConfigurationManager.AppSettings["adminWebsiteUrl"];


        //    return View(listadeProductos);
        //}

        // GET: VistaServiciosRenta
        public ActionResult Index(SearchModel model)
        {

            List<Busqueda> ItemList = new List<Busqueda>();
            ItemList.Add(new Busqueda { ItemID = 1, Idtext = "buy", Nombre = "Venta", IsCheck = true });
            ItemList.Add(new Busqueda { ItemID = 2, Idtext = "rent", Nombre = "Renta", IsCheck = false });
            ItemList.Add(new Busqueda { ItemID = 3, Idtext = "property", Nombre = "Precio", IsCheck = false });
            ItemList.Add(new Busqueda { ItemID = 4, Idtext = "agents", Nombre = "Vendedores", IsCheck = false });

            ViewBag.ItemList = ItemList;

            var productosBL = new ProductosBL();
            var listadeProductos = productosBL.ObtenerProductosActivos3().AsQueryable();  // Marcar como AsQueryable

            var factory = new PageSourceFactory
            {

                MaxItemsPerPage = 10, // maximo elementos por pagina
                DefaultItemsPerPage = 8 // elementos por pagina
            };

            var searchText = model.SearchText;
            if (!string.IsNullOrWhiteSpace(searchText)) listadeProductos
                    = listadeProductos.Where(c => c.Descripcion.ToLower().Contains(searchText)); // Buscar en descripcion de la categoria

            var source = factory.CreateSource(listadeProductos, model);

            ViewBag.adminWebsiteUrl =
                ConfigurationManager.AppSettings["adminWebsiteUrl"];

            return View(source); // enviar el query al view
        }
    }
}