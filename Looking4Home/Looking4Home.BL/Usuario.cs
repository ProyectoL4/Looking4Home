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

        [Display(Name = "Edad")]
        [Range(18, 100, ErrorMessage = "Debe ser mayor a 18 años")]
        public int edad { get; set; }

        public DateTime FechaInicio { get; set; }

        
        public double Cedula { get; set; }

        //SEGURIDAD
        [Display(Name = "Nombre de Usuario")]
        [Required(ErrorMessage = "Ingrese el Nombre")]
        public string NombUsuario { get; set; }

        [Display(Name = "Contraseña")]
        [Required(ErrorMessage = "Este campo es requerido.")]
        [MinLength(6, ErrorMessage = "Longitud minima es de 6 caracteres.")]
        [DataType(DataType.Password)]
        public string Contrasena { get; set; }

        [Display(Name = "Confirmar Contraseña")]
        [Required(ErrorMessage = "Este campo es requerido.")]
        [MinLength(6, ErrorMessage = "Longitud minima es de 6 caracteres.")]
        [DataType(DataType.Password)]
        public string Contrasena2 { get; set; }

        [Display(Name = "Imagen")]
        public string UrlImagen { get; set; }

        public Usuario()
        {
            FechaInicio = DateTime.Now;
        }

    }
}
