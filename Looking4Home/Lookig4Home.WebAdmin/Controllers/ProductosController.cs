﻿using Looking4Home.BL;
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
        public ActionResult Crear(Producto producto, HttpPostedFileBase imagen)
        {
            if (ModelState.IsValid)
            {

                //if (imagen == null)
                //{
                //    ModelState.AddModelError("UrlImagen", "Seleccione una Imagen");
                //    return View(producto);
                //}
             
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
                

                if (imagen != null)
                    {
                        producto.UrlImagen = GuardarImagen(imagen);
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
        public ActionResult Editar(Producto producto, HttpPostedFileBase imagen)
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

                if (imagen != null )
                {
                    producto.UrlImagen = GuardarImagen(imagen);
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
    }
}