using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NumerosPrimos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmdcoladera_Click(object sender, EventArgs e)
        {
            Coladera col = new Coladera();
            txtmostrar.Text = col.eratostenes();
        }
    }
}
