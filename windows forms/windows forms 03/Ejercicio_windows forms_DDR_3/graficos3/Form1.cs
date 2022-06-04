using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace graficos3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAniadir_Click(object sender, EventArgs e)
        {

            string nombre = this.txtNombre.Text;
            string apellidos = this.txtNombre.Text;
            decimal edad = this.nudEdad.Value;

            this.dgvPersonas.Rows.Add(nombre, apellidos, edad);


        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

            if (this.dgvPersonas.CurrentRow.Index != -1)
            {
                this.dgvPersonas.Rows.RemoveAt(this.dgvPersonas.CurrentRow.Index);
            }   
            else
            {
                MessageBox.Show("Debes seleccionar una fila");
            }

        }
    }
}
