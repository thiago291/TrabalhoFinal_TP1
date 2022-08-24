namespace TrabalhoFinal_TP1
{
    partial class FormCadastroCliente
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
            this.lblDadosPessoais = new System.Windows.Forms.Label();
            this.lblNomeCli = new System.Windows.Forms.Label();
            this.mtbNomeCli = new System.Windows.Forms.MaskedTextBox();
            this.lblCpfCli = new System.Windows.Forms.Label();
            this.mtbCpfCli = new System.Windows.Forms.MaskedTextBox();
            this.lblCelCli = new System.Windows.Forms.Label();
            this.mtbCelCli = new System.Windows.Forms.MaskedTextBox();
            this.lblDataNascCli = new System.Windows.Forms.Label();
            this.mtbDataNascCli = new System.Windows.Forms.MaskedTextBox();
            this.lblEmailCli = new System.Windows.Forms.Label();
            this.mtbEmailCli = new System.Windows.Forms.MaskedTextBox();
            this.lblCnhCli = new System.Windows.Forms.Label();
            this.mtbCnhCli = new System.Windows.Forms.MaskedTextBox();
            this.lblGenCli = new System.Windows.Forms.Label();
            this.mtbGenCli = new System.Windows.Forms.MaskedTextBox();
            this.lblEndereçoCli = new System.Windows.Forms.Label();
            this.lblRuaCli = new System.Windows.Forms.Label();
            this.mtbRuaCli = new System.Windows.Forms.MaskedTextBox();
            this.lblNumCli = new System.Windows.Forms.Label();
            this.mtbNumCli = new System.Windows.Forms.MaskedTextBox();
            this.lblCidadeCli = new System.Windows.Forms.Label();
            this.mtbCidadeCli = new System.Windows.Forms.MaskedTextBox();
            this.lblUf = new System.Windows.Forms.Label();
            this.mtbUfCli = new System.Windows.Forms.MaskedTextBox();
            this.lblCepCli = new System.Windows.Forms.Label();
            this.mtbCepCli = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // lblDadosPessoais
            // 
            this.lblDadosPessoais.AutoSize = true;
            this.lblDadosPessoais.Location = new System.Drawing.Point(10, 9);
            this.lblDadosPessoais.Name = "lblDadosPessoais";
            this.lblDadosPessoais.Size = new System.Drawing.Size(87, 15);
            this.lblDadosPessoais.TabIndex = 0;
            this.lblDadosPessoais.Text = "Dados Pessoais";
            // 
            // lblNomeCli
            // 
            this.lblNomeCli.AutoSize = true;
            this.lblNomeCli.Location = new System.Drawing.Point(10, 48);
            this.lblNomeCli.Name = "lblNomeCli";
            this.lblNomeCli.Size = new System.Drawing.Size(96, 15);
            this.lblNomeCli.TabIndex = 1;
            this.lblNomeCli.Text = "Nome Completo";
            // 
            // mtbNomeCli
            // 
            this.mtbNomeCli.Location = new System.Drawing.Point(10, 66);
            this.mtbNomeCli.Name = "mtbNomeCli";
            this.mtbNomeCli.Size = new System.Drawing.Size(175, 23);
            this.mtbNomeCli.TabIndex = 2;
            // 
            // lblCpfCli
            // 
            this.lblCpfCli.AutoSize = true;
            this.lblCpfCli.Location = new System.Drawing.Point(191, 48);
            this.lblCpfCli.Name = "lblCpfCli";
            this.lblCpfCli.Size = new System.Drawing.Size(28, 15);
            this.lblCpfCli.TabIndex = 1;
            this.lblCpfCli.Text = "CPF";
            // 
            // mtbCpfCli
            // 
            this.mtbCpfCli.Location = new System.Drawing.Point(191, 66);
            this.mtbCpfCli.Mask = "000.000.000-00";
            this.mtbCpfCli.Name = "mtbCpfCli";
            this.mtbCpfCli.Size = new System.Drawing.Size(126, 23);
            this.mtbCpfCli.TabIndex = 2;
            // 
            // lblCelCli
            // 
            this.lblCelCli.AutoSize = true;
            this.lblCelCli.Location = new System.Drawing.Point(323, 48);
            this.lblCelCli.Name = "lblCelCli";
            this.lblCelCli.Size = new System.Drawing.Size(44, 15);
            this.lblCelCli.TabIndex = 1;
            this.lblCelCli.Text = "Celular";
            // 
            // mtbCelCli
            // 
            this.mtbCelCli.Location = new System.Drawing.Point(323, 66);
            this.mtbCelCli.Mask = "(00) 00000-0000";
            this.mtbCelCli.Name = "mtbCelCli";
            this.mtbCelCli.Size = new System.Drawing.Size(126, 23);
            this.mtbCelCli.TabIndex = 2;
            // 
            // lblDataNascCli
            // 
            this.lblDataNascCli.AutoSize = true;
            this.lblDataNascCli.Location = new System.Drawing.Point(455, 48);
            this.lblDataNascCli.Name = "lblDataNascCli";
            this.lblDataNascCli.Size = new System.Drawing.Size(114, 15);
            this.lblDataNascCli.TabIndex = 1;
            this.lblDataNascCli.Text = "Data de Nascimento";
            // 
            // mtbDataNascCli
            // 
            this.mtbDataNascCli.Location = new System.Drawing.Point(455, 66);
            this.mtbDataNascCli.Mask = "00/00/0000";
            this.mtbDataNascCli.Name = "mtbDataNascCli";
            this.mtbDataNascCli.Size = new System.Drawing.Size(126, 23);
            this.mtbDataNascCli.TabIndex = 2;
            this.mtbDataNascCli.ValidatingType = typeof(System.DateTime);
            // 
            // lblEmailCli
            // 
            this.lblEmailCli.AutoSize = true;
            this.lblEmailCli.Location = new System.Drawing.Point(10, 93);
            this.lblEmailCli.Name = "lblEmailCli";
            this.lblEmailCli.Size = new System.Drawing.Size(36, 15);
            this.lblEmailCli.TabIndex = 1;
            this.lblEmailCli.Text = "Email";
            // 
            // mtbEmailCli
            // 
            this.mtbEmailCli.Location = new System.Drawing.Point(10, 111);
            this.mtbEmailCli.Name = "mtbEmailCli";
            this.mtbEmailCli.Size = new System.Drawing.Size(175, 23);
            this.mtbEmailCli.TabIndex = 2;
            // 
            // lblCnhCli
            // 
            this.lblCnhCli.AutoSize = true;
            this.lblCnhCli.Location = new System.Drawing.Point(191, 93);
            this.lblCnhCli.Name = "lblCnhCli";
            this.lblCnhCli.Size = new System.Drawing.Size(33, 15);
            this.lblCnhCli.TabIndex = 1;
            this.lblCnhCli.Text = "CNH";
            // 
            // mtbCnhCli
            // 
            this.mtbCnhCli.Location = new System.Drawing.Point(191, 111);
            this.mtbCnhCli.Mask = "00000000000";
            this.mtbCnhCli.Name = "mtbCnhCli";
            this.mtbCnhCli.Size = new System.Drawing.Size(126, 23);
            this.mtbCnhCli.TabIndex = 2;
            // 
            // lblGenCli
            // 
            this.lblGenCli.AutoSize = true;
            this.lblGenCli.Location = new System.Drawing.Point(323, 93);
            this.lblGenCli.Name = "lblGenCli";
            this.lblGenCli.Size = new System.Drawing.Size(45, 15);
            this.lblGenCli.TabIndex = 1;
            this.lblGenCli.Text = "Gênero";
            // 
            // mtbGenCli
            // 
            this.mtbGenCli.Location = new System.Drawing.Point(323, 111);
            this.mtbGenCli.Mask = "00000000000";
            this.mtbGenCli.Name = "mtbGenCli";
            this.mtbGenCli.Size = new System.Drawing.Size(126, 23);
            this.mtbGenCli.TabIndex = 2;
            // 
            // lblEndereçoCli
            // 
            this.lblEndereçoCli.AutoSize = true;
            this.lblEndereçoCli.Location = new System.Drawing.Point(10, 162);
            this.lblEndereçoCli.Name = "lblEndereçoCli";
            this.lblEndereçoCli.Size = new System.Drawing.Size(107, 15);
            this.lblEndereçoCli.TabIndex = 0;
            this.lblEndereçoCli.Text = "Dados Residenciais";
            // 
            // lblRuaCli
            // 
            this.lblRuaCli.AutoSize = true;
            this.lblRuaCli.Location = new System.Drawing.Point(10, 192);
            this.lblRuaCli.Name = "lblRuaCli";
            this.lblRuaCli.Size = new System.Drawing.Size(27, 15);
            this.lblRuaCli.TabIndex = 1;
            this.lblRuaCli.Text = "Rua";
            // 
            // mtbRuaCli
            // 
            this.mtbRuaCli.Location = new System.Drawing.Point(10, 210);
            this.mtbRuaCli.Name = "mtbRuaCli";
            this.mtbRuaCli.Size = new System.Drawing.Size(175, 23);
            this.mtbRuaCli.TabIndex = 2;
            // 
            // lblNumCli
            // 
            this.lblNumCli.AutoSize = true;
            this.lblNumCli.Location = new System.Drawing.Point(191, 192);
            this.lblNumCli.Name = "lblNumCli";
            this.lblNumCli.Size = new System.Drawing.Size(21, 15);
            this.lblNumCli.TabIndex = 1;
            this.lblNumCli.Text = "Nº";
            // 
            // mtbNumCli
            // 
            this.mtbNumCli.Location = new System.Drawing.Point(191, 210);
            this.mtbNumCli.Mask = "00000";
            this.mtbNumCli.Name = "mtbNumCli";
            this.mtbNumCli.Size = new System.Drawing.Size(33, 23);
            this.mtbNumCli.TabIndex = 2;
            this.mtbNumCli.ValidatingType = typeof(int);
            // 
            // lblCidadeCli
            // 
            this.lblCidadeCli.AutoSize = true;
            this.lblCidadeCli.Location = new System.Drawing.Point(10, 236);
            this.lblCidadeCli.Name = "lblCidadeCli";
            this.lblCidadeCli.Size = new System.Drawing.Size(44, 15);
            this.lblCidadeCli.TabIndex = 1;
            this.lblCidadeCli.Text = "Cidade";
            // 
            // mtbCidadeCli
            // 
            this.mtbCidadeCli.Location = new System.Drawing.Point(10, 254);
            this.mtbCidadeCli.Name = "mtbCidadeCli";
            this.mtbCidadeCli.Size = new System.Drawing.Size(175, 23);
            this.mtbCidadeCli.TabIndex = 2;
            // 
            // lblUf
            // 
            this.lblUf.AutoSize = true;
            this.lblUf.Location = new System.Drawing.Point(191, 236);
            this.lblUf.Name = "lblUf";
            this.lblUf.Size = new System.Drawing.Size(21, 15);
            this.lblUf.TabIndex = 1;
            this.lblUf.Text = "UF";
            // 
            // mtbUfCli
            // 
            this.mtbUfCli.Location = new System.Drawing.Point(191, 254);
            this.mtbUfCli.Mask = "AA";
            this.mtbUfCli.Name = "mtbUfCli";
            this.mtbUfCli.Size = new System.Drawing.Size(33, 23);
            this.mtbUfCli.TabIndex = 2;
            // 
            // lblCepCli
            // 
            this.lblCepCli.AutoSize = true;
            this.lblCepCli.Location = new System.Drawing.Point(10, 280);
            this.lblCepCli.Name = "lblCepCli";
            this.lblCepCli.Size = new System.Drawing.Size(28, 15);
            this.lblCepCli.TabIndex = 1;
            this.lblCepCli.Text = "CEP";
            // 
            // mtbCepCli
            // 
            this.mtbCepCli.Location = new System.Drawing.Point(10, 298);
            this.mtbCepCli.Mask = "00000-000";
            this.mtbCepCli.Name = "mtbCepCli";
            this.mtbCepCli.Size = new System.Drawing.Size(175, 23);
            this.mtbCepCli.TabIndex = 2;
            // 
            // FormCadastroCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 352);
            this.Controls.Add(this.mtbDataNascCli);
            this.Controls.Add(this.lblDataNascCli);
            this.Controls.Add(this.mtbCelCli);
            this.Controls.Add(this.lblCelCli);
            this.Controls.Add(this.mtbGenCli);
            this.Controls.Add(this.lblGenCli);
            this.Controls.Add(this.mtbCnhCli);
            this.Controls.Add(this.lblCnhCli);
            this.Controls.Add(this.mtbCpfCli);
            this.Controls.Add(this.lblCpfCli);
            this.Controls.Add(this.mtbEmailCli);
            this.Controls.Add(this.lblEmailCli);
            this.Controls.Add(this.mtbUfCli);
            this.Controls.Add(this.lblUf);
            this.Controls.Add(this.mtbNumCli);
            this.Controls.Add(this.lblNumCli);
            this.Controls.Add(this.mtbCepCli);
            this.Controls.Add(this.lblCepCli);
            this.Controls.Add(this.mtbCidadeCli);
            this.Controls.Add(this.lblCidadeCli);
            this.Controls.Add(this.mtbRuaCli);
            this.Controls.Add(this.lblRuaCli);
            this.Controls.Add(this.mtbNomeCli);
            this.Controls.Add(this.lblNomeCli);
            this.Controls.Add(this.lblEndereçoCli);
            this.Controls.Add(this.lblDadosPessoais);
            this.Name = "FormCadastroCliente";
            this.Text = "FormCadastroCliente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblDadosPessoais;
        private Label lblNomeCli;
        private MaskedTextBox mtbNomeCli;
        private Label lblCpfCli;
        private MaskedTextBox mtbCpfCli;
        private Label lblCelCli;
        private MaskedTextBox mtbCelCli;
        private Label lblDataNascCli;
        private MaskedTextBox mtbDataNascCli;
        private Label lblEmailCli;
        private MaskedTextBox mtbEmailCli;
        private Label lblCnhCli;
        private MaskedTextBox mtbCnhCli;
        private Label lblGenCli;
        private MaskedTextBox mtbGenCli;
        private Label lblEndereçoCli;
        private Label lblRuaCli;
        private MaskedTextBox mtbRuaCli;
        private Label lblNumCli;
        private MaskedTextBox mtbNumCli;
        private Label lblCidadeCli;
        private MaskedTextBox mtbCidadeCli;
        private Label lblUf;
        private MaskedTextBox mtbUfCli;
        private Label lblCepCli;
        private MaskedTextBox mtbCepCli;
    }
}