using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Looking4Home.BL
{
   public class VendedoresBL
    {
        Contexto _contexto;
        public List<Vendedor> ListadeVendedores { get; set; }

        public VendedoresBL()
        {
            _contexto = new Contexto();
            ListadeVendedores = new List<Vendedor>();
        }

        public List<Vendedor> ObtenerVendedores()
        {
           

            ListadeVendedores = _contexto.Vendedores.ToList();
            return ListadeVendedores;
        }

       

        public void GuardarVendedor(Vendedor vendedor)
        {
            if (vendedor.Id == 0)
            {
                _contexto.Vendedores.Add(vendedor);
            }
            else
            {
                var vendedorExistente = _contexto.Vendedores.Find(vendedor.Id);
                vendedorExistente.Nombre = vendedor.Nombre;
                vendedorExistente.Contrasena = vendedor.Contrasena;
                vendedorExistente.Telefono = vendedor.Telefono;
                vendedorExistente.Correo = vendedor.Correo;
                vendedorExistente.Celular = vendedor.Celular;
                vendedorExistente.Activo = vendedor.Activo;
                vendedorExistente.Descripcion = vendedor.Descripcion;

                if (vendedor.UrlImagen != null)
                {
                    vendedorExistente.UrlImagen = vendedor.UrlImagen;
                }

            }
            _contexto.SaveChanges();
        }

        public Vendedor ObtenerVendedor(int id)
        {
            var vendedor = _contexto.Vendedores.Find(id);
            return vendedor;
        }

        public void EliminarVendedor(int id)
        {
            var vendedor = _contexto.Vendedores.Find(id);
            _contexto.Vendedores.Remove(vendedor);
            _contexto.SaveChanges();
        }

        public List<Vendedor> ObtenerVendedoresActivos()
        {
            ListadeVendedores = _contexto.Vendedores
                .Where(r => r.Activo == true)
                .OrderBy(r => r.Nombre)
                .ToList();

            return ListadeVendedores;
        }
    }
}