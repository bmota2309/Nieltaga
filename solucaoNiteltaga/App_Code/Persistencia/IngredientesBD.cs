using NIELTAGA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using solucaoNiteltaga.Classes;
using System.Data;

namespace solucaoNiteltaga.Pesistencia
{


    /// <summary>
    /// Descrição resumida de FuncionadoBD
    /// </summary>
    ///

    public class IngredientesBD
    {
        public bool Insert(Ingredientes ingredientes)
        {
            System.Data.IDbConnection objConexao;
            System.Data.IDbCommand objCommand;
            string sql = "INSERT INTO tbl_ingredientes (ing_id, ing_nome, ing_marca, ing_quantidade, ing_valorUnitario, ing_quantidadeMax) VALUES (?Id, ?Nome, ?Marca, ?Quantidade, ?ValorUnitario, ?QuantidadeMax)";

            objConexao = Mapped.Connection();
            objCommand = Mapped.Command(sql, objConexao);

            objCommand.Parameters.Add(Mapped.Parameter("?id", ingredientes.Id));     
            objCommand.Parameters.Add(Mapped.Parameter("?nome", ingredientes.Nome));
            objCommand.Parameters.Add(Mapped.Parameter("?marca", ingredientes.Marca));
            objCommand.Parameters.Add(Mapped.Parameter("?quantidade", ingredientes.Quantidade));
            objCommand.Parameters.Add(Mapped.Parameter("?valorUnitario", ingredientes.ValorUnitario));
            objCommand.Parameters.Add(Mapped.Parameter("?quantidadeMax", ingredientes.QuantidadeMax));

            objCommand.ExecuteNonQuery();
            objConexao.Close();
            objCommand.Dispose();
            objConexao.Dispose();

            return true;

        }
        //SelecAll
        public DataSet SelectAll()
        {
            DataSet ds = new DataSet();
            System.Data.IDbConnection objConexao;
            System.Data.IDbCommand objCommand;
            System.Data.IDataAdapter objDataAdapter;
            objConexao = Mapped.Connection();
            objCommand = Mapped.Command("SELECT  (ing_quantidade/ing_quantidadeMax) as porcentagem, tbl_ingredientes.* FROM nieltagabd.tbl_ingredientes;", objConexao);
            objDataAdapter = Mapped.Adapter(objCommand);
            objDataAdapter.Fill(ds);
            objConexao.Close();
            objCommand.Dispose();
            objConexao.Dispose();
            return ds;
        }
        public Ingredientes Select(int id)
        {
            Ingredientes obj = null;

            System.Data.IDbConnection objConexao;
            System.Data.IDbCommand objCommand;
            System.Data.IDataReader objDataReader;

            objConexao = Mapped.Connection();
            objCommand = Mapped.Command("SELECT * FROM tbl_ingredientes WHERE ing_id = ?id", objConexao);
            objCommand.Parameters.Add(Mapped.Parameter("?id", id));

            objDataReader = objCommand.ExecuteReader(); // exceção sem tratamento do usuario
            while (objDataReader.Read())
            {
                obj = new Ingredientes();
                obj.Id = Convert.ToInt32(objDataReader["ing_id"]);
                obj.Nome = Convert.ToString(objDataReader["ing_nome"]);
                obj.Marca = Convert.ToString(objDataReader["ing_marca"]);
                obj.Quantidade = Convert.ToInt32(objDataReader["ing_quantidade"]);
                obj.ValorUnitario = Convert.ToDecimal(objDataReader["ing_valorUnitario"]);
                obj.QuantidadeMax = Convert.ToDouble(objDataReader["ing_quantidadeMax"]);

            }
            objDataReader.Close();
            objConexao.Close();

            objCommand.Dispose();
            objConexao.Dispose();
            objDataReader.Dispose();

            return obj;
        }

        public bool Update(Ingredientes ingredientes)
        {
            System.Data.IDbConnection objConexao;
            System.Data.IDbCommand objCommand;
            string sql = "UPDATE tbl_ingredientes SET ing_id = ?id, ing_nome = ?nome, ing_marca = ?marca, ing_quantidade = ?quantidade, ing_valorUnitario = ?valorUnitario, ing_quantidadeMax=?quantidadeMax WHERE ing_id = ?id";

            objConexao = Mapped.Connection();
            objCommand = Mapped.Command(sql, objConexao);

            objCommand.Parameters.Add(Mapped.Parameter("?id", ingredientes.Id));
            objCommand.Parameters.Add(Mapped.Parameter("?nome", ingredientes.Nome));
            objCommand.Parameters.Add(Mapped.Parameter("?marca", ingredientes.Marca));
            objCommand.Parameters.Add(Mapped.Parameter("?quantidade", ingredientes.Quantidade));
            objCommand.Parameters.Add(Mapped.Parameter("?valorUnitario", ingredientes.ValorUnitario));
            objCommand.Parameters.Add(Mapped.Parameter("?quantidadeMax", ingredientes.QuantidadeMax));

            objCommand.ExecuteNonQuery();
            objConexao.Close();
            objCommand.Dispose();
            objConexao.Dispose();

            return true;
        }

        public bool Delete(int id)
        {
            System.Data.IDbConnection objConexao;
            System.Data.IDbCommand objCommand;
            string sql = "DELETE FROM tbl_ingredientes WHERE ing_id=?id";

            objConexao = Mapped.Connection();
            objCommand = Mapped.Command(sql, objConexao);

            objCommand.Parameters.Add(Mapped.Parameter("?id", id));

            objCommand.ExecuteNonQuery();
            objConexao.Close();
            objCommand.Dispose();
            objConexao.Dispose();

            return true;
        }







        public IngredientesBD()
        {
            //
            // TODO: Adicionar lógica do construtor aqui
            //
        }
        

    }
}