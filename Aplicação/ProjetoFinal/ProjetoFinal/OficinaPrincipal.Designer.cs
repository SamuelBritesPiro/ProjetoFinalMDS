namespace ProjetoFinal
{
    partial class OficinaPrincipal
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
            this.labelValorTotal = new System.Windows.Forms.Label();
            this.labelTextoValorTotal = new System.Windows.Forms.Label();
            this.labelMoradaCliente = new System.Windows.Forms.Label();
            this.labelNumeroCliente = new System.Windows.Forms.Label();
            this.labelNomeCliente = new System.Windows.Forms.Label();
            this.groupBoxParcelas = new System.Windows.Forms.GroupBox();
            this.buttonAdicionarParcela = new System.Windows.Forms.Button();
            this.buttonGerirParcela = new System.Windows.Forms.Button();
            this.listBoxParcelas = new System.Windows.Forms.ListBox();
            this.listBoxServicos = new System.Windows.Forms.ListBox();
            this.groupBoxServicos = new System.Windows.Forms.GroupBox();
            this.buttonAdicionarServico = new System.Windows.Forms.Button();
            this.buttonServico = new System.Windows.Forms.Button();
            this.listBoxCarrosOficina = new System.Windows.Forms.ListBox();
            this.groupBoxCarrosOficina = new System.Windows.Forms.GroupBox();
            this.buttonAdicionarCarro = new System.Windows.Forms.Button();
            this.buttonGerirCarroDeOficina = new System.Windows.Forms.Button();
            this.listBoxClientes = new System.Windows.Forms.ListBox();
            this.groupBoxClientes = new System.Windows.Forms.GroupBox();
            this.textBoxFiltrar = new System.Windows.Forms.TextBox();
            this.buttonFiltrar = new System.Windows.Forms.Button();
            this.buttonImprimir = new System.Windows.Forms.Button();
            this.groupBoxParcelas.SuspendLayout();
            this.groupBoxServicos.SuspendLayout();
            this.groupBoxCarrosOficina.SuspendLayout();
            this.groupBoxClientes.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelValorTotal
            // 
            this.labelValorTotal.AutoSize = true;
            this.labelValorTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelValorTotal.Location = new System.Drawing.Point(968, 94);
            this.labelValorTotal.Name = "labelValorTotal";
            this.labelValorTotal.Size = new System.Drawing.Size(16, 18);
            this.labelValorTotal.TabIndex = 8;
            this.labelValorTotal.Text = "0";
            this.labelValorTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelTextoValorTotal
            // 
            this.labelTextoValorTotal.AutoSize = true;
            this.labelTextoValorTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTextoValorTotal.Location = new System.Drawing.Point(875, 94);
            this.labelTextoValorTotal.Name = "labelTextoValorTotal";
            this.labelTextoValorTotal.Size = new System.Drawing.Size(87, 18);
            this.labelTextoValorTotal.TabIndex = 7;
            this.labelTextoValorTotal.Text = "Valor Total: ";
            this.labelTextoValorTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelMoradaCliente
            // 
            this.labelMoradaCliente.AutoSize = true;
            this.labelMoradaCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMoradaCliente.Location = new System.Drawing.Point(294, 94);
            this.labelMoradaCliente.Name = "labelMoradaCliente";
            this.labelMoradaCliente.Size = new System.Drawing.Size(13, 18);
            this.labelMoradaCliente.TabIndex = 6;
            this.labelMoradaCliente.Text = "-";
            // 
            // labelNumeroCliente
            // 
            this.labelNumeroCliente.AutoSize = true;
            this.labelNumeroCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumeroCliente.Location = new System.Drawing.Point(294, 67);
            this.labelNumeroCliente.Name = "labelNumeroCliente";
            this.labelNumeroCliente.Size = new System.Drawing.Size(13, 18);
            this.labelNumeroCliente.TabIndex = 5;
            this.labelNumeroCliente.Text = "-";
            // 
            // labelNomeCliente
            // 
            this.labelNomeCliente.AutoSize = true;
            this.labelNomeCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNomeCliente.Location = new System.Drawing.Point(292, 29);
            this.labelNomeCliente.Name = "labelNomeCliente";
            this.labelNomeCliente.Size = new System.Drawing.Size(319, 29);
            this.labelNomeCliente.TabIndex = 4;
            this.labelNomeCliente.Text = "Nenhum cliente selecionado";
            // 
            // groupBoxParcelas
            // 
            this.groupBoxParcelas.Controls.Add(this.buttonAdicionarParcela);
            this.groupBoxParcelas.Controls.Add(this.buttonGerirParcela);
            this.groupBoxParcelas.Controls.Add(this.listBoxParcelas);
            this.groupBoxParcelas.Location = new System.Drawing.Point(815, 130);
            this.groupBoxParcelas.Name = "groupBoxParcelas";
            this.groupBoxParcelas.Size = new System.Drawing.Size(256, 338);
            this.groupBoxParcelas.TabIndex = 3;
            this.groupBoxParcelas.TabStop = false;
            this.groupBoxParcelas.Text = "Lista de Parcelas";
            // 
            // buttonAdicionarParcela
            // 
            this.buttonAdicionarParcela.BackColor = System.Drawing.Color.Aquamarine;
            this.buttonAdicionarParcela.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdicionarParcela.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdicionarParcela.Location = new System.Drawing.Point(28, 225);
            this.buttonAdicionarParcela.Margin = new System.Windows.Forms.Padding(0);
            this.buttonAdicionarParcela.Name = "buttonAdicionarParcela";
            this.buttonAdicionarParcela.Size = new System.Drawing.Size(200, 40);
            this.buttonAdicionarParcela.TabIndex = 2;
            this.buttonAdicionarParcela.Text = "Adicionar Parcela";
            this.buttonAdicionarParcela.UseVisualStyleBackColor = false;
            this.buttonAdicionarParcela.Click += new System.EventHandler(this.buttonAdicionarParcela_Click);
            // 
            // buttonGerirParcela
            // 
            this.buttonGerirParcela.BackColor = System.Drawing.Color.Wheat;
            this.buttonGerirParcela.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGerirParcela.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGerirParcela.Location = new System.Drawing.Point(28, 281);
            this.buttonGerirParcela.Margin = new System.Windows.Forms.Padding(0);
            this.buttonGerirParcela.Name = "buttonGerirParcela";
            this.buttonGerirParcela.Size = new System.Drawing.Size(200, 40);
            this.buttonGerirParcela.TabIndex = 1;
            this.buttonGerirParcela.Text = "Gerir Parcela";
            this.buttonGerirParcela.UseVisualStyleBackColor = false;
            this.buttonGerirParcela.Click += new System.EventHandler(this.buttonGerirParcela_Click);
            // 
            // listBoxParcelas
            // 
            this.listBoxParcelas.FormattingEnabled = true;
            this.listBoxParcelas.HorizontalScrollbar = true;
            this.listBoxParcelas.Location = new System.Drawing.Point(6, 19);
            this.listBoxParcelas.Name = "listBoxParcelas";
            this.listBoxParcelas.Size = new System.Drawing.Size(244, 199);
            this.listBoxParcelas.TabIndex = 0;
            this.listBoxParcelas.TabStop = false;
            this.listBoxParcelas.SelectedIndexChanged += new System.EventHandler(this.listBoxParcelas_SelectedIndexChanged);
            // 
            // listBoxServicos
            // 
            this.listBoxServicos.FormattingEnabled = true;
            this.listBoxServicos.HorizontalScrollbar = true;
            this.listBoxServicos.Location = new System.Drawing.Point(6, 19);
            this.listBoxServicos.Name = "listBoxServicos";
            this.listBoxServicos.Size = new System.Drawing.Size(244, 199);
            this.listBoxServicos.TabIndex = 0;
            this.listBoxServicos.TabStop = false;
            this.listBoxServicos.SelectedIndexChanged += new System.EventHandler(this.listBoxServicos_SelectedIndexChanged);
            // 
            // groupBoxServicos
            // 
            this.groupBoxServicos.Controls.Add(this.buttonImprimir);
            this.groupBoxServicos.Controls.Add(this.buttonAdicionarServico);
            this.groupBoxServicos.Controls.Add(this.buttonServico);
            this.groupBoxServicos.Controls.Add(this.listBoxServicos);
            this.groupBoxServicos.Location = new System.Drawing.Point(553, 130);
            this.groupBoxServicos.Name = "groupBoxServicos";
            this.groupBoxServicos.Size = new System.Drawing.Size(256, 338);
            this.groupBoxServicos.TabIndex = 2;
            this.groupBoxServicos.TabStop = false;
            this.groupBoxServicos.Text = "Lista de Serviços";
            // 
            // buttonAdicionarServico
            // 
            this.buttonAdicionarServico.BackColor = System.Drawing.Color.Aquamarine;
            this.buttonAdicionarServico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdicionarServico.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdicionarServico.Location = new System.Drawing.Point(28, 223);
            this.buttonAdicionarServico.Margin = new System.Windows.Forms.Padding(0);
            this.buttonAdicionarServico.Name = "buttonAdicionarServico";
            this.buttonAdicionarServico.Size = new System.Drawing.Size(200, 35);
            this.buttonAdicionarServico.TabIndex = 2;
            this.buttonAdicionarServico.Text = "Adicionar Serviço";
            this.buttonAdicionarServico.UseVisualStyleBackColor = false;
            this.buttonAdicionarServico.Click += new System.EventHandler(this.buttonAdicionarServico_Click);
            // 
            // buttonServico
            // 
            this.buttonServico.BackColor = System.Drawing.Color.Wheat;
            this.buttonServico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonServico.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonServico.Location = new System.Drawing.Point(28, 260);
            this.buttonServico.Margin = new System.Windows.Forms.Padding(0);
            this.buttonServico.Name = "buttonServico";
            this.buttonServico.Size = new System.Drawing.Size(200, 35);
            this.buttonServico.TabIndex = 1;
            this.buttonServico.Text = "Gerir Serviço";
            this.buttonServico.UseVisualStyleBackColor = false;
            this.buttonServico.Click += new System.EventHandler(this.buttonServico_Click);
            // 
            // listBoxCarrosOficina
            // 
            this.listBoxCarrosOficina.FormattingEnabled = true;
            this.listBoxCarrosOficina.HorizontalScrollbar = true;
            this.listBoxCarrosOficina.Location = new System.Drawing.Point(6, 19);
            this.listBoxCarrosOficina.Name = "listBoxCarrosOficina";
            this.listBoxCarrosOficina.Size = new System.Drawing.Size(244, 199);
            this.listBoxCarrosOficina.TabIndex = 0;
            this.listBoxCarrosOficina.TabStop = false;
            this.listBoxCarrosOficina.SelectedIndexChanged += new System.EventHandler(this.listBoxCarrosOficina_SelectedIndexChanged);
            // 
            // groupBoxCarrosOficina
            // 
            this.groupBoxCarrosOficina.Controls.Add(this.buttonAdicionarCarro);
            this.groupBoxCarrosOficina.Controls.Add(this.buttonGerirCarroDeOficina);
            this.groupBoxCarrosOficina.Controls.Add(this.listBoxCarrosOficina);
            this.groupBoxCarrosOficina.Location = new System.Drawing.Point(291, 130);
            this.groupBoxCarrosOficina.Name = "groupBoxCarrosOficina";
            this.groupBoxCarrosOficina.Size = new System.Drawing.Size(256, 338);
            this.groupBoxCarrosOficina.TabIndex = 1;
            this.groupBoxCarrosOficina.TabStop = false;
            this.groupBoxCarrosOficina.Text = "Lista de Carros de Oficina";
            // 
            // buttonAdicionarCarro
            // 
            this.buttonAdicionarCarro.BackColor = System.Drawing.Color.Aquamarine;
            this.buttonAdicionarCarro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdicionarCarro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdicionarCarro.Location = new System.Drawing.Point(28, 225);
            this.buttonAdicionarCarro.Margin = new System.Windows.Forms.Padding(0);
            this.buttonAdicionarCarro.Name = "buttonAdicionarCarro";
            this.buttonAdicionarCarro.Size = new System.Drawing.Size(200, 40);
            this.buttonAdicionarCarro.TabIndex = 2;
            this.buttonAdicionarCarro.Text = "Adicionar Carro de Oficina";
            this.buttonAdicionarCarro.UseVisualStyleBackColor = false;
            this.buttonAdicionarCarro.Click += new System.EventHandler(this.buttonAdicionarCarro_Click);
            // 
            // buttonGerirCarroDeOficina
            // 
            this.buttonGerirCarroDeOficina.BackColor = System.Drawing.Color.Wheat;
            this.buttonGerirCarroDeOficina.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGerirCarroDeOficina.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGerirCarroDeOficina.Location = new System.Drawing.Point(28, 281);
            this.buttonGerirCarroDeOficina.Margin = new System.Windows.Forms.Padding(0);
            this.buttonGerirCarroDeOficina.Name = "buttonGerirCarroDeOficina";
            this.buttonGerirCarroDeOficina.Size = new System.Drawing.Size(200, 40);
            this.buttonGerirCarroDeOficina.TabIndex = 1;
            this.buttonGerirCarroDeOficina.Text = "Gerir Carro de Oficina";
            this.buttonGerirCarroDeOficina.UseVisualStyleBackColor = false;
            this.buttonGerirCarroDeOficina.Click += new System.EventHandler(this.buttonGerirCarroDeOficina_Click);
            // 
            // listBoxClientes
            // 
            this.listBoxClientes.FormattingEnabled = true;
            this.listBoxClientes.HorizontalScrollbar = true;
            this.listBoxClientes.Location = new System.Drawing.Point(7, 20);
            this.listBoxClientes.Name = "listBoxClientes";
            this.listBoxClientes.Size = new System.Drawing.Size(259, 316);
            this.listBoxClientes.TabIndex = 0;
            this.listBoxClientes.TabStop = false;
            this.listBoxClientes.SelectedIndexChanged += new System.EventHandler(this.listBoxClientes_SelectedIndexChanged);
            // 
            // groupBoxClientes
            // 
            this.groupBoxClientes.Controls.Add(this.textBoxFiltrar);
            this.groupBoxClientes.Controls.Add(this.listBoxClientes);
            this.groupBoxClientes.Controls.Add(this.buttonFiltrar);
            this.groupBoxClientes.Location = new System.Drawing.Point(12, 12);
            this.groupBoxClientes.Name = "groupBoxClientes";
            this.groupBoxClientes.Size = new System.Drawing.Size(273, 456);
            this.groupBoxClientes.TabIndex = 0;
            this.groupBoxClientes.TabStop = false;
            this.groupBoxClientes.Text = "Lista de Clientes";
            // 
            // textBoxFiltrar
            // 
            this.textBoxFiltrar.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.textBoxFiltrar.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBoxFiltrar.Location = new System.Drawing.Point(7, 363);
            this.textBoxFiltrar.Name = "textBoxFiltrar";
            this.textBoxFiltrar.Size = new System.Drawing.Size(259, 20);
            this.textBoxFiltrar.TabIndex = 1;
            this.textBoxFiltrar.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBoxFiltrar_KeyUp);
            // 
            // buttonFiltrar
            // 
            this.buttonFiltrar.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.buttonFiltrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFiltrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFiltrar.Location = new System.Drawing.Point(33, 396);
            this.buttonFiltrar.Margin = new System.Windows.Forms.Padding(0);
            this.buttonFiltrar.Name = "buttonFiltrar";
            this.buttonFiltrar.Size = new System.Drawing.Size(207, 40);
            this.buttonFiltrar.TabIndex = 2;
            this.buttonFiltrar.Text = "Filtrar por Nome";
            this.buttonFiltrar.UseVisualStyleBackColor = false;
            this.buttonFiltrar.Click += new System.EventHandler(this.buttonFiltrar_Click);
            // 
            // buttonImprimir
            // 
            this.buttonImprimir.BackColor = System.Drawing.Color.Silver;
            this.buttonImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonImprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.buttonImprimir.Location = new System.Drawing.Point(28, 297);
            this.buttonImprimir.Name = "buttonImprimir";
            this.buttonImprimir.Size = new System.Drawing.Size(200, 35);
            this.buttonImprimir.TabIndex = 3;
            this.buttonImprimir.Text = "Imprimir Recibo";
            this.buttonImprimir.UseVisualStyleBackColor = false;
            this.buttonImprimir.Click += new System.EventHandler(this.buttonImprimir_Click);
            // 
            // OficinaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1074, 471);
            this.Controls.Add(this.labelValorTotal);
            this.Controls.Add(this.labelTextoValorTotal);
            this.Controls.Add(this.labelMoradaCliente);
            this.Controls.Add(this.labelNumeroCliente);
            this.Controls.Add(this.labelNomeCliente);
            this.Controls.Add(this.groupBoxParcelas);
            this.Controls.Add(this.groupBoxServicos);
            this.Controls.Add(this.groupBoxCarrosOficina);
            this.Controls.Add(this.groupBoxClientes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "OficinaPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestão De Oficina";
            this.Load += new System.EventHandler(this.GestaoDeOficinaPrincipal_Load);
            this.groupBoxParcelas.ResumeLayout(false);
            this.groupBoxServicos.ResumeLayout(false);
            this.groupBoxCarrosOficina.ResumeLayout(false);
            this.groupBoxClientes.ResumeLayout(false);
            this.groupBoxClientes.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelValorTotal;
        private System.Windows.Forms.Label labelTextoValorTotal;
        private System.Windows.Forms.Label labelMoradaCliente;
        private System.Windows.Forms.Label labelNumeroCliente;
        private System.Windows.Forms.Label labelNomeCliente;
        private System.Windows.Forms.GroupBox groupBoxParcelas;
        private System.Windows.Forms.ListBox listBoxParcelas;
        private System.Windows.Forms.ListBox listBoxServicos;
        private System.Windows.Forms.GroupBox groupBoxServicos;
        private System.Windows.Forms.ListBox listBoxCarrosOficina;
        private System.Windows.Forms.GroupBox groupBoxCarrosOficina;
        private System.Windows.Forms.ListBox listBoxClientes;
        private System.Windows.Forms.GroupBox groupBoxClientes;
        private System.Windows.Forms.Button buttonGerirCarroDeOficina;
        private System.Windows.Forms.Button buttonGerirParcela;
        private System.Windows.Forms.Button buttonServico;
        private System.Windows.Forms.TextBox textBoxFiltrar;
        private System.Windows.Forms.Button buttonFiltrar;
        private System.Windows.Forms.Button buttonAdicionarParcela;
        private System.Windows.Forms.Button buttonAdicionarServico;
        private System.Windows.Forms.Button buttonAdicionarCarro;
        private System.Windows.Forms.Button buttonImprimir;
    }
}