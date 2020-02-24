using Looking4Home.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lookig4Home.WebAdmin.Controllers
{
    public class ProductosController : Controller
    {
        ProductosBL _productosBL;
        CategoriasBL _categoriasBL;
        EstructurasBL _estructurasBL;

        public ProductosController()
        {
            _productosBL = new ProductosBL();
            _categoriasBL = new CategoriasBL();
            _estructurasBL = new EstructurasBL();
        }

        // GET: Productos
        public ActionResult Index()
        {
            var listadeProductos = _productosBL.ObtenerProductos();

            return View(listadeProductos);
        }

        public ActionResult Crear()
        {
            var nuevoProducto = new Producto();
            var categorias = _categoriasBL.ObtenerCategorias();
            var estructuras = _estructurasBL.ObtenerEstructuras();

            ViewBag.ListaEstructuras = 
                new SelectList(estructuras, "Id", "Descripcion");

            ViewBag.ListaCategorias = 
                new SelectList(categorias, "Id", "Descripcion");

            return View(nuevoProducto);
        }

        [HttpPost]
        public ActionResult Crear(Producto producto)
        {
            _productosBL.GuardarProducto(producto);

            return RedirectToAction("Index");
        }

        public ActionResult Editar(int id)
        {
            var producto = _productosBL.ObtenerProducto(id);
            var categorias = _categoriasBL.ObtenerCategorias();
            var estructuras = _estructurasBL.ObtenerEstructuras();

            ViewBag.EstructuraId = new SelectList(estructuras, "Id", "Descripcion");

            ViewBag.CategoriaId =
                new SelectList(categorias, "Id", "Descripcion", producto.CategoriaId);

            return View(producto);
        }

        [HttpPost]
        public ActionResult Editar(Producto producto)
        {
            _productosBL.GuardarProducto(producto);

            return RedirectToAction("Index");
        }

        public ActionResult Detalle(int id)
        {
            var producto = _productosBL.ObtenerProducto(id);

            return View(producto);
        }

        public ActionResult Eliminar(int id)
        {
            var producto = _productosBL.ObtenerProducto(id);

            return View(producto);
        }

        [HttpPost]
        public ActionResult Eliminar(Producto producto)
        {
            _productosBL.EliminarProducto(producto.Id);

            return RedirectToAction("Index");
        } 
    }
}