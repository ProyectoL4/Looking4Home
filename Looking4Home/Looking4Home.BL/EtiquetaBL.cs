using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Looking4Home.BL
{
    public class EtiquetaBL
    {
        Contexto _contexto;

        public List<Etiqueta> ListadeEtiquetas { get; set; }

        public EtiquetaBL()
        {
            _contexto = new Contexto();
            ListadeEtiquetas = new List<Etiqueta>();
        }

        public List<Etiqueta> ObtenerEtiquetas()
        {
            ListadeEtiquetas = _contexto.Etiquetas.ToList();

            return ListadeEtiquetas;
        }

        public void GuardarEtiqueta(Etiqueta etiqueta)
        {
            if (etiqueta.Id == 0)
            {
                _contexto.Etiquetas.Add(etiqueta);
            }
            else
            {
                var etiquetaExistente = _contexto.Etiquetas.Find(etiqueta.Id);
                etiquetaExistente.Descripcion = etiqueta.Descripcion;
            }

            _contexto.SaveChanges();
        }

        public Etiqueta ObtenerEtiqueta(int id)
        {
            var etiqueta = _contexto.Etiquetas.Find(id);

            return etiqueta;
        }

        public void EliminarEtiqueta(int id)
        {
            var etiqueta = _contexto.Etiquetas.Find(id);

            _contexto.Etiquetas.Remove(etiqueta);
            _contexto.SaveChanges();
        }
    }
}
