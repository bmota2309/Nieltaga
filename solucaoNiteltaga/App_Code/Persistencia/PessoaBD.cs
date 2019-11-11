using NIELTAGA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebLogin.Classes;

namespace WebLogin.Persistencia
{ 
/// <summary>
/// Descrição resumida de PessoaBD
/// </summary>

public class PessoaBD
{
    public Pessoa Autentica(string nome, string cpf)
    {
        Pessoa obj = null;

        System.Data.IDbConnection objConexao;
        System.Data.IDbCommand objCommand;
        System.Data.IDataReader objDataReader;

        objConexao = Mapped.Connection();
        objCommand = Mapped.Command("SELECT * FROM tbl_usuario WHERE usu_nome = ?nome and usu_senha = ?senha", objConexao);

        objCommand.Parameters.Add(Mapped.Parameter("?nome", nome));
        objCommand.Parameters.Add(Mapped.Parameter("?senha", cpf));

        objDataReader = objCommand.ExecuteReader();

        while (objDataReader.Read())
            {
            obj = new Pessoa();
            obj.Codigo = Convert.ToInt32(objDataReader["usu_id"]);
            obj.Nome = Convert.ToString(objDataReader["usu_nome"]);
            obj.Cpf = Convert.ToString(objDataReader["usu_senha"]);
            //obj.Tipo = Convert.ToInt32(objDataReader["usu_tipo"]);
        }
        objDataReader.Close();
        objConexao.Close();

        objCommand.Dispose();
        objConexao.Dispose();
        objDataReader.Dispose();

        return obj;
    }
    public Pessoa Select(int id)
    {
        Pessoa obj = null;

        System.Data.IDbConnection objConexao;
        System.Data.IDbCommand objCommand;
        System.Data.IDataReader objDataReader;

        objConexao = Mapped.Connection();
        objCommand = Mapped.Command("SELECT * FROM usu_usuario WHERE usu_id = ?codigo", objConexao);
        objCommand.Parameters.Add(Mapped.Parameter("?codigo", id));

        objDataReader = objCommand.ExecuteReader();

        while (objDataReader.Read())
        {
            obj = new Pessoa();
            obj.Codigo = Convert.ToInt32(objDataReader["usu_id"]);
            obj.Nome = Convert.ToString(objDataReader["usu_nome"]);
            obj.Cpf = Convert.ToString(objDataReader["usu_senha"]);
            obj.Tipo = Convert.ToInt32(objDataReader["usu_tipo"]);
        }
        objDataReader.Close();
        objConexao.Close();

        objCommand.Dispose();
        objConexao.Dispose();
        objDataReader.Dispose();

        return obj;
    }
    public PessoaBD()
    {
        //
        // TODO: Add constructor logic here
        //

    }
}
}