using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace graficos2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {

            Aleatorios a = new Aleatorios();

            int[] numerosElegidos = a.generarNumerosAleatoriosNoRepetidos(6, 1, 49);

            Control[] controles = { txtN1, txtN2, txtN3, txtN4, txtN5, txtN6 };

            for (int i = 0; i < controles.Length; i++)
            {
                int valor = numerosElegidos[i];
                controles[i].Text = valor + "";
            }


        }
    }
}
