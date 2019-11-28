using NIELTAGA;
using System.Web.UI;
using System.Web.UI.WebControls;
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

        //Insert ITEM PEDIDO
        
        public bool Insertit(Itempedido itemPedido)
        {
            System.Data.IDbConnection objConexao;
            System.Data.IDbCommand objCommand;
            string sql = "INSERT INTO tbl_itemPedido)(itp_drescricao, itp_quantidade, car_id, ped_id) VALUES (?descricao, ?quantidade, ?cardapio)";
            objConexao = Mapped.Connection();
            objCommand = Mapped.Command(sql, objConexao);
            objCommand.Parameters.Add(Mapped.Parameter("?descricao", itemPedido.Descricao));
            objCommand.Parameters.Add(Mapped.Parameter("?quantidade", itemPedido.Quantidade));
            //objCommand.Parameters.Add(Mapped.Parameter("?cardapio", cardapio));
            //objCommand.Parameters.Add(Mapped.Parameter("?codigo", codigo));
            objCommand.ExecuteNonQuery();
            objConexao.Close();
            objCommand.Dispose();
            objConexao.Dispose();
            return true;
        }
        /*
        public static Itempedido Select(string itCardapio)
        {
            try
            {
                Itempedido Objcardapio= null;

                IDbConnection objConnection;
                IDbCommand objCommand;

                IDataReader objLeitura;

                objConnection = Mapped.Connection();
                string sql = "SELECT p.ped_id as PEDIDO, p.ped_dataPedido as DATA, p.ped_dataEntrega as ENTREGA FROM tbl_cardapio p WHERE ped_id = ?id";

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

        */
        //Search
        public DataSet Search(string termo)
        {
            DataSet ds = new DataSet();
            System.Data.IDbConnection objConexao;
            System.Data.IDbCommand objCommand;
            System.Data.IDataAdapter objDataAdapter;
            objConexao = Mapped.Connection();
            objCommand = Mapped.Command("SELECT ped_id AS 'PEDIDO', ped_dataPedido AS 'DT.PEDIDO', ped_dataEntrega AS 'DT.ENTREGA', ped_observacao AS 'OBSERVAÇÃO', ped_valorTotal AS 'R$' FROM tbl_pedido WHERE ped_id LIKE ?ped_id or ped_dataPedido LIKE ?ped_dataPedido or ped_observacao LIKE ?ped_observacao ORDER BY ped_id", objConexao);
            objCommand.Parameters.Add(Mapped.Parameter("?ped_id", '%' + termo + '%'));
            objCommand.Parameters.Add(Mapped.Parameter("?ped_dataPedido", '%' + termo + '%'));
            objCommand.Parameters.Add(Mapped.Parameter("?ped_observacao", '%' + termo + '%'));
            objDataAdapter = Mapped.Adapter(objCommand);
            objDataAdapter.Fill(ds);
            objConexao.Close();
            objCommand.Dispose();
            objConexao.Dispose();
            return ds;
        }
        

        //update
        public bool Update(Pedido pedido)
        {

            System.Data.IDbConnection objConexao;
            System.Data.IDbCommand objCommand;
            string sql = "UPDATE tbl_pedido SET ped_dataPedido=?dataPedido, ped_dataEntrega=?dataEntrega ped_valorTotal=?valorTotal, ped_observacao=?observacao WHERE ped_id=?codigo";
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
        //update Entrega
        public bool Updatee(int pedido)

        {
            DateTime date = DateTime.Now;
            System.Data.IDbConnection objConexao;
            System.Data.IDbCommand objCommand;
            string sql = "UPDATE tbl_pedido SET ped_dataEntrega =?dataEntrega, ped_entregue= '1'WHERE ped_id=?codigo";
            objConexao = Mapped.Connection();
            objCommand = Mapped.Command(sql, objConexao);
            objCommand.Parameters.Add(Mapped.Parameter("?codigo", pedido));
            objCommand.Parameters.Add(Mapped.Parameter("?dataEntrega", date));
            objCommand.ExecuteNonQuery();
            objConexao.Close();
            objCommand.Dispose();
            objConexao.Dispose();
            return true;
        }

        //Insert
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
        public Pedido Select(int id)
        {
            Pedido obj = null;
            System.Data.IDbConnection objConexao;
            System.Data.IDbCommand objCommand;
            System.Data.IDataReader objDataReader;
            objConexao = Mapped.Connection();
            objCommand = Mapped.Command("SELECT ped_id, ped_dataPedido , ped_dataEntrega, ped_observacao FROM tbl_pedido p WHERE ped_id = ?codigo", objConexao);
            objCommand.Parameters.Add(Mapped.Parameter("?codigo", id));
            objDataReader = objCommand.ExecuteReader();
            while (objDataReader.Read())
            {
                obj = new Pedido();
                obj.Codigo = Convert.ToInt32(objDataReader["ped_id"]);
                DateTime dataPedido = Convert.ToDateTime(objDataReader["ped_dataPedido"]);
                DateTime dataEntrega = Convert.ToDateTime(objDataReader["ped_dataEntrega"]);

                obj.Observacao = Convert.ToString(objDataReader["ped_observacao"]);
                
            }
            objDataReader.Close();
            objConexao.Close();
            objCommand.Dispose();
            objConexao.Dispose();
            objDataReader.Dispose();
            return obj;
        }

        //Select All
        public DataSet SelectAll()
        {
            DataSet ds = new DataSet();
            System.Data.IDbConnection objConexao;
            System.Data.IDbCommand objCommand;
            System.Data.IDataAdapter objDataAdapter;
            objConexao = Mapped.Connection();
            objCommand = Mapped.Command("SELECT ped_id AS 'PEDIDO', ped_dataPedido AS 'DT.PEDIDO', ped_dataEntrega AS 'DT.ENTREGA', ped_observacao AS 'OBSERVAÇÃO', ped_valorTotal AS 'R$' FROM tbl_pedido AS p WHERE ped_entregue <> 1 ", objConexao);
            objDataAdapter = Mapped.Adapter(objCommand);
            objDataAdapter.Fill(ds);
            objConexao.Close();
            objCommand.Dispose();
            objConexao.Dispose();
            return ds;
        }

        //Seleciona Grid Pedidos
        //public DataSet SelectAllG(int cod)
        //{
        //    DataSet ds = new DataSet();
        //    System.Data.IDbConnection objConexao;
        //    System.Data.IDbCommand objCommand;
        //    System.Data.IDataAdapter objDataAdapter;
        //    objConexao = Mapped.Connection();
        //    objCommand = Mapped.Command("SELECT ped_id AS 'PEDIDO', ped_dataPedido AS 'DT.PEDIDO', ped_dataEntrega AS 'DT.ENTREGA', ped_observacao AS 'OBSERVAÇÃO', ped_valorTotal AS 'R$' FROM tbl_pedido AS p WHERE ped_id = ?codigo", objConexao);
        //    objCommand.Parameters.Add(Mapped.Parameter("?codigo", cod));
        //    objDataAdapter = Mapped.Adapter(objCommand);
        //    objDataAdapter.Fill(ds);
        //    objConexao.Close();
        //    objCommand.Dispose();
        //    objConexao.Dispose();
        //    return ds;
        //}

        //Select All Entregue
        public DataSet SelectAllE()
        {

            DataSet dse = new DataSet();
            System.Data.IDbConnection objConexao;
            System.Data.IDbCommand objCommand;
            System.Data.IDataAdapter objDataAdapter;
            objConexao = Mapped.Connection();
            objCommand = Mapped.Command("SELECT * FROM tbl_pedido AS p where ped_entregue <> 0", objConexao);
            objDataAdapter = Mapped.Adapter(objCommand);
            objDataAdapter.Fill(dse);
            objConexao.Close();
            objCommand.Dispose();
            objConexao.Dispose();
            return dse;
        }

        //delete
        public bool Delete(int id)
        {
            System.Data.IDbConnection objConexao;
            System.Data.IDbCommand objCommand;
            string sql = "DELETE FROM tbl_pedido WHERE ped_id=?codigo";
            objConexao = Mapped.Connection();
            objCommand = Mapped.Command(sql, objConexao);
            objCommand.Parameters.Add(Mapped.Parameter("?codigo", id));

            objCommand.ExecuteNonQuery();
            objConexao.Close();
            objCommand.Dispose();
            objConexao.Dispose();
            return true;
        }
    }
}