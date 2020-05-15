using Looking4Home.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lookig4Home.WebAdmin.Controllers
{
    [Authorize]
    public class ProductosController : Controller
    {
        ProductosBL _productosBL;
        CategoriasBL _categoriasBL;
        EstructurasBL _estructurasBL;
        VendedoresBL _vendedoresBL;
        EtiquetaBL _etiquetaBL;

        public ProductosController()
        {
            _productosBL = new ProductosBL();
            _categoriasBL = new CategoriasBL();
            _estructurasBL = new EstructurasBL();
            _vendedoresBL = new VendedoresBL();
            _etiquetaBL = new EtiquetaBL();
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
            var vendedores = _vendedoresBL.ObtenerVendedores();
            var etiquetas = _etiquetaBL.ObtenerEtiquetas();

            ViewBag.EstructuraId = 
                new SelectList(estructuras, "Id", "Descripcion");

            ViewBag.CategoriaId = 
                new SelectList(categorias, "Id", "Descripcion");

            ViewBag.VendedorId =
                 new SelectList(vendedores, "Id", "Nombre");

            ViewBag.EtiquetaId =
                new SelectList(etiquetas, "Id", "Descripcion");

            return View(nuevoProducto);
        }

        [HttpPost]
        public ActionResult Crear(Producto producto, HttpPostedFileBase imagen, HttpPostedFileBase imagen2, 
            HttpPostedFileBase imagen3, HttpPostedFileBase imagen4, HttpPostedFileBase imagen5)
        {
            if (ModelState.IsValid)
            {


                    if (producto.CategoriaId == 0)
                    {
                        ModelState.AddModelError("CategoriaId", "Seleccione una Categoria");
                        return View(producto);
                    }

                    if (producto.EstructuraId == 0)
                    {
                        ModelState.AddModelError("EstructuraId", "Seleccione una Estructura");
                        return View(producto);
                    }

                if (producto.EtiquetaId == 0)
                {
                    ModelState.AddModelError("EtiquetaId", "Seleccione una Etiqueta");
                    return View(producto);
                }

                if (producto.VendedorId == 0)
                {
                    ModelState.AddModelError("VendedorId", "Seleccione un Vendedor");
                    return View(producto);
                }
                

                if (imagen != null && imagen2 != null && imagen3 != null && imagen4 != null && imagen5 != null)
                    {
                        producto.UrlImagen = GuardarImagen(imagen);
                        producto.UrlImagen2 = GuardarImagen2(imagen2);
                        producto.UrlImagen3 = GuardarImagen3(imagen3);
                        producto.UrlImagen4 = GuardarImagen4(imagen4);
                        producto.UrlImagen5 = GuardarImagen5(imagen5);

                }

                    _productosBL.GuardarProducto(producto);

                    return RedirectToAction("Index");
                

            }

            return View(producto);
        }

        public ActionResult Editar(int id)
        {
            var producto = _productosBL.ObtenerProducto(id);
            var categorias = _categoriasBL.ObtenerCategorias();
            var estructuras = _estructurasBL.ObtenerEstructuras();
            var vendedores = _vendedoresBL.ObtenerVendedores();
            var etiquetas = _etiquetaBL.ObtenerEtiquetas();


            ViewBag.EstructuraId = new SelectList(estructuras, "Id", "Descripcion", producto.EstructuraId);

            ViewBag.CategoriaId = new SelectList(categorias, "Id", "Descripcion", producto.CategoriaId);

            ViewBag.VendedorId = new SelectList(vendedores, "Id", "Nombre", producto.VendedorId);

            ViewBag.EtiquetaId = new SelectList(etiquetas, "Id", "Descripcion", producto.EtiquetaId);

            return View(producto);
        }

        [HttpPost]
        public ActionResult Editar(Producto producto, HttpPostedFileBase imagen, HttpPostedFileBase imagen2,
            HttpPostedFileBase imagen3, HttpPostedFileBase imagen4, HttpPostedFileBase imagen5)
        {
            if (ModelState.IsValid)
            {

                if (producto.CategoriaId == 0)
                {
                    ModelState.AddModelError("CategoriaId", "Seleccione una Categoria");
                    return View(producto);
                }

                if (producto.EstructuraId == 0)
                {
                    ModelState.AddModelError("EstructuraId", "Seleccione una Estructura");
                    return View(producto);
                }

                if (producto.EtiquetaId == 0)
                {
                    ModelState.AddModelError("EtiquetaId", "Seleccione una Etiqueta");
                    return View(producto);
                }

                if (producto.VendedorId == 0)
                {
                    ModelState.AddModelError("VendedorId", "Seleccione un Vendedor");
                    return View(producto);
                }

                if (imagen != null && imagen2 != null && imagen3 != null && imagen4 != null && imagen5 != null)
                {
                    producto.UrlImagen = GuardarImagen(imagen);
                    producto.UrlImagen2 = GuardarImagen2(imagen2);
                    producto.UrlImagen3 = GuardarImagen3(imagen3);
                    producto.UrlImagen4 = GuardarImagen4(imagen4);
                    producto.UrlImagen5 = GuardarImagen5(imagen5);

                }

                _productosBL.GuardarProducto(producto);

                return RedirectToAction("Index");
            }

            return View(producto);
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

        private string GuardarImagen(HttpPostedFileBase imagen)
        {

            string path = Server.MapPath("~/Imagenes/" + imagen.FileName);
            imagen.SaveAs(path);

            return "/imagenes/" + imagen.FileName;

        }

        private string GuardarImagen2(HttpPostedFileBase imagen2)
        {

            string path = Server.MapPath("~/Imagenes/" + imagen2.FileName);
            imagen2.SaveAs(path);

            return "/imagenes/" + imagen2.FileName;

        }

        private string GuardarImagen3(HttpPostedFileBase imagen3)
        {

            string path = Server.MapPath("~/Imagenes/" + imagen3.FileName);
            imagen3.SaveAs(path);

            return "/imagenes/" + imagen3.FileName;

        }

        private string GuardarImagen4(HttpPostedFileBase imagen4)
        {

            string path = Server.MapPath("~/Imagenes/" + imagen4.FileName);
            imagen4.SaveAs(path);

            return "/imagenes/" + imagen4.FileName;

        }

        private string GuardarImagen5(HttpPostedFileBase imagen5)
        {

            string path = Server.MapPath("~/Imagenes/" + imagen5.FileName);
            imagen5.SaveAs(path);

            return "/imagenes/" + imagen5.FileName;

        }
    }
}