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

        public List<Producto> ObtenerProductos(string buscar, string etiqueta)
        {
            string precio = "Precio";
            string vendedores = "Vendedores";
            ListadeProductos = _contexto.Productos
                .Include("Categoria")
                .Include("Estructura")
                .Include("Vendedor")
                .Include("Etiqueta")
                .Where(r => r.Localizacion.ToLower().Contains(buscar.ToLower()) &&
                            r.Etiqueta.Descripcion.Contains(etiqueta) ||
                            r.Precio.ToString().Contains(buscar) && etiqueta == precio ||
                            r.Vendedor.Nombre.ToLower().Contains(buscar.ToLower()) && etiqueta == vendedores) // busca en cualquier parte de la descripcion
                .ToList();

            return ListadeProductos;
        }

        public List<Producto> ObtenerProductosIndividuales(string buscar)
        {
            ListadeProductos = _contexto.Productos
                .Include("Categoria")
                .Include("Estructura")
                .Include("Vendedor")
                .Include("Etiqueta")
                .Where(r => r.Id.ToString().Contains(buscar.ToLower())) // busca en cualquier parte de la descripcion
                .ToList();

            return ListadeProductos;
        }

        public List<Producto> ObtenerProductos()
        {
            ListadeProductos = _contexto.Productos
                .Include("Categoria")
                .Include("Estructura")
                .Include("Vendedor")
                .Include("Etiqueta")
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
            }
            else
            {
                var productoExistente = _contexto.Productos.Find(producto.Id);
                productoExistente.Descripcion = producto.Descripcion;
                productoExistente.CategoriaId = producto.CategoriaId;
                productoExistente.EstructuraId = producto.EstructuraId;
                productoExistente.Localizacion = producto.Localizacion;
                productoExistente.Parking = producto.Parking;
                productoExistente.Habitaciones = producto.Habitaciones;
                productoExistente.Metros = producto.Metros;
                productoExistente.Precio = producto.Precio;
                productoExistente.Estado = producto.Estado;
                productoExistente.Bano = producto.Bano;
                productoExistente.EtiquetaId = producto.EtiquetaId;
                productoExistente.Latitude = producto.Latitude;
                productoExistente.Longitud = producto.Longitud;
                productoExistente.VendedorId = producto.VendedorId;

                if (producto.UrlImagen != null || producto.UrlImagen2 != null || producto.UrlImagen3 != null
                    || producto.UrlImagen4 != null || producto.UrlImagen5 != null)
                {
                    productoExistente.UrlImagen = producto.UrlImagen;
                    productoExistente.UrlImagen2 = producto.UrlImagen2;
                    productoExistente.UrlImagen3 = producto.UrlImagen3;
                    productoExistente.UrlImagen4 = producto.UrlImagen4;
                    productoExistente.UrlImagen5 = producto.UrlImagen5;
                }

            }

            if (producto.Activo == true)
            {

            }

            _contexto.SaveChanges();
        }

        public Producto ObtenerProducto(int id)
        {
            var producto = _contexto.Productos
                .Include("Categoria")
                .Include("Estructura")
                .Include("Vendedor")
                .Include("Etiqueta")
                .FirstOrDefault(p => p.Id == id);

            return producto;
        }

        public void EliminarProducto(int id)
        {
            var producto = _contexto.Productos.Find(id);

            _contexto.Productos.Remove(producto);
            _contexto.SaveChanges();
        }

        public List<Producto> ObtenerProductosActivos()
        {
            ListadeProductos = _contexto.Productos
                .Include("Categoria")
                .Include("Estructura")
                .Include("Vendedor")
                .Include("Etiqueta")
                .Where(r => r.Activo == true)
                .OrderBy(r => r.Descripcion)
                .ToList();

            return ListadeProductos;
        }

        public List<Producto> ObtenerProductosActivos2()
        {
            string categoria = "Venta";
            ListadeProductos = _contexto.Productos
                .Include("Categoria")
                .Include("Estructura")
                .Include("Vendedor")
                .Include("Etiqueta")
                .Where(r => r.Activo == true && r.Etiqueta.Descripcion.Contains(categoria))
                .OrderBy(r => r.Id)
                .ToList();

            return ListadeProductos;
        }

        public List<Producto> ObtenerProductosActivos3()
        {
            string categoria = "Renta";
            ListadeProductos = _contexto.Productos
                .Include("Categoria")
                .Include("Estructura")
                .Include("Vendedor")
                .Include("Etiqueta")
                .Where(r => r.Activo == true && r.Etiqueta.Descripcion.Contains(categoria))
                .OrderBy(r => r.Id)
                .ToList();

            return ListadeProductos;
        }
    }
}
