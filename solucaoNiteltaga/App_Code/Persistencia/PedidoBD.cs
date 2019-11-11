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
       
        //Insert
        public bool Insert(Itempedido itemPedido)
        {
            System.Data.IDbConnection objConexao;
            System.Data.IDbCommand objCommand;
            string sql = "INSERT INTO tbl_itemPedido)(itp_drescricao, itp_quantidade) VALUES (?descricao, ?quantidade)";
            objConexao = Mapped.Connection();
            objCommand = Mapped.Command(sql, objConexao);
            objCommand.Parameters.Add(Mapped.Parameter("?dataPedido", itemPedido.Nome));
            objCommand.Parameters.Add(Mapped.Parameter("?dataEntrega", itemPedido.Quantidade));
            objCommand.ExecuteNonQuery();
            objConexao.Close();
            objCommand.Dispose();
            objConexao.Dispose();
            return true;
        }
        public static Itempedido Select(string itCardapio)
        {
            try
            {
                Itempedido Objcardapio= null;

                IDbConnection objConnection;
                IDbCommand objCommand;

                IDataReader objLeitura;

                objConnection = Mapped.Connection();
                string sql = "SELECT * FROM tbl_cardapio WHERE car_id = ?id";

                objCommand = Mapped.Command(sql, objConnection);
                objCommand.Parameters.Add(Mapped.Parameter("?id", itCardapio));

                objLeitura = objCommand.ExecuteReader();

                while (objLeitura.Read())
                {
                    Objcardapio = new Itempedido();
                    Objcardapio.Nome = objLeitura["car_nome"].ToString();
                }

                objLeitura.Close();
                objConnection.Close();
                objCommand.Dispose();
                objConnection.Dispose();
                objLeitura.Dispose();

                return Objcardapio;

            }
            catch (Exception ex)
            {
                return null;
            }
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
        //Select
        public Itempedido Select(int id)
        {
            Itempedido obj = null;
            System.Data.IDbConnection objConnection;
            System.Data.IDbCommand objCommand;
            System.Data.IDataReader objDataReader;
            objConnection = Mapped.Connection();
            objCommand = Mapped.Command("SELECT * FROM tbl_funcionario WHERE tbl_cardapio = ?codigo", objConnection);
            objCommand.Parameters.Add(Mapped.Parameter("?codigo", id));
            objDataReader = objCommand.ExecuteReader();
            while (objDataReader.Read())
            {
                obj = new Itempedido();
                //obj.Nome = Convert.ToInt32(objDataReader["car_nome"]);
                obj.Nome = Convert.ToString(objDataReader["car_nome"]);
            }
            objDataReader.Close();
            objConnection.Close();
            objCommand.Dispose();
            objConnection.Dispose();
            objDataReader.Dispose();
            return obj;
        }
        //Select All
        public static DataSet SelectAll()
        {
            try
            {
                IDbConnection objConnection;
                IDbCommand objComando;
                IDataAdapter objAdapter;
                DataSet ds = new DataSet();

                objConnection = Mapped.Connection();
                string sql = "SELECT * FROM tbl_cardapio";

                objComando = Mapped.Command(sql, objConnection);

                objAdapter = Mapped.Adapter(objComando);
                objAdapter.Fill(ds);

                objConnection.Close();
                objComando.Dispose();
                objConnection.Dispose();

                return ds;

            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}