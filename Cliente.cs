using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocacaoQuarto
{
    public class Cliente
    {
        public string Nome { get; set; }

        public Cliente(string nome)
        {
            this.Nome = nome;
        }
        public override string ToString() => $"{Nome}";
    }
}
