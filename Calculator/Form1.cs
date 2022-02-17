using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        double Numero1 = 0, Numero2 = 0;
        char Operador;

        public Form1()
        {
            InitializeComponent();
        } 

        private void agregarNumero (object sender, EventArgs e)
        {
            var boton = ((Button)sender);

            if (textResultado.Text == "0")
                textResultado.Text = "";

            textResultado.Text += boton.Text;
        }

        private void btnResultado_Click(object sender, EventArgs e)
        {
            Numero2 = Convert.ToDouble(textResultado.Text); 

            if (Operador == '+')
            {
                textResultado.Text = (Numero1 + Numero2).ToString();
                Numero1 = Convert.ToDouble(textResultado.Text); 
            }
            else if (Operador == '−')
            {
                textResultado.Text = (Numero1 -Numero2).ToString();
                Numero1 = Convert.ToDouble(textResultado.Text);
            }
            else if (Operador == 'X')
            {
                textResultado.Text = (Numero1 * Numero2).ToString();
                Numero1 = Convert.ToDouble(textResultado.Text);
            }
            else if (Operador == '÷')
            {
                if (textResultado.Text != "0")
                {
                    textResultado.Text = (Numero1 / Numero2).ToString();
                    Numero1 = Convert.ToDouble(textResultado.Text);
                }
               else
                {
                    MessageBox.Show("Por cero no se puede dividir");
                }
            }
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            if (textResultado.Text.Length > 1)
            {
                textResultado.Text = textResultado.Text.Substring(0, textResultado.Text.Length - 1);
            }
            else
            {
                textResultado.Text = "0";
            }
        }

        private void btnBorrarTodo_Click(object sender, EventArgs e)
        {
            Numero1 = 0;
            Numero2 = 0;
            Operador = '\0';
            textResultado.Text = "0";
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            textResultado.Text = "0";
        }

        private void btnPunto_Click(object sender, EventArgs e)
        {
            if (!textResultado.Text.Contains ("."))
            {
                textResultado.Text += ".";
            }
        }

        private void btnSigno_Click(object sender, EventArgs e)
        {
            Numero1 = Convert.ToDouble(textResultado.Text);
            Numero1 *= -1;
            textResultado.Text = Numero1.ToString();
        }

        private void clickOperador(object sender, EventArgs e)
        {
            var boton = ((Button)sender);

            Operador = Convert.ToChar(boton.Tag);
            Numero1 = Convert.ToDouble(textResultado.Text);
              if (Operador == '²')
            {
                Numero1 = Math.Pow(Numero1, 2);
                textResultado.Text = Numero1.ToString();
            }
            else if (Operador == '√')
                {
                    Numero1 = Math.Sqrt(Numero1);
                    textResultado.Text = Numero1.ToString();
            }
            else
            {
                textResultado.Text = "0";
        }
      }
    }
}
