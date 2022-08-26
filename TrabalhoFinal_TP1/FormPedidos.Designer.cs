namespace TrabalhoFinal_TP1
{
    partial class FormPedidos
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.mtb_Valor_Total = new System.Windows.Forms.MaskedTextBox();
            this.lblValorTotal = new System.Windows.Forms.Label();
            this.lblPedido = new System.Windows.Forms.Label();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.mtb_CPF = new System.Windows.Forms.MaskedTextBox();
            this.mtb_Atendente = new System.Windows.Forms.MaskedTextBox();
            this.mtb_Placa = new System.Windows.Forms.MaskedTextBox();
            this.lblCPF = new System.Windows.Forms.Label();
            this.lblPlaca = new System.Windows.Forms.Label();
            this.lblIDValido = new System.Windows.Forms.Label();
            this.mtbDiarias = new System.Windows.Forms.MaskedTextBox();
            this.dtpAluguel = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "ID do atendente:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "Placa do carro:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "CPF do cliente:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "Data de aluguel:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 258);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 15);
            this.label6.TabIndex = 13;
            this.label6.Text = "Número de diárias:";
            // 
            // mtb_Valor_Total
            // 
            this.mtb_Valor_Total.Enabled = false;
            this.mtb_Valor_Total.Location = new System.Drawing.Point(11, 325);
            this.mtb_Valor_Total.Name = "mtb_Valor_Total";
            this.mtb_Valor_Total.Size = new System.Drawing.Size(255, 23);
            this.mtb_Valor_Total.TabIndex = 4;
            // 
            // lblValorTotal
            // 
            this.lblValorTotal.AutoSize = true;
            this.lblValorTotal.Location = new System.Drawing.Point(11, 307);
            this.lblValorTotal.Name = "lblValorTotal";
            this.lblValorTotal.Size = new System.Drawing.Size(61, 15);
            this.lblValorTotal.TabIndex = 28;
            this.lblValorTotal.Text = "Valor Total";
            // 
            // lblPedido
            // 
            this.lblPedido.AutoSize = true;
            this.lblPedido.Location = new System.Drawing.Point(11, 9);
            this.lblPedido.Name = "lblPedido";
            this.lblPedido.Size = new System.Drawing.Size(150, 15);
            this.lblPedido.TabIndex = 10;
            this.lblPedido.Text = "Let\'s Drive - NOVO PEDIDO";
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(171, 354);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(95, 25);
            this.btnConfirmar.TabIndex = 5;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(11, 354);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(95, 25);
            this.btnVoltar.TabIndex = 6;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // mtb_CPF
            // 
            this.mtb_CPF.Location = new System.Drawing.Point(10, 59);
            this.mtb_CPF.Mask = "00000000000";
            this.mtb_CPF.Name = "mtb_CPF";
            this.mtb_CPF.PromptChar = ' ';
            this.mtb_CPF.Size = new System.Drawing.Size(151, 23);
            this.mtb_CPF.TabIndex = 0;
            this.mtb_CPF.TextChanged += new System.EventHandler(this.mtb_CPF_TextChanged);
            // 
            // mtb_Atendente
            // 
            this.mtb_Atendente.Location = new System.Drawing.Point(10, 115);
            this.mtb_Atendente.Mask = "00000";
            this.mtb_Atendente.Name = "mtb_Atendente";
            this.mtb_Atendente.PromptChar = ' ';
            this.mtb_Atendente.Size = new System.Drawing.Size(95, 23);
            this.mtb_Atendente.TabIndex = 1;
            this.mtb_Atendente.TextChanged += new System.EventHandler(this.mtb_Atendente_TextChanged);
            // 
            // mtb_Placa
            // 
            this.mtb_Placa.Location = new System.Drawing.Point(10, 168);
            this.mtb_Placa.Mask = "aaa0000";
            this.mtb_Placa.Name = "mtb_Placa";
            this.mtb_Placa.PromptChar = ' ';
            this.mtb_Placa.Size = new System.Drawing.Size(95, 23);
            this.mtb_Placa.TabIndex = 2;
            this.mtb_Placa.TextChanged += new System.EventHandler(this.mtb_Placa_TextChanged);
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.Location = new System.Drawing.Point(171, 62);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(0, 15);
            this.lblCPF.TabIndex = 34;
            // 
            // lblPlaca
            // 
            this.lblPlaca.AutoSize = true;
            this.lblPlaca.Location = new System.Drawing.Point(117, 171);
            this.lblPlaca.Name = "lblPlaca";
            this.lblPlaca.Size = new System.Drawing.Size(0, 15);
            this.lblPlaca.TabIndex = 35;
            // 
            // lblIDValido
            // 
            this.lblIDValido.AutoSize = true;
            this.lblIDValido.Location = new System.Drawing.Point(117, 123);
            this.lblIDValido.Name = "lblIDValido";
            this.lblIDValido.Size = new System.Drawing.Size(0, 15);
            this.lblIDValido.TabIndex = 36;
            // 
            // mtbDiarias
            // 
            this.mtbDiarias.Location = new System.Drawing.Point(10, 276);
            this.mtbDiarias.Mask = "000";
            this.mtbDiarias.Name = "mtbDiarias";
            this.mtbDiarias.PromptChar = ' ';
            this.mtbDiarias.Size = new System.Drawing.Size(256, 23);
            this.mtbDiarias.TabIndex = 4;
            this.mtbDiarias.TextChanged += new System.EventHandler(this.mtbDiarias_TextChanged);
            // 
            // dtpAluguel
            // 
            this.dtpAluguel.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpAluguel.Location = new System.Drawing.Point(13, 221);
            this.dtpAluguel.Name = "dtpAluguel";
            this.dtpAluguel.Size = new System.Drawing.Size(93, 23);
            this.dtpAluguel.TabIndex = 3;
            this.dtpAluguel.Value = new System.DateTime(2022, 8, 25, 18, 25, 50, 0);
            // 
            // FormPedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 387);
            this.Controls.Add(this.dtpAluguel);
            this.Controls.Add(this.mtbDiarias);
            this.Controls.Add(this.lblIDValido);
            this.Controls.Add(this.lblPlaca);
            this.Controls.Add(this.lblCPF);
            this.Controls.Add(this.mtb_Placa);
            this.Controls.Add(this.mtb_Atendente);
            this.Controls.Add(this.mtb_CPF);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.mtb_Valor_Total);
            this.Controls.Add(this.lblValorTotal);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblPedido);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormPedidos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormPedidos";
            this.Load += new System.EventHandler(this.FormPedidos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label6;
        private MaskedTextBox mtb_Valor_Total;
        private Label lblValorTotal;
        private Label lblPedido;
        private Button btnConfirmar;
        private Button btnVoltar;
        private MaskedTextBox mtb_CPF;
        private MaskedTextBox mtb_Atendente;
        private MaskedTextBox mtb_Placa;
        private Label lblCPF;
        private Label lblPlaca;
        private Label lblIDValido;
        private MaskedTextBox mtbDiarias;
        private DateTimePicker dtpAluguel;
    }
}