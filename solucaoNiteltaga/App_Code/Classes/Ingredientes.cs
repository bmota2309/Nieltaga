using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace solucaoNiteltaga.Classes
{
    /// <summary>
    /// Descrição resumida de Funcionario
    /// </summary>
    public class Ingredientes
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Marca { get; set; }
        public int Quantidade { get; set; }
        public decimal ValorUnitario { get; set; }
        public double QuantidadeMax { get; set; }
        public int ReceitaID { get; set; }
        public int QuantidadeIng { get; set; }
        public int IngredienteID { get; set; }

        public Ingredientes()
        {
            //
            // TODO: Adicionar lógica do construtor aqui
            //
        }
    }
}