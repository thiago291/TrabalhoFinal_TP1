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
            
            
            if (!InicializaDBs.pedidos.Any(ped => ped.Cod_Pedido == int.Parse(mtbNumPedido.Text)))
            {
                await Task.Delay(TimeSpan.FromSeconds(5));
                MessageBox.Show("Pedido não existe, tente novamente");
                btnCons.Enabled = true;
                mtbNumPedido.ReadOnly = false;
            }
            else
            {
                lblAviso.ForeColor = Color.Red;
                lblAviso.Text = "Buscando pedido, por favor aguarde...";


                Pedidos p = InicializaDBs.pedidos.Find(ped => ped.Cod_Pedido == int.Parse(mtbNumPedido.Text));
                await Task.Delay(TimeSpan.FromSeconds(0.2));
                txb_ID_Atendente.Text = p.ID_Atendente.ToString();
                await Task.Delay(TimeSpan.FromSeconds(0.2));
                txb_Placa_Carro.Text = p.Placa;
                await Task.Delay(TimeSpan.FromSeconds(0.2));
                txb_CPF.Text = Convert.ToUInt64(p.CPF).ToString(@"000\.000\.000\-00");
                await Task.Delay(TimeSpan.FromSeconds(0.2));
                mtbDataAluguel.Text = p.DataAluguel.ToString("dd/MM/yyyy");
                await Task.Delay(TimeSpan.FromSeconds(0.2));
                mtbDataRetorno.Text = p.DataRetorno.ToString("dd/MM/yyyy");
                await Task.Delay(TimeSpan.FromSeconds(0.2));
                txb_Nº_Diarias.Text = p.NumDiaria.ToString();
                await Task.Delay(TimeSpan.FromSeconds(0.2));
                mtb_Valor_Total.Text = $"R$ {p.ValorTotal.ToString("0.00")}";

                lblAviso.Text = "Busca concluída!";
                lblAviso.ForeColor = Color.Green;

            }
        }

        private async void btnNovaConsulta_Click(object sender, EventArgs e)
        {
            await Task.Delay(TimeSpan.FromSeconds(1));
            lblAviso.Text = "";
            mtbNumPedido.Clear();
            txb_ID_Atendente.Clear();
            txb_Placa_Carro.Clear();
            txb_CPF.Clear();
            mtbDataAluguel.Clear();
            mtbDataRetorno.Clear();
            txb_Nº_Diarias.Clear();
            mtb_Valor_Total.Clear();
            btnCons.Enabled = true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Pedidos p = InicializaDBs.pedidos.Find(ped => ped.Cod_Pedido == int.Parse(mtbNumPedido.Text));

        }
    }
}
