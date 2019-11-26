using System;
using System.Windows.Forms;

namespace Retangulo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Retangulo r = new Retangulo();
        private void Button1_Click(object sender, EventArgs e)
        {
            r.Altura = textBox1.Text;
            r.Largura = textBox2.Text;
            if (radioButton1.Checked) label1.Text = r.Area;
            else if (radioButton2.Checked) label1.Text = r.Perimetro;
            else if (radioButton3.Checked) label1.Text = r.Diagonal;
        }
    }
}
