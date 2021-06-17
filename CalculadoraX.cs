using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AULA8
{
    public partial class CalculadoraX : Form
    {
        double valorMen;
    
        public CalculadoraX()
        {
            InitializeComponent();
        }

        private void btn_Plus_Click(object sender, EventArgs e)
        {
            valorMen = valorMen + Convert.ToDouble(txtValor.Text);
            txtValor.Text = string.Empty;
        }

        private void CalculadoraX_Load(object sender, EventArgs e)
        {
            valorMen = 0;
            txtValor.Text = string.Empty;
        }

        private void btn_Iqual_Click(object sender, EventArgs e)
        {
            txtValor.Text = valorMen.ToString();
           
        }

        private void btn_Minus_Click(object sender, EventArgs e)
        {
            valorMen = valorMen - Convert.ToDouble(txtValor.Text);
            txtValor.Text = string.Empty;
        }

        private void btn_Multi_Click(object sender, EventArgs e)
        {
            valorMen = valorMen * Convert.ToDouble(txtValor.Text);
            txtValor.Text = string.Empty;
        }

        private void btn_Division_Click(object sender, EventArgs e)
        {
            valorMen = valorMen / Convert.ToDouble(txtValor.Text);
            txtValor.Text = string.Empty;
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txtValor.Text = string.Empty;
        }
    }
}
