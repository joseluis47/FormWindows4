using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int tipo = 0;
            Teste teste = new Teste();

            if (radioButton1.Checked)
            {
                tipo = 1;
            } else if (radioButton1.Checked)
            {
                tipo = 2;
            } else
            {
                tipo = 3;
            }

            Teste teste1 = new Teste();
            double valor = double.Parse(textBox1.Text);
            System.Windows.Forms.MessageBox.Show(teste1.ValorFinal(valor, tipo).ToString());
                
        }
    }
}
