using RegistroArticulos.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RegistroArticulos.UI.Registros
{
    public partial class RegistroDeArticulos : Form
    {
        public RegistroDeArticulos()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Aqui completamos la clase articulo
        /// </summary>
        /// <returns></returns>

        private Articulo LlenaClase()
        {
            Articulo Articulos = new Articulo();
            Articulos.ArticuloID = Convert.ToInt32(ArticuloIDnumericUpDown.Value);
            Articulos.FechaVencimiento = FechaVencimientodateTimePicker.Value;
            Articulos.Descripcion = DescripciontextBox.Text;
            Articulos.Precio = PreciotextBox.Text;
            Articulos.Existencia = Convert.ToInt32(ExistencianumericUpDown.Value);
            Articulos.CantidadCotizada = Convert.ToInt32(CantidadCotizadanumericUpDown.Value);

            return Articulos;
        }

        /// <summary>
        /// Aqui Validamos los campos 
        /// </summary>
        /// <param name="error"></param>
        /// <returns></returns>
        public bool Validar(int error)
        {
            bool paso = false;

            if (error == 1 && ArticuloIDnumericUpDown.Value == 0)
            {
                errorProvider.SetError(ArticuloIDnumericUpDown, "Llenar ID");
                paso = true;
            }
            if (error == 2 && string.IsNullOrEmpty(DescripciontextBox.Text))
            {
                errorProvider.SetError(DescripciontextBox, "Favor LLenar");
                paso = true;
            }
            if (error == 3 && string.IsNullOrEmpty(PreciotextBox.Text))
            {
                errorProvider.SetError(PreciotextBox, "Favor LLenar");
                paso = true;
            }
            if (error == 4 && ExistencianumericUpDown.Value == 0)
            {
                errorProvider.SetError(ExistencianumericUpDown, "Favor Llenar");
                paso = true;
            }
            if (error == 5 && CantidadCotizadanumericUpDown.Value == 0)
            {
                errorProvider.SetError(CantidadCotizadanumericUpDown, "Favor Llenar");
                paso = true;
            }
            return paso;
        }
        /// <summary>
        /// Aqui tenemos el Button Guardar la cual guardamos lo que esta en los campos y llamamos la funcion validar para validar
        /// nuestros campos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            if (Validar(2))
            {
                MessageBox.Show("Llenar campos", "Llene los campos",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Articulo articulo = LlenaClase();

                bool paso = false;


                if (ArticuloIDnumericUpDown.Value == 0)
                {
                    paso = BLL.ArticulosBLL.Guardar(articulo);

                }
                else
                {
                    paso = BLL.ArticulosBLL.Modificar(LlenaClase());
                }
                if (paso)
                {
                    MessageBox.Show("Guardado!!", "Se Guardo Correctamente",
                     MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ArticuloIDnumericUpDown.Value = 0;
                    FechaVencimientodateTimePicker.Value = DateTime.Now;
                    DescripciontextBox.Clear();
                    PreciotextBox.Clear();
                    ExistencianumericUpDown.Value = 0;
                    CantidadCotizadanumericUpDown.Value = 0;
                    errorProvider.Clear();
                }
                else
                {
                    MessageBox.Show("No se guardo!!", "Intente Guardar de nuevo",
                      MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
        }

        /// <summary>
        /// El Botton Eliminar la cual llama la funcion Validar para ver si el ID esta vacio o contiene un numero
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {

            if (Validar(1))
            {
                MessageBox.Show("El TipoID esta vacio", "Llene Campo",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                int id = Convert.ToInt32(ArticuloIDnumericUpDown.Value);

                if (BLL.ArticulosBLL.Eliminar(id))
                {
                    MessageBox.Show("Eliminado", "Bien hecho", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ArticuloIDnumericUpDown.Value = 0;
                    FechaVencimientodateTimePicker.Value = DateTime.Now;
                    DescripciontextBox.Clear();
                    PreciotextBox.Clear();
                    ExistencianumericUpDown.Value = 0;
                    CantidadCotizadanumericUpDown.Value = 0;
                    errorProvider.Clear();
                }
                else
                {
                    MessageBox.Show("No se puede Eliminar", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
        }

        /// <summary>
        /// Button Buscar que pide ID para ver si esta Creado o no
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(ArticuloIDnumericUpDown.Value);
            Articulo Articulo = BLL.ArticulosBLL.Buscar(id);



            if (Articulo != null)
            {
                ArticuloIDnumericUpDown.Value = Articulo.ArticuloID;
                FechaVencimientodateTimePicker.Value = Articulo.FechaVencimiento;
                DescripciontextBox.Text = Articulo.Descripcion;
                PreciotextBox.Text = Articulo.Precio;
                ExistencianumericUpDown.Value = Articulo.Existencia;
                CantidadCotizadanumericUpDown.Value = Articulo.CantidadCotizada;

            }
            else
            {
                MessageBox.Show("No se encontro", "Intente Buscar de nuevo",
                 MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void RegistroDeArticulos_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        ///  El Button Nuevo la cual  nos limpia nuestra Ventana
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            ArticuloIDnumericUpDown.Value = 0;
            FechaVencimientodateTimePicker.Value = DateTime.Now;
            DescripciontextBox.Clear();
            PreciotextBox.Clear();
            ExistencianumericUpDown.Value = 0;
            CantidadCotizadanumericUpDown.Value = 0;
            errorProvider.Clear();

        }
    }
}
