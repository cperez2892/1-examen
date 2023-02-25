using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarlosPerez
{
    public partial class Intereses : Form
    {
        public Intereses()
        {
            InitializeComponent();
        }

        private void Meses_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void calculo()
        {
            const double tasa = 0.0015;
            int capital = 2000000;
            Meses.Items.Clear();

            for (int mes = 1; mes <= 12; mes++)
            {
                double interes = capital * tasa;
                capital += (int)interes;
                Meses.Items.Add("Mes " + mes + ": " + interes.ToString("C2"));


            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            calculo();
        }
    }
}