using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora3
{
    public partial class Form1 : Form
    {
        double num1;
        double num2;
        string Cadena = "";
        char[] simbolos;
        string[] numbers;

        string operacion;
        public Form1()
        {
            InitializeComponent();

        }

        Clases.ClsDiv objDiv = new Clases.ClsDiv();
        Clases.ClsMul objMul = new Clases.ClsMul();
        Clases.ClsRes objRes = new Clases.ClsRes();
        Clases.ClsSuma objSuma = new Clases.ClsSuma();


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "7";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "4";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "1";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "8";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "5";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "2";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "0";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + ".";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "9";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "6";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "3";
        }

        private void BtnMul_Click(object sender, EventArgs e)
        {
            operacion = "*";
           // num1 = double.Parse(textBox1.Text);
            textBox1.Clear();
        }

        private void BtnSum_Click(object sender, EventArgs e)
        {
            
            textBox1.Text = textBox1.Text + "+";
            Console.WriteLine(textBox1.Text.Substring(0,1));
            num1 = double.Parse(textBox1.Text.Substring(0,1));
            //Console.WriteLine(num1);
            operacion = "+";





            //textBox1.Clear();
        }

        private void BtnDiv_Click(object sender, EventArgs e)
        {
            operacion = "/";
           num1 = double.Parse(textBox1.Text);
            textBox1.Clear();
        }

        private void BtnRes_Click(object sender, EventArgs e)
        {
            operacion = "-";
            //num1 = double.Parse(textBox1.Text);
            textBox1.Clear();
        }

        private void button16_Click(object sender, EventArgs e)
        {
           // Console.WriteLine(textBox1.Text.Substring(2));
            //textBox1.Text = textBox1.Text.TrimStart();
            num2= double.Parse(textBox1.Text.Substring(2));
            double Sum;
            double Res;
            double Mult;
            double Div;

            switch (operacion)
            {
                case "+":

                    Sum = objSuma.Sumar((num1), (num2));
                    textBox1.Text = Sum.ToString();
                    break;

                case "-":
                    Res = objRes.Restar((num1), (num2));
                    textBox1.Text = Res.ToString();
                    break;

                case "*":
                    Mult = objMul.Multiplicar((num1), (num2));
                    textBox1.Text = Mult.ToString();
                    break;

                case "/":
                    Div = objDiv.Dividir((num1), (num2));
                    textBox1.Text = Div.ToString();
                    break;
            }
        }
    }
}
