using CrudIngrediente.Persistencia;
using NIELTAGA;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

/// <summary>
/// Descrição resumida de ItemPedidoBD
/// </summary>
/// 


public class ItemPedidoBD
{
    public DataSet SelectAll()
    {
        DataSet ds = new DataSet();
        System.Data.IDbConnection objConexao;
        System.Data.IDbCommand objCommand;
        System.Data.IDataAdapter objDataAdapter;
        objConexao = Mapped.Connection();
        objCommand = Mapped.Command("SELECT * FROM tbl_itempedido", objConexao);
        objDataAdapter = Mapped.Adapter(objCommand);
        objDataAdapter.Fill(ds);
        objConexao.Close();
        objCommand.Dispose();
        objConexao.Dispose();
        return ds;
    }

    //Select
    public DataSet SelectIt(int id)
    {
        DataSet ds = new DataSet();
        System.Data.IDbConnection objConexao;
        System.Data.IDbCommand objCommand;
        System.Data.IDataAdapter objDataAdapter;
        objConexao = Mapped.Connection();
        objCommand = Mapped.Command("select it.itp_id, c.car_valorunitario, it.itp_quantidade as qtd, (C.CAR_VALORUNITARIO * IT.ITP_QUANTIDADE) AS VALOR_TOTAL, p.ped_id as PEDIDO, c.car_nome AS CARDAPIO, c.car_valorUnitario as 'VALOR UNT', it.itp_quantidade AS 'QUANTIDADE' FROM tbl_pedido p, tbl_cardapio c, tbl_itempedido it where p.ped_id =?codigo and p.ped_id = it.ped_id and it.car_id =  c.car_id", objConexao);
        objCommand.Parameters.Add(Mapped.Parameter("?codigo", id));
        objDataAdapter = Mapped.Adapter(objCommand);
        objDataAdapter.Fill(ds);
        objConexao.Close();
        objCommand.Dispose();
        objConexao.Dispose();
        return ds;
    }

    //delete
    public bool Delete(int id)
    {
        System.Data.IDbConnection objConexao;
        System.Data.IDbCommand objCommand;
        string sql = "DELETE FROM TBL_ITEMPEDIDO WHERE itp_id=?codigo";
        objConexao = Mapped.Connection();
        objCommand = Mapped.Command(sql, objConexao);
        objCommand.Parameters.Add(Mapped.Parameter("?codigo", id));

        objCommand.ExecuteNonQuery();
        objConexao.Close();
        objCommand.Dispose();
        objConexao.Dispose();
        return true;
    }

    //public ItemPedido SelectIt(int id)
    //{
    //    ItemPedido obj = null;
    //    System.Data.IDbConnection objConexao;
    //    System.Data.IDbCommand objCommand;
    //    System.Data.IDataReader objDataReader;
    //    objConexao = Mapped.Connection();
    //    objCommand = Mapped.Command("select it.itp_quantidade as qtd, c.car_valorunitario * it.itp_quantidade as VALOR_TOTAL, p.ped_id as PEDIDO, c.car_nome AS CARDAPIO, c.car_valorUnitario as 'VALOR UNT', it.itp_quantidade AS 'QUANTIDADE' FROM tbl_pedido p, tbl_cardapio c, tbl_itempedido it where p.ped_id =?codigo and p.ped_id = it.ped_id and it.car_id =  c.car_id", objConexao);
    //    objCommand.Parameters.Add(Mapped.Parameter("?codigo", id));
    //    objDataReader = objCommand.ExecuteReader();
    //    while (objDataReader.Read())
    //    {
    //        obj = new ItemPedido();
    //        obj.PedidoID = Convert.ToInt32(objDataReader["ped_id"]);
    //        obj.ItemPedidoID = Convert.ToInt32(objDataReader["itp_id"]);
    //        obj.Quantidade = Convert.ToInt32(objDataReader["itp_quantidade"]);
    //        obj.ValorUnitario = Convert.ToDecimal(objDataReader["car_valorunitario"]);
    //        obj.ValorTotal = Convert.ToDecimal(objDataReader["VALOR_TOTAL"]);
    //        obj.CardapioID = Convert.ToInt32(objDataReader["car_id"]);
    //        obj.CardapioNome = Convert.ToString(objDataReader["CARDAPIO"]);
    //    }
    //    objDataReader.Close();
    //    objConexao.Close();
    //    objCommand.Dispose();
    //    objConexao.Dispose();
    //    objDataReader.Dispose();
    //    return obj;
    //}

