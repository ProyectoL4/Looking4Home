using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Looking4Home.BL
{
    public class UsuarioWebBL
    {
        Contexto _contexto;
        public List<UsuarioWeb> ListadeUsuariosWebs { get; set; }

        public UsuarioWebBL()
        {
            _contexto = new Contexto();
            ListadeUsuariosWebs = new List<UsuarioWeb>();
        }

        public List<UsuarioWeb> ObtenerUsuariosWeb()
        {
            ListadeUsuariosWebs = _contexto.UsuariosWebs
                .OrderBy(r => r.Nombre)
                .ToList();

            return ListadeUsuariosWebs;
        }

        public void GuardarUsuarioWeb(UsuarioWeb usuarioWeb)
        {
            if(usuarioWeb.Id == 0)
            {
                _contexto.UsuariosWebs.Add(usuarioWeb);
            }else
            {
                var usuarioWebExistente = _contexto.UsuariosWebs.Find(usuarioWeb.Id);
                usuarioWebExistente.Nombre = usuarioWeb.Nombre;
                usuarioWebExistente.CorreoE = usuarioWeb.CorreoE;
                usuarioWebExistente.Contrasena = usuarioWeb.Contrasena;
            }

            _contexto.SaveChanges();
        }

        public UsuarioWeb ObtenerUsuarioWeb(int id)
        {
            var usuarioWeb = _contexto.UsuariosWebs.Find(id);
            return usuarioWeb;
        }
    }
}
