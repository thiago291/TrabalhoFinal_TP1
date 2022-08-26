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
        bool CPFExistente = false;
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
                DialogResult dr = MessageBox.Show("CPF não cadastrado. Gostaria de adicioná-lo?", "Atenção", MessageBoxButtons.YesNo);
                if (dr == DialogResult.No)
                {
                    btnBusca.Enabled = true;
                    mtbCpfCli.Focus();
                }
                else
                {
                    mtbCpfCli.Enabled = false;
                    btnBusca.Enabled = false;
                    btnConfirmar.Enabled = true;
                    btnLimpar.Enabled = true;
                    mtbNomeCli.Enabled = true;
                    mtbCelCli.Enabled = true;
                    mtbDataNascCli.Enabled = true;
                    mtbEmailCli.Enabled = true;
                    mtbCnhCli.Enabled = true;
                    mtbRuaCli.Enabled = true;
                    mtbNumCli.Enabled = true;
                    mtbComplemento.Enabled = true;
                    mtbCidadeCli.Enabled = true;
                    mtbUfCli.Enabled = true;
                    mtbCepCli.Enabled = true;
                    mtbGenero.Enabled = true;
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
                string[] s = c.Endereco.Split("/");
                mtbRuaCli.Text = s[0];
                mtbNumCli.Text = s[1];
                mtbComplemento.Text = s[2];
                mtbCidadeCli.Text = c.Cidade;
                mtbUfCli.Text = c.UF;
                mtbCepCli.Text = c.CEP;
                mtbGenero.Text = c.Genero;
                btnLimpar.Enabled = true;

                mtbCpfCli.Enabled = false;
                btnBusca.Enabled = false;
                DialogResult dr = MessageBox.Show("Gostaria de alterar este cadastro?", "Atenção", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    btnConfirmar.Enabled = true;
                    CPFExistente = true;
                    mtbCpfCli.Enabled = false;
                    mtbNomeCli.Enabled = true;
                    mtbCelCli.Enabled = true;
                    mtbDataNascCli.Enabled = true;
                    mtbEmailCli.Enabled = true;
                    mtbCnhCli.Enabled = true;
                    mtbRuaCli.Enabled = true;
                    mtbNumCli.Enabled = true;
                    mtbComplemento.Enabled = true;
                    mtbCidadeCli.Enabled = true;
                    mtbUfCli.Enabled = true;
                    mtbCepCli.Enabled = true;
                    mtbGenero.Enabled = true;
                }
            }
        }

        private void Limpar()
        {
            mtbCpfCli.Enabled = true;
            mtbCpfCli.Focus();
            btnLimpar.Enabled = false;
            btnConfirmar.Enabled = false;
            mtbCpfCli.Clear();
            mtbNomeCli.Clear();
            mtbCelCli.Clear();
            mtbDataNascCli.Clear();
            mtbEmailCli.Clear();
            mtbCnhCli.Clear();
            mtbRuaCli.Clear();
            mtbNumCli.Clear();
            mtbComplemento.Clear();
            mtbCidadeCli.Clear();
            mtbUfCli.Clear();
            mtbCepCli.Clear();
            CPFExistente = false;
            btnBusca.Enabled = true;
            mtbNomeCli.Enabled = false;
            mtbCelCli.Enabled = false;
            mtbDataNascCli.Enabled = false;
            mtbEmailCli.Enabled = false;
            mtbCnhCli.Enabled = false;
            mtbRuaCli.Enabled = false;
            mtbNumCli.Enabled = false;
            mtbComplemento.Enabled = false;
            mtbCidadeCli.Enabled = false;
            mtbUfCli.Enabled = false;
            mtbCepCli.Enabled = false;
            mtbGenero.Enabled = false;
        }
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        private async void btnConfirmar_Click(object sender, EventArgs e)
        {
            btnConfirmar.Enabled = false;
            await Task.Delay(TimeSpan.FromSeconds(3));
            if (string.IsNullOrEmpty(mtbComplemento.Text))
                mtbComplemento.Text = " ";
            if (CPFExistente)
            {
                InicializaDBs.clientes.RemoveAt(InicializaDBs.clientes.FindIndex(c => c.CPF == mtbCpfCli.Text));
                InicializaDBs.clientes.Add(new Clientes(mtbNomeCli.Text, mtbCpfCli.Text, mtbCelCli.Text, mtbDataNascCli.Text, mtbEmailCli.Text,
                    mtbCnhCli.Text, mtbGenero.Text, mtbRuaCli.Text + "/" + mtbNumCli.Text + "/" + mtbComplemento.Text, mtbCidadeCli.Text,
                    mtbUfCli.Text, mtbCepCli.Text));
                MessageBox.Show("Cadastro alterado com sucesso.","Alerta");
            }
            else
            {
                InicializaDBs.clientes.Add(new Clientes(mtbNomeCli.Text, mtbCpfCli.Text, mtbCelCli.Text, mtbDataNascCli.Text, mtbEmailCli.Text,
                    mtbCnhCli.Text, mtbGenero.Text, mtbRuaCli.Text + "/" + mtbNumCli.Text + "/" + mtbComplemento.Text, mtbCidadeCli.Text,
                    mtbUfCli.Text, mtbCepCli.Text));
                MessageBox.Show("Cadastro inserido com sucesso.", "Alerta");
            }

            Limpar();
        }
    }
}