    //Select
    public ItemPedido Select(int id)
    {
        ItemPedido obj = null;
        System.Data.IDbConnection objConexao;
        System.Data.IDbCommand objCommand;
        System.Data.IDataReader objDataReader;
        objConexao = Mapped.Connection();
        objCommand = Mapped.Command("SELECT * FROM tbl_itempedido WHERE ped_id = ?codigo", objConexao);
        objCommand.Parameters.Add(Mapped.Parameter("?codigo", id));
        objDataReader = objCommand.ExecuteReader();
        while (objDataReader.Read())
        {
            obj = new ItemPedido();
            obj.PedidoID = Convert.ToInt32(objDataReader["ped_id"]);
            obj.ItemPedidoID = Convert.ToInt32(objDataReader["itp_id"]);
            obj.Quantidade = Convert.ToInt32(objDataReader["itp_quantidade"]);
            obj.CardapioID = Convert.ToInt32(objDataReader["car_id"]);
        }
        objDataReader.Close();
        objConexao.Close();
        objCommand.Dispose();
        objConexao.Dispose();
        objDataReader.Dispose();
        return obj;
    }

    //Select
    public static int Count()
    {
        int count;
        count = 0;

        System.Data.IDbConnection objConexao;
        System.Data.IDbCommand objCommand;
        System.Data.IDataReader objDataReader;
        objConexao = Mapped.Connection();
        objCommand = Mapped.Command("SELECT max(itp_id) count FROM tbl_itempedido", objConexao);
        
        objDataReader = objCommand.ExecuteReader();
        while (objDataReader.Read())
        {
            
            count =  Convert.ToInt32(objDataReader["count"]);
   
        }
        objDataReader.Close();
        objConexao.Close();
        objCommand.Dispose();
        objConexao.Dispose();
        objDataReader.Dispose();
        return count;
    }

    //Insert
    public bool Insert(ItemPedido item)
    {
        System.Data.IDbConnection objConexao;
        System.Data.IDbCommand objCommand;
        string sql = "INSERT INTO tbl_itempedido(itp_quantidade, car_id, ped_id) VALUES (?quantidade, ?cardapio, ?pedido)";
        objConexao = Mapped.Connection();
        objCommand = Mapped.Command(sql, objConexao);
        objCommand.Parameters.Add(Mapped.Parameter("?quantidade", item.Quantidade));
        objCommand.Parameters.Add(Mapped.Parameter("?cardapio", item.CardapioID));
        objCommand.Parameters.Add(Mapped.Parameter("?pedido", item.PedidoID));
        objCommand.ExecuteNonQuery();
        objConexao.Close();
        objCommand.Dispose();
        objConexao.Dispose();
        return true;
    }


    public double updateTotal(int id)

    {
        double upTotal = 0;
        System.Data.IDbConnection objConexao;
        System.Data.IDbCommand objCommand;
        string sql = "update tbl_pedido set ped_valorTotal = (select SUM(c.car_valorUnitario * i.itp_quantidade)" +
                     " total from tbl_itempedido i left join tbl_cardapio c on c.car_id = i.car_id where i.ped_id = ?codigo) " +
                     "where ped_id = ?codigo";
        objConexao = Mapped.Connection();
        objCommand = Mapped.Command(sql, objConexao);
        objCommand.Parameters.Add(Mapped.Parameter("?codigo", id));
        objCommand.Parameters.Add(Mapped.Parameter("?valorTotal", upTotal));
        objCommand.ExecuteNonQuery();
        objConexao.Close();
        objCommand.Dispose();
        objConexao.Dispose();
        return upTotal;
    }
    //public double updateTotal(int id)
    //{
    //    double upTotal = 0;
    //    System.Data.IDbConnection objConexao;
    //    System.Data.IDbCommand objCommand;
    //    System.Data.IDataReader objDataReader;
    //    objConexao = Mapped.Connection();
    //    string sql = "update tbl_pedido set ped_valorTotal = (select SUM(c.car_valorUnitario * i.itp_quantidade)" +
    //                 " total from tbl_itempedido i left join tbl_cardapio c on c.car_id = i.car_id where i.ped_id = ? codigo) " +
    //                 "where ped_id = ? codigo";

    //    objCommand = Mapped.Command(sql, objConexao);
    //    objCommand.Parameters.Add(Mapped.Parameter("?id", id));
    //    objDataReader = objCommand.ExecuteReader();

    //    while (objDataReader.Read())
    //    {
    //        if (objDataReader["total"] != DBNull.Value)
    //        {

    //            upTotal = Convert.ToDouble(objDataReader["total"]);


    //        }
    //    }
    //    objDataReader.Close();
    //    objConexao.Close();
    //    objCommand.Dispose();
    //    objConexao.Dispose();
    //    objDataReader.Dispose();
    //    return upTotal;
    //}

    public double totalizaItens(int id)
    {
        double total = 0;
        System.Data.IDbConnection objConexao;
        System.Data.IDbCommand objCommand;
        System.Data.IDataReader objDataReader;
        objConexao = Mapped.Connection();
        string sql = "select sum(c.car_valorUnitario * i.itp_quantidade) total from tbl_itempedido i " +

                     " left join tbl_cardapio c on " +
                     " c.car_id = i.car_id " +

                     " where i.ped_id = ?id";

        objCommand = Mapped.Command(sql, objConexao);
        objCommand.Parameters.Add(Mapped.Parameter("?id", id));
        objDataReader = objCommand.ExecuteReader();

        while (objDataReader.Read())
        {
            if (objDataReader["total"] != DBNull.Value)
            {

                total = Convert.ToDouble(objDataReader["total"]);


            }
        }
        objDataReader.Close();
        objConexao.Close();
        objCommand.Dispose();
        objConexao.Dispose();
        objDataReader.Dispose();
        return total;
    }

    public static void BaixarItem(int id)
    {
        System.Data.IDbConnection objConexao;
        System.Data.IDbCommand objCommand;
        System.Data.IDataReader objDataReader;
        objConexao = Mapped.Connection();

        string sql = "select i.ing_id, itp.itp_quantidade * r.rec_quantidadeIngrediente qtd_baixa " +
 " from tbl_itempedido itp " +
" left join tbl_pedido p on itp.ped_id = p.ped_id " +
" left join tbl_cardapio c on itp.car_id = c.car_id " +
" left join tbl_receita r on c.rec_id = r.rec_id " +
" left join tbl_ingredientes i on r.ing_id = i.ing_id " +
" where itp.itp_id = ?item ";

        objCommand = Mapped.Command(sql, objConexao);
        
        objCommand.Parameters.Add(Mapped.Parameter("?item", id));
        objDataReader = objCommand.ExecuteReader();
        while (objDataReader.Read())
        { 
            IngredienteBD.BaixaEstoque(Convert.ToInt32(objDataReader["ing_id"]),
                                       Convert.ToInt32(objDataReader["qtd_baixa"]));
            
            
 
        }
        objDataReader.Close();
        objConexao.Close();
        objCommand.Dispose();
        objConexao.Dispose();
        objDataReader.Dispose();
     }




}