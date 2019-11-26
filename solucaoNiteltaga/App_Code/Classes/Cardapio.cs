using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descrição resumida de Cardapio
/// </summary>
public class Cardapio
{
    public int CardapioID { get; set; }
    public string Nome { get; set; }
    public double ValorUnitario { get; set; }
    public int EmbalagemID { get; set; }
    public int ReceitaID { get; set; }


    public Cardapio()
    {
        //
        // TODO: Adicionar lógica do construtor aqui
        //
    }
}