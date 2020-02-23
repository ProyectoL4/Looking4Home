using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Looking4Home.BL
{
    public class ProductosBL
    {
        Contexto _contexto;

        public List<Producto> ListadeProductos { get; set; }

        public ProductosBL()
        {
            _contexto = new Contexto();
            ListadeProductos = new List<Producto>();
        }

        public List<Producto> ObtenerProductos()
        {
            ListadeProductos= _contexto.Productos
                .Include("Categoria")
                .ToList();

            return ListadeProductos;
        }

        public void GuardarProducto(Producto producto)
        {

            if (producto.Activo == true)
            {
                producto.Estado = "Disponible";
            }
            else
            {
                producto.Estado = "No Disponible";
            }

            if (producto.Id == 0)
            {
                _contexto.Productos.Add(producto);
            }else
            {
                var productoExistente = _contexto.Productos.Find(producto.Id);
                productoExistente.Descripcion = producto.Descripcion;
                productoExistente.CategoriaId = producto.CategoriaId;
                productoExistente.Localizacion = producto.Localizacion;
                productoExistente.Parking = producto.Parking;
                productoExistente.Habitaciones = producto.Habitaciones;
                productoExistente.Metros = producto.Metros;
                productoExistente.Precio = producto.Precio;
                productoExistente.Estado = producto.Estado;
            }

            if (producto.Activo == true)
            {
               
            }
            
            _contexto.SaveChanges();
        }

        public Producto ObtenerProducto(int id)
        {
            var producto = _contexto.Productos
                .Include("Categoria").FirstOrDefault(p => p.Id == id);

            return producto;
        }

        public void EliminarProducto(int id)
        {
            var producto = _contexto.Productos.Find(id);

            _contexto.Productos.Remove(producto);
            _contexto.SaveChanges();
        }
    }
}
