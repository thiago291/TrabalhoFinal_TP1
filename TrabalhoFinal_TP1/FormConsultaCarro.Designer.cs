namespace TrabalhoFinal_TP1
{
    partial class FormConsultaCarro
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
            this.lblCarro = new System.Windows.Forms.Label();
            this.lblPlaca = new System.Windows.Forms.Label();
            this.mtbPlaca = new System.Windows.Forms.MaskedTextBox();
            this.lblAlugado = new System.Windows.Forms.Label();
            this.mtbAlugado = new System.Windows.Forms.MaskedTextBox();
            this.lblInfoCarro = new System.Windows.Forms.Label();
            this.ltbInfoCarro = new System.Windows.Forms.ListBox();
            this.lblDiaria = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.btnNovaConsulta = new System.Windows.Forms.Button();
            this.btnMenu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCarro
            // 
            this.lblCarro.AutoSize = true;
            this.lblCarro.Location = new System.Drawing.Point(6, 8);
            this.lblCarro.Name = "lblCarro";
            this.lblCarro.Size = new System.Drawing.Size(250, 45);
            this.lblCarro.TabIndex = 0;
            this.lblCarro.Text = "CONSULTA DE VEÍCULOS\r\n\r\nDigite a placa do veículo que deseja consultar:";
            // 
            // lblPlaca
            // 
            this.lblPlaca.AutoSize = true;
            this.lblPlaca.Location = new System.Drawing.Point(10, 89);
            this.lblPlaca.Name = "lblPlaca";
            this.lblPlaca.Size = new System.Drawing.Size(35, 15);
            this.lblPlaca.TabIndex = 1;
            this.lblPlaca.Text = "Placa";
            // 
            // mtbPlaca
            // 
            this.mtbPlaca.Location = new System.Drawing.Point(6, 107);
            this.mtbPlaca.Mask = "AAA0000";
            this.mtbPlaca.Name = "mtbPlaca";
            this.mtbPlaca.Size = new System.Drawing.Size(126, 23);
            this.mtbPlaca.TabIndex = 2;
            // 
            // lblAlugado
            // 
            this.lblAlugado.AutoSize = true;
            this.lblAlugado.Location = new System.Drawing.Point(166, 89);
            this.lblAlugado.Name = "lblAlugado";
            this.lblAlugado.Size = new System.Drawing.Size(52, 15);
            this.lblAlugado.TabIndex = 1;
            this.lblAlugado.Text = "Alugado";
            // 
            // mtbAlugado
            // 
            this.mtbAlugado.Location = new System.Drawing.Point(162, 107);
            this.mtbAlugado.Name = "mtbAlugado";
            this.mtbAlugado.Size = new System.Drawing.Size(126, 23);
            this.mtbAlugado.TabIndex = 2;
            // 
            // lblInfoCarro
            // 
            this.lblInfoCarro.AutoSize = true;
            this.lblInfoCarro.Location = new System.Drawing.Point(6, 155);
            this.lblInfoCarro.Name = "lblInfoCarro";
            this.lblInfoCarro.Size = new System.Drawing.Size(131, 15);
            this.lblInfoCarro.TabIndex = 3;
            this.lblInfoCarro.Text = "Informações do Veículo";
            // 
            // ltbInfoCarro
            // 
            this.ltbInfoCarro.FormattingEnabled = true;
            this.ltbInfoCarro.ItemHeight = 15;
            this.ltbInfoCarro.Location = new System.Drawing.Point(6, 173);
            this.ltbInfoCarro.Name = "ltbInfoCarro";
            this.ltbInfoCarro.Size = new System.Drawing.Size(282, 169);
            this.ltbInfoCarro.TabIndex = 4;
            // 
            // lblDiaria
            // 
            this.lblDiaria.AutoSize = true;
            this.lblDiaria.Location = new System.Drawing.Point(10, 354);
            this.lblDiaria.Name = "lblDiaria";
            this.lblDiaria.Size = new System.Drawing.Size(139, 15);
            this.lblDiaria.TabIndex = 1;
            this.lblDiaria.Text = "Valor da diária do veículo";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(6, 372);
            this.maskedTextBox1.Mask = "$";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(282, 23);
            this.maskedTextBox1.TabIndex = 2;
            // 
            // btnNovaConsulta
            // 
            this.btnNovaConsulta.Location = new System.Drawing.Point(6, 413);
            this.btnNovaConsulta.Name = "btnNovaConsulta";
            this.btnNovaConsulta.Size = new System.Drawing.Size(103, 24);
            this.btnNovaConsulta.TabIndex = 5;
            this.btnNovaConsulta.Text = "Nova Consulta";
            this.btnNovaConsulta.UseVisualStyleBackColor = true;
            // 
            // btnMenu
            // 
            this.btnMenu.Location = new System.Drawing.Point(185, 413);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(103, 24);
            this.btnMenu.TabIndex = 5;
            this.btnMenu.Text = "Voltar ao Menu";
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // FormConsultaCarro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(294, 450);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.btnNovaConsulta);
            this.Controls.Add(this.ltbInfoCarro);
            this.Controls.Add(this.lblInfoCarro);
            this.Controls.Add(this.mtbAlugado);
            this.Controls.Add(this.lblAlugado);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.lblDiaria);
            this.Controls.Add(this.mtbPlaca);
            this.Controls.Add(this.lblPlaca);
            this.Controls.Add(this.lblCarro);
            this.Name = "FormConsultaCarro";
            this.Text = "FormConsultaCarro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblCarro;
        private Label lblPlaca;
        private MaskedTextBox mtbPlaca;
        private Label lblAlugado;
        private MaskedTextBox mtbAlugado;
        private Label lblInfoCarro;
        private ListBox ltbInfoCarro;
        private Label lblDiaria;
        private MaskedTextBox maskedTextBox1;
        private Button btnNovaConsulta;
        private Button btnMenu;
    }
}