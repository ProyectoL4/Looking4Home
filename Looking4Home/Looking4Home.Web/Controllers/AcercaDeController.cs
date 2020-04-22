using Looking4Home.BL;
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

            ViewBag.adminWebsiteUrl =
                ConfigurationManager.AppSettings["adminWebsiteUrl"];

            

            return View(listaVendedores);
        }
    }
}