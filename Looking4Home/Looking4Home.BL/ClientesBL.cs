using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Looking4Home.BL
{
    public class ClientesBL
    {
        Contexto _contexto;
        public List<Cliente> ListadeClientes { get; set; }

        public ClientesBL()
        {
            _contexto = new Contexto();
            ListadeClientes = new List<Cliente>();
        }

        public List<Cliente> ObtenerClientes()
        {
            ListadeClientes = _contexto.Clientes
                .OrderBy(r => r.Nombre)
                .ToList();
            return ListadeClientes;
        }
    
        public void GuardarCliente(Cliente cliente)
        {
            if (cliente.Id == 0)
            {
                _contexto.Clientes.Add(cliente);
            } else
            {
                var clienteExistente = _contexto.Clientes.Find(cliente.Id);
                clienteExistente.Nombre = cliente.Nombre;
                clienteExistente.Contraseña = cliente.Contraseña;
                clienteExistente.Telefono = cliente.Telefono;
                clienteExistente.Correo = cliente.Correo;
                clienteExistente.Celular = cliente.Celular;
                clienteExistente.Activo = cliente.Activo;
                if (cliente.UrlImagen != null)
                {
                    clienteExistente.UrlImagen = cliente.UrlImagen;
                }

            }
            _contexto.SaveChanges();
        }

        public Cliente ObtenerCliente(int id)
        {
            var cliente = _contexto.Clientes.Find(id);
            return cliente;
        }

        public void EliminarCliente (int id)
        {
            var cliente = _contexto.Clientes.Find(id);
            _contexto.Clientes.Remove(cliente);
            _contexto.SaveChanges();
        }

        public List<Cliente> ObtenerClientesActivos()
        {
            ListadeClientes = _contexto.Clientes
                .Where(r => r.Activo == true)
                .OrderBy(r => r.Nombre)
                .ToList();

            return ListadeClientes;
        }
    }
}
