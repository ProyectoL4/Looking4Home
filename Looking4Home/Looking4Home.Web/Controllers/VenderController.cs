using Looking4Home.BL;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Looking4Home.Web.Controllers
{
    public class VenderController : Controller
    {
        ProductosBL _productosBL;

        public VenderController()
        {
            _productosBL = new ProductosBL();
        }

        // GET: Vender
        public ActionResult Index()
        {
            var listadeProductos = _productosBL.ObtenerProductosActivos();

            ViewBag.adminWebsiteUrl =
                ConfigurationManager.AppSettings["adminWebsiteUrl"];

            return View(listadeProductos);
        }
    }
}