using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descrição resumida de ItemPedido
/// </summary>
public class ItemPedido
{

    public int ItemPedidoID { get; set; }
    public int Quantidade { get; set; }
    public decimal ValorUnitario { get; set; }
    public decimal ValorTotal { get; set; }
    public int Descricao { get; set; }
    public string CardapioNome { get; set; }
    public int CardapioID { get; set; }
    public int PedidoID { get; set; }

    public ItemPedido()
    {
        //
        // TODO: Adicionar lógica do construtor aqui
        //
    }
}