using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocacaoQuarto
{
    public class RepositorioCliente
    {
        public static List<Cliente> InicializarClientes()
        {
            List<Cliente> clientes = new List<Cliente>();
            {
                clientes.Add(new Cliente("Rodrigo Ramos"));
                clientes.Add(new Cliente("Kawan Mendes"));
                clientes.Add(new Cliente("Edson Babisque"));
                clientes.Add(new Cliente("Giovana Ramos"));
                clientes.Add(new Cliente("Alice Lopes"));

                return clientes;
            }
        }
    }
}
