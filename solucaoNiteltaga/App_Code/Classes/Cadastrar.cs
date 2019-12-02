using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace solucaoNiteltaga.Classes
{



/// <summary>
/// Descrição resumida de Funcionario
/// </summary>
public class Cadastrar
{
        public int Id {get; set;}
        public int CardapioId {get; set;}
        public int EmbalagemId {get; set;}
        public double ReceitaId {get; set;}
        public string Nome {get; set;}
        public decimal valorUnitario { get; set;}


    public Cadastrar()
    {
        //
        // TODO: Adicionar lógica do construtor aqui
        //
    }
}
}