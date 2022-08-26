namespace TrabalhoFinal_TP1
{
    partial class FormMenuPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenuPrincipal));
            this.btnCliente = new System.Windows.Forms.Button();
            this.btnCarros = new System.Windows.Forms.Button();
            this.btnPedidos = new System.Windows.Forms.Button();
            this.btnSobre = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnConsultaPedido = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCliente
            // 
            this.btnCliente.BackColor = System.Drawing.Color.SteelBlue;
            this.btnCliente.ForeColor = System.Drawing.Color.White;
            this.btnCliente.Location = new System.Drawing.Point(13, 255);
            this.btnCliente.Margin = new System.Windows.Forms.Padding(4);
            this.btnCliente.Name = "btnCliente";
            this.btnCliente.Size = new System.Drawing.Size(244, 38);
            this.btnCliente.TabIndex = 0;
            this.btnCliente.Text = "Cadastro/Consulta Cliente";
            this.btnCliente.UseVisualStyleBackColor = false;
            this.btnCliente.Click += new System.EventHandler(this.btnCliente_Click);
            // 
            // btnCarros
            // 
            this.btnCarros.BackColor = System.Drawing.Color.SteelBlue;
            this.btnCarros.ForeColor = System.Drawing.Color.White;
            this.btnCarros.Location = new System.Drawing.Point(13, 298);
            this.btnCarros.Margin = new System.Windows.Forms.Padding(4);
            this.btnCarros.Name = "btnCarros";
            this.btnCarros.Size = new System.Drawing.Size(244, 38);
            this.btnCarros.TabIndex = 1;
            this.btnCarros.Text = "Consulta de carros";
            this.btnCarros.UseVisualStyleBackColor = false;
            this.btnCarros.Click += new System.EventHandler(this.btnCarros_Click);
            // 
            // btnPedidos
            // 
            this.btnPedidos.BackColor = System.Drawing.Color.SteelBlue;
            this.btnPedidos.ForeColor = System.Drawing.Color.White;
            this.btnPedidos.Location = new System.Drawing.Point(13, 164);
            this.btnPedidos.Margin = new System.Windows.Forms.Padding(4);
            this.btnPedidos.Name = "btnPedidos";
            this.btnPedidos.Size = new System.Drawing.Size(244, 38);
            this.btnPedidos.TabIndex = 3;
            this.btnPedidos.Text = "Novo Pedido";
            this.btnPedidos.UseVisualStyleBackColor = false;
            this.btnPedidos.Click += new System.EventHandler(this.btnPedidos_Click);
            // 
            // btnSobre
            // 
            this.btnSobre.BackColor = System.Drawing.Color.SteelBlue;
            this.btnSobre.ForeColor = System.Drawing.Color.White;
            this.btnSobre.Location = new System.Drawing.Point(13, 344);
            this.btnSobre.Margin = new System.Windows.Forms.Padding(4);
            this.btnSobre.Name = "btnSobre";
            this.btnSobre.Size = new System.Drawing.Size(103, 38);
            this.btnSobre.TabIndex = 4;
            this.btnSobre.Text = "Sobre";
            this.btnSobre.UseVisualStyleBackColor = false;
            this.btnSobre.Click += new System.EventHandler(this.btnSobre_Click);
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.SteelBlue;
            this.btnSair.ForeColor = System.Drawing.Color.White;
            this.btnSair.Location = new System.Drawing.Point(149, 344);
            this.btnSair.Margin = new System.Windows.Forms.Padding(4);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(108, 38);
            this.btnSair.TabIndex = 5;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 79);
            this.label1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 63);
            this.label1.TabIndex = 6;
            this.label1.Text = "Seja bem vindo à Let\'s Drive!\r\n\r\nSelecione uma opção:\r\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnConsultaPedido
            // 
            this.btnConsultaPedido.BackColor = System.Drawing.Color.SteelBlue;
            this.btnConsultaPedido.ForeColor = System.Drawing.Color.White;
            this.btnConsultaPedido.Location = new System.Drawing.Point(13, 207);
            this.btnConsultaPedido.Margin = new System.Windows.Forms.Padding(1, 3, 1, 3);
            this.btnConsultaPedido.Name = "btnConsultaPedido";
            this.btnConsultaPedido.Size = new System.Drawing.Size(244, 42);
            this.btnConsultaPedido.TabIndex = 7;
            this.btnConsultaPedido.Text = "Consulta Pedido";
            this.btnConsultaPedido.UseVisualStyleBackColor = false;
            this.btnConsultaPedido.Click += new System.EventHandler(this.btnConsultaPedido_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Enabled = false;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(13, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(244, 49);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // FormMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(270, 393);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnConsultaPedido);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnSobre);
            this.Controls.Add(this.btnPedidos);
            this.Controls.Add(this.btnCarros);
            this.Controls.Add(this.btnCliente);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Let\'s Drive";
            this.Load += new System.EventHandler(this.FormMenuPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnCliente;
        private Button btnCarros;
        private Button btnPedidos;
        private Button btnSobre;
        private Button btnSair;
        private Label label1;
        private Button btnConsultaPedido;
        private PictureBox pictureBox1;
    }
}