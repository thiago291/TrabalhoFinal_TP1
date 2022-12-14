using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabalhoFinal_TP1
{
    public partial class FormMenuPrincipal : Form
    {
        public FormMenuPrincipal()
        {
            InitializeComponent();
        }

        private void btnPedidos_Click(object sender, EventArgs e)
        {
            FormPedidos fp = new();
            this.Hide();
            fp.ShowDialog();
            this.Show();
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            FormCadastroCliente fc = new();
            this.Hide();
            fc.ShowDialog();
            this.Show();
        }

        private void btnCarros_Click(object sender, EventArgs e)
        {
            FormConsultaCarro fc = new();
            this.Hide();
            fc.ShowDialog();
            this.Show();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Quer mesmo sair do programa?", "Atenção", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
                this.Close();
        }

        private void FormMenuPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void btnConsultaPedido_Click(object sender, EventArgs e)
        {
            FormConsultaPedidos fp = new();
            this.Hide();
            fp.ShowDialog();
            this.Show();
        }

        private void btnSobre_Click(object sender, EventArgs e)
        {
            FormSobre fs = new();
            this.Hide();
            fs.ShowDialog();
            this.Show();
        }
    }
}
