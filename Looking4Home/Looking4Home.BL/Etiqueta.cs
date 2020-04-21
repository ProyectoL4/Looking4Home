using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Looking4Home.BL
{
    public class Etiqueta
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Ingrese la Etiqueta")]
        public string Descripcion { get; set; }
    }
}
