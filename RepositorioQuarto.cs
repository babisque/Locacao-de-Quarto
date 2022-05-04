using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocacaoQuarto
{
    public class RepositorioQuarto
    {
        public static List<Quarto> InicializadorQuartos()
        {
            List<Quarto> quartos = new List<Quarto>();
            {
                quartos.Add(new Quarto(121, 150.00m));
                quartos.Add(new Quarto(131, 250.00m));
                quartos.Add(new Quarto(141, 300.00m));
                quartos.Add(new Quarto(151, 400.00m));
                quartos.Add(new Quarto(161, 800.00m));

                return quartos;
            }
        }
    }
}
