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
            #region Clientes

            var cliente1 = new Cliente();
            cliente1.Nombre = "Kevin Amaya";
            cliente1.Contraseña = "kevin123";
            cliente1.Telefono ="98563241";
            cliente1.Celular ="93652487";
            cliente1.correo ="Kevinamaya@gmail.com";
            cliente1.Activo = true;
            contexto.Clientes.Add(cliente1);

            var cliente2 = new Cliente();
            cliente2.Nombre = "German Mendoza";
            cliente2.Contraseña = "german123";
            cliente2.Telefono = "98563241";
            cliente2.Celular = "93652487";
            cliente2.correo = "GermanMendoza@outlook.com";
            cliente2.Activo = true;
            contexto.Clientes.Add(cliente2);


            var cliente3 = new Cliente();
            cliente3.Nombre = "Andres Baide";
            cliente3.Contraseña = "andres123";
            cliente3.Telefono = "98563241";
            cliente3.Celular = "93652487";
            cliente3.correo = "AndresBaide@aol.com";
            cliente3.Activo = true;
            contexto.Clientes.Add(cliente3);

            var cliente4 = new Cliente();
            cliente4.Nombre = "Juan Alvarado";
            cliente4.Contraseña = "juan123";
            cliente4.Telefono = "98563241";
            cliente4.Celular = "93652487";
            cliente4.correo = "JuanAlvarado@yahoo.com";
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
            Vendedor1.Nombre = "Euro Casas";
            Vendedor1.Contraseña = "euro123";
            Vendedor1.Telefono = "98563241";
            Vendedor1.Celular = "93652487";
            Vendedor1.correo = "EuroCasas@gmail.com";
            Vendedor1.Activo = true;
            contexto.Vendedores.Add(Vendedor1);

            var Vendedor2 = new Vendedor();
            Vendedor2.Nombre = "Mi Roca Fuerte";
            Vendedor2.Contraseña = "roca123";
            Vendedor2.Telefono = "98563241";
            Vendedor2.Celular = "93652487";
            Vendedor2.correo = "rocafuerte@yahoo.com";
            Vendedor2.Activo = true;
            contexto.Vendedores.Add(Vendedor2);

            var Vendedor3 = new Vendedor();
            Vendedor3.Nombre = "Alpine";
            Vendedor3.Contraseña = "alpine123";
            Vendedor3.Telefono = "98563241";
            Vendedor3.Celular = "93652487";
            Vendedor3.correo = "alpine@outlook.com";
            Vendedor3.Activo = true;
            contexto.Vendedores.Add(Vendedor3);

            var Vendedor4 = new Vendedor();
            Vendedor4.Nombre = "Fenix";
            Vendedor4.Contraseña = "fenix123";
            Vendedor4.Telefono = "98563241";
            Vendedor4.Celular = "93652487";
            Vendedor4.correo = "fenix@aol.com";
            Vendedor4.Activo = true;
            contexto.Vendedores.Add(Vendedor4);

            #endregion

            base.Seed(contexto);
        }
    }
}
