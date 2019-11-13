using System;
using System.Web;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web.UI;
using System.Web.UI.WebControls;
using solucaoNiteltaga.Persistencia;
using solucaoNiteltaga.Classes;



namespace solucaoNiteltaga.Classes
{

    /// <summary>
    /// Descrição resumida de Pedido
    /// </summary>
   public class Itempedido
    {
        
        //propriedades
        //tbl_itemPedido
        public string Descricao { get; set; } //itp_descricao
        public int Quantidade { get; set; } //itp_quantidade
        public int Cardapio { get; set;} //car_id
        public int Pedido { get; set; } //ped_id

        //construtor
        public Itempedido()
        {
            //
            // TODO: Add constructor logic here
            //
        }
    }
    public class Pedido
    {
        //propriedades
        //tbl_pedido
        public int Codigo { get; set; }
        public DateTime DataPedido { get; set; }
        public DateTime DataEntrega { get; set; }
        public decimal ValorTotal { get; set; }
        public string Observacao { get; set; }
        public int UsuarioId { get; set; }


        //construtor
        public Pedido()
        {
            //
            // TODO: Add constructor logic here
            //
        }
    }
}