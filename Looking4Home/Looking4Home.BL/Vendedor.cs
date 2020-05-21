using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Looking4Home.BL
{
   public class Vendedor
    {
        public Vendedor()
    {
        Activo = true;
    }

    public int Id { get; set; }
    [Required(ErrorMessage = "Ingrese un Nombre")]
    public string Nombre { get; set; }
    
    [Required(ErrorMessage = "Ingrese una Descripcion")]
    public string Descripcion { get; set; }
    

    [Display(Name = "Contraseña")]
    [Required(ErrorMessage = "Este campo es requerido.")]
    [StringLength(15, ErrorMessage = "Longitud entre 6 y 15 caracteres.", MinimumLength = 6)]
    [DataType(DataType.Password)]
    public string Contrasena { get; set; }

    [Required(ErrorMessage = "Ingrese un Telefono")]
    public string Telefono { get; set; }

    [Required(ErrorMessage = "Ingrese un Celular")]
    public string Celular { get; set; }

    [EmailAddress(ErrorMessage = "Ingrese un Correo")]
    public string Correo { get; set; }


    [Display(Name = "Imagen")]
    public string UrlImagen { get; set; }
    public bool Activo { get; set; }
 }
}