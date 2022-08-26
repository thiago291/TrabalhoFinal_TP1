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
    public partial class FormPedidos : Form
    {
        bool CPFValido = false, IDValido = false, PlacaValida = false;
        int i;
        public FormPedidos()
        {
            InitializeComponent();
        }

        private void FormPedidos_Load(object sender, EventArgs e)
        {
            mtb_CPF.Focus();
            dtpAluguel.Value = DateTime.Now;
        }

        private void mtb_Atendente_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(mtb_Atendente.Text))
            {
                lblIDValido.Visible = true;
                if (Funcionarios.funcionarios.ContainsKey(int.Parse(mtb_Atendente.Text)))
                {
                    lblIDValido.ForeColor = Color.Black;
                    IDValido = true;
                    lblIDValido.Text = Funcionarios.funcionarios.GetValueOrDefault(int.Parse(mtb_Atendente.Text));
                }
                else
                {
                    lblIDValido.ForeColor = Color.Red;
                    lblIDValido.Text = "Atendente não existe";
                    IDValido = false;
                }
            }
            else
            {
                lblIDValido.Visible = false;
                IDValido = false;
            }
        }

        private void mtb_Placa_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(mtb_Placa.Text))
            {
                lblPlaca.Visible = true;
                if (mtb_Placa.Text.Length == 7)
                {
                    if (InicializaDBs.carros.Any(x => x.Placa == mtb_Placa.Text))
                    {
                        i = InicializaDBs.carros.FindIndex(c => c.Placa == mtb_Placa.Text.ToUpper());
                        if (InicializaDBs.carros[i].Disponibilidade)
                        {
                            lblPlaca.ForeColor = Color.Green;
                            PlacaValida = true;
                            lblPlaca.Text = "Carro disponível";
                        }
                        else
                        {
                            lblPlaca.ForeColor = Color.Red;
                            lblPlaca.Text = "Carro já alugado";
                            PlacaValida = false;
                        }
                    }
                    else
                    {
                        lblPlaca.ForeColor = Color.Red;
                        lblPlaca.Text = "Carro não existe";
                        PlacaValida = false;
                    }
                }
                else
                {
                    lblPlaca.ForeColor = Color.Red;
                    lblPlaca.Text = "Valor inválido";
                    PlacaValida = false;
                }
            }
            else
            {
                lblPlaca.Visible = false;
                PlacaValida = false;
            }
        }

        private void mtbDiarias_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(mtbDiarias.Text) && PlacaValida)
                mtb_Valor_Total.Text = $"R$ {InicializaDBs.carros[i].PrecoDiaria * int.Parse(mtbDiarias.Text):0.00}";
            else
                mtb_Valor_Total.Text = "";
        }

        private async void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (IDValido && CPFValido && PlacaValida && !string.IsNullOrEmpty(mtbDiarias.Text) && !string.IsNullOrEmpty(mtb_Valor_Total.Text))
            {
                btnConfirmar.Enabled = false;
                InicializaDBs.numPedido++;
                await Task.Delay(TimeSpan.FromSeconds(5));
                InicializaDBs.pedidos.Add(new Pedidos(InicializaDBs.numPedido, int.Parse(mtb_Atendente.Text), mtb_Placa.Text,
                    mtb_CPF.Text, dtpAluguel.Value.Date, dtpAluguel.Value.Date.AddDays(int.Parse(mtbDiarias.Text)),
                    int.Parse(mtbDiarias.Text), InicializaDBs.carros[i].PrecoDiaria * int.Parse(mtbDiarias.Text)));
                InicializaDBs.carros[i].Disponibilidade = false;
                MessageBox.Show("Dados cadastrados com sucesso.", "Alerta");
                mtb_CPF.Focus();
                mtb_CPF.Clear();
                mtb_Placa.Clear();
                mtb_Atendente.Clear();
                mtbDiarias.Clear();
                mtb_Valor_Total.Clear();
                IDValido = false;
                PlacaValida = false;
                CPFValido = false;
                btnConfirmar.Enabled = true;
            }
            else
                MessageBox.Show("Existem dados errados.", "Alerta");
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mtb_CPF_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(mtb_CPF.Text))
            {
                lblCPF.Visible = true;
                if (mtb_CPF.Text.Length == 11)
                {
                    if (InicializaDBs.clientes.Any(x => x.CPF == mtb_CPF.Text))
                    {
                        lblCPF.ForeColor = Color.Green;
                        CPFValido = true;
                        lblCPF.Text = "CPF OK";
                    }
                    else
                    {
                        lblCPF.ForeColor = Color.Red;
                        lblCPF.Text = "CPF não existe";
                        CPFValido = false;
                    }
                }
                else
                {
                    lblCPF.ForeColor = Color.Red;
                    lblCPF.Text = "Valor inválido";
                    CPFValido = false;
                }

            }
            else
            {
                lblCPF.Visible = false;
                CPFValido = false;
            }
        }
    }
}
