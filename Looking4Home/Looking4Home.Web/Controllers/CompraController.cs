using Looking4Home.BL;
using Looking4Home.Web.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Looking4Home.Web.Controllers
{
    public class CompraController : Controller
    {
        ProductosBL _productosBL;

        #region /*LISTADO POR PAGINA*/

        private readonly int _RegistrosPorPagina = 10;

        private Contexto _DbContext;
        private List<Producto> _Productos;
        private PaginadorGenerico _PaginadorProductos;

        #endregion

        public CompraController()
        {
            _productosBL = new ProductosBL();
        }

        // GET: Mapa
        public ActionResult Index()
        {

            var listadeProductos = _productosBL.ObtenerProductosActivos();

            ViewBag.adminWebsiteUrl =
                ConfigurationManager.AppSettings["adminWebsiteUrl"];

            return View(listadeProductos);

        }

        // GET: LISTADO POR PAGINA
        public ActionResult Index2(int pagina = 1)
        {
            #region /*LISTADO POR PAGINA*/

            using (_DbContext = new Contexto())
            {
                // Obtenemos la 'página de registros' de la tabla Customers
                _Productos = _DbContext.Productos.OrderBy(x => x.Id)
                                                 .Skip((pagina - 1) * _RegistrosPorPagina)
                                                 .Take(_RegistrosPorPagina)
                                                 .ToList();

                // Enviamos a la Vista la 'Clase de paginación'
                return View(_PaginadorProductos);
            }

            #endregion
        }


    }


}