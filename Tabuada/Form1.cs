using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tabuada
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int numero = int.Parse(textNumero.Text);
            //Variavel para controlar a contagem
            int contador = 1;

            //Variavel para armazenar o texto completo da tabuada
            string tabuada = "";

            while  (contador <= 10)
            {
                int resultado = numero * contador;
                tabuada += ($"{numero} X {contador} = {resultado}\n");

                contador++;
            }
            textTabuada.Text = tabuada;

        }
    }
}
