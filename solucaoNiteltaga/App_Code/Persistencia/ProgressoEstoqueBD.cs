using NIELTAGA;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

/// <summary>
/// Descrição resumida de ProgressoEstoqueBD
/// </summary>
public class ProgressoEstoqueBD
{
    //SelecAll
    public DataSet SelectAll()
    {
        DataSet ds = new DataSet();
        System.Data.IDbConnection objConexao;
        System.Data.IDbCommand objCommand;
        System.Data.IDataAdapter objDataAdapter;
        objConexao = Mapped.Connection();
        objCommand = Mapped.Command("SELECT (ing_quantidade/ing_quantidadeMax) as porcentagem, tbl_ingredientes.* FROM nieltagabd.tbl_ingredientes;", objConexao);
        objDataAdapter = Mapped.Adapter(objCommand);
        objDataAdapter.Fill(ds);
        objConexao.Close();
        objCommand.Dispose();
        objConexao.Dispose();
        return ds;
    }
    public ProgressoEstoqueBD()
    {
        //
        // TODO: Adicionar lógica do construtor aqui
        //
    }
}