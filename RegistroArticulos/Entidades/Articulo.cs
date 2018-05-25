using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace RegistroArticulos.Entidades
{
    public class Articulo
    {
        [Key]
        public int ArticuloID { get; set; }
        public DateTime FechaVencimiento { get; set; }
        public string Descripcion { get; set; }
        public string Precio { get; set; }
        public int Existencia { get; set; }
        public int CantidadCotizada { get; set; }

        public Articulo()
        {
            ArticuloID = 0;
            FechaVencimiento = DateTime.Now;
            Descripcion = string.Empty;
            Precio = string.Empty;
            Existencia = 0;
            CantidadCotizada = 0;
        }
    }
}
