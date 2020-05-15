using Looking4Home.BL;
using Looking4Home.Web.ViewModel;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Looking4Home.Web.Controllers
{
    public class AcercaDeController : Controller
    {

        public AcercaDeController()
        {
            
        }

        // GET: AcercaDe
        public ActionResult Index()
        {
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

            

            return View(listaVendedores);
        }
    }
}