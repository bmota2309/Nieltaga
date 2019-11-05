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
        public bool Insert(Pedido pedido)
        {
            System.Data.IDbConnection objConexao;
            System.Data.IDbCommand objCommand;
            string sql = "INSERT INTO pedido)(ItemPedido, Total, DataPedido, DataEntrega) VALUES (?total, ?dataPedido, ?datataEntrega)";
            objConexao = Mapped.Connection();
            objCommand = Mapped.Command(sql, objConexao);
            objCommand.Parameters.Add(Mapped.Parameter("?total", pedido.Total));
            objCommand.Parameters.Add(Mapped.Parameter("?dataPedido", pedido.DataPedido));
            objCommand.Parameters.Add(Mapped.Parameter("?dataEntrega", pedido.DataEntrega));
            objCommand.ExecuteNonQuery();
            objConexao.Close();
            objCommand.Dispose();
            objConexao.Dispose();
            return true;
        }
    }
}