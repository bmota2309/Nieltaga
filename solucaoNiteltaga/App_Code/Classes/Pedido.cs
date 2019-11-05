using System;
using System.Web;
namespace solucaoNiteltaga.Classes
{

    /// <summary>
    /// Descrição resumida de Pedido
    /// </summary>
    public class Pedido
    {
        //propriedades
        public int Codigo { get; set; }
        public Char ItemPedido { get; set; }
        public int Total { get; set; }
        public DateTime DataPedido { get; set; }
        public DateTime DataEntrega { get; set; }
        //construtor
        public Pedido()
        {
            //
            // TODO: Add constructor logic here
            //
        }
    }
}