﻿using System;
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
            this++;
            labelQuantity.Text = ValorLabel.ToString();
        }
    }
}
