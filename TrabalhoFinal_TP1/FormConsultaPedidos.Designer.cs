namespace TrabalhoFinal_TP1
{
    partial class FormConsultaPedidos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblCodPed = new System.Windows.Forms.Label();
            this.mtbNumPedido = new System.Windows.Forms.MaskedTextBox();
            this.mtbDataRetorno = new System.Windows.Forms.MaskedTextBox();
            this.mtbDataAluguel = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblIdAtend = new System.Windows.Forms.Label();
            this.txb_Nº_Diarias = new System.Windows.Forms.TextBox();
            this.txb_CPF = new System.Windows.Forms.TextBox();
            this.txb_ID_Atendente = new System.Windows.Forms.TextBox();
            this.lblValorTotal = new System.Windows.Forms.Label();
            this.txb_Placa_Carro = new System.Windows.Forms.TextBox();
            this.mtb_Valor_Total = new System.Windows.Forms.MaskedTextBox();
            this.btnNovaConsulta = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnConsulta = new System.Windows.Forms.Button();
            this.btnCons = new System.Windows.Forms.Button();
            this.lblAviso = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblCodPed
            // 
            this.lblCodPed.AutoSize = true;
            this.lblCodPed.Location = new System.Drawing.Point(7, 8);
            this.lblCodPed.Name = "lblCodPed";
            this.lblCodPed.Size = new System.Drawing.Size(122, 45);
            this.lblCodPed.TabIndex = 0;
            this.lblCodPed.Text = "CONSULTA PEDIDOS\r\n\r\nInsira o Nº do pedido:";
            this.lblCodPed.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // mtbNumPedido
            // 
            this.mtbNumPedido.Location = new System.Drawing.Point(7, 56);
            this.mtbNumPedido.Mask = "00000";
            this.mtbNumPedido.Name = "mtbNumPedido";
            this.mtbNumPedido.PromptChar = ' ';
            this.mtbNumPedido.Size = new System.Drawing.Size(122, 23);
            this.mtbNumPedido.TabIndex = 1;
            // 
            // mtbDataRetorno
            // 
            this.mtbDataRetorno.Enabled = false;
            this.mtbDataRetorno.Location = new System.Drawing.Point(7, 317);
            this.mtbDataRetorno.Name = "mtbDataRetorno";
            this.mtbDataRetorno.ReadOnly = true;
            this.mtbDataRetorno.Size = new System.Drawing.Size(255, 23);
            this.mtbDataRetorno.TabIndex = 27;
            // 
            // mtbDataAluguel
            // 
            this.mtbDataAluguel.Enabled = false;
            this.mtbDataAluguel.Location = new System.Drawing.Point(7, 268);
            this.mtbDataAluguel.Name = "mtbDataAluguel";
            this.mtbDataAluguel.ReadOnly = true;
            this.mtbDataAluguel.Size = new System.Drawing.Size(255, 23);
            this.mtbDataAluguel.TabIndex = 26;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 343);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 15);
            this.label6.TabIndex = 25;
            this.label6.Text = "Número de diárias:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 299);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 15);
            this.label5.TabIndex = 24;
            this.label5.Text = "Data de retorno:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 250);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 15);
            this.label4.TabIndex = 23;
            this.label4.Text = "Data de aluguel:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 15);
            this.label3.TabIndex = 22;
            this.label3.Text = "CPF do cliente:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 15);
            this.label2.TabIndex = 21;
            this.label2.Text = "Placa do carro:";
            // 
            // lblIdAtend
            // 
            this.lblIdAtend.AutoSize = true;
            this.lblIdAtend.Location = new System.Drawing.Point(7, 118);
            this.lblIdAtend.Name = "lblIdAtend";
            this.lblIdAtend.Size = new System.Drawing.Size(94, 15);
            this.lblIdAtend.TabIndex = 20;
            this.lblIdAtend.Text = "ID do atendente:";
            // 
            // txb_Nº_Diarias
            // 
            this.txb_Nº_Diarias.Enabled = false;
            this.txb_Nº_Diarias.Location = new System.Drawing.Point(7, 361);
            this.txb_Nº_Diarias.Name = "txb_Nº_Diarias";
            this.txb_Nº_Diarias.ReadOnly = true;
            this.txb_Nº_Diarias.Size = new System.Drawing.Size(255, 23);
            this.txb_Nº_Diarias.TabIndex = 19;
            // 
            // txb_CPF
            // 
            this.txb_CPF.Enabled = false;
            this.txb_CPF.Location = new System.Drawing.Point(7, 224);
            this.txb_CPF.Name = "txb_CPF";
            this.txb_CPF.ReadOnly = true;
            this.txb_CPF.Size = new System.Drawing.Size(255, 23);
            this.txb_CPF.TabIndex = 18;
            // 
            // txb_ID_Atendente
            // 
            this.txb_ID_Atendente.Enabled = false;
            this.txb_ID_Atendente.Location = new System.Drawing.Point(7, 136);
            this.txb_ID_Atendente.Name = "txb_ID_Atendente";
            this.txb_ID_Atendente.ReadOnly = true;
            this.txb_ID_Atendente.Size = new System.Drawing.Size(255, 23);
            this.txb_ID_Atendente.TabIndex = 16;
            // 
            // lblValorTotal
            // 
            this.lblValorTotal.AutoSize = true;
            this.lblValorTotal.Location = new System.Drawing.Point(7, 388);
            this.lblValorTotal.Name = "lblValorTotal";
            this.lblValorTotal.Size = new System.Drawing.Size(61, 15);
            this.lblValorTotal.TabIndex = 25;
            this.lblValorTotal.Text = "Valor Total";
            // 
            // txb_Placa_Carro
            // 
            this.txb_Placa_Carro.Enabled = false;
            this.txb_Placa_Carro.Location = new System.Drawing.Point(7, 180);
            this.txb_Placa_Carro.Name = "txb_Placa_Carro";
            this.txb_Placa_Carro.ReadOnly = true;
            this.txb_Placa_Carro.Size = new System.Drawing.Size(255, 23);
            this.txb_Placa_Carro.TabIndex = 17;
            // 
            // mtb_Valor_Total
            // 
            this.mtb_Valor_Total.Enabled = false;
            this.mtb_Valor_Total.Location = new System.Drawing.Point(7, 406);
            this.mtb_Valor_Total.Name = "mtb_Valor_Total";
            this.mtb_Valor_Total.ReadOnly = true;
            this.mtb_Valor_Total.Size = new System.Drawing.Size(255, 23);
            this.mtb_Valor_Total.TabIndex = 27;
            // 
            // btnNovaConsulta
            // 
            this.btnNovaConsulta.Location = new System.Drawing.Point(7, 450);
            this.btnNovaConsulta.Name = "btnNovaConsulta";
            this.btnNovaConsulta.Size = new System.Drawing.Size(122, 22);
            this.btnNovaConsulta.TabIndex = 28;
            this.btnNovaConsulta.Text = "Nova Consulta";
            this.btnNovaConsulta.UseVisualStyleBackColor = true;
            this.btnNovaConsulta.Click += new System.EventHandler(this.btnNovaConsulta_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(75, 478);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(122, 22);
            this.btnVoltar.TabIndex = 28;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(140, 450);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(122, 22);
            this.btnDelete.TabIndex = 28;
            this.btnDelete.Text = "Excluir Pedido";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnConsulta
            // 
            this.btnConsulta.Location = new System.Drawing.Point(135, 57);
            this.btnConsulta.Name = "btnConsulta";
            this.btnConsulta.Size = new System.Drawing.Size(122, 22);
            this.btnConsulta.TabIndex = 29;
            this.btnConsulta.Text = "Consulta";
            this.btnConsulta.UseVisualStyleBackColor = true;
            // 
            // btnCons
            // 
            this.btnCons.Location = new System.Drawing.Point(135, 57);
            this.btnCons.Name = "btnCons";
            this.btnCons.Size = new System.Drawing.Size(122, 22);
            this.btnCons.TabIndex = 29;
            this.btnCons.Text = "Consulta";
            this.btnCons.UseVisualStyleBackColor = true;
            this.btnCons.Click += new System.EventHandler(this.btnCons_Click);
            // 
            // lblAviso
            // 
            this.lblAviso.Location = new System.Drawing.Point(7, 82);
            this.lblAviso.Name = "lblAviso";
            this.lblAviso.Size = new System.Drawing.Size(122, 36);
            this.lblAviso.TabIndex = 30;
            // 
            // FormConsultaPedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(274, 515);
            this.Controls.Add(this.lblAviso);
            this.Controls.Add(this.btnCons);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnNovaConsulta);
            this.Controls.Add(this.mtb_Valor_Total);
            this.Controls.Add(this.mtbDataRetorno);
            this.Controls.Add(this.mtbDataAluguel);
            this.Controls.Add(this.lblValorTotal);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblIdAtend);
            this.Controls.Add(this.txb_Nº_Diarias);
            this.Controls.Add(this.txb_CPF);
            this.Controls.Add(this.txb_Placa_Carro);
            this.Controls.Add(this.txb_ID_Atendente);
            this.Controls.Add(this.mtbNumPedido);
            this.Controls.Add(this.lblCodPed);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormConsultaPedidos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta Pedidos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblCodPed;
        private MaskedTextBox mtbNumPedido;
        private MaskedTextBox mtbDataRetorno;
        private MaskedTextBox mtbDataAluguel;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label lblIdAtend;
        private TextBox txb_Nº_Diarias;
        private TextBox txb_CPF;
        private TextBox txb_ID_Atendente;
        private Label lblValorTotal;
        private TextBox txb_Placa_Carro;
        private MaskedTextBox mtb_Valor_Total;
        private Button btnNovaConsulta;
        private Button btnVoltar;
        private Button btnDelete;
        private Button btnConsulta;
        private Button btnCons;
        private Label lblAviso;
    }
}