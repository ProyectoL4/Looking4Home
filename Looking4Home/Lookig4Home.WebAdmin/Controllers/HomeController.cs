using Looking4Home.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lookig4Home.WebAdmin.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        public static Usuario usuario;

        UsuariosBL _usuariosBL;

        public HomeController()
        {
            _usuariosBL = new UsuariosBL();
        }

        // GET: Home
        public ActionResult Index()
        {
            var listadeUsuarios = _usuariosBL.ObtenerUsuarios();
            return View(listadeUsuarios);
        }
    }
}