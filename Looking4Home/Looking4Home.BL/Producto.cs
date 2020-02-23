using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Looking4Home.BL
{
    public class Producto
    {
        public Producto()
        {
            CategoriaId = 1;
            Activo = true;
        }

        public int Id { get; set; }
        public string Descripcion { get; set; }
        public string Localizacion { get; set; }
        public int Parking { get; set; }
        public int Habitaciones { get; set; }
        public double Metros { get; set; }
        public double Precio { get; set; }
        public int CategoriaId { get; set; }
        public Categoria Categoria { get; set; }
        public bool Activo { get; set; }

    }
}
