 using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoUpside
{
    internal class ProductDAO
    {
        private  Connection Con {  get; set; }
        private SqlCommand Cmd {  get; set; }

        public ProductDAO()
        {
            Con = new Connection();
            Cmd = new SqlCommand();
        }
        public void Insert(Product product)
        {
            Cmd.Connection = Con.ReturnConnection();
            Cmd.CommandText = @"INSERT INTO Product VALUES (@IdProduto, @NomeProduto, @Preco, @Quantidade)";

            Cmd.Parameters.AddWithValue("@IdProduto", product.IdProduct);
            Cmd.Parameters.AddWithValue("@NomeProduto", product.NameProduct);
            Cmd.Parameters.AddWithValue("@Preco", product.Price);
            Cmd.Parameters.AddWithValue("@Quantidade", product.Quantity);


            try
            {
                Cmd.ExecuteNonQuery();
            }
            catch (Exception err) 
            {
                throw new Exception("Erro: Problemas ao inserir " + "produto no banco. \n" + err.Message);
            }
            finally
            {
                Con.CloseConnect();
            }
        }
    }
}
