using NIELTAGA;
using System;
using System.Web;
using solucaoNiteltaga.Classes;//para acesso a classe Pedido
using System.Data; //para uso de DataSet
namespace solucaoNiteltaga.Persistencia
{
    
    /// <summary>
    /// Descrição resumida de PedidoBD
    /// </summary>
    public class PedidoBD
    {
       

        public bool Insert(Itempedido itemPedido)
        {
            System.Data.IDbConnection objConexao;
            System.Data.IDbCommand objCommand;
            string sql = "INSERT INTO tbl_itemPedido)(itp_drescricao, itp_quantidade) VALUES (?descricao, ?quantidade)";
            objConexao = Mapped.Connection();
            objCommand = Mapped.Command(sql, objConexao);
            objCommand.Parameters.Add(Mapped.Parameter("?dataPedido", itemPedido.Descricao));
            objCommand.Parameters.Add(Mapped.Parameter("?dataEntrega", itemPedido.Quantidade));
            objCommand.ExecuteNonQuery();
            objConexao.Close();
            objCommand.Dispose();
            objConexao.Dispose();
            return true;
        }
        public bool Insert(Pedido pedido)
        {
            System.Data.IDbConnection objConexao;
            System.Data.IDbCommand objCommand; //INSERT INTO `nieltagabd`.`tbl_pedido` (`ped_dataPedido`, `ped_dataEntrega`, `ped_valorTotal`, `usu_id`) VALUES ('20191106', '20191106', '80', '1');


            string sql = "INSERT INTO tbl_pedido (ped_dataPedido, ped_dataEntrega, ped_valorTotal, ped_observacao,usu_id) VALUES (?dataPedido, ?dataEntrega, ?valorTotal,?observacao,'1')";
            objConexao = Mapped.Connection();
            objCommand = Mapped.Command(sql, objConexao);
            objCommand.Parameters.Add(Mapped.Parameter("?dataPedido", pedido.DataPedido));
            objCommand.Parameters.Add(Mapped.Parameter("?dataEntrega", pedido.DataEntrega));
            objCommand.Parameters.Add(Mapped.Parameter("?valorTotal", pedido.ValorTotal));
            objCommand.Parameters.Add(Mapped.Parameter("?observacao", pedido.Observacao));
            objCommand.ExecuteNonQuery();   
            objConexao.Close();
            objCommand.Dispose();
            objConexao.Dispose();
            return true;
        }
    }
}