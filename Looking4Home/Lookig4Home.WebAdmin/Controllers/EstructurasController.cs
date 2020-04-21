using Looking4Home.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lookig4Home.WebAdmin.Controllers
{
    [Authorize]
    public class EstructurasController : Controller
    {
        EstructurasBL _estructurasBL;

        public EstructurasController()
        {
            _estructurasBL = new EstructurasBL();
        }

        // GET: Estructuras
        public ActionResult Index()
        {
            var listadeEstructuras = _estructurasBL.ObtenerEstructuras();
            return View(listadeEstructuras);
        }

        public ActionResult Crear()
        {
            var nuevaEstructura = new Estructura();
            return View(nuevaEstructura);
        }

        [HttpPost]
        public ActionResult Crear(Estructura estructura)
        {
            _estructurasBL.GuardarEstructura(estructura);

            return RedirectToAction("Index");
        }

        public ActionResult Editar(int id)
        {
            var estructura = _estructurasBL.ObtenerEstructura(id);
            return View(estructura);
        }

        [HttpPost]
        public ActionResult Editar(Estructura estructura)
        {
            _estructurasBL.GuardarEstructura(estructura);
            return RedirectToAction("Index");
        }

        public ActionResult Detalle(int id)
        {
            var estructura = _estructurasBL.ObtenerEstructura(id);
            return View(estructura);
        }

        public ActionResult Eliminar(int id)
        {
            var estructura = _estructurasBL.ObtenerEstructura(id);
            return View(estructura);
        }

        [HttpPost]
        public ActionResult Eliminar(Estructura estructura)
        {
            _estructurasBL.EliminarEstructura(estructura.Id);
            return RedirectToAction("Index");
        }
    }
}