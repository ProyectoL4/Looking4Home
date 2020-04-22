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
    }
}
