using Looking4Home.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lookig4Home.WebAdmin.Controllers
{
    [Authorize]
    public class VendedoresController : Controller
    {
        VendedoresBL _vendedoresBL;
        public VendedoresController()
        {
            _vendedoresBL = new VendedoresBL();
        }
        // GET: Clientes
        public ActionResult Index()
        {

            var listadeVendedores = _vendedoresBL.ObtenerVendedores();

            return View(listadeVendedores);
        }

        public ActionResult Crear()
        {
            var nuevoVendedor = new Vendedor();
            return View(nuevoVendedor);
        }

        [HttpPost]
        public ActionResult Crear(Vendedor vendedor, HttpPostedFileBase imagen)
        {
            if (ModelState.IsValid)
            {
                if (vendedor.Contrasena == "")
                {
                    ModelState.AddModelError("Contraseña", "Seleccione una Categoria");
                    return View(vendedor);
                }


                if (imagen != null)
                {
                    vendedor.UrlImagen = GuardarImagen(imagen);
                }

                _vendedoresBL.GuardarVendedor(vendedor);

                return RedirectToAction("Index");
            }
            return View(vendedor);
        }

        public ActionResult Editar(int id)
        {

            var vendedor = _vendedoresBL.ObtenerVendedor(id);
            return View(vendedor);
        }

        [HttpPost]
        public ActionResult Editar(Vendedor vendedor, HttpPostedFileBase imagen)
        {
            if (ModelState.IsValid)
            {
                if (vendedor.Contrasena == "")
                {
                    ModelState.AddModelError("Contraseña", "Seleccione una Contraseña");
                    return View(vendedor);
                }

                if (imagen != null)
                {
                    vendedor.UrlImagen = GuardarImagen(imagen);
                }
                _vendedoresBL.GuardarVendedor(vendedor);
                return RedirectToAction("Index");
            }

            return View(vendedor);

        }

        public ActionResult Detalle(int id)
        {
            var vendedor = _vendedoresBL.ObtenerVendedor(id);
            return View(vendedor);

        }

        public ActionResult Eliminar(int id)
        {
            var vendedor = _vendedoresBL.ObtenerVendedor(id);
            return View(vendedor);

        }

        [HttpPost]
        public ActionResult Eliminar(Vendedor vendedor)
        {
            _vendedoresBL.EliminarVendedor(vendedor.Id);
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