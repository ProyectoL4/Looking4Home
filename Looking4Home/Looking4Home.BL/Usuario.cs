using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Looking4Home.BL
{
    public class Usuario
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Ingrese el Nombre")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "Ingrese el Apellido")]
        public string Apellido { get; set; }

        [EmailAddress(ErrorMessage = "Ingrese un Correo")]
        public string Correo { get; set; }

        [Range(1, 100, ErrorMessage = "Colocar un valor mayor a 0")]
        public int edad { get; set; }

        public DateTime FechaInicio { get; set; }

        [Range(1, 1000000000000, ErrorMessage = "Colocar un valor mayor a 0")]
        public double Cedula { get; set; }

        //SEGURIDAD
        [Required(ErrorMessage = "Ingrese el Nombre")]
        public string NombUsuario { get; set; }

        [Display(Name = "Contraseña")]
        [Required(ErrorMessage = "Este campo es requerido.")]
        [StringLength(15, ErrorMessage = "Longitud entre 6 y 15 caracteres.", MinimumLength = 5)]
        [DataType(DataType.Password)]
        public string Contrasena { get; set; }

        [Display(Name = "Imagen")]
        public string UrlImagen { get; set; }

        public Usuario()
        {
            FechaInicio = DateTime.Now;
        }

    }
}
