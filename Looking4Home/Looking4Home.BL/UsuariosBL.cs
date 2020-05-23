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
                
                usuario.Contrasena = Encriptar.CodificarConstrasena(usuario.Contrasena);

                _contexto.Usuarios.Add(usuario);
            }
            else
            {
                

                var usuarioExistente = _contexto.Usuarios.Find(usuario.Id);

                usuario.Contrasena = Encriptar.CodificarConstrasena(usuario.Contrasena);

                usuarioExistente.Nombre = usuario.Nombre;
                usuarioExistente.Apellido = usuario.Apellido;
                usuarioExistente.NombUsuario = usuario.NombUsuario;
                usuarioExistente.Contrasena = usuario.Contrasena;
                usuarioExistente.Contrasena2 = usuario.Contrasena2;

                usuarioExistente.Cedula = usuario.Cedula;
                usuarioExistente.edad = usuario.edad;
                usuarioExistente.Correo = usuario.Correo;
                usuarioExistente.FechaInicio = usuario.FechaInicio;

                if (usuario.UrlImagen != null )
                {
                    usuarioExistente.UrlImagen = usuario.UrlImagen;

                }

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
