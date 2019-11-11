using NIELTAGA;
using System;
using System.Web;
using solucaoNiteltaga.Classes;//para acesso a classe Pedido
using System.Data; //para uso de DataSet
using System.Web.UI.WebControls;

/// <summary>
/// Descrição resumida de Receita
/// </summary>
namespace solucaoNiteltaga.Classes
{
    public class ReceitaBD
    {

        //Insert
        public bool Insert(Receitas itemreceita)
        {
            System.Data.IDbConnection objConexao;
            System.Data.IDbCommand objCommand;
            string sql = "INSERT INTO tbl_receita(rec_quantidadeIngrediente, ing_id) VALUES (?quantidade, ?ing)";
            objConexao = Mapped.Connection();
            objCommand = Mapped.Command(sql, objConexao);
            objCommand.Parameters.Add(Mapped.Parameter("?quantidade", itemreceita.Quantidade));
            objCommand.Parameters.Add(Mapped.Parameter("?ing", itemreceita.Ingrediente));
            objCommand.ExecuteNonQuery();
            objConexao.Close();
            objCommand.Dispose();
            objConexao.Dispose();
            return true;
        }
    }
}