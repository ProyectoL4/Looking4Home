using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Looking4Home.BL
{
    public class ProductosBL
    {
        public List<Producto> ObtenerProductos()
        {
            var producto1 = new Producto();
            producto1.Id = 1;
            producto1.Descripcion = "Casa";
            producto1.Direccion = "EL Pedregal";
            producto1.Precio = 5000000;

            var producto2 = new Producto();
            producto2.Id = 2;
            producto2.Descripcion = "Townhouse";
            producto2.Direccion = "Los Andes";
            producto2.Precio = 3000000;

            var producto3 = new Producto();
            producto3.Id = 3;
            producto3.Descripcion = "Condominio";
            producto3.Direccion = "Colonia Jardines del Valle";
            producto3.Precio = 1500000;

            var producto4 = new Producto();
            producto4.Id = 4;
            producto4.Descripcion = "Departamento";
            producto4.Direccion = "Barrio Barandillas";
            producto4.Precio = 800000;

            var listadeProductos = new List<Producto>();
            listadeProductos.Add(producto1);
            listadeProductos.Add(producto2);
            listadeProductos.Add(producto3);
            listadeProductos.Add(producto4);

            return listadeProductos;
        }
    }
}
