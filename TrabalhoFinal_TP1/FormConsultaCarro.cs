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
        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            InicializaDBs a = new();
        }
    }
}
