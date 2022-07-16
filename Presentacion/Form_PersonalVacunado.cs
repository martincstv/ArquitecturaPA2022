using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Entidad;
using Negocio;

namespace Presentacion
{
    public partial class Form_PersonalVacunado : Form
    {
        PersonalVacunadoEntidad personalVacunado = new PersonalVacunadoEntidad();

        public Form_PersonalVacunado()
        {
            InitializeComponent();
        }

        private void Form_PersonalVacunado_Load(object sender, EventArgs e)
        {
            CargarValoresIniciales();
        }

        private void CargarValoresIniciales()
        {
            CargarPersonalVacunadoEnDataGrid();
        }

        private void CargarPersonalVacunadoEnDataGrid()
        {
            dataGridView_ListaPersonasVacunadas.DataSource = null;
            dataGridView_ListaPersonasVacunadas.DataSource = PersonalVacunadoNegocio.DevolverListaPersonasVacunadas();
        }

        private void button_Guardar_Click(object sender, EventArgs e)
        {
            GuardarPersonaVacunada();
        }

        private void GuardarPersonaVacunada()
        {
            personalVacunado.Nombre = textBox_Nombre.Text.ToUpper();
            personalVacunado.Apellido = textBox_Apellido.Text.ToUpper();
            personalVacunado.Cedula = textBox_Cedula.Text;
            personalVacunado.Telefono = textBox_Telefono.Text;
            personalVacunado.NumeroDosis = Convert.ToInt32(textBox_NumeroDosis.Text);

            personalVacunado = PersonalVacunadoNegocio.Guardar(personalVacunado);
            if (personalVacunado != null)
            {
                textBox_Id.Text = personalVacunado.Id.ToString();
                MessageBox.Show("Los datos se han ingresado correctamente");
                CargarPersonalVacunadoEnDataGrid();
            }
            else
            {
                MessageBox.Show("Se produjo un error en el proceso", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #region Controles para ingreso de datos

        private void textBox_Nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Condicion para solo letras
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            //Para Backspace
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            //Para Space bar
            //else if (char.IsSeparator(e.KeyChar))
            //{
            //    e.Handled = false;
            //}
            //Si no cumple con nada de lo anterior no deja pasar
            else
            {
                MessageBox.Show("Este campo solo admite caracteres", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
            }
        }

        private void textBox_Apellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Condicion para solo letras
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            //Para Backspace
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            //Para Space bar
            //else if (char.IsSeparator(e.KeyChar))
            //{
            //    e.Handled = false;
            //}
            //Si no cumple con nada de lo anterior no deja pasar
            else
            {
                MessageBox.Show("Este campo solo admite caracteres", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
            }
        }

        private void textBox_Cedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Condicion para solo números
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            //Para Backspace
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            //Para punto y que solo se pueda ingresar uno
            //else if ((e.KeyChar == '.') && (!textBox_Cedula.Text.Contains(".")))
            //{
            //    e.Handled = false;
            //}
            //Si no cumple con nada de lo anterior no deja pasar
            else
            {
                MessageBox.Show("Este campo solo admite valores numéricos", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
            }
        }

        private void textBox_Telefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Condicion para solo números
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            //Para Backspace
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            //Para punto y que solo se pueda ingresar uno
            //else if ((e.KeyChar == '.') && (!textBox_Cedula.Text.Contains(".")))
            //{
            //    e.Handled = false;
            //}
            //Si no cumple con nada de lo anterior no deja pasar
            else
            {
                MessageBox.Show("Este campo solo admite valores numéricos", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
            }
        }

        private void textBox_NumeroDosis_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Este campo solo admite valores numéricos", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
            }
        }

        #endregion

        private void dataGridView_ListaPersonasVacunadas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var id = Convert.ToInt32(dataGridView_ListaPersonasVacunadas.Rows[e.RowIndex].Cells["Id"].Value.ToString());
            CargarPersonalVacunadoPorId(id);
        }

        private void CargarPersonalVacunadoPorId(int id)
        {
            personalVacunado = PersonalVacunadoNegocio.DevolverPersonalVacunadoPorId(id);
            textBox_Id.Text = personalVacunado.Id.ToString();
            textBox_Nombre.Text = personalVacunado.Nombre;
            textBox_Apellido.Text = personalVacunado.Apellido;
            textBox_Cedula.Text = personalVacunado.Cedula;
            textBox_Telefono.Text = personalVacunado.Telefono;
            textBox_NumeroDosis.Text = personalVacunado.NumeroDosis.ToString();
        }

        private void button_Eliminar_Click(object sender, EventArgs e)
        {
            EliminarPersonalVacunado();
        }

        private void EliminarPersonalVacunado()
        {
            if (MessageBox.Show("Esta Ud. realmente seguro de eliminar este registro???", "Eliminar Dato", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                if (PersonalVacunadoNegocio.ElimminarPersonalVacunado(personalVacunado.Id))
                {
                    MessageBox.Show("El dato fue eliminado satisfactoriamente!!!");
                    CargarPersonalVacunadoEnDataGrid();
                }
            }
        }
    }
}