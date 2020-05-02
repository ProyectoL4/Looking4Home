using Lookig4Home.WebAdmin.Models;
using Looking4Home.BL;
using Pagination;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lookig4Home.WebAdmin.Controllers
{
    [Authorize]
    public class CategoriasController : Controller
    {
        CategoriasBL _categoriasBL;
        public CategoriasController()
        {
            _categoriasBL = new CategoriasBL();
        }

        // GET: Categorias
        public ActionResult Index(SearchModel model)
        {
            var factory = new PageSourceFactory
            {

                MaxItemsPerPage = 10, // maximo elementos por pagina
                DefaultItemsPerPage = 5 // elementos por pagina
            };

            var listadeCategorias =
                _categoriasBL.ObtenerCategorias().AsQueryable(); // Marcar como AsQueryable

            var searchText = model.SearchText;
            if (!string.IsNullOrWhiteSpace(searchText)) listadeCategorias
                    = listadeCategorias.Where(c => c.Descripcion.ToLower().Contains(searchText.ToLower())); // Buscar en descripcion de la categoria

            var source = factory.CreateSource(listadeCategorias, model);

            return View(source); // enviar el query al view
        }

        public ActionResult Crear()
        {
            var nuevacategoria = new Categoria();

            return View(nuevacategoria);
        }

        [HttpPost]
        public ActionResult Crear(Categoria categoria)
        {

            if (ModelState.IsValid)
            {
                _categoriasBL.GuardarCategoria(categoria);

                return RedirectToAction("Index");
            }

            return View(categoria);
        }

        public ActionResult Editar(int id)
        {
            var categoria = _categoriasBL.ObtenerCategoria(id);
            return View(categoria);
        }

        [HttpPost]
        public ActionResult Editar(Categoria categoria)
        {
            if (ModelState.IsValid)
            {
                _categoriasBL.GuardarCategoria(categoria);

                return RedirectToAction("Index");
            }

            return View(categoria);
        }

        public ActionResult Detalle(int id)
        {
            var categoria = _categoriasBL.ObtenerCategoria(id);
            return View(categoria);
        }

        public ActionResult Eliminar(int id)
        {
            var categoria = _categoriasBL.ObtenerCategoria(id);
            return View(categoria);
        }

        [HttpPost]
        public ActionResult Eliminar(Categoria categoria)
        {
            _categoriasBL.EliminarCategoria(categoria.Id);
            return RedirectToAction("Index");
        }
    }
}