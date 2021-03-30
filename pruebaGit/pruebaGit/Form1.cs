using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pruebaGit
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // Hola Profe, ya me funciona :D, no creí que me iba a costar tanto xD
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Efectivamente se ejecuta el Messagebox");
        }
    }
}
