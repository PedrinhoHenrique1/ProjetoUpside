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
    public partial class Carrinho : Form
    {

        public Carrinho()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            labelQuantity.Text = (int.Parse(labelQuantity.Text) + 1).ToString();
            labelPrice.Text = (double.Parse(labelPrice.Text) + 1199.99).ToString();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            labelQuantity.Text = (double.Parse(labelQuantity.Text) - 1).ToString();
            if (double.Parse(labelPrice.Text) < 1199.99)
            {
                MessageBox.Show("Erro: quantidade inválida.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                labelPrice.Text = (double.Parse(labelPrice.Text) - 1199.99).ToString();
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
