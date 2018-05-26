using Microsoft.VisualStudio.TestTools.UnitTesting;
using RegistroArticulos.BLL;
using RegistroArticulos.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RegistroArticulos.BLL.Tests
{
    [TestClass()]
    public class ArticulosBLLTests
    {
        [TestMethod()]
        public void GuardarTest()
        {
            bool paso;
            Articulo Articulos = new Articulo();

            Articulos.ArticuloID = 0;
            Articulos.FechaVencimiento = DateTime.Now;
            Articulos.Descripcion = "Esto fue excelente";
            Articulos.Precio ="3000";
            Articulos.Existencia = 9;
            Articulos.CantidadCotizada = 4;

            paso = ArticulosBLL.Guardar(Articulos);


            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void ModificarTest()
        {
            bool paso;
            Articulo Articulos = new Articulo();

            Articulos.ArticuloID = 0;
            Articulos.FechaVencimiento = DateTime.Now;
            Articulos.Descripcion = "Esto fue excelente";
            Articulos.Precio = "3000";
            Articulos.Existencia = 9;
            Articulos.CantidadCotizada = 4;

            paso = ArticulosBLL.Guardar(Articulos);


            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void EliminarTest()
        {
            bool paso;
            Articulo Articulos = new Articulo();

            Articulos.ArticuloID = 0;
            Articulos.FechaVencimiento = DateTime.Now;
            Articulos.Descripcion = "Esto fue excelente";
            Articulos.Precio = "3000";
            Articulos.Existencia = 9;
            Articulos.CantidadCotizada = 4;

            paso = ArticulosBLL.Guardar(Articulos);


            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void BuscarTest()
        {
            bool paso;
            Articulo Articulos = new Articulo();

            Articulos.ArticuloID = 0;
            Articulos.FechaVencimiento = DateTime.Now;
            Articulos.Descripcion = "Esto fue excelente";
            Articulos.Precio = "3000";
            Articulos.Existencia = 9;
            Articulos.CantidadCotizada = 4;

            paso = ArticulosBLL.Guardar(Articulos);


            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void GetListTest()
        {
            bool paso;
            Articulo Articulos = new Articulo();

            Articulos.ArticuloID = 0;
            Articulos.FechaVencimiento = DateTime.Now;
            Articulos.Descripcion = "Esto fue excelente";
            Articulos.Precio = "3000";
            Articulos.Existencia = 9;
            Articulos.CantidadCotizada = 4;

            paso = ArticulosBLL.Guardar(Articulos);


            Assert.AreEqual(paso, true);
        }
    }
}