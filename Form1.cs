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
    public partial class Form1 : Form
    {

        decimal salario ;
        decimal ImpRenda;
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Calcular_Click(object sender, EventArgs e)
        {

            if (txtSalario.Text =="")
            {
                MessageBox.Show("O valor de salário deve ser fornecido! ", "Salário", MessageBoxButtons.OK,
                                 MessageBoxIcon.Information);
            }
            else
            {
                salario = Convert.ToDecimal(txtSalario.Text);

                if (salario < 540M)
                {
                    MessageBox.Show("O valor de salário não pode ser menor que salário mínimo! ", "Salário", MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                }
                else if (salario > 27000M)
                {
                    MessageBox.Show("O valor de salário não pode ser maior que o teto nacional de R$ 27000","Salário",
                                   MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
               
                else if (salario > 1000 && CheckPlanoSaude.Checked )
                {
                    salario = salario - 100;                 
                }

                if ( dateTimePicker1.Value.Month == 12)
                {
                    salario = salario * 2;     
                }

                ImpRenda = 0;

                if (salario > 0M && salario <= 1500M)
                {
                    ImpRenda = 0M;
                }
                else if ( salario > 1500 && salario <= 2500M)
                {
                    ImpRenda = 5;

                }
                else if (salario > 2500M && salario <= 5000M)
                {
                    ImpRenda = 10M;
                }

                else if(salario > 5000M)
                {
                    ImpRenda = 20M;
                }

                switch (comboBox1.Text)
                {
                    case "Clube A":
                        salario = salario - 100;
                        break;
                    case "Clube B":
                        salario = salario - 50;
                        break;
                    case "Clube C":
                        salario = salario - 10;
                        break;
                    default:
                        break;
                }

                txtSalFolha.Text = salario.ToString();
                txtImpostoRenda.Text = Convert.ToString( salario * (ImpRenda /100));
                txtSalLiquido.Text = Convert.ToString(salario - (salario * (ImpRenda / 100)));



            }


        }
    }
}
