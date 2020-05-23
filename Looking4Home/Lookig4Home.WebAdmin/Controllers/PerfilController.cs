using Looking4Home.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lookig4Home.WebAdmin.Controllers
{
    public class PerfilController : Controller
    {

        UsuariosBL _usuariosBL;

        public PerfilController()
        {
            _usuariosBL = new UsuariosBL();
        }

        // GET: Perfil
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Index2()
        {

            var listadeUsuarios = _usuariosBL.ObtenerUsuarios();

            return View(listadeUsuarios);
        }

        public ActionResult Crear()
        {
            var nuevoUsuario = new Usuario();

            return View(nuevoUsuario);
        }

        [HttpPost]
        public ActionResult Crear(Usuario usuario, HttpPostedFileBase imagen)
        {
            if (ModelState.IsValid)
            {
                if (usuario.Contrasena != usuario.Contrasena2)
                {
                    ModelState.AddModelError(usuario.Contrasena2, "Las contraseñas no coinciden");
                    return View(usuario);
                }

                if (imagen != null)
                {
                    usuario.UrlImagen = GuardarImagen(imagen);
                }

                _usuariosBL.Guardarusuario(usuario);

                return RedirectToAction("Index");
            }

            return View(usuario);

        }

        public ActionResult Editar(int id)
        {
            var usuario = _usuariosBL.ObtenerUsuarios(id);

            return View(usuario);
        }

        [HttpPost]
        public ActionResult Editar(Usuario usuario, HttpPostedFileBase imagen)
        {
            if (ModelState.IsValid)
            {
                if (usuario.Contrasena != usuario.Contrasena2)
                {
                    ModelState.AddModelError(usuario.Contrasena2, "Las contraseñas no coinciden");
                    return View(usuario);
                }

                if (imagen != null)
                {
                    usuario.UrlImagen = GuardarImagen(imagen);
                }

                _usuariosBL.Guardarusuario(usuario);

                return RedirectToAction("Index");
            }

            return View(usuario);
        }

        public ActionResult Detalle(int id)
        {
            var usuario = _usuariosBL.ObtenerUsuarios(id);

            return View(usuario);
        }

        public ActionResult Eliminar(int id)
        {
            var usuario = _usuariosBL.ObtenerUsuarios(id);

            return View(usuario);
        }

        [HttpPost]
        public ActionResult Eliminar(Usuario usuario)
        {
            _usuariosBL.EliminarUsuario(usuario.Id);

            return RedirectToAction("Index");
        }

        private string GuardarImagen(HttpPostedFileBase imagen)
        {

            string path = Server.MapPath("~/Imagenes/" + imagen.FileName);
            imagen.SaveAs(path);

            return "/imagenes/" + imagen.FileName;

        }
    }
}