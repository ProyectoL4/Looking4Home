using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Looking4Home.Web.Models
{
    public class PaginadorGenerico
    {
        public int PaginaActual { get; set; }
        public int RegistrosPorPagina { get; set; }
        public int TotalRegistros { get; set; }
        public int TotalPaginas { get; set; }
        /*public IEnumerable<T> Resultado { get; set; }*/
    }
}