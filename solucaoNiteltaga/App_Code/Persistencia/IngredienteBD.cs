 //para acesso a classe Mapped
using System;
using System.Web;
using solucaoNiteltaga.Classes; //para acesso a classe Funcionario
using System.Data; //para uso de DataSet
using NIELTAGA;
using CrudIngrediente.Classes;

namespace CrudIngrediente.Persistencia
{
    /// <summary>
    /// Summary description for FuncionarioBD
    /// </summary>
    public class IngredienteBD
    {
        //métodos
        //insert
        //métodos
        //insert
        public bool Insert(Ingrediente ingrediente)
        {
            System.Data.IDbConnection objConexao;
            System.Data.IDbCommand objCommand;
            string sql = "INSERT INTO tbl_ingredientes(ing_nome, ing_marca, ing_quantidade, ing_valorUnitario) VALUES (?nome, ?marca, ?quantidade, ?valorUnitario)";
            objConexao = Mapped.Connection();
            objCommand = Mapped.Command(sql, objConexao);
            objCommand.Parameters.Add(Mapped.Parameter("?nome", ingrediente.Nome));
            objCommand.Parameters.Add(Mapped.Parameter("?marca", ingrediente.Marca));
            objCommand.Parameters.Add(Mapped.Parameter("?quantidade", ingrediente.Quantidade));
            objCommand.Parameters.Add(Mapped.Parameter("?valorUnitario", ingrediente.ValorUnitario));
            objCommand.ExecuteNonQuery();
            objConexao.Close();
            objCommand.Dispose();
            objConexao.Dispose();
            return true;
        }
        //selectall
        //selectall
        public DataSet SelectAll()
        {
            DataSet ds = new DataSet();
            System.Data.IDbConnection objConexao;
            System.Data.IDbCommand objCommand;
            System.Data.IDataAdapter objDataAdapter;
            objConexao = Mapped.Connection();
            objCommand = Mapped.Command("SELECT * FROM tlb_ingredientes", objConexao);
            objDataAdapter = Mapped.Adapter(objCommand);
            objDataAdapter.Fill(ds);
            objConexao.Close();
            objCommand.Dispose();
            objConexao.Dispose();
            return ds;
        }
        //select
        //select
        public Ingrediente Select(int id)
        {
            Ingrediente obj = null;
            System.Data.IDbConnection objConexao;
            System.Data.IDbCommand objCommand;
            System.Data.IDataReader objDataReader;
            objConexao = Mapped.Connection();
            objCommand = Mapped.Command("SELECT * FROM tbl_ingredientes WHERE ing_id = ?codigo", objConexao);
            objCommand.Parameters.Add(Mapped.Parameter("?codigo", id));
            objDataReader = objCommand.ExecuteReader();
            while (objDataReader.Read())
            {
                obj = new Ingrediente();
                obj.Codigo = Convert.ToInt16(objDataReader["ing_id"]);
                obj.Nome = Convert.ToString(objDataReader["ing_nome"]);
                obj.Marca = Convert.ToString(objDataReader["ing_marca"]);
                obj.Quantidade = Convert.ToInt16(objDataReader["ing_quantidade"]);
                obj.ValorUnitario = Convert.ToDouble(objDataReader["ing_valorUnitario"]);

            }
            objDataReader.Close();
            objConexao.Close();
            objCommand.Dispose();
            objConexao.Dispose();
            objDataReader.Dispose();
            return obj;
        }

        //update
        public bool Update(Ingrediente ingrediente)
        {
            System.Data.IDbConnection objConexao;
            System.Data.IDbCommand objCommand;
            string sql = "UPDATE tbl_ingredientes SET ing_nome = ?nome, ing_marca = ?marca, ing_quantidade = ?quantidade WHERE ing_id = ?codigo";
            objConexao = Mapped.Connection();
            objCommand = Mapped.Command(sql, objConexao);
            objCommand.Parameters.Add(Mapped.Parameter("?nome", ingrediente.Nome));
            objCommand.Parameters.Add(Mapped.Parameter("?marca", ingrediente.Marca));
            objCommand.Parameters.Add(Mapped.Parameter("?quantidade", ingrediente.Quantidade));
            objCommand.Parameters.Add(Mapped.Parameter("?valorUnitario", ingrediente.ValorUnitario));

            objCommand.ExecuteNonQuery();
            objConexao.Close();
            objCommand.Dispose();
            objConexao.Dispose();
            return true;
        }
        //delete
        public bool Delete(int id)
        {
            System.Data.IDbConnection objConexao;
            System.Data.IDbCommand objCommand;
            string sql = "DELETE FROM tbl_ingredientes WHERE ing_id = ?codigo";
            objConexao = Mapped.Connection();
            objCommand = Mapped.Command(sql, objConexao);
            objCommand.Parameters.Add(Mapped.Parameter("?codigo", id));

            objCommand.ExecuteNonQuery();
            objConexao.Close();
            objCommand.Dispose();
            objConexao.Dispose();
            return true;
        }
        //update
        //delete


        //BAIXA ESTOQUE
        //update
        public static bool BaixaEstoque(int id, int qtdBaixa)
        {
            System.Data.IDbConnection objConexao;
            System.Data.IDbCommand objCommand;
            string sql = "UPDATE tbl_ingredientes SET ing_quantidade = ing_quantidade - ?quantidade WHERE ing_id = ?codigo";
            objConexao = Mapped.Connection();
            objCommand = Mapped.Command(sql, objConexao);

            objCommand.Parameters.Add(Mapped.Parameter("?codigo", id));
            objCommand.Parameters.Add(Mapped.Parameter("?quantidade", qtdBaixa));
  
            objCommand.ExecuteNonQuery();
            objConexao.Close();
            objCommand.Dispose();
            objConexao.Dispose();
            return true;
        }
    }
}