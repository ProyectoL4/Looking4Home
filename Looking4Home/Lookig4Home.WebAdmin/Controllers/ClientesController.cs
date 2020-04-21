using Looking4Home.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lookig4Home.WebAdmin.Controllers
{
    [Authorize]
    public class ClientesController : Controller
    {
        ClientesBL _clientesBL;
        public ClientesController()
        {
            _clientesBL = new ClientesBL();
        }
        // GET: Clientes
        public ActionResult Index()
        {
           
            var listadeClientes = _clientesBL.ObtenerClientesActivos();

            return View(listadeClientes);
        }

        public ActionResult Crear()
        {
            var nuevoCliente = new Cliente();
            return View(nuevoCliente);
        }

        [HttpPost]
        public ActionResult Crear(Cliente cliente, HttpPostedFileBase imagen)
        {
            if (ModelState.IsValid)
            {
                if (cliente.Contraseña == "")
                {
                    ModelState.AddModelError("CategoriaID", "Seleccione una Categoria");
                    return View(cliente);
                }


                if (imagen != null)
                {
                    cliente.UrlImagen = GuardarImagen(imagen);
                }

                _clientesBL.GuardarCliente(cliente);

                return RedirectToAction("Index");
            }
            return View(cliente);
        }

        public ActionResult Editar(int id)
        {
            var cliente = _clientesBL.ObtenerCliente(id);
            return View(cliente);
        }

        [HttpPost]
        public ActionResult Editar(Cliente cliente, HttpPostedFileBase imagen)
        {
            if (ModelState.IsValid)
            {
                if (cliente.Contraseña == "")
                {
                    ModelState.AddModelError("Contraseña", "Seleccione una Contraseña");
                    return View(cliente);
                }

                if (imagen != null)
                {
                    cliente.UrlImagen = GuardarImagen(imagen);
                }
                _clientesBL.GuardarCliente(cliente);
                return RedirectToAction("Index");
            }

            return View(cliente);

        }

        public ActionResult Detalle(int id)
        {
            var cliente = _clientesBL.ObtenerCliente(id);
            return View(cliente);

        }

        public ActionResult Eliminar(int id)
        {
            var cliente = _clientesBL.ObtenerCliente(id);
            return View(cliente);

        }

        [HttpPost]
        public ActionResult Eliminar(Cliente cliente)
        {
            _clientesBL.EliminarCliente(cliente.Id);
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