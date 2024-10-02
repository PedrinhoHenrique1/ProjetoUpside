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
            string currentValueString = labelPrice.Text.Replace("R$ ", "").Replace(",", ".");
            if (double.TryParse(currentValueString, out double currentValue))
            {
                string newValue = (currentValue + 1199.99).ToString("C"); // formato de moeda
                labelPrice.Invoke((MethodInvoker)delegate { labelPrice.Text = newValue; });
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
                labelQuantity.Text = (int.Parse(labelQuantity.Text) - 1).ToString();
        }
    }
}
