using RegistroArticulos.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Windows.Forms;

namespace RegistroArticulos.UI.Consultas
{
    public partial class ConsultaDeArticulos : Form
    {
        public ConsultaDeArticulos()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Aqui tenemos el Boton Buscar la cual en este validamos varios campos y programamos para que consulte por fecha 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void Buscar1button_Click(object sender, EventArgs e)
        {
           
            Expression<Func<Articulo, bool>> filtro= x=>true;
            int id;
            if (CriteriotextBox.Text == string.Empty&& FiltrarcomboBox.SelectedIndex!=3)
            {
                MessageBox.Show("Digite el criterio", "Debe introducir el criterio",
              MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            

            switch (FiltrarcomboBox.SelectedIndex)
            {
                case 0://ArticuloID
                    id = Convert.ToInt32(CriteriotextBox.Text);

                    filtro = x => x.ArticuloID == id &&(x.FechaVencimiento.Day>=DesdedateTimePicker.Value.Day)&&(x.FechaVencimiento.Month>=DesdedateTimePicker.Value.Month)&&(x.FechaVencimiento.Year>=DesdedateTimePicker.Value.Year)
                    && (x.FechaVencimiento.Day <= HastadateTimePicker.Value.Day) && (x.FechaVencimiento.Month <= HastadateTimePicker.Value.Month) && (x.FechaVencimiento.Year <= HastadateTimePicker.Value.Year);
                    
                    break;

                case 2://Precio
                    filtro = x => x.Precio.Equals(CriteriotextBox.Text) && (x.FechaVencimiento.Day >= DesdedateTimePicker.Value.Day) && (x.FechaVencimiento.Month >= DesdedateTimePicker.Value.Month) && (x.FechaVencimiento.Year >= DesdedateTimePicker.Value.Year)
                    && (x.FechaVencimiento.Day <= HastadateTimePicker.Value.Day) && (x.FechaVencimiento.Month <= HastadateTimePicker.Value.Month) && (x.FechaVencimiento.Year <= HastadateTimePicker.Value.Year); 
                    
                    break;

                case 1://Fecha
                    filtro = x => x.FechaVencimiento.Equals(CriteriotextBox.Text) && (x.FechaVencimiento.Day >= DesdedateTimePicker.Value.Day) && (x.FechaVencimiento.Month >= DesdedateTimePicker.Value.Month) && (x.FechaVencimiento.Year >= DesdedateTimePicker.Value.Year)
                    && (x.FechaVencimiento.Day <= HastadateTimePicker.Value.Day) && (x.FechaVencimiento.Month <= HastadateTimePicker.Value.Month) && (x.FechaVencimiento.Year <= HastadateTimePicker.Value.Year);

                    break;
            
                case 3://Todo
                    dataGridView.DataSource = BLL.ArticulosBLL.GetList(filtro); 
                    break;
            }
            dataGridView.DataSource = BLL.ArticulosBLL.GetList(filtro);


        }

        private void FiltrarcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(FiltrarcomboBox.SelectedIndex ==3)
            {
                CriteriotextBox.Enabled = false;
            }
            else
                CriteriotextBox.Enabled = true;



        }
    }
}
