using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inicio_Sesion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Iniciar_Click(object sender, EventArgs e)
        {
            //Validacion para que los campos no esten vacios
            if (string.IsNullOrWhiteSpace(txt_Id.Text) || string.IsNullOrWhiteSpace(txt_Nombre.Text) ||
               string.IsNullOrWhiteSpace(txt_Apellidos.Text) || string.IsNullOrWhiteSpace(txt_Telefono.Text) ||
               string.IsNullOrWhiteSpace(txt_Direccion.Text))
            {
                MessageBox.Show("Debes llenar todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show("Sesion Iniciada!!", "Felicidades", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void txt_Id_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 48 && e.KeyChar <= 57 || e.KeyChar == 8 || e.KeyChar == 13)
            {
            }
            else
            {
                MessageBox.Show("Solo Puede Ingresar Numeros...");
                e.Handled= true;
                return;
            }
            if(e.KeyChar == 13)
            {
                txt_Nombre.Focus();
            }
        }

        private void txt_Nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 65 && e.KeyChar <= 90 || e.KeyChar >= 97 && e.KeyChar <= 122 || e.KeyChar == 8 ||
                e.KeyChar == 32 || e.KeyChar == 13)
            {
            }
            else
            {
                MessageBox.Show("Solo Puede Ingresar Letras...");
                e.Handled = true;
                return;
            }
            if (e.KeyChar == 13)
            {
                txt_Apellidos.Focus();
            }
        }

        private void txt_Apellidos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 65 && e.KeyChar <= 90 || e.KeyChar >= 97 && e.KeyChar <= 122 || e.KeyChar == 8 ||
                e.KeyChar == 32 || e.KeyChar == 13)
            {
            }
            else
            {
                MessageBox.Show("Solo Puede Ingresar Letras...");
                e.Handled = true;
                return;
            }
            if (e.KeyChar == 13)
            {
                txt_Telefono.Focus();
            }
        }

        private void txt_Telefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 48 && e.KeyChar <= 57 || e.KeyChar == 8 || e.KeyChar == 13)
            {
            }
            else
            {
                MessageBox.Show("Solo Puede Ingresar Numeros...");
                e.Handled = true;
                return;
            }
            if (e.KeyChar == 13)
            {
                txt_Direccion.Focus();
            }
        }

        private void txt_Direccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 48 && e.KeyChar <= 57 || e.KeyChar >= 65 && e.KeyChar <= 90 || e.KeyChar >= 97 &&
                e.KeyChar <= 122 || e.KeyChar == 8 || e.KeyChar == 13 || e.KeyChar == 45 || e.KeyChar == 35 ||
                e.KeyChar == 32)
            {
            }
            else
            {
                MessageBox.Show("El Caracter Ingresado Es Invalido...");
                e.Handled = true;
                return;
            }
            if (e.KeyChar == 13)
            {
                btn_Iniciar.Focus();
            }
        }
    }
}
