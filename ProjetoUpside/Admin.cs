using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.CompilerServices.RuntimeHelpers;
using System.Windows.Forms.Design;

namespace ProjetoUpside
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            string name = nameTxb.Text;
            int quantity = int.Parse(quantityTxb.Text);
            float price = float.Parse(priceTxb.Text);

            //Cria objeto do tipo da entidade manipulada.
            Product product = new Product(name, price, quantity);

            //Cria objeto para interação com o banco de dados.
            ProductDAO productDAO = new ProductDAO();

            //Chama o insert
            productDAO.Insert(product);


        }
    }
}
