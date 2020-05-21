using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Looking4Home.BL
{
    public class Producto
    {
        public Producto()
        {
            EstructuraId = 1;
            CategoriaId = 1;
            Activo = true;
        }

        public int Id { get; set; }
        public string Descripcion { get; set; }
        public string Localizacion { get; set; }

        [Range(0, 1000000000, ErrorMessage = "Ilogico este Valor")]
        public int Parking { get; set; }

        [Range(1, 1000000000, ErrorMessage = "Colocar un valor mayor a 0")]
        public int Habitaciones { get; set; }

        [Range(1, 1000000000,ErrorMessage ="Colocar un valor mayor a 0")]
        public double Metros { get; set; }

        [Range(1, 1000000000, ErrorMessage = "Colocar un valor mayor a 0")]
        public double Precio { get; set; }

        [Range(1, 1000000000, ErrorMessage = "Colocar un valor mayor a 0")]
        public int Bano { get; set; }
        
        public string Estado { get; set; }        

        public int VendedorId { get; set; }
        public Vendedor Vendedor { get; set; }
        public int CategoriaId { get; set; }
        public Categoria Categoria { get; set; }
        public int EstructuraId { get; set; }
        public Estructura Estructura { get; set; }
        public int EtiquetaId { get; set; }
        public Etiqueta Etiqueta { get; set; }
        public double Latitude { get; set; }
        public double Longitud { get; set; }

        [Display(Name = "Imagen")]
        public string UrlImagen { get; set; }

        [Display(Name = "Imagen2")]
        public string UrlImagen2 { get; set; }

        [Display(Name = "Imagen3")]
        public string UrlImagen3 { get; set; }

        [Display(Name = "Imagen4")]
        public string UrlImagen4 { get; set; }

        [Display(Name = "Imagen5")]
        public string UrlImagen5 { get; set; }

        public bool Activo { get; set; }

    }
}
