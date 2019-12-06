using NIELTAGA;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

/// <summary>
/// Descrição resumida de CardapioBD
/// </summary>
public class CardapioBD
{

    public DataSet SelectAll()
    {
        DataSet ds = new DataSet();
        System.Data.IDbConnection objConexao;
        System.Data.IDbCommand objCommand;
        System.Data.IDataAdapter objDataAdapter;
        objConexao = Mapped.Connection();
        objCommand = Mapped.Command("SELECT * FROM tbl_cardapio", objConexao);
        objDataAdapter = Mapped.Adapter(objCommand);
        objDataAdapter.Fill(ds);
        objConexao.Close();
        objCommand.Dispose();
        objConexao.Dispose();
        return ds;
    }

    public DataSet ListaEmbalagem()
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

    //Seleciona Cardapio
    public DataSet SelectCardapio()
    {
        DataSet ds = new DataSet();
        System.Data.IDbConnection objConexao;
        System.Data.IDbCommand objCommand;
        System.Data.IDataAdapter objDataAdapter;
        objConexao = Mapped.Connection();
        objCommand = Mapped.Command("select c.car_nome as CARDAPIO, r.rec_nome as RECEITA , e.emb_nome as EMBALAGEM, CONCAT_WS('R$',' ',ROUND(c.car_valorUnitario, 2)) as 'VALOR UNITARIO'  from tbl_cardapio c" +
            " left join tbl_receita r on r.rec_id = c.rec_id left join tbl_embalagem e on e.emb_id = c.emb_id " +
            "group by  car_id; ", objConexao);
        objDataAdapter = Mapped.Adapter(objCommand);
        objDataAdapter.Fill(ds);
        objConexao.Close();
        objCommand.Dispose();
        objConexao.Dispose();
        return ds;
    }

    

}