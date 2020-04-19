using Looking4Home.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Looking4Home.Web.Controllers
{
    public class LoginController : Controller
    {
        SeguridadBL _seguridadBL;
        UsuarioWebBL _usuarioWebBL;

        public LoginController()
        {
            _seguridadBL = new SeguridadBL();
            _usuarioWebBL = new UsuarioWebBL();
        }

        // GET: Login
        public ActionResult Index()
        {
            var nuevoUsuarioWeb = new UsuarioWeb();

            return View(nuevoUsuarioWeb);
        }

        [HttpPost]
        public ActionResult Index(FormCollection data, UsuarioWeb usuarioWeb)
        {
            var usuario = data["username"];
            var correoWeb = data["username"];
            var contrasenaWeb = data["password"];

            var usuarioValido = _seguridadBL
                .AutorizacionWeb(usuario, contrasenaWeb, correoWeb);

            if (usuarioValido)
            {
                return RedirectToAction("Index", "Home");
            }else
            {
                ModelState.AddModelError("", "Usuario o Contraseña Invalido");
            }

            _usuarioWebBL.GuardarUsuarioWeb(usuarioWeb);

            return View(usuarioWeb);
        }
    }
}