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
            etiqueta1.Id = 1;
            etiqueta1.Descripcion = "Venta";
            contexto.Etiquetas.Add(etiqueta1);

            var etiqueta2 = new Etiqueta();
            etiqueta2.Id = 2;
            etiqueta2.Descripcion = "Renta";
            contexto.Etiquetas.Add(etiqueta2);

            #endregion

            #region Clientes

            var cliente1 = new Cliente();
            cliente1.Nombre = "Kevin Amaya";
            cliente1.Contraseña = "kevin123";
            cliente1.Telefono = "98563241";
            cliente1.Celular = "93652487";
            cliente1.Correo = "Kevinamaya@gmail.com";
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

            var cliente5 = new Cliente();
            cliente5.Nombre = "Ricardo Gonzales";
            cliente5.Contraseña = "ricardo123";
            cliente5.Telefono = "92543241";
            cliente5.Celular = "98622457";
            cliente5.Correo = "RicardoG@yahoo.com";
            cliente5.Activo = true;
            contexto.Clientes.Add(cliente5);

            var cliente6 = new Cliente();
            cliente6.Nombre = "David Rodriquez";
            cliente6.Contraseña = "david123";
            cliente6.Telefono = "92145241";
            cliente6.Celular = "92324457";
            cliente6.Correo = "DavidR@hotmail.com";
            cliente6.Activo = true;
            contexto.Clientes.Add(cliente6);

            var cliente7 = new Cliente();
            cliente7.Nombre = "Oscar Pineda";
            cliente7.Contraseña = "oscar123";
            cliente7.Telefono = "99944241";
            cliente7.Celular = "93324259";
            cliente7.Correo = "Oscar1993@hotmail.com";
            cliente7.Activo = true;
            contexto.Clientes.Add(cliente7);


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
            Vendedor1.Id = 1;
            Vendedor1.Nombre = "Rick's";
            Vendedor1.Descripcion = "Experto en Ventas y financiamiento";
            Vendedor1.Contrasena = "ricks123";
            Vendedor1.Telefono = "98675878";
            Vendedor1.Celular = "96457865";
            Vendedor1.Correo = "ricks@gmail.com";
            Vendedor1.Activo = true;
            contexto.Vendedores.Add(Vendedor1);

            var Vendedor2 = new Vendedor();
            Vendedor2.Id = 2;
            Vendedor2.Nombre = "Mi Roca Fuerte";
            Vendedor2.Descripcion = "Experto en Compra y Ventas";
            Vendedor2.Contrasena = "roca123";
            Vendedor2.Telefono = "98563241";
            Vendedor2.Celular = "93652487";
            Vendedor2.Correo = "rocafuerte@yahoo.com";
            Vendedor2.Activo = true;
            contexto.Vendedores.Add(Vendedor2);

            var Vendedor3 = new Vendedor();
            Vendedor3.Id = 3;
            Vendedor3.Nombre = "Alpine";
            Vendedor3.Descripcion = "Veterano en lo que a Venta de casas respecta, con mas de 20 años en servicio";
            Vendedor3.Contrasena = "alpine123";
            Vendedor3.Telefono = "98563241";
            Vendedor3.Celular = "93652487";
            Vendedor3.Correo = "alpine@outlook.com";
            Vendedor3.Activo = true;
            contexto.Vendedores.Add(Vendedor3);

            var Vendedor4 = new Vendedor();
            Vendedor4.Id = 4;
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
            UsuarioAdmin.NombUsuario = "admin";
            UsuarioAdmin.Contrasena = Encriptar.CodificarConstrasena("123456");
            UsuarioAdmin.Contrasena2 = "123456";
            UsuarioAdmin.Nombre = "Kevin";
            UsuarioAdmin.Apellido = "Rivera";
            UsuarioAdmin.Correo = "prueba1234@gmail.com";
            UsuarioAdmin.edad = 22;
            UsuarioAdmin.FechaInicio = new DateTime(1997, 4, 29);
            UsuarioAdmin.Cedula = 0512199700879;
            UsuarioAdmin.UrlImagen = "/Imagenes/foto1.jpg";
            contexto.Usuarios.Add(UsuarioAdmin);

            var usuario1 = new Usuario();
            usuario1.NombUsuario = "gerente";
            usuario1.Contrasena = Encriptar.CodificarConstrasena("123456");
            usuario1.Contrasena2 = "123456";
            usuario1.Nombre = "German";
            usuario1.Apellido = "Mendoza";
            usuario1.Correo = "prueba1234@gmail.com";
            usuario1.edad = 21;
            usuario1.FechaInicio = new DateTime(1998, 10, 18);
            usuario1.Cedula = 0512199700666;
            usuario1.UrlImagen = "/Imagenes/foto2.jpg";
            contexto.Usuarios.Add(usuario1);

            var usuario2 = new Usuario();
            usuario2.NombUsuario = "super";
            usuario2.Contrasena = Encriptar.CodificarConstrasena("123456");
            usuario2.Contrasena2 = "123456";
            usuario2.Nombre = "Juan";
            usuario2.Apellido = "Alvarado";
            usuario2.Correo = "prueba1234@gmail.com";
            usuario2.edad = 22;
            usuario2.FechaInicio = new DateTime(2002, 12, 9);
            usuario2.Cedula = 0512199700999;
            usuario2.UrlImagen = null;
            contexto.Usuarios.Add(usuario2);

            var usuario3 = new Usuario();
            usuario3.NombUsuario = "extra";
            usuario3.Contrasena = Encriptar.CodificarConstrasena("123456");
            usuario3.Contrasena2 = "123456";
            usuario3.Nombre = "Andres";
            usuario3.Apellido = "Baide";
            usuario3.Correo = "andreswbaide@gmail.com";
            usuario3.edad = 22;
            usuario3.FechaInicio = new DateTime(2002, 12, 9);
            usuario3.Cedula = 0512199700999;
            usuario3.UrlImagen = null;
            contexto.Usuarios.Add(usuario3);

            var usuario4 = new Usuario();
            usuario4.NombUsuario = "doctor";
            usuario4.Contrasena = Encriptar.CodificarConstrasena("123456");
            usuario4.Contrasena2 = "123456";
            usuario4.Nombre = "Luis";
            usuario4.Apellido = "Lopez";
            usuario4.Correo = "luislopez@gmail.com";
            usuario4.edad = 42;
            usuario4.FechaInicio = new DateTime(2002, 12, 9);
            usuario4.Cedula = 0512198400999;
            usuario4.UrlImagen = null;
            contexto.Usuarios.Add(usuario4);

            #endregion

            #region PRODUCTOS ---MIO POR QUE YO LO ARREGLE, INUTILES.

            var producto1 = new Producto();
            producto1.Descripcion = "Cerca de posta policial, bella vista y vecindad amistosa";
            producto1.Localizacion = "Colonia trejo 13 calle 7 avenida";
            producto1.Parking = 2;
            producto1.Habitaciones = 4;
            producto1.Metros = 4500;
            producto1.Precio = 120500;
            producto1.Bano = 4;
            producto1.Estado = "Disponible";

            producto1.VendedorId = 1;
            producto1.CategoriaId = 1;
            producto1.EstructuraId = 1;
            producto1.EtiquetaId = 1;
            producto1.UrlImagen = null;
            producto1.UrlImagen2 = null;
            producto1.UrlImagen3 = null;
            producto1.UrlImagen4 = null;
            producto1.UrlImagen5 = null;
            contexto.Productos.Add(producto1);


            var producto2 = new Producto();
            producto2.Descripcion = "Hospital cerca de la zona, Escuela a unas cuantas cuadras";
            producto2.Localizacion = "Barrio Rio Piedras";
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
            producto2.UrlImagen2 = null;
            producto2.UrlImagen3 = null;
            producto2.UrlImagen4 = null;
            producto2.UrlImagen5 = null;
            contexto.Productos.Add(producto2);


            var producto3 = new Producto();
            producto3.Descripcion = "Escuela Bilingue de facil acceso, Campo de Football cerca";
            producto3.Localizacion = "Colonia Pedegral";
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
            producto3.UrlImagen2 = null;
            producto3.UrlImagen3 = null;
            producto3.UrlImagen4 = null;
            producto3.UrlImagen5 = null;
            contexto.Productos.Add(producto3);


            var producto4 = new Producto();
            producto4.Descripcion = "Escuela catolica cercana, bella vista";
            producto4.Localizacion = "Barrio Primavera";
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
            producto4.UrlImagen2 = null;
            producto4.UrlImagen3 = null;
            producto4.UrlImagen4 = null;
            producto4.UrlImagen5 = null;
            contexto.Productos.Add(producto4);


            var producto5 = new Producto();
            producto5.Descripcion = "Cerca de Hospital, bella vista y gran jardin";
            producto5.Localizacion = "Colonia Pedegral";
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
            producto5.UrlImagen2 = null;
            producto5.UrlImagen3 = null;
            producto5.UrlImagen4 = null;
            producto5.UrlImagen5 = null;
            contexto.Productos.Add(producto5);


            var producto6 = new Producto();
            producto6.Descripcion = "Seguridad Privada, Wifi Gratis";
            producto6.Localizacion = "Colonia Universidad";
            producto6.Parking = 0;
            producto6.Habitaciones = 2;
            producto6.Metros = 200;
            producto6.Precio = 55500;
            producto6.Bano = 1;
            producto6.Estado = "Disponible";

            producto6.VendedorId = 1;
            producto6.EtiquetaId = 1;
            producto6.CategoriaId = 1;
            producto6.EstructuraId = 4;
            producto6.UrlImagen = null;
            producto6.UrlImagen2 = null;
            producto6.UrlImagen3 = null;
            producto6.UrlImagen4 = null;
            producto6.UrlImagen5 = null;
            contexto.Productos.Add(producto6);


            var producto7 = new Producto();
            producto7.Descripcion = "Seguridad Privada, Wifi Gratis";
            producto7.Localizacion = "Colonia Smith";
            producto7.Parking = 1;
            producto7.Habitaciones = 3;
            producto7.Metros = 200;
            producto7.Precio = 65500;
            producto7.Bano = 2;
            producto7.Estado = "Disponible";

            producto7.VendedorId = 3;
            producto7.EtiquetaId = 1;
            producto7.CategoriaId = 1;
            producto7.EstructuraId = 2;
            producto7.UrlImagen = null;
            producto7.UrlImagen2 = null;
            producto7.UrlImagen3 = null;
            producto7.UrlImagen4 = null;
            producto7.UrlImagen5 = null;
            contexto.Productos.Add(producto7);


            var producto8 = new Producto();
            producto8.Descripcion = "Una Hermoza vecindad, con escuela cerca";
            producto8.Localizacion = "Los Castaños";
            producto8.Parking = 4;
            producto8.Habitaciones = 8;
            producto8.Metros = 2000;
            producto8.Precio = 600500;
            producto8.Bano = 4;
            producto8.Estado = "Disponible";

            producto8.VendedorId = 4;
            producto8.EtiquetaId = 1;
            producto8.CategoriaId = 1;
            producto8.EstructuraId = 4;
            producto8.UrlImagen = null;
            producto8.UrlImagen2 = null;
            producto8.UrlImagen3 = null;
            producto8.UrlImagen4 = null;
            producto8.UrlImagen5 = null;
            contexto.Productos.Add(producto8);


            var producto9 = new Producto();
            producto9.Descripcion = "Zona cercana a la Universidad, punto de buses cercano";
            producto9.Localizacion = "Colonia El Roble";
            producto9.Parking = 0;
            producto9.Habitaciones = 3;
            producto9.Metros = 70000;
            producto9.Precio = 500000;
            producto9.Bano = 2;
            producto9.Estado = "Disponible";

            producto9.VendedorId = 3;
            producto9.EtiquetaId = 1;
            producto9.CategoriaId = 2;
            producto9.EstructuraId = 2;
            producto9.UrlImagen = null;
            producto9.UrlImagen2 = null;
            producto9.UrlImagen3 = null;
            producto9.UrlImagen4 = null;
            producto9.UrlImagen5 = null;
            contexto.Productos.Add(producto9);


            var producto10 = new Producto();
            producto10.Descripcion = "Zona Urbana con gran cantidad de Vegetacion, con un parque cerca.";
            producto10.Localizacion = "Merendon Hills";
            producto10.Parking = 5;
            producto10.Habitaciones = 4;
            producto10.Metros = 26000;
            producto10.Precio = 1500000;
            producto10.Bano = 2;
            producto10.Estado = "Disponible";

            producto10.VendedorId = 2;
            producto10.EtiquetaId = 1;
            producto10.CategoriaId = 1;
            producto10.EstructuraId = 4;
            producto10.UrlImagen = null;
            producto10.UrlImagen2 = null;
            producto10.UrlImagen3 = null;
            producto10.UrlImagen4 = null;
            producto10.UrlImagen5 = null;
            contexto.Productos.Add(producto10);

            var producto11 = new Producto();
            producto11.Descripcion = "Con seguridad privada, terreno 410v2 y metros de construcción 205 metros aproximado, sala, comedor, cocina con mueble";
            producto11.Localizacion = "Casa de una planta en Res. Villas del Campo (frente a campisa)";
            producto11.Parking = 1;
            producto11.Habitaciones = 3;
            producto11.Metros = 40000;
            producto11.Precio = 1600000;
            producto11.Bano = 2;
            producto11.Estado = "Disponible";

            producto11.VendedorId = 3;
            producto11.EtiquetaId = 1;
            producto11.CategoriaId = 1;
            producto11.EstructuraId = 2;
            producto11.UrlImagen = null;
            producto11.UrlImagen2 = null;
            producto11.UrlImagen3 = null;
            producto11.UrlImagen4 = null;
            producto11.UrlImagen5 = null;
            contexto.Productos.Add(producto11);

            var producto12 = new Producto();
            producto12.Descripcion = "Seguridad las 24 horas, circuito cerrado, casa esquina, parqueo adicional, finos acabados, cerámica";
            producto12.Localizacion = "Col, Sitratelh";
            producto12.Parking = 2;
            producto12.Habitaciones = 3;
            producto12.Metros = 40000;
            producto12.Precio = 2800000;
            producto12.Bano = 2;
            producto12.Estado = "Disponible";

            producto12.VendedorId = 2;
            producto12.EtiquetaId = 1;
            producto12.CategoriaId = 1;
            producto12.EstructuraId = 2;
            producto12.UrlImagen = null;
            producto12.UrlImagen2 = null;
            producto12.UrlImagen3 = null;
            producto12.UrlImagen4 = null;
            producto12.UrlImagen5 = null;
            contexto.Productos.Add(producto12);

            var producto13 = new Producto();
            producto13.Descripcion = "Casa circuito cerrado, seguridad privada, con parqueo.";
            producto13.Localizacion = "Res Andalucia San Pedro Sula - Cortés";
            producto13.Parking = 1;
            producto13.Habitaciones = 4;
            producto13.Metros = 32000;
            producto13.Precio = 1800000;
            producto13.Bano = 1;
            producto13.Estado = "Disponible";

            producto13.VendedorId = 4;
            producto13.EtiquetaId = 1;
            producto13.CategoriaId = 1;
            producto13.EstructuraId = 4;
            producto13.UrlImagen = null;
            producto13.UrlImagen2 = null;
            producto13.UrlImagen3 = null;
            producto13.UrlImagen4 = null;
            producto13.UrlImagen5 = null;
            contexto.Productos.Add(producto13);

            var producto14 = new Producto();
            producto14.Descripcion = "Fuente de agua en jardín frontal, Instalaciones para central de aire en áreas de sala comedor y cocina";
            producto14.Localizacion = "Res Villas Paraiso San Pedro Sula - Cortés";
            producto14.Parking = 1;
            producto14.Habitaciones = 3;
            producto14.Metros = 20000;
            producto14.Precio = 2300000;
            producto14.Bano = 1;
            producto14.Estado = "Disponible";

            producto14.VendedorId = 2;
            producto14.EtiquetaId = 1;
            producto14.CategoriaId = 1;
            producto14.EstructuraId = 4;
            producto14.UrlImagen = null;
            producto14.UrlImagen2 = null;
            producto14.UrlImagen3 = null;
            producto14.UrlImagen4 = null;
            producto14.UrlImagen5 = null;
            contexto.Productos.Add(producto14);

            var producto15 = new Producto();
            producto15.Descripcion = "Excelente Oportunidad para vivir en un lugar seguro y con buen vecindario. ";
            producto15.Localizacion = "Casa Res, Brisas del Merendon.";
            producto15.Parking = 1;
            producto15.Habitaciones = 3;
            producto15.Metros = 29000;
            producto15.Precio = 1300000;
            producto15.Bano = 2;
            producto15.Estado = "Disponible";

            producto15.VendedorId = 3;
            producto15.EtiquetaId = 1;
            producto15.CategoriaId = 1;
            producto15.EstructuraId = 1;
            producto15.UrlImagen = null;
            producto15.UrlImagen2 = null;
            producto15.UrlImagen3 = null;
            producto15.UrlImagen4 = null;
            producto15.UrlImagen5 = null;
            contexto.Productos.Add(producto15);

            var producto16 = new Producto();
            producto16.Descripcion = "Casa de habitacion con 3 cuartos, 1 baño y seguridad privada";
            producto16.Localizacion = "Col. Fesitranh San Pedro Sula, Cortés";
            producto16.Parking = 1;
            producto16.Habitaciones = 3;
            producto16.Metros = 25000;
            producto16.Precio = 1030000;
            producto16.Bano = 1;
            producto16.Estado = "Disponible";

            producto16.VendedorId = 2;
            producto16.EtiquetaId = 1;
            producto16.CategoriaId = 1;
            producto16.EstructuraId = 3;
            producto16.UrlImagen = null;
            producto16.UrlImagen2 = null;
            producto16.UrlImagen3 = null;
            producto16.UrlImagen4 = null;
            producto16.UrlImagen5 = null;
            contexto.Productos.Add(producto16);

            var producto17 = new Producto();
            producto17.Descripcion = "Casa Residencial con seguridad privada y circuito cerrado";
            producto17.Localizacion = "Res La Foresta San Pedro Sula - Cortés";
            producto17.Parking = 1;
            producto17.Habitaciones = 3;
            producto17.Metros = 40000;
            producto17.Precio = 10200000;
            producto17.Bano = 2;
            producto17.Estado = "Disponible";

            producto17.VendedorId = 1;
            producto17.EtiquetaId = 1;
            producto17.CategoriaId = 1;
            producto17.EstructuraId = 2;
            producto17.UrlImagen = null;
            producto17.UrlImagen2 = null;
            producto17.UrlImagen3 = null;
            producto17.UrlImagen4 = null;
            producto17.UrlImagen5 = null;
            contexto.Productos.Add(producto17);

            var producto18 = new Producto();
            producto18.Descripcion = "Estudio. Dos salas, Comedor. Cocina con alacena y desayunador.";
            producto18.Localizacion = "Rancho San Manuel contiguo a Col. Fesitranh S.P.S.";
            producto18.Parking = 2;
            producto18.Habitaciones = 3;
            producto18.Metros = 20000;
            producto18.Precio = 1020000;
            producto18.Bano = 2;
            producto18.Estado = "Disponible";

            producto18.VendedorId = 1;
            producto18.EtiquetaId = 1;
            producto18.CategoriaId = 1;
            producto18.EstructuraId = 1;
            producto18.UrlImagen = null;
            producto18.UrlImagen2 = null;
            producto18.UrlImagen3 = null;
            producto18.UrlImagen4 = null;
            producto18.UrlImagen5 = null;
            contexto.Productos.Add(producto18);

            var producto19 = new Producto();
            producto19.Descripcion = "475vr2 de terreno y 259 mtr2 de construccion!, 3 cuartos, 2.5 baños, pequeña sala familiar, estudio";
            producto19.Localizacion = "Residencial Buena Vista";
            producto19.Parking = 2;
            producto19.Habitaciones = 3;
            producto19.Metros = 20000;
            producto19.Precio = 1200000;
            producto19.Bano = 2;
            producto19.Estado = "Disponible";

            producto19.VendedorId = 3;
            producto19.EtiquetaId = 1;
            producto19.CategoriaId = 1;
            producto19.EstructuraId = 3;
            producto19.UrlImagen = null;
            producto19.UrlImagen2 = null;
            producto19.UrlImagen3 = null;
            producto19.UrlImagen4 = null;
            producto19.UrlImagen5 = null;
            contexto.Productos.Add(producto19);

            var producto20 = new Producto();
            producto20.Descripcion = "Acceso controlado, Área de barbacoas, Área de bodegas, Área juegos infantiles";
            producto20.Localizacion = "Residencial Buena Vista";
            producto20.Parking = 2;
            producto20.Habitaciones = 3;
            producto20.Metros = 20000;
            producto20.Precio = 12000000;
            producto20.Bano = 2;
            producto20.Estado = "Disponible";

            producto20.VendedorId = 2;
            producto20.EtiquetaId = 1;
            producto20.CategoriaId = 1;
            producto20.EstructuraId = 2;
            producto20.UrlImagen = null;
            producto20.UrlImagen2 = null;
            producto20.UrlImagen3 = null;
            producto20.UrlImagen4 = null;
            producto20.UrlImagen5 = null;
            contexto.Productos.Add(producto20);

            var producto21 = new Producto();
            producto21.Descripcion = "Casa en renta con: Sala, Cocina, Comedor ,Area lavanderia, Area social con Bar y Piscina";
            producto21.Localizacion = "Residencial Las UVAS";
            producto21.Parking = 1;
            producto21.Habitaciones = 5;
            producto21.Metros = 20000;
            producto21.Precio = 1500000;
            producto21.Bano = 3;
            producto21.Estado = "Disponible";

            producto21.VendedorId = 2;
            producto21.EtiquetaId = 2;
            producto21.CategoriaId = 1;
            producto21.EstructuraId = 2;
            producto21.UrlImagen = null;
            producto21.UrlImagen2 = null;
            producto21.UrlImagen3 = null;
            producto21.UrlImagen4 = null;
            producto21.UrlImagen5 = null;
            contexto.Productos.Add(producto21);

            var producto22 = new Producto();
            producto22.Descripcion = "3 cuartos, 2 baños, pequeña sala familiar, estudio, 2 bodegas, aerea de servicio ampliado";
            producto22.Localizacion = "Colonia Modelo";
            producto22.Parking = 2;
            producto22.Habitaciones = 3;
            producto22.Metros = 20000;
            producto22.Precio = 12000;
            producto22.Bano = 2;
            producto22.Estado = "Disponible";

            producto22.VendedorId = 3;
            producto22.EtiquetaId = 2;
            producto22.CategoriaId = 2;
            producto22.EstructuraId = 4;
            producto22.UrlImagen = null;
            producto22.UrlImagen2 = null;
            producto22.UrlImagen3 = null;
            producto22.UrlImagen4 = null;
            producto22.UrlImagen5 = null;
            contexto.Productos.Add(producto22);

            var producto23 = new Producto();
            producto23.Descripcion = "2 habitaciones, 2 baños, Sala , comedor, Cocina, Area lavanderia y Estacionamiento para 2 vehiculos";
            producto23.Localizacion = "Apartamentos Lomas del Guijarro";
            producto23.Parking = 2;
            producto23.Habitaciones = 2;
            producto23.Metros = 22000;
            producto23.Precio = 8000;
            producto23.Bano = 1;
            producto23.Estado = "Disponible";

            producto23.VendedorId = 2;
            producto23.EtiquetaId = 2;
            producto23.CategoriaId = 2;
            producto23.EstructuraId = 2;
            producto23.UrlImagen = null;
            producto23.UrlImagen2 = null;
            producto23.UrlImagen3 = null;
            producto23.UrlImagen4 = null;
            producto23.UrlImagen5 = null;
            contexto.Productos.Add(producto23);

            var producto24 = new Producto();
            producto24.Descripcion = "Acceso controlado, Área de barbacoas, Área de bodegas, Área juegos infantiles, Área social, Ascensor, Azotea (Área social)";
            producto24.Localizacion = "Barrio Las Palmas";
            producto24.Parking = 2;
            producto24.Habitaciones = 2;
            producto24.Metros = 20000;
            producto24.Precio = 8500;
            producto24.Bano = 2;
            producto24.Estado = "Disponible";

            producto24.VendedorId = 1;
            producto24.EtiquetaId = 2;
            producto24.CategoriaId = 2;
            producto24.EstructuraId = 4;
            producto24.UrlImagen = null;
            producto24.UrlImagen2 = null;
            producto24.UrlImagen3 = null;
            producto24.UrlImagen4 = null;
            producto24.UrlImagen5 = null;
            contexto.Productos.Add(producto24);

            var producto25 = new Producto();
            producto25.Descripcion = "Calentador, Closets, Extractores de baño, Instalación lavadora, Intercomunicador, Lámparas, Luces spot, Muebles de baño, Muebles de cocina, Walk-in closets";
            producto25.Localizacion = "Departamentos Deluxe - Las lomas";
            producto25.Parking = 2;
            producto25.Habitaciones = 3;
            producto25.Metros = 23000;
            producto25.Precio = 9000;
            producto25.Bano = 2;
            producto25.Estado = "Disponible";

            producto25.VendedorId = 4;
            producto25.EtiquetaId = 2;
            producto25.CategoriaId = 2;
            producto25.EstructuraId = 4;
            producto25.UrlImagen = null;
            producto25.UrlImagen2 = null;
            producto25.UrlImagen3 = null;
            producto25.UrlImagen4 = null;
            producto25.UrlImagen5 = null;
            contexto.Productos.Add(producto25);

            var producto26 = new Producto();
            producto26.Descripcion = "Las lomas es un circuito cerrado de apartamentos famoso por sus hermosas áreas sociales, amplia piscina con aguas cristalinas estilo resort";
            producto26.Localizacion = "Departamentos Deluxe - Las lomas";
            producto26.Parking = 2;
            producto26.Habitaciones = 3;
            producto26.Metros = 20000;
            producto26.Precio = 10000;
            producto26.Bano = 2;
            producto26.Estado = "Disponible";

            producto26.VendedorId = 2;
            producto26.EtiquetaId = 2;
            producto26.CategoriaId = 2;
            producto26.EstructuraId = 4;
            producto26.UrlImagen = null;
            producto26.UrlImagen2 = null;
            producto26.UrlImagen3 = null;
            producto26.UrlImagen4 = null;
            producto26.UrlImagen5 = null;
            contexto.Productos.Add(producto26);

            var producto27 = new Producto();
            producto27.Descripcion = "Las lomas es un circuito cerrado de apartamentos famoso por sus hermosas áreas sociales, amplia piscina con aguas cristalinas estilo resort";
            producto27.Localizacion = "Departamentos Deluxe - Las lomas";
            producto27.Parking = 2;
            producto27.Habitaciones = 3;
            producto27.Metros = 20000;
            producto27.Precio = 95000;
            producto27.Bano = 2;
            producto27.Estado = "Disponible";

            producto27.VendedorId = 1;
            producto27.EtiquetaId = 2;
            producto27.CategoriaId = 2;
            producto27.EstructuraId = 4;
            producto27.UrlImagen = null;
            producto27.UrlImagen2 = null;
            producto27.UrlImagen3 = null;
            producto27.UrlImagen4 = null;
            producto27.UrlImagen5 = null;
            contexto.Productos.Add(producto27);

            var producto28 = new Producto();
            producto28.Descripcion = "Estilo, diseño y exclusividad definen este espacioso apartamento de 2 Dormitorios, 2.5 Baños con espectacular cocina estilo abierto equipada con muebles de madera de caoba finamente acabados top de cuarzo";
            producto28.Localizacion = "Departamentos - Portal del bosque";
            producto28.Parking = 2;
            producto28.Habitaciones = 3;
            producto28.Metros = 20000;
            producto28.Precio = 1000;
            producto28.Bano = 2;
            producto28.Estado = "Disponible";

            producto28.VendedorId = 2;
            producto28.EtiquetaId = 2;
            producto28.CategoriaId = 2;
            producto28.EstructuraId = 2;
            producto28.UrlImagen = null;
            producto28.UrlImagen2 = null;
            producto28.UrlImagen3 = null;
            producto28.UrlImagen4 = null;
            producto28.UrlImagen5 = null;
            contexto.Productos.Add(producto28);

            var producto29 = new Producto();
            producto29.Descripcion = "Estilo, diseño y exclusividad definen este espacioso apartamento de 2 Dormitorios, 2.5 Baños con espectacular cocina estilo abierto equipada con muebles de madera de caoba finamente acabados top de cuarzo";
            producto29.Localizacion = "Departamentos - Portal del bosque";
            producto29.Parking = 2;
            producto29.Habitaciones = 3;
            producto29.Metros = 20000;
            producto29.Precio = 1000000;
            producto29.Bano = 2;
            producto29.Estado = "Disponible";

            producto29.VendedorId = 2;
            producto29.EtiquetaId = 2;
            producto29.CategoriaId = 2;
            producto29.EstructuraId = 2;
            producto29.UrlImagen = null;
            producto29.UrlImagen2 = null;
            producto29.UrlImagen3 = null;
            producto29.UrlImagen4 = null;
            producto29.UrlImagen5 = null;
            contexto.Productos.Add(producto29);

            var producto30 = new Producto();
            producto30.Descripcion = "Estilo, diseño y exclusividad definen este espacioso apartamento de 2 Dormitorios, 2.5 Baños con espectacular cocina estilo abierto equipada con muebles de madera de caoba finamente acabados top de cuarzo";
            producto30.Localizacion = "Departamentos - Portal del bosque";
            producto30.Parking = 2;
            producto30.Habitaciones = 3;
            producto30.Metros = 23000;
            producto30.Precio = 8900;
            producto30.Bano = 2;
            producto30.Estado = "Disponible";

            producto30.VendedorId = 3;
            producto30.EtiquetaId = 2;
            producto30.CategoriaId = 2;
            producto30.EstructuraId = 4;
            producto30.UrlImagen = null;
            producto30.UrlImagen2 = null;
            producto30.UrlImagen3 = null;
            producto30.UrlImagen4 = null;
            producto30.UrlImagen5 = null;
            contexto.Productos.Add(producto30);

            #endregion

            base.Seed(contexto);
        }
    }
}
