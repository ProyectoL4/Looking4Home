using Looking4Home.BL;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace Lookig4Home.WebAdmin.Controllers
{
    public class LoginController : Controller
    {
        SeguridadBL _seguridadBL;

        public LoginController()
        {
            _seguridadBL = new SeguridadBL();
        }

        // GET: Login
        public ActionResult Index()
        {
            FormsAuthentication.SignOut();
            return View();
        }

        [HttpPost]
        public ActionResult Index(FormCollection Data)
        {
            var nombreUsuario = Data["username"];
            var correo = Data["username"];
            var contrasena = Data["password"];

            var usuarioValido = _seguridadBL
                .Autorizar(nombreUsuario, contrasena, correo);

            if (usuarioValido != null)
            {
                //FormsAuthentication.SetAuthCookie(nombreUsuario, true);

                FormsAuthenticationTicket ticket = new FormsAuthenticationTicket(1,
                                                                                 correo,
                                                                                 DateTime.Now,
                                                                                 DateTime.Now.AddDays(1),
                                                                                 false,
                                                                                 JsonConvert.SerializeObject(usuarioValido),
                                                                                 FormsAuthentication.FormsCookiePath);

                string hash = FormsAuthentication.Encrypt(ticket);
                HttpCookie authcookie = new HttpCookie(FormsAuthentication.FormsCookieName, hash);

                Response.Cookies.Add(authcookie);                                                            
                
                return RedirectToAction("Index", "Home");
            }

            ModelState.AddModelError("", "Usuario o Contraseña invalido");

            return View();
        }
    }
}