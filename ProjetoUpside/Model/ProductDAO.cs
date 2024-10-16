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
            Cmd.CommandText = @"INSERT INTO Product (@IdProduto, @NomeProduto, @Preco, @Quantidade)";

            Cmd.Parameters.AddWithValue("@IdProduto", product.IdProduto);
            Cmd.Parameters.AddWithValue("@NomeProduto", product.NomeProduto);
            Cmd.Parameters.AddWithValue("@Preco", product.Preco);
            Cmd.Parameters.AddWithValue("@Quantidade", product.Quantidade);


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
