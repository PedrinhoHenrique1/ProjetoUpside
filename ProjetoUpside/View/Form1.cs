using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoUpside
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Registro registro = new Registro();
            registro.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Product1 product1 = new Product1();
            product1.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Product2 product2 = new Product2();
            product2.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Product3 Product3 = new Product3();
            Product3.ShowDialog();
        }
    }
}
