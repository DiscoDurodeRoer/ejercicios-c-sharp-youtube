using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace graficos4
{
    public partial class Form1 : Form
    {

        private string path;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            OpenFileDialog abrir = new OpenFileDialog();
            abrir.Filter = "JPEG(*.JPG)|*.JPG|BMP(*.BMP)|*.BMP";
            
            if (abrir.ShowDialog() == DialogResult.OK)
            {
                path = abrir.FileName;
                pbFoto.Image = Image.FromFile(abrir.FileName);
            }
            

        }

        private void btnCopiar_Click(object sender, EventArgs e)
        {
            File.Copy(path, "images/image.jpg", true);
            MessageBox.Show("Imagen copiada");
        }
    }
}
