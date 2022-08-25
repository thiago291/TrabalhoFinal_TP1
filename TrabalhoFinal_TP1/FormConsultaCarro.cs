using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrabalhoFinal_TP1.DB;

namespace TrabalhoFinal_TP1
{
    public partial class FormConsultaCarro : Form
    {
        InicializaDBs db = new();
        
        public FormConsultaCarro()
        {
            InitializeComponent();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNovaConsulta_Click(object sender, EventArgs e)
        {
            mtbAlugado.Text = "";
            mtbPlaca.Text = "";
            mtbValorDiaria.Text = "";
            ltbInfoCarro.Items.Clear();
            mtbPlaca.Focus();
            btnNovaConsulta.Enabled = false;
            btnConsulta.Enabled = true;
        }

        private async void btnConsulta_Click(object sender, EventArgs e)
        {
            btnConsulta.Enabled = false;
            await Task.Delay(TimeSpan.FromSeconds(3));
            if (!InicializaDBs.carros.Any(x => x.Placa == mtbPlaca.Text.ToUpper()))
            {
                MessageBox.Show("Placa não cadastrada");
                btnConsulta.Enabled = true;
                mtbPlaca.Focus();
            }
            else
            {
                Carros c = InicializaDBs.carros.Find(x => x.Placa == mtbPlaca.Text.ToUpper());
                
                if (c.Disponibilidade)
                    mtbAlugado.Text = "Não";
                else
                    mtbAlugado.Text = "Sim";
                string[] infos = c.InfoCarro.Split('/');
                foreach (string info in infos)
                    ltbInfoCarro.Items.Add(info);
                mtbValorDiaria.Text = $"R$ {c.PrecoDiaria.ToString("0.00")}";
                btnNovaConsulta.Enabled = true;
            }
        }

        private void FormConsultaCarro_Load(object sender, EventArgs e)
        {
            mtbPlaca.Focus();
            btnNovaConsulta.Enabled = false;
        }
    }
}
