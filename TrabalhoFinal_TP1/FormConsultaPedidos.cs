using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrabalhoFinal_TP1.DB;

namespace TrabalhoFinal_TP1 
{
    
    public partial class FormConsultaPedidos : Form
    {
        
        public FormConsultaPedidos()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

        private async void btnCons_Click(object sender, EventArgs e)
        {
            
            btnCons.Enabled = false;
            mtbNumPedido.ReadOnly = true;
            
            await Task.Delay(TimeSpan.FromSeconds(5));
            if (!InicializaDBs.pedidos.Any(ped => ped.Cod_Pedido == int.Parse(mtbNumPedido.Text)))
            {
                MessageBox.Show("Pedido não existe, tente novamente");
                btnCons.Enabled = true;
                mtbNumPedido.ReadOnly = false;
            }
            else
            {
                Pedidos p = InicializaDBs.pedidos.Find(ped => ped.Cod_Pedido == int.Parse(mtbNumPedido.Text));
                txb_ID_Atendente.Text = p.ID_Atendente.ToString();
                txb_Placa_Carro.Text = p.Placa;
                txb_CPF.Text = p.CPF;
                mtbDataAluguel.Text = p.DataAluguel.ToString("dd/MM/yyyy");
                mtbDataRetorno.Text = p.DataRetorno.ToString("dd/MM/yyyy");
                txb_Nº_Diarias.Text = p.NumDiaria.ToString();
                mtb_Valor_Total.Text = $"R$ {p.ValorTotal.ToString("0.00")}";
                btnCons.Enabled = true;
                
            }
        }

    }
}
