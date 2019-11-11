using System;
using System.Web;

namespace CrudIngrediente.Classes
{
    /// <summary>
    /// Summary description for Funcionario
    /// </summary>
    public class Ingrediente
    {
        //propriedades
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public string Marca { get; set; }
        public int Quantidade { get; set; }
        public double ValorUnitario { get; set; }
        //construtor
        public Ingrediente()
        {
            //
            // TODO: Add constructor logic here
            //
        }
    }
}