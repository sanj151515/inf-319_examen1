using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ex1_319_2
{
    public partial class Form1 : Form
    {
        int pantalla;
        int pantallaAux;
        string operacion="";
        public Form1()
        {
            InitializeComponent();
        }   
        private void cargarDigito(object sender, EventArgs e)
        {
            int digito;
            digito = Convert.ToInt32(((Button)sender).Text);
            pantalla = pantalla * 10 + digito;
            textBox1.Text = pantalla.ToString();
        }
        private void operacionMatematica(object sender, EventArgs e)
        {
            operacion= ((Button)sender).Text;
            pantallaAux = pantalla;
            pantalla = 0;
            textBox1.Text = operacion;
        }
        private void resultado(object sender, EventArgs e)
        {
            if (operacion != "")
            {
                textBox1.Text = operar(operacion, pantallaAux, pantalla).ToString();
                pantalla = 0;
                pantallaAux = 0;
                operacion = "";
            }            
        }
        private float operar(string ope, int a, int b)
        {
            switch (ope)
            {
                case "+":
                    return a + b;
                case "-":
                    return a - b;
                case "*":
                    return a * b;
                case "/":
                    if(b!=0)
                        return (float)a / (float)b;
                    return 0;
                default:
                    return 0;
            }
        }
    }
}
