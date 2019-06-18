namespace ProjetoFinal
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.labelVendas = new System.Windows.Forms.Label();
            this.labelAlugueres = new System.Windows.Forms.Label();
            this.labelClientes = new System.Windows.Forms.Label();
            this.labelOficina = new System.Windows.Forms.Label();
            this.btnAluguer = new System.Windows.Forms.Button();
            this.btnVendas = new System.Windows.Forms.Button();
            this.btnOficina = new System.Windows.Forms.Button();
            this.btnClientes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelVendas
            // 
            this.labelVendas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelVendas.BackColor = System.Drawing.SystemColors.ControlLight;
            this.labelVendas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVendas.Location = new System.Drawing.Point(752, 9);
            this.labelVendas.Name = "labelVendas";
            this.labelVendas.Size = new System.Drawing.Size(220, 20);
            this.labelVendas.TabIndex = 9;
            this.labelVendas.Text = "Gestão de Vendas";
            this.labelVendas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelAlugueres
            // 
            this.labelAlugueres.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelAlugueres.BackColor = System.Drawing.SystemColors.ControlLight;
            this.labelAlugueres.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAlugueres.Location = new System.Drawing.Point(506, 9);
            this.labelAlugueres.Name = "labelAlugueres";
            this.labelAlugueres.Size = new System.Drawing.Size(220, 20);
            this.labelAlugueres.TabIndex = 8;
            this.labelAlugueres.Text = "Gestão de Aluguer";
            this.labelAlugueres.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelClientes
            // 
            this.labelClientes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelClientes.BackColor = System.Drawing.SystemColors.ControlLight;
            this.labelClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClientes.Location = new System.Drawing.Point(13, 9);
            this.labelClientes.Name = "labelClientes";
            this.labelClientes.Size = new System.Drawing.Size(221, 20);
            this.labelClientes.TabIndex = 6;
            this.labelClientes.Text = "Gestão de Clientes";
            this.labelClientes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelOficina
            // 
            this.labelOficina.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelOficina.BackColor = System.Drawing.SystemColors.ControlLight;
            this.labelOficina.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOficina.Location = new System.Drawing.Point(260, 9);
            this.labelOficina.Name = "labelOficina";
            this.labelOficina.Size = new System.Drawing.Size(220, 20);
            this.labelOficina.TabIndex = 7;
            this.labelOficina.Text = "Gestão de Oficina";
            this.labelOficina.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAluguer
            // 
            this.btnAluguer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAluguer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAluguer.BackgroundImage")));
            this.btnAluguer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAluguer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAluguer.Location = new System.Drawing.Point(506, 31);
            this.btnAluguer.Name = "btnAluguer";
            this.btnAluguer.Size = new System.Drawing.Size(220, 220);
            this.btnAluguer.TabIndex = 2;
            this.btnAluguer.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAluguer.UseVisualStyleBackColor = true;
            this.btnAluguer.Click += new System.EventHandler(this.btnAluguer_Click);
            // 
            // btnVendas
            // 
            this.btnVendas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnVendas.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnVendas.BackgroundImage")));
            this.btnVendas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVendas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVendas.Location = new System.Drawing.Point(752, 31);
            this.btnVendas.Name = "btnVendas";
            this.btnVendas.Size = new System.Drawing.Size(220, 220);
            this.btnVendas.TabIndex = 3;
            this.btnVendas.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnVendas.UseVisualStyleBackColor = true;
            this.btnVendas.Click += new System.EventHandler(this.btnVendas_Click);
            // 
            // btnOficina
            // 
            this.btnOficina.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnOficina.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnOficina.BackgroundImage")));
            this.btnOficina.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnOficina.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOficina.Location = new System.Drawing.Point(260, 32);
            this.btnOficina.Name = "btnOficina";
            this.btnOficina.Size = new System.Drawing.Size(220, 220);
            this.btnOficina.TabIndex = 1;
            this.btnOficina.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnOficina.UseVisualStyleBackColor = true;
            this.btnOficina.Click += new System.EventHandler(this.btnOficina_Click);
            // 
            // btnClientes
            // 
            this.btnClientes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnClientes.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClientes.BackgroundImage")));
            this.btnClientes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClientes.Location = new System.Drawing.Point(14, 31);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(220, 220);
            this.btnClientes.TabIndex = 0;
            this.btnClientes.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnClientes.UseVisualStyleBackColor = true;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // Main
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(984, 261);
            this.Controls.Add(this.labelVendas);
            this.Controls.Add(this.labelAlugueres);
            this.Controls.Add(this.labelClientes);
            this.Controls.Add(this.labelOficina);
            this.Controls.Add(this.btnAluguer);
            this.Controls.Add(this.btnVendas);
            this.Controls.Add(this.btnOficina);
            this.Controls.Add(this.btnClientes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Principal";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label labelVendas;
        private System.Windows.Forms.Label labelAlugueres;
        private System.Windows.Forms.Label labelClientes;
        private System.Windows.Forms.Label labelOficina;
        private System.Windows.Forms.Button btnAluguer;
        private System.Windows.Forms.Button btnVendas;
        private System.Windows.Forms.Button btnOficina;
        private System.Windows.Forms.Button btnClientes;
    }
}