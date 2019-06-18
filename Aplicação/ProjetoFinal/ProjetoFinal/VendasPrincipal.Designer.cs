namespace ProjetoFinal
{
    partial class VendasPrincipal
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
            this.groupBoxClientes = new System.Windows.Forms.GroupBox();
            this.textBoxFiltrar = new System.Windows.Forms.TextBox();
            this.listBoxClientes = new System.Windows.Forms.ListBox();
            this.buttonFiltrar = new System.Windows.Forms.Button();
            this.labelMoradaCliente = new System.Windows.Forms.Label();
            this.labelNumeroCliente = new System.Windows.Forms.Label();
            this.labelNomeCliente = new System.Windows.Forms.Label();
            this.groupBoxCarrosVenda = new System.Windows.Forms.GroupBox();
            this.buttonGestaoCarroDeVenda = new System.Windows.Forms.Button();
            this.buttonAddCarroDeVenda = new System.Windows.Forms.Button();
            this.listBoxCarros = new System.Windows.Forms.ListBox();
            this.labelDataVenda = new System.Windows.Forms.Label();
            this.labelEstado = new System.Windows.Forms.Label();
            this.labelValor = new System.Windows.Forms.Label();
            this.textBoxEstado = new System.Windows.Forms.TextBox();
            this.textBoxValor = new System.Windows.Forms.TextBox();
            this.dateTimePickerVenda = new System.Windows.Forms.DateTimePicker();
            this.groupBoxVendas = new System.Windows.Forms.GroupBox();
            this.buttonImprimir = new System.Windows.Forms.Button();
            this.buttonCriarVenda = new System.Windows.Forms.Button();
            this.listBoxVendas = new System.Windows.Forms.ListBox();
            this.groupBoxClientes.SuspendLayout();
            this.groupBoxCarrosVenda.SuspendLayout();
            this.groupBoxVendas.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxClientes
            // 
            this.groupBoxClientes.Controls.Add(this.textBoxFiltrar);
            this.groupBoxClientes.Controls.Add(this.listBoxClientes);
            this.groupBoxClientes.Controls.Add(this.buttonFiltrar);
            this.groupBoxClientes.Location = new System.Drawing.Point(12, 12);
            this.groupBoxClientes.Name = "groupBoxClientes";
            this.groupBoxClientes.Size = new System.Drawing.Size(273, 542);
            this.groupBoxClientes.TabIndex = 0;
            this.groupBoxClientes.TabStop = false;
            this.groupBoxClientes.Text = "Lista de Clientes";
            // 
            // textBoxFiltrar
            // 
            this.textBoxFiltrar.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.textBoxFiltrar.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBoxFiltrar.Location = new System.Drawing.Point(7, 469);
            this.textBoxFiltrar.Name = "textBoxFiltrar";
            this.textBoxFiltrar.Size = new System.Drawing.Size(259, 20);
            this.textBoxFiltrar.TabIndex = 1;
            this.textBoxFiltrar.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBoxFiltrar_KeyUp);
            // 
            // listBoxClientes
            // 
            this.listBoxClientes.FormattingEnabled = true;
            this.listBoxClientes.HorizontalScrollbar = true;
            this.listBoxClientes.Location = new System.Drawing.Point(7, 20);
            this.listBoxClientes.Name = "listBoxClientes";
            this.listBoxClientes.Size = new System.Drawing.Size(259, 446);
            this.listBoxClientes.TabIndex = 0;
            this.listBoxClientes.TabStop = false;
            this.listBoxClientes.SelectedIndexChanged += new System.EventHandler(this.listBoxClientes_SelectedIndexChanged);
            // 
            // buttonFiltrar
            // 
            this.buttonFiltrar.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.buttonFiltrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFiltrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFiltrar.Location = new System.Drawing.Point(33, 492);
            this.buttonFiltrar.Margin = new System.Windows.Forms.Padding(0);
            this.buttonFiltrar.Name = "buttonFiltrar";
            this.buttonFiltrar.Size = new System.Drawing.Size(207, 40);
            this.buttonFiltrar.TabIndex = 2;
            this.buttonFiltrar.Text = "Filtrar por Nome";
            this.buttonFiltrar.UseVisualStyleBackColor = false;
            this.buttonFiltrar.Click += new System.EventHandler(this.buttonFiltrar_Click);
            // 
            // labelMoradaCliente
            // 
            this.labelMoradaCliente.AutoSize = true;
            this.labelMoradaCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMoradaCliente.Location = new System.Drawing.Point(293, 74);
            this.labelMoradaCliente.Name = "labelMoradaCliente";
            this.labelMoradaCliente.Size = new System.Drawing.Size(13, 18);
            this.labelMoradaCliente.TabIndex = 11;
            this.labelMoradaCliente.Text = "-";
            // 
            // labelNumeroCliente
            // 
            this.labelNumeroCliente.AutoSize = true;
            this.labelNumeroCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumeroCliente.Location = new System.Drawing.Point(293, 47);
            this.labelNumeroCliente.Name = "labelNumeroCliente";
            this.labelNumeroCliente.Size = new System.Drawing.Size(13, 18);
            this.labelNumeroCliente.TabIndex = 10;
            this.labelNumeroCliente.Text = "-";
            // 
            // labelNomeCliente
            // 
            this.labelNomeCliente.AutoSize = true;
            this.labelNomeCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNomeCliente.Location = new System.Drawing.Point(291, 9);
            this.labelNomeCliente.Name = "labelNomeCliente";
            this.labelNomeCliente.Size = new System.Drawing.Size(319, 29);
            this.labelNomeCliente.TabIndex = 9;
            this.labelNomeCliente.Text = "Nenhum cliente selecionado";
            // 
            // groupBoxCarrosVenda
            // 
            this.groupBoxCarrosVenda.Controls.Add(this.buttonGestaoCarroDeVenda);
            this.groupBoxCarrosVenda.Controls.Add(this.buttonAddCarroDeVenda);
            this.groupBoxCarrosVenda.Controls.Add(this.listBoxCarros);
            this.groupBoxCarrosVenda.Location = new System.Drawing.Point(296, 95);
            this.groupBoxCarrosVenda.Name = "groupBoxCarrosVenda";
            this.groupBoxCarrosVenda.Size = new System.Drawing.Size(256, 459);
            this.groupBoxCarrosVenda.TabIndex = 1;
            this.groupBoxCarrosVenda.TabStop = false;
            this.groupBoxCarrosVenda.Text = "Carros de Venda";
            // 
            // buttonGestaoCarroDeVenda
            // 
            this.buttonGestaoCarroDeVenda.BackColor = System.Drawing.Color.Wheat;
            this.buttonGestaoCarroDeVenda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGestaoCarroDeVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGestaoCarroDeVenda.Location = new System.Drawing.Point(6, 409);
            this.buttonGestaoCarroDeVenda.Margin = new System.Windows.Forms.Padding(0);
            this.buttonGestaoCarroDeVenda.Name = "buttonGestaoCarroDeVenda";
            this.buttonGestaoCarroDeVenda.Size = new System.Drawing.Size(244, 40);
            this.buttonGestaoCarroDeVenda.TabIndex = 2;
            this.buttonGestaoCarroDeVenda.Text = "Gerir Carro de Venda";
            this.buttonGestaoCarroDeVenda.UseVisualStyleBackColor = false;
            this.buttonGestaoCarroDeVenda.Click += new System.EventHandler(this.buttonGestaoCarroDeVenda_Click);
            // 
            // buttonAddCarroDeVenda
            // 
            this.buttonAddCarroDeVenda.BackColor = System.Drawing.Color.Aquamarine;
            this.buttonAddCarroDeVenda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddCarroDeVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddCarroDeVenda.Location = new System.Drawing.Point(6, 356);
            this.buttonAddCarroDeVenda.Margin = new System.Windows.Forms.Padding(0);
            this.buttonAddCarroDeVenda.Name = "buttonAddCarroDeVenda";
            this.buttonAddCarroDeVenda.Size = new System.Drawing.Size(244, 40);
            this.buttonAddCarroDeVenda.TabIndex = 1;
            this.buttonAddCarroDeVenda.Text = "Adicionar Carro de Venda";
            this.buttonAddCarroDeVenda.UseVisualStyleBackColor = false;
            this.buttonAddCarroDeVenda.Click += new System.EventHandler(this.buttonAddCarroDeVenda_Click);
            // 
            // listBoxCarros
            // 
            this.listBoxCarros.FormattingEnabled = true;
            this.listBoxCarros.HorizontalScrollbar = true;
            this.listBoxCarros.Location = new System.Drawing.Point(6, 19);
            this.listBoxCarros.Name = "listBoxCarros";
            this.listBoxCarros.Size = new System.Drawing.Size(244, 329);
            this.listBoxCarros.TabIndex = 0;
            this.listBoxCarros.SelectedIndexChanged += new System.EventHandler(this.listBoxCarros_SelectedIndexChanged);
            // 
            // labelDataVenda
            // 
            this.labelDataVenda.AutoSize = true;
            this.labelDataVenda.Location = new System.Drawing.Point(558, 205);
            this.labelDataVenda.Name = "labelDataVenda";
            this.labelDataVenda.Size = new System.Drawing.Size(82, 13);
            this.labelDataVenda.TabIndex = 6;
            this.labelDataVenda.Text = "Data de Venda:";
            // 
            // labelEstado
            // 
            this.labelEstado.AutoSize = true;
            this.labelEstado.Location = new System.Drawing.Point(558, 150);
            this.labelEstado.Name = "labelEstado";
            this.labelEstado.Size = new System.Drawing.Size(46, 13);
            this.labelEstado.TabIndex = 4;
            this.labelEstado.Text = "Estado :";
            // 
            // labelValor
            // 
            this.labelValor.AutoSize = true;
            this.labelValor.Location = new System.Drawing.Point(558, 95);
            this.labelValor.Name = "labelValor";
            this.labelValor.Size = new System.Drawing.Size(37, 13);
            this.labelValor.TabIndex = 2;
            this.labelValor.Text = "Valor :";
            // 
            // textBoxEstado
            // 
            this.textBoxEstado.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.textBoxEstado.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBoxEstado.Location = new System.Drawing.Point(561, 166);
            this.textBoxEstado.Name = "textBoxEstado";
            this.textBoxEstado.Size = new System.Drawing.Size(200, 20);
            this.textBoxEstado.TabIndex = 5;
            // 
            // textBoxValor
            // 
            this.textBoxValor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.textBoxValor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBoxValor.Location = new System.Drawing.Point(561, 111);
            this.textBoxValor.MaxLength = 9;
            this.textBoxValor.Name = "textBoxValor";
            this.textBoxValor.Size = new System.Drawing.Size(200, 20);
            this.textBoxValor.TabIndex = 3;
            this.textBoxValor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxValor_KeyPress);
            // 
            // dateTimePickerVenda
            // 
            this.dateTimePickerVenda.Location = new System.Drawing.Point(561, 221);
            this.dateTimePickerVenda.Name = "dateTimePickerVenda";
            this.dateTimePickerVenda.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerVenda.TabIndex = 7;
            // 
            // groupBoxVendas
            // 
            this.groupBoxVendas.Controls.Add(this.buttonImprimir);
            this.groupBoxVendas.Controls.Add(this.buttonCriarVenda);
            this.groupBoxVendas.Controls.Add(this.listBoxVendas);
            this.groupBoxVendas.Location = new System.Drawing.Point(767, 95);
            this.groupBoxVendas.Name = "groupBoxVendas";
            this.groupBoxVendas.Size = new System.Drawing.Size(316, 459);
            this.groupBoxVendas.TabIndex = 8;
            this.groupBoxVendas.TabStop = false;
            this.groupBoxVendas.Text = "Vendas";
            // 
            // buttonImprimir
            // 
            this.buttonImprimir.BackColor = System.Drawing.Color.Silver;
            this.buttonImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonImprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.buttonImprimir.Location = new System.Drawing.Point(6, 417);
            this.buttonImprimir.Name = "buttonImprimir";
            this.buttonImprimir.Size = new System.Drawing.Size(304, 40);
            this.buttonImprimir.TabIndex = 2;
            this.buttonImprimir.Text = "Imprimir Recibo";
            this.buttonImprimir.UseVisualStyleBackColor = false;
            this.buttonImprimir.Click += new System.EventHandler(this.buttonImprimir_Click);
            // 
            // buttonCriarVenda
            // 
            this.buttonCriarVenda.BackColor = System.Drawing.Color.Aquamarine;
            this.buttonCriarVenda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCriarVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.buttonCriarVenda.Location = new System.Drawing.Point(6, 371);
            this.buttonCriarVenda.Name = "buttonCriarVenda";
            this.buttonCriarVenda.Size = new System.Drawing.Size(304, 40);
            this.buttonCriarVenda.TabIndex = 1;
            this.buttonCriarVenda.Text = "Criar Venda";
            this.buttonCriarVenda.UseVisualStyleBackColor = false;
            this.buttonCriarVenda.Click += new System.EventHandler(this.buttonCriarVenda_Click);
            // 
            // listBoxVendas
            // 
            this.listBoxVendas.FormattingEnabled = true;
            this.listBoxVendas.HorizontalScrollbar = true;
            this.listBoxVendas.Location = new System.Drawing.Point(6, 19);
            this.listBoxVendas.Name = "listBoxVendas";
            this.listBoxVendas.Size = new System.Drawing.Size(304, 342);
            this.listBoxVendas.TabIndex = 0;
            this.listBoxVendas.SelectedIndexChanged += new System.EventHandler(this.listBoxVendas_SelectedIndexChanged);
            // 
            // VendasPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 556);
            this.Controls.Add(this.groupBoxVendas);
            this.Controls.Add(this.labelDataVenda);
            this.Controls.Add(this.labelEstado);
            this.Controls.Add(this.labelValor);
            this.Controls.Add(this.textBoxEstado);
            this.Controls.Add(this.textBoxValor);
            this.Controls.Add(this.dateTimePickerVenda);
            this.Controls.Add(this.groupBoxCarrosVenda);
            this.Controls.Add(this.labelMoradaCliente);
            this.Controls.Add(this.labelNumeroCliente);
            this.Controls.Add(this.labelNomeCliente);
            this.Controls.Add(this.groupBoxClientes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "VendasPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestão das Vendas";
            this.Load += new System.EventHandler(this.VendasPrincipal_Load);
            this.groupBoxClientes.ResumeLayout(false);
            this.groupBoxClientes.PerformLayout();
            this.groupBoxCarrosVenda.ResumeLayout(false);
            this.groupBoxVendas.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxClientes;
        private System.Windows.Forms.TextBox textBoxFiltrar;
        private System.Windows.Forms.ListBox listBoxClientes;
        private System.Windows.Forms.Button buttonFiltrar;
        private System.Windows.Forms.Label labelMoradaCliente;
        private System.Windows.Forms.Label labelNumeroCliente;
        private System.Windows.Forms.Label labelNomeCliente;
        private System.Windows.Forms.GroupBox groupBoxCarrosVenda;
        private System.Windows.Forms.Button buttonGestaoCarroDeVenda;
        private System.Windows.Forms.Button buttonAddCarroDeVenda;
        private System.Windows.Forms.ListBox listBoxCarros;
        private System.Windows.Forms.Label labelDataVenda;
        private System.Windows.Forms.Label labelEstado;
        private System.Windows.Forms.Label labelValor;
        private System.Windows.Forms.TextBox textBoxEstado;
        private System.Windows.Forms.TextBox textBoxValor;
        private System.Windows.Forms.DateTimePicker dateTimePickerVenda;
        private System.Windows.Forms.GroupBox groupBoxVendas;
        private System.Windows.Forms.Button buttonCriarVenda;
        private System.Windows.Forms.ListBox listBoxVendas;
        private System.Windows.Forms.Button buttonImprimir;
    }
}