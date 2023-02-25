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
    public partial class Facturacion1 : Form
    {
        public Facturacion1()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            decimal precio = Convert.ToDecimal(textBox1Precio.Text);
            decimal cantidad = Convert.ToDecimal(textBox1Precio.Text);
            decimal total = await DescuentoAsync(precio, cantidad);
            textBox1Resultado.Text = total.ToString();


        }

        private async Task<decimal> DescuentoAsync(decimal precio, decimal cantidad)
        {
            decimal subtotal = await Task.Run(() =>
            {
                return precio * cantidad;
            });
            decimal Descuento = await Task.Run(() =>
            {
                return subtotal * 0.15M;
            });
            decimal total = await Task.Run(() =>
            {
                return subtotal - Descuento;
            });
            return total;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1Resultado.Clear();
            textBox1Cantidad.Clear();
            textBox1Nombre.Clear();
            textBox1Resultado.Clear();
        }
    }
}