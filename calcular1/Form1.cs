using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calcular1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Limpiar_Click(object sender, EventArgs e)
        {
            txt_Valor1.Clear();
            txt_Valor2.Clear();
            txt_Resultado.Clear();
            txt_Resta.Clear();
            txt_Multiplicacion.Clear();
            txt_Division.Clear();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            Close();

        }

        
        private void btn_C_Click(object sender, EventArgs e)
        {
            int valor1, valor2;

            valor1 = int.Parse(txt_Valor1.Text);
            valor2 = int.Parse(txt_Valor2.Text);

            int resultado = valor1 + valor2;
            int Resta = valor1 - valor2;
            int Multiplicacion = valor1 * valor2;
            int Division = valor1 / valor2;


            txt_Resultado.Text = resultado.ToString();
            txt_Resta.Text = Resta.ToString();
            txt_Multiplicacion.Text = Multiplicacion.ToString();
            txt_Division.Text = Division.ToString();

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void btn_Salir_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_Limpiar_Click_1(object sender, EventArgs e)
        {
            txt_Valor1.Clear();
            txt_Valor2.Clear();
            txt_Resultado.Clear();
            txt_Resta.Clear();
            txt_Multiplicacion.Clear();
            txt_Division.Clear();
        }

        private void btn_Calcular_Click(object sender, EventArgs e)
        {
            int valor1, valor2;

            valor1 = int.Parse(txt_Valor1.Text);
            valor2 = int.Parse(txt_Valor2.Text);

            int resultado = valor1 + valor2;
            int Resta = valor1 - valor2;
            int Multiplicacion = valor1 * valor2;
            int Division = valor1 / valor2;


            txt_Resultado.Text = resultado.ToString();
            txt_Resta.Text = Resta.ToString();
            txt_Multiplicacion.Text = Multiplicacion.ToString();
            txt_Division.Text = Division.ToString();

        }
    }
}
