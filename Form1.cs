using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewCalculadora
{
    public partial class Form1 : Form
    {
        double primero = 0, segundo = 0;
        string operador = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Resultado.Clear();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Resultado.Text.Trim() == string.Empty)
            {
                return;
            }
            primero = Convert.ToInt32(Resultado.Text);
            operador = "*";
            Resultado.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Resultado.Text.Trim() ==string.Empty)
            { 
                return;
            }
            primero = Convert.ToInt32(Resultado.Text);
            operador = "/";
            Resultado.Clear();
        }
    }
}
