using System;
using System.Web;
namespace solucaoNiteltaga.Classes
{

    /// <summary>
    /// Descrição resumida de Pedido
    /// </summary>
    public class Itempedido
    {
        //propriedades
        //tbl_itemPedido
        public Char Descricao { get; set; }
        public int Quantidade { get; set; }

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
        public Char UsuarioId { get; set; }


        //construtor
        public Pedido()
        {
            //
            // TODO: Add constructor logic here
            //
        }
    }
/*
public class Cardapio
    { 
    //propriedades
    //tbl_cardapio
public int Codigo { get; set; }
    public DateTime Nome { get; set; }
    public DateTime ValorUnitario { get; set; }
    public Decimal EmbalagemId { get; set; }
    public Char ReceitaId { get; set; }

    //construtor
    public Cardapio()
    {
        //
        // TODO: Add constructor logic here
        //
    } 
}*/
}