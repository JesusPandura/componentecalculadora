using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using operacionesCAL;
namespace componentecalculadora
{
    public partial class calculadoraa : UserControl
    {
        public calculadoraa()
        {
            InitializeComponent();
        }

        double numero1 = 0.0;
        double numero2 = 0.0;
        string operador;

       

       

        private void btn1_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "1";

        }

       
        

        private void btnsuma_Click(object sender, EventArgs e)
        {
            operador = "+";
            numero1 = double.Parse(pantalla.Text);
            pantalla.Clear();
        }

        private void btn2_Click_1(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "2";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            operador = "-";
            numero1 = double.Parse(pantalla.Text);
            pantalla.Clear();
        }

        private void btnDiv_Click_1(object sender, EventArgs e)
        {
            operador = "/";
            numero1 = double.Parse(pantalla.Text);
            pantalla.Clear();
        }

        private void btnMult_Click_1(object sender, EventArgs e)
        {
            operador = "*";
            numero1 = double.Parse(pantalla.Text);
            pantalla.Clear();
        }

        private void btncero_Click_1(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "0";

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            pantalla.Text = "";
            pantalla.Clear();
        }

        private void btnigual_Click(object sender, EventArgs e)
        {
            numero2 = double.Parse(pantalla.Text);

            double sum;
            double res;
            double div;
            double mult;

            switch (operador)
            {
                case "+":
                    sum = opera.sumar((numero1), (numero2));
                    pantalla.Text = sum.ToString();
                    break;
                case "-":
                    res = opera.resta((numero1), (numero2));
                    pantalla.Text = res.ToString();
                    break;
                case "/":
                    div = opera.div((numero1), (numero2));
                    pantalla.Text = div.ToString();
                    break;
                case "*":
                    mult = opera.Mult((numero1), (numero2));
                    pantalla.Text = mult.ToString();
                    break;

            }
        }

        private void btn3_Click_1(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "3";
        }

        private void btn6_Click_1(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "4";
        }

        private void bt5_Click_1(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "5";
        }

        private void btn4_Click_1(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "6";
        }

        private void btn7_Click_1(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "7";
        }

        private void btn8_Click_1(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "8";
        }

        private void btn9_Click_1(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "9";
        }

        private void calculadoraa_Load(object sender, EventArgs e)
        {

        }
    }
}
