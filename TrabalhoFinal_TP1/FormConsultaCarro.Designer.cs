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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormConsultaCarro));
            this.lblCarro = new System.Windows.Forms.Label();
            this.lblPlaca = new System.Windows.Forms.Label();
            this.mtbPlaca = new System.Windows.Forms.MaskedTextBox();
            this.lblAlugado = new System.Windows.Forms.Label();
            this.mtbAlugado = new System.Windows.Forms.MaskedTextBox();
            this.lblInfoCarro = new System.Windows.Forms.Label();
            this.ltbInfoCarro = new System.Windows.Forms.ListBox();
            this.lblDiaria = new System.Windows.Forms.Label();
            this.mtbValorDiaria = new System.Windows.Forms.MaskedTextBox();
            this.btnNovaConsulta = new System.Windows.Forms.Button();
            this.btnMenu = new System.Windows.Forms.Button();
            this.btnConsulta = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCarro
            // 
            this.lblCarro.AutoSize = true;
            this.lblCarro.Location = new System.Drawing.Point(6, 9);
            this.lblCarro.Name = "lblCarro";
            this.lblCarro.Size = new System.Drawing.Size(250, 105);
            this.lblCarro.TabIndex = 0;
            this.lblCarro.Text = "CONSULTA DE VEÍCULOS\r\n\r\n\r\n\r\n\r\n\r\nDigite a placa do veículo que deseja consultar:";
            // 
            // lblPlaca
            // 
            this.lblPlaca.AutoSize = true;
            this.lblPlaca.Location = new System.Drawing.Point(10, 125);
            this.lblPlaca.Name = "lblPlaca";
            this.lblPlaca.Size = new System.Drawing.Size(35, 15);
            this.lblPlaca.TabIndex = 1;
            this.lblPlaca.Text = "Placa";
            // 
            // mtbPlaca
            // 
            this.mtbPlaca.Location = new System.Drawing.Point(6, 143);
            this.mtbPlaca.Mask = "AAA0000";
            this.mtbPlaca.Name = "mtbPlaca";
            this.mtbPlaca.PromptChar = ' ';
            this.mtbPlaca.Size = new System.Drawing.Size(69, 23);
            this.mtbPlaca.TabIndex = 2;
            // 
            // lblAlugado
            // 
            this.lblAlugado.AutoSize = true;
            this.lblAlugado.Location = new System.Drawing.Point(166, 125);
            this.lblAlugado.Name = "lblAlugado";
            this.lblAlugado.Size = new System.Drawing.Size(52, 15);
            this.lblAlugado.TabIndex = 1;
            this.lblAlugado.Text = "Alugado";
            // 
            // mtbAlugado
            // 
            this.mtbAlugado.Enabled = false;
            this.mtbAlugado.Location = new System.Drawing.Point(162, 143);
            this.mtbAlugado.Name = "mtbAlugado";
            this.mtbAlugado.Size = new System.Drawing.Size(126, 23);
            this.mtbAlugado.TabIndex = 2;
            // 
            // lblInfoCarro
            // 
            this.lblInfoCarro.AutoSize = true;
            this.lblInfoCarro.Location = new System.Drawing.Point(6, 184);
            this.lblInfoCarro.Name = "lblInfoCarro";
            this.lblInfoCarro.Size = new System.Drawing.Size(131, 15);
            this.lblInfoCarro.TabIndex = 3;
            this.lblInfoCarro.Text = "Informações do Veículo";
            // 
            // ltbInfoCarro
            // 
            this.ltbInfoCarro.Enabled = false;
            this.ltbInfoCarro.FormattingEnabled = true;
            this.ltbInfoCarro.ItemHeight = 15;
            this.ltbInfoCarro.Location = new System.Drawing.Point(6, 202);
            this.ltbInfoCarro.Name = "ltbInfoCarro";
            this.ltbInfoCarro.Size = new System.Drawing.Size(282, 94);
            this.ltbInfoCarro.TabIndex = 4;
            // 
            // lblDiaria
            // 
            this.lblDiaria.AutoSize = true;
            this.lblDiaria.Location = new System.Drawing.Point(6, 313);
            this.lblDiaria.Name = "lblDiaria";
            this.lblDiaria.Size = new System.Drawing.Size(139, 15);
            this.lblDiaria.TabIndex = 1;
            this.lblDiaria.Text = "Valor da diária do veículo";
            // 
            // mtbValorDiaria
            // 
            this.mtbValorDiaria.Enabled = false;
            this.mtbValorDiaria.Location = new System.Drawing.Point(6, 331);
            this.mtbValorDiaria.Name = "mtbValorDiaria";
            this.mtbValorDiaria.Size = new System.Drawing.Size(282, 23);
            this.mtbValorDiaria.TabIndex = 2;
            // 
            // btnNovaConsulta
            // 
            this.btnNovaConsulta.BackColor = System.Drawing.Color.SteelBlue;
            this.btnNovaConsulta.ForeColor = System.Drawing.Color.White;
            this.btnNovaConsulta.Location = new System.Drawing.Point(6, 372);
            this.btnNovaConsulta.Name = "btnNovaConsulta";
            this.btnNovaConsulta.Size = new System.Drawing.Size(103, 24);
            this.btnNovaConsulta.TabIndex = 5;
            this.btnNovaConsulta.Text = "Nova Consulta";
            this.btnNovaConsulta.UseVisualStyleBackColor = false;
            this.btnNovaConsulta.Click += new System.EventHandler(this.btnNovaConsulta_Click);
            // 
            // btnMenu
            // 
            this.btnMenu.BackColor = System.Drawing.Color.SteelBlue;
            this.btnMenu.ForeColor = System.Drawing.Color.White;
            this.btnMenu.Location = new System.Drawing.Point(185, 372);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(103, 24);
            this.btnMenu.TabIndex = 5;
            this.btnMenu.Text = "Voltar ao Menu";
            this.btnMenu.UseVisualStyleBackColor = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // btnConsulta
            // 
            this.btnConsulta.BackColor = System.Drawing.Color.SteelBlue;
            this.btnConsulta.ForeColor = System.Drawing.Color.White;
            this.btnConsulta.Location = new System.Drawing.Point(81, 143);
            this.btnConsulta.Name = "btnConsulta";
            this.btnConsulta.Size = new System.Drawing.Size(75, 23);
            this.btnConsulta.TabIndex = 6;
            this.btnConsulta.Text = "Consultar";
            this.btnConsulta.UseVisualStyleBackColor = false;
            this.btnConsulta.Click += new System.EventHandler(this.btnConsulta_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Enabled = false;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(148, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(140, 49);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // FormConsultaCarro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(294, 405);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnConsulta);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.btnNovaConsulta);
            this.Controls.Add(this.ltbInfoCarro);
            this.Controls.Add(this.lblInfoCarro);
            this.Controls.Add(this.mtbAlugado);
            this.Controls.Add(this.lblAlugado);
            this.Controls.Add(this.mtbValorDiaria);
            this.Controls.Add(this.lblDiaria);
            this.Controls.Add(this.mtbPlaca);
            this.Controls.Add(this.lblPlaca);
            this.Controls.Add(this.lblCarro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormConsultaCarro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta de carros";
            this.Load += new System.EventHandler(this.FormConsultaCarro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private MaskedTextBox mtbValorDiaria;
        private Button btnNovaConsulta;
        private Button btnMenu;
        private Button btnConsulta;
        private PictureBox pictureBox1;
    }
}