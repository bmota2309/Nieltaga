using NIELTAGA;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

/// <summary>
/// Descrição resumida de LucratividadeBD
/// </summary>
public class LucratividadeBD
{

    //Select
    public DataSet Select(int codigo)
    {
        DataSet ds = new DataSet();
        System.Data.IDbConnection objConexao;
        System.Data.IDbCommand objCommand;
        System.Data.IDataAdapter objDataAdapter;
        objConexao = Mapped.Connection();
        objCommand = Mapped.Command("select p.ped_id as PEDIDO,c.car_nome as CARDAPIO, itp.itp_quantidade as QUANTIDADE , concat_ws(' ',i.ing_nome, ' - Qtd:',rec_quantidadeIngrediente) as INGREDIENTE," +
            " round(((rec_quantidadeIngrediente * ing_valorUnitario) / ing_quantidadeMax) * itp.itp_quantidade, 3) CUSTO " +
            "from  tbl_receita r left join tbl_cardapio c on c.rec_id = r.rec_id left join tbl_itempedido itp on itp.car_id = c.car_id left join tbl_pedido p on p.ped_id = itp.ped_id left join tbl_ingredientes i on r.ing_id = i.ing_id where p.ped_id = ?codigo group by p.ped_id,car_nome, itp_quantidade, INGREDIENTE order by p.ped_id,c.car_nome,custo ;", objConexao);
        objCommand.Parameters.Add(Mapped.Parameter("?codigo", codigo));
        objDataAdapter = Mapped.Adapter(objCommand);
        objDataAdapter.Fill(ds);
        objConexao.Close();
        objCommand.Dispose();
        objConexao.Dispose();
        return ds;
    }

    public double totalizaCusto(int codigo)
    {
        double custoTotal = 0;
        System.Data.IDbConnection objConexao;
        System.Data.IDbCommand objCommand;
        System.Data.IDataReader objDataReader;
        objConexao = Mapped.Connection();
        string sql = "select round(SUM((rec_quantidadeIngrediente * ing_valorUnitario) / ing_quantidadeMax * itp.itp_quantidade), 2) CUSTO " +
            "from tbl_receita r left join tbl_cardapio c on c.rec_id = r.rec_id left join tbl_itempedido itp on itp.car_id = c.car_id left join tbl_pedido p on p.ped_id = itp.ped_id left join tbl_ingredientes i on r.ing_id = i.ing_id where p.ped_id = ?codigo; ";
        objCommand = Mapped.Command(sql, objConexao);
        objCommand.Parameters.Add(Mapped.Parameter("?codigo", codigo));
        objDataReader = objCommand.ExecuteReader();

        while (objDataReader.Read())
        {
            if (objDataReader["CUSTO"] != DBNull.Value)
            {

                custoTotal = Convert.ToDouble(objDataReader["CUSTO"]);


            }
        }
        objDataReader.Close();
        objConexao.Close();
        objCommand.Dispose();
        objConexao.Dispose();
        objDataReader.Dispose();
        return custoTotal;
    }




    //Select All

    public DataSet SelectAll()
    {
        DataSet ds = new DataSet();
        System.Data.IDbConnection objConexao;
        System.Data.IDbCommand objCommand;
        System.Data.IDataAdapter objDataAdapter;
        objConexao = Mapped.Connection();
        objCommand = Mapped.Command("SELECT * FROM tbl_pedido", objConexao);
        objDataAdapter = Mapped.Adapter(objCommand);
        objDataAdapter.Fill(ds);
        objConexao.Close();
        objCommand.Dispose();
        objConexao.Dispose();
        return ds;
    }

}