using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Looking4Home.BL
{
    public class EstructurasBL
    {
        Contexto _contexto;

        public List<Estructura> ListadeEstructuras { get; set; }

        public EstructurasBL()
        {
            _contexto = new Contexto();
            ListadeEstructuras = new List<Estructura>();
        }

        public List<Estructura> ObtenerEstructuras()
        {
            ListadeEstructuras = _contexto.Estructuras.ToList();

            return ListadeEstructuras;
        }

        public void GuardarEstructura(Estructura estructura)
        {
            if (estructura.Id == 0)
            {
                _contexto.Estructuras.Add(estructura);
            }else
            {
                var estructuraExistente = _contexto.Estructuras.Find(estructura.Id);
                estructuraExistente.Descripcion = estructura.Descripcion;
            }

            _contexto.SaveChanges();
        }

        public Estructura ObtenerEstructura(int id)
        {
            var estructura = _contexto.Estructuras.Find(id);
            return estructura;
        }

        public void EliminarEstructura(int id)
        {
            var estructura = _contexto.Estructuras.Find(id);

            _contexto.Estructuras.Remove(estructura);
            _contexto.SaveChanges();
        }
    }
}
