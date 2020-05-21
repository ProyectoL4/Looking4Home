using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Looking4Home.BL
{

    public class UsuariosBL
    {
        Contexto _contexto;
        public List<Usuario> ListadeUsuarios { get; set; }

        public UsuariosBL()
        {
            _contexto = new Contexto();
        }

        public List<Usuario> ObtenerUsuarios()
        {
            ListadeUsuarios = _contexto.Usuarios
                .OrderBy(r => r.Nombre)
                .ToList();

            return ListadeUsuarios;
        }


        //EXTRA ---------------------------------------------------------------------->

        public void Guardarusuario(Usuario usuario)
        {
            if (usuario.Id == 0)
            {
                _contexto.Usuarios.Add(usuario);
            }
            else
            {
                var usuarioExistente = _contexto.Usuarios.Find(usuario.Id);
                usuarioExistente.Nombre = usuario.Nombre;
            }

            _contexto.SaveChanges();
        }

        public Usuario ObtenerUsuarios(int id)
        {
            var usuario = _contexto.Usuarios.Find(id);

            return usuario;
        }

        public void EliminarUsuario(int id)
        {
            var usuario = _contexto.Usuarios.Find(id);

            _contexto.Usuarios.Remove(usuario);
            _contexto.SaveChanges();
        }
    }
}
