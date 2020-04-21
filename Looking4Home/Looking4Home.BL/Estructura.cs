using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Looking4Home.BL
{
    public class Estructura
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Ingrese una Estructura")]
        public string Descripcion { get; set; }
               
    }
}
