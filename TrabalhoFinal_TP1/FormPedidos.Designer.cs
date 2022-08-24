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
            this.txb_ID_Atendente = new System.Windows.Forms.TextBox();
            this.txb_Placa_Carro = new System.Windows.Forms.TextBox();
            this.txb_CPF = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.mtbDataAluguel = new System.Windows.Forms.MaskedTextBox();
            this.mtbDataRetorno = new System.Windows.Forms.MaskedTextBox();
            this.mtb_Valor_Total = new System.Windows.Forms.MaskedTextBox();
            this.lblValorTotal = new System.Windows.Forms.Label();
            this.lblPedido = new System.Windows.Forms.Label();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txb_ID_Atendente
            // 
            this.txb_ID_Atendente.Location = new System.Drawing.Point(11, 115);
            this.txb_ID_Atendente.Name = "txb_ID_Atendente";
            this.txb_ID_Atendente.Size = new System.Drawing.Size(255, 23);
            this.txb_ID_Atendente.TabIndex = 0;
            // 
            // txb_Placa_Carro
            // 
            this.txb_Placa_Carro.Location = new System.Drawing.Point(11, 168);
            this.txb_Placa_Carro.Name = "txb_Placa_Carro";
            this.txb_Placa_Carro.Size = new System.Drawing.Size(255, 23);
            this.txb_Placa_Carro.TabIndex = 1;
            // 
            // txb_CPF
            // 
            this.txb_CPF.Location = new System.Drawing.Point(10, 59);
            this.txb_CPF.Name = "txb_CPF";
            this.txb_CPF.Size = new System.Drawing.Size(256, 23);
            this.txb_CPF.TabIndex = 2;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(11, 327);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(255, 23);
            this.textBox6.TabIndex = 5;
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 256);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 15);
            this.label5.TabIndex = 12;
            this.label5.Text = "Data de retorno:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 309);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 15);
            this.label6.TabIndex = 13;
            this.label6.Text = "Número de diárias:";
            // 
            // mtbDataAluguel
            // 
            this.mtbDataAluguel.Location = new System.Drawing.Point(11, 221);
            this.mtbDataAluguel.Mask = "__/__/____";
            this.mtbDataAluguel.Name = "mtbDataAluguel";
            this.mtbDataAluguel.Size = new System.Drawing.Size(255, 23);
            this.mtbDataAluguel.TabIndex = 14;
            // 
            // mtbDataRetorno
            // 
            this.mtbDataRetorno.Location = new System.Drawing.Point(11, 274);
            this.mtbDataRetorno.Mask = "__/__/____";
            this.mtbDataRetorno.Name = "mtbDataRetorno";
            this.mtbDataRetorno.Size = new System.Drawing.Size(255, 23);
            this.mtbDataRetorno.TabIndex = 15;
            // 
            // mtb_Valor_Total
            // 
            this.mtb_Valor_Total.Location = new System.Drawing.Point(11, 376);
            this.mtb_Valor_Total.Mask = "$";
            this.mtb_Valor_Total.Name = "mtb_Valor_Total";
            this.mtb_Valor_Total.Size = new System.Drawing.Size(255, 23);
            this.mtb_Valor_Total.TabIndex = 29;
            // 
            // lblValorTotal
            // 
            this.lblValorTotal.AutoSize = true;
            this.lblValorTotal.Location = new System.Drawing.Point(11, 358);
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
            this.btnConfirmar.Location = new System.Drawing.Point(171, 405);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(95, 25);
            this.btnConfirmar.TabIndex = 30;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(11, 405);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(95, 25);
            this.btnVoltar.TabIndex = 30;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            // 
            // FormPedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 446);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.mtb_Valor_Total);
            this.Controls.Add(this.lblValorTotal);
            this.Controls.Add(this.mtbDataRetorno);
            this.Controls.Add(this.mtbDataAluguel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblPedido);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.txb_CPF);
            this.Controls.Add(this.txb_Placa_Carro);
            this.Controls.Add(this.txb_ID_Atendente);
            this.Name = "FormPedidos";
            this.Text = "FormPedidos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txb_ID_Atendente;
        private TextBox txb_Placa_Carro;
        private TextBox txb_CPF;
        private TextBox textBox6;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private MaskedTextBox mtbDataAluguel;
        private MaskedTextBox mtbDataRetorno;
        private MaskedTextBox mtb_Valor_Total;
        private Label lblValorTotal;
        private Label lblPedido;
        private Button btnConfirmar;
        private Button btnVoltar;
    }
}