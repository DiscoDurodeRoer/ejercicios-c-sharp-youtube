using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Graficos1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSuma_Click(object sender, EventArgs e)
        {

            decimal v1 = this.nudOp1.Value;
            decimal v2 = this.nudOp2.Value;

            decimal total = v1 + v2;

            this.txtResultado.Text = total + "";

        }

        private void btnResta_Click(object sender, EventArgs e)
        {
            decimal v1 = this.nudOp1.Value;
            decimal v2 = this.nudOp2.Value;

            decimal total = v1 - v2;

            this.txtResultado.Text = total + "";
        }

        private void btnMultp_Click(object sender, EventArgs e)
        {
            decimal v1 = this.nudOp1.Value;
            decimal v2 = this.nudOp2.Value;

            decimal total = v1 * v2;

            this.txtResultado.Text = total + "";
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            decimal v1 = this.nudOp1.Value;
            decimal v2 = this.nudOp2.Value;

            if (v2 == 0)
            {
                MessageBox.Show("No puede ser un cero");
            }
            else
            {
                decimal total = v1 / v2;

                this.txtResultado.Text = total + "";
            }

            
        }
    }
}
