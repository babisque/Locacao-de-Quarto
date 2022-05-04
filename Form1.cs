using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LocacaoQuarto
{
    public partial class Form1 : Form
    {
        List<Cliente> repositorioCliente = RepositorioCliente.InicializarClientes();
        List<Quarto> repositorioQuarto = RepositorioQuarto.InicializadorQuartos();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (Cliente cliente in repositorioCliente)
            {
                cbxClientes.Items.Add(cliente);
            }

            foreach (Quarto quarto in repositorioQuarto)
            {
                cbxQuartos.Items.Add(quarto);
            }
        }

        private void btnReserva_Click(object sender, EventArgs e)
        {            
            string cliente = cbxClientes.Text;
            int numQuarto = repositorioQuarto.ToArray()[cbxQuartos.SelectedIndex].Numero;
            decimal valor = repositorioQuarto.ToArray()[cbxQuartos.SelectedIndex].Valor;
            Reserva reserva = new Reserva(cliente, numQuarto, txtEntrada.Text, txtSaida.Text, valor);
            lbxReservas.Items.Add(reserva.ToString());
        }
    }
}
