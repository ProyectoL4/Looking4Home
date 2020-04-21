using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Looking4Home.BL
{
    public class DatosdeInicio : CreateDatabaseIfNotExists<Contexto>
    {
        protected override void Seed(Contexto contexto)
        {
            #region Etiqueta
            var etiqueta1 = new Etiqueta();
            etiqueta1.Descripcion = "Venta";
            contexto.Etiquetas.Add(etiqueta1);

            var etiqueta2 = new Etiqueta();
            etiqueta2.Descripcion = "Renta";
            contexto.Etiquetas.Add(etiqueta2);

            #endregion

            #region Clientes

            var cliente1 = new Cliente();
            cliente1.Nombre = "Kevin Amaya";
            cliente1.Contraseña = "kevin123";
            cliente1.Telefono ="98563241";
            cliente1.Celular ="93652487";
            cliente1.Correo ="Kevinamaya@gmail.com";
            cliente1.Activo = true;
            contexto.Clientes.Add(cliente1);

            var cliente2 = new Cliente();
            cliente2.Nombre = "German Mendoza";
            cliente2.Contraseña = "german123";
            cliente2.Telefono = "98563241";
            cliente2.Celular = "93652487";
            cliente2.Correo = "GermanMendoza@outlook.com";
            cliente2.Activo = true;
            contexto.Clientes.Add(cliente2);


            var cliente3 = new Cliente();
            cliente3.Nombre = "Andres Baide";
            cliente3.Contraseña = "andres123";
            cliente3.Telefono = "98563241";
            cliente3.Celular = "93652487";
            cliente3.Correo = "AndresBaide@aol.com";
            cliente3.Activo = true;
            contexto.Clientes.Add(cliente3);

            var cliente4 = new Cliente();
            cliente4.Nombre = "Juan Alvarado";
            cliente4.Contraseña = "juan123";
            cliente4.Telefono = "98563241";
            cliente4.Celular = "93652487";
            cliente4.Correo = "JuanAlvarado@yahoo.com";
            cliente4.Activo = true;
            contexto.Clientes.Add(cliente4);


            #endregion

            #region Estructura

            var estructura1 = new Estructura();
            estructura1.Descripcion = "Hormigón";
            contexto.Estructuras.Add(estructura1);

            var estructura2 = new Estructura();
            estructura2.Descripcion = "Acero";
            contexto.Estructuras.Add(estructura2);


            var estructura3 = new Estructura();
            estructura3.Descripcion = "Madera";
            contexto.Estructuras.Add(estructura3);

            var estructura4 = new Estructura();
            estructura4.Descripcion = "Acero de Calibre Ligero";
            contexto.Estructuras.Add(estructura4);


            #endregion

            #region Categoria

            var categoria1 = new Categoria();
            categoria1.Descripcion = "Casa";
            contexto.Categorias.Add(categoria1);

            var categoria2 = new Categoria();
            categoria2.Descripcion = "Departamento";
            contexto.Categorias.Add(categoria2);


            var categoria3 = new Categoria();
            categoria3.Descripcion = "Local";
            contexto.Categorias.Add(categoria3);

            var categoria4 = new Categoria();
            categoria4.Descripcion = "Terreno";
            contexto.Categorias.Add(categoria4);

            var categoria5 = new Categoria();
            categoria5.Descripcion = "Edificio";
            contexto.Categorias.Add(categoria5);

            var categoria6 = new Categoria();
            categoria6.Descripcion = "Nave Industrial";
            contexto.Categorias.Add(categoria6);

            var categoria7 = new Categoria();
            categoria7.Descripcion = "Condominio";
            contexto.Categorias.Add(categoria7);

            var categoria8 = new Categoria();
            categoria8.Descripcion = "Bodega Industrial";
            contexto.Categorias.Add(categoria8);

            var categoria9 = new Categoria();
            categoria9.Descripcion = "Casa Rodante";
            contexto.Categorias.Add(categoria9);


            #endregion

            #region Vendedor

            var Vendedor1 = new Vendedor();
            Vendedor1.Nombre = cliente1.Nombre;
            Vendedor1.Descripcion = "Experto en Ventas y financiamiento";
            Vendedor1.Contrasena = cliente1.Contraseña;
            Vendedor1.Telefono = cliente1.Telefono;
            Vendedor1.Celular = cliente1.Celular;
            Vendedor1.Correo = cliente1.Correo;
            Vendedor1.Activo = cliente1.Activo;
            contexto.Vendedores.Add(Vendedor1);

            var Vendedor2 = new Vendedor();
            Vendedor2.Nombre = "Mi Roca Fuerte";
            Vendedor2.Descripcion = "Experto en Compra y Ventas";
            Vendedor2.Contrasena = "roca123";
            Vendedor2.Telefono = "98563241";
            Vendedor2.Celular = "93652487";
            Vendedor2.Correo = "rocafuerte@yahoo.com";
            Vendedor2.Activo = true;
            contexto.Vendedores.Add(Vendedor2);

            var Vendedor3 = new Vendedor();
            Vendedor3.Nombre = "Alpine";
            Vendedor3.Descripcion = "Veterano en lo que a Venta de casas respecta, con mas de 20 años en servicio";
            Vendedor3.Contrasena = "alpine123";
            Vendedor3.Telefono = "98563241";
            Vendedor3.Celular = "93652487";
            Vendedor3.Correo = "alpine@outlook.com";
            Vendedor3.Activo = true;
            contexto.Vendedores.Add(Vendedor3);

            var Vendedor4 = new Vendedor();
            Vendedor4.Nombre = "Fenix";
            Vendedor4.Descripcion = "Nuevo, pero emprendedor y abriendoce paso en el mundo";
            Vendedor4.Contrasena = "fenix123";
            Vendedor4.Telefono = "98563241";
            Vendedor4.Celular = "93652487";
            Vendedor4.Correo = "fenix@aol.com";
            Vendedor4.Activo = true;
            contexto.Vendedores.Add(Vendedor4);

            #endregion

            #region Usuarios
            var UsuarioAdmin = new Usuario();
            UsuarioAdmin.Nombre = "admin";            
            UsuarioAdmin.Contrasena = Encriptar.CodificarConstrasena("123");
            contexto.Usuarios.Add(UsuarioAdmin);

            var usuario1 = new Usuario();
            usuario1.Nombre = "German Mendoza";
            usuario1.Correo = "german.mendoza1998@gmail.com";
            usuario1.Contrasena = Encriptar.CodificarConstrasena("12345");
            contexto.Usuarios.Add(usuario1);

            var usuario2 = new Usuario();
            usuario2.Nombre = "Kevin Rivera";
            usuario2.Correo = "kevrivera@gmail.com";
            usuario2.Contrasena = Encriptar.CodificarConstrasena("12345");
            contexto.Usuarios.Add(usuario2);

            var usuario3 = new Usuario();
            usuario3.Nombre = "Juan Alvarado";
            usuario3.Correo = "juanalva@gmail.com";
            usuario3.Contrasena = Encriptar.CodificarConstrasena("12345");
            contexto.Usuarios.Add(usuario3);

            var usuario4 = new Usuario();
            usuario4.Nombre = "Andres Baide";
            usuario4.Correo = "andreswbaide@gmail.com";
            usuario4.Contrasena = Encriptar.CodificarConstrasena("12345");
            contexto.Usuarios.Add(usuario4);

            #endregion



            #region PRODUCTOS ---ES DE QUIEN LA PUEDA ARREGLAR
            /*
            var producto1 = new Producto();           
            producto1.Descripcion = "Cerca de posta policial, bella vista y vecindad amistosa";
            producto1.Localizacion = "Aun no Disponible";
            producto1.Parking = 2;
            producto1.Habitaciones = 4;
            producto1.Metros = 4500;
            producto1.Precio = 12500;
            producto1.Bano = 4;
            producto1.Estado = "Disponible";

            producto1.VendedorId = 1;
            producto1.EtiquetaId = 1;
            producto1.CategoriaId = 1;
            producto1.EstructuraId = 3;
            producto1.UrlImagen = null;
            contexto.Productos.Add(producto1);

            var producto2 = new Producto();
            producto2.Descripcion = "Hospital cerca de la zona, Escuela a unas cuantas cuadras";
            producto2.Localizacion = "Aun no Disponible";
            producto2.Parking = 1;
            producto2.Habitaciones = 3;
            producto2.Metros = 1200;
            producto2.Precio = 20500;
            producto2.Bano = 5;
            producto2.Estado = "Disponible";

            producto2.VendedorId = 2;
            producto2.EtiquetaId = 1;
            producto2.CategoriaId = 1;
            producto2.EstructuraId = 2;
            producto2.UrlImagen = null;
            contexto.Productos.Add(producto2);

            var producto3 = new Producto();
            producto3.Descripcion = "Escuela Bilingue de facil acceso, Campo de Football cerca";
            producto3.Localizacion = "Aun no Disponible";
            producto3.Parking = 1;
            producto3.Habitaciones = 3;
            producto3.Metros = 1200;
            producto3.Precio = 12500;
            producto3.Bano = 5;
            producto3.Estado = "Disponible";

            producto3.VendedorId = 3;
            producto3.EtiquetaId = 1;
            producto3.CategoriaId = 1;
            producto3.EstructuraId = 1;
            producto3.UrlImagen = null;
            contexto.Productos.Add(producto3);

            var producto4 = new Producto();
            producto4.Descripcion = "Escuela catolica cercana, bella vista";
            producto4.Localizacion = "Aun no Disponible";
            producto4.Parking = 8;
            producto4.Habitaciones = 4;
            producto4.Metros = 12000;
            producto4.Precio = 200500;
            producto4.Bano = 5;
            producto4.Estado = "Disponible";

            producto4.VendedorId = 4;
            producto4.EtiquetaId = 1;
            producto4.CategoriaId = 1;
            producto4.EstructuraId = 4;
            producto4.UrlImagen = null;
            contexto.Productos.Add(producto4);

            var producto5 = new Producto();
            producto5.Descripcion = "Cerca de Hospital, bella vista y gran jardin";
            producto5.Localizacion = "Aun no Disponible";
            producto5.Parking = 0;
            producto5.Habitaciones = 8;
            producto5.Metros = 52000;
            producto5.Precio = 200500;
            producto5.Bano = 8;
            producto5.Estado = "Disponible";

            producto5.VendedorId = 2;
            producto5.EtiquetaId = 1;
            producto5.CategoriaId = 1;
            producto5.EstructuraId = 1;
            producto5.UrlImagen = null;
            contexto.Productos.Add(producto5);

            var producto6 = new Producto();
            producto6.Descripcion = "Seguridad Privada, Wifi Gratis";
            producto6.Localizacion = "Aun no Disponible";
            producto6.Parking = 0;
            producto6.Habitaciones = 2;
            producto6.Metros = 200;
            producto6.Precio = 5500;
            producto6.Bano = 1;
            producto6.Estado = "Disponible";

            producto6.VendedorId = 1;
            producto6.EtiquetaId = 2;
            producto6.CategoriaId = 2;
            producto6.EstructuraId = 4;
            producto6.UrlImagen = null;
            contexto.Productos.Add(producto6);

            var producto7 = new Producto();
            producto7.Descripcion = "Seguridad Privada, Wifi Gratis";
            producto7.Localizacion = "Aun no Disponible";
            producto7.Parking = 1;
            producto7.Habitaciones = 3;
            producto7.Metros = 200;
            producto7.Precio = 6500;
            producto7.Bano = 2;
            producto7.Estado = "Disponible";

            producto7.VendedorId = 3;
            producto7.EtiquetaId = 2;
            producto7.CategoriaId = 2;
            producto7.EstructuraId = 2;
            producto7.UrlImagen = null;
            contexto.Productos.Add(producto7);
            */

            #endregion

            base.Seed(contexto);
        }
    }
}
