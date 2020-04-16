using Looking4Home.BL;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Looking4Home.Web.Controllers
{
    public class RentaController : Controller
    {
        ProductosBL _productosBL;

        public RentaController()
        {
            _productosBL = new ProductosBL();
        }

        // GET: Venta
        public ActionResult Index()
        {
            var listadeProductos = _productosBL.ObtenerProductosActivos();

            ViewBag.adminWebsiteUrl =
                ConfigurationManager.AppSettings["adminWebsiteUrl"];

            return View(listadeProductos);
        }
    }
}