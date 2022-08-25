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
        InicializaDBs db = new();
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
            btnNovaConsulta.Focus();
            btnCons.Enabled = false;
            mtbNumPedido.ReadOnly = true;
            
            await Task.Delay(TimeSpan.FromSeconds(5));
            if (!db.pedidos.Any(ped => ped.Cod_Pedido == int.Parse(mtbNumPedido.Text)))
            {
                MessageBox.Show("Pedido não existe, tente novamente");
                btnCons.Enabled = true;
                mtbNumPedido.ReadOnly = false;
            }
            else
            {

            }
        }
        
    }
}
