using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocacaoQuarto
{
    public class Quarto
    {
        public int Numero { get; set; }
        public decimal Valor { get; set; }

        public Quarto(int numero, decimal valor)
        {
            this.Numero = numero;
            this.Valor = valor;
        }

        public override string ToString() => $"Quarto Nº. {Numero}. Valor R$ {Valor} por noite.";
    }
}
