using NIELTAGA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using solucaoNiteltaga.Classes;

namespace solucaoNiteltaga.Persistencia
{

    /// <summary>
    /// Descrição resumida de FuncionarioBD
    /// </summary>
    public class CadastrarBD
    {
        public bool Insert(Cadastrar cadastrar)
        {
            System.Data.IDbConnection objConexao;
            System.Data.IDbCommand objCommand;
            string sql = "INSERT INTO tbl_cardapio(car_id, car_nome, car_valorUnitario, emb_id, rec_id) VALUES (?id, ?nome, ?valorUnitario, ?embalagemId, ?receitaId)";

            objConexao = Mapped.Connection();
            objCommand = Mapped.Command(sql, objConexao);

            objCommand.Parameters.Add(Mapped.Parameter("?id", cadastrar.Id));
            objCommand.Parameters.Add(Mapped.Parameter("?nome", cadastrar.Nome));
            objCommand.Parameters.Add(Mapped.Parameter("?valorUnitario", cadastrar.valorUnitario));
            objCommand.Parameters.Add(Mapped.Parameter("?embalagemId", cadastrar.EmbalagemId));
            objCommand.Parameters.Add(Mapped.Parameter("?receitaId", cadastrar.ReceitaId));

            objCommand.ExecuteNonQuery();
            objConexao.Close();
            objCommand.Dispose();
            objConexao.Dispose();

            return true;
        }

        public DataSet SelectAll()
        {
            DataSet ds = new DataSet();

            System.Data.IDbConnection objConexao;
            System.Data.IDbCommand objCommand;
            System.Data.IDataAdapter objDataAdapter;

            objConexao = Mapped.Connection();
            objCommand = Mapped.Command("SELECT * FROM tbl_embalagem", objConexao);
            objDataAdapter = Mapped.Adapter(objCommand);
            objDataAdapter.Fill(ds);

            objConexao.Close();

            objCommand.Dispose();
            objConexao.Dispose();

            return ds;        
        }
        public Cadastrar Select(int id)
        {
            Cadastrar obj = null;

            System.Data.IDbConnection objConexao;
            System.Data.IDbCommand objCommand;
            System.Data.IDataReader objDataReader;

            objConexao = Mapped.Connection();
            objCommand = Mapped.Command("SELECT * FROM tbl_cardapio WHERE car_id = ?id", objConexao);
            objCommand.Parameters.Add(Mapped.Parameter("?id", id));

            objDataReader = objCommand.ExecuteReader();
            while (objDataReader.Read())
            {
                obj = new Cadastrar();
                obj.Id = Convert.ToInt32(objDataReader["car_id"]);
                obj.Nome = Convert.ToString(objDataReader["car_nome"]);
                obj.valorUnitario = Convert.ToInt32(objDataReader["car_valorUnitario"]);
                obj.EmbalagemId = Convert.ToInt32(objDataReader["emb_id"]);
                obj.ReceitaId = Convert.ToInt32(objDataReader["rec_id"]);

            }
            objDataReader.Close();
            objConexao.Close();

            objCommand.Dispose();
            objConexao.Dispose();
            objDataReader.Dispose();

            return obj;
        }
        public bool Update(Cadastrar cadastrar)
        {

            System.Data.IDbConnection objConexao;
            System.Data.IDbCommand objCommand;
            string sql = "UPDATE tbl_cardapio SET car_id=?id, car_nome=?nome, car_valorUnitario=?valorUnitario, emb_id=?embalagemId, rec_id=?receitaId WHERE car_id=?id";

            objConexao = Mapped.Connection();
            objCommand = Mapped.Command(sql, objConexao);

            objCommand.Parameters.Add(Mapped.Parameter("?id", cadastrar.Id));
            objCommand.Parameters.Add(Mapped.Parameter("?nome", cadastrar.Nome));
            objCommand.Parameters.Add(Mapped.Parameter("?valorUnitario", cadastrar.valorUnitario));
            objCommand.Parameters.Add(Mapped.Parameter("?embalagemId", cadastrar.EmbalagemId));
            objCommand.Parameters.Add(Mapped.Parameter("?receitaId", cadastrar.ReceitaId));

            objCommand.ExecuteNonQuery();
            objConexao.Close();
            objCommand.Dispose();
            objConexao.Dispose();

            return true;
        }

        public DataSet ListarReceita()
        {
            DataSet ds = new DataSet();

            System.Data.IDbConnection objConexao;
            System.Data.IDbCommand objCommand;
            System.Data.IDataAdapter objDataAdapter;

            objConexao = Mapped.Connection();
            objCommand = Mapped.Command("SELECT * FROM tbl_receita", objConexao);
            objDataAdapter = Mapped.Adapter(objCommand);
            objDataAdapter.Fill(ds);

            objConexao.Close();

            objCommand.Dispose();
            objConexao.Dispose();

            return ds;
        }
        public CadastrarBD()
        {
            //
            // TODO: Adicionar lógica do construtor aqui
            //
        }
    }
}