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
    public partial class FormCadastroCliente : Form
    {
        public FormCadastroCliente()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormCadastroCliente_Load(object sender, EventArgs e)
        {
            btnConfirmar.Enabled = false;
            btnLimpar.Enabled = false;
            mtbCpfCli.Focus();
        }

        private async void btnBusca_Click(object sender, EventArgs e)
        {
            btnBusca.Enabled = false;
            await Task.Delay(TimeSpan.FromSeconds(3));
            if (!InicializaDBs.clientes.Any(x => x.CPF == mtbCpfCli.Text))
            {
                DialogResult dr = MessageBox.Show("CPF não cadastrado. Gostaria de adicioná-lo?", "Alerta", MessageBoxButtons.YesNo);
                if (dr == DialogResult.No)
                {
                    btnBusca.Enabled = true;
                    mtbCpfCli.Focus();
                }
                else
                {

                }
            }

            else
            {
                Clientes c = InicializaDBs.clientes.Find(x => x.CPF == mtbCpfCli.Text);
                mtbNomeCli.Text = c.Nome;
                mtbCelCli.Text = c.Celular;
                mtbDataNascCli.Text = c.DataDeNascimento;
                mtbEmailCli.Text = c.Email;
                mtbCnhCli.Text = c.CNH;
                string[] s = c.Endereco.Split();
                mtbRuaCli.Text = s[0];
                mtbNumCli.Text = s[1];
                mtbComplemento.Text = s[2];
                mtbCidadeCli.Text = c.Cidade;
                mtbUfCli.Text = c.UF;
                mtbCepCli.Text = c.CEP;
                DialogResult dr = MessageBox.Show("Gostaria de alterar este cadastro?","Alerta",MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    
                }
                else
                {

                }
                
                btnLimpar.Enabled = true;
            }
        }
    }
}
