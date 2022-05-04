using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocacaoQuarto
{
    public class Reserva
    {
        public string NomeCliente { get; set; }
        public int NumQuarto { get; set; }
        public string DataEntrada { get; set; }
        public string DataSaida { get; set; }
        public int Duracao { get; set; }
        public decimal Valor { get; set; }

        public Reserva(string nome, int numQuarto, string dataEntrada, string dataSaida, decimal valor)
        {
            this.NomeCliente = nome;
            this.NumQuarto = numQuarto;
            this.DataEntrada = dataEntrada;
            this.DataSaida = dataSaida;

            CultureInfo cultura = CultureInfo.CreateSpecificCulture("pt-BR");
            DateTime entrada = DateTime.Parse(dataEntrada, cultura);
            DateTime saida = DateTime.Parse(dataSaida, cultura);
            int duracao = (saida.Date - entrada.Date).Days;
            this.Duracao = duracao;

            this.Valor = valor;
        }

        public override string ToString() => $"Reserva para {NomeCliente}. {Duracao} noites, Total: R$ {Valor * Duracao}";
    }
}
