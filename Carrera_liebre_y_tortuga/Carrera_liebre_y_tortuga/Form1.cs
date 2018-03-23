using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Carrera_liebre_y_tortuga
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtmostrar.Clear();
            txtganador.Clear();
            txtmostrar.Text = "";
            Liebre libra = new Liebre();
            Tortuga caguama = new Tortuga();
            while(libra.noPasos < 80 && caguama.noPasos < 80)
            {
                libra.avanzar();
                txtmostrar.Text += libra.ToString() + Environment.NewLine;
                caguama.avanzar();
                txtmostrar.Text += caguama.ToString() + Environment.NewLine;
            };
            if(libra.noPasos >=80)
            {
                txtganador.Text = "Liebre";

            }
            if(caguama.noPasos >= 80)
            {
                txtganador.Text = "Tortuga";
            }
            if(libra.noPasos >=80 && caguama.noPasos >=80)
            {
                txtganador.Text = "Empate";
            }
        }
    }
}
