using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora_Nobreak
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
          
        }

        private void tensao_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void potencia_KeyPress(object sender, KeyPressEventArgs e)
        {
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float autonomia, corrente, tensao, quantidade, potencia;

            corrente = float.Parse(txtCorrente.Text);
            tensao = float.Parse(txtTensao.Text);
            quantidade = float.Parse(txtQuantidade.Text);
            potencia = float.Parse(txtPotencia.Text);

            /* Cálculo de autonomia */
            autonomia =  corrente * tensao * quantidade / potencia;

            /**Horas**/
            float horas = (float)Math.Truncate(autonomia);

            /*obter minutos*/
            float minutesInDecimal = (autonomia - horas) * 60;
            float minutes = (float)Math.Truncate((autonomia - horas)*60);

            /* obter segundos */
            float secondsInDecimal = minutesInDecimal - minutes;
            float seconds = (float)Math.Truncate(secondsInDecimal*60);

            lblResultado.Text = horas.ToString()+"h : "+minutes.ToString()+"m : "+ seconds.ToString()+"s";

        }
    }
}
