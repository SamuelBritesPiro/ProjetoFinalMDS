namespace ProjetoFinal
{
    partial class AlugueresPrincipal
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
            this.listBoxClientes = new System.Windows.Forms.ListBox();
            this.buttonGestaoCarroDeAluguer = new System.Windows.Forms.Button();
            this.buttonAddCarroDeAluguer = new System.Windows.Forms.Button();
            this.listBoxCarros = new System.Windows.Forms.ListBox();
            this.buttonCriarAluguer = new System.Windows.Forms.Button();
            this.buttonEliminarAluguer = new System.Windows.Forms.Button();
            this.listBoxAlugueres = new System.Windows.Forms.ListBox();
            this.labelDataInicio = new System.Windows.Forms.Label();
            this.labelKms = new System.Windows.Forms.Label();
            this.labelValor = new System.Windows.Forms.Label();
            this.textBoxKms = new System.Windows.Forms.TextBox();
            this.textBoxValor = new System.Windows.Forms.TextBox();
            this.dateTimePickerInicio = new System.Windows.Forms.DateTimePicker();
            this.labelMoradaCliente = new System.Windows.Forms.Label();
            this.labelNumeroCliente = new System.Windows.Forms.Label();
            this.labelNomeCliente = new System.Windows.Forms.Label();
            this.groupBoxAlugueres = new System.Windows.Forms.GroupBox();
            this.buttonImprimir = new System.Windows.Forms.Button();
            this.groupBoxCarrosAluguer = new System.Windows.Forms.GroupBox();
            this.groupBoxClientes = new System.Windows.Forms.GroupBox();
            this.textBoxFiltrar = new System.Windows.Forms.TextBox();
            this.buttonFiltrar = new System.Windows.Forms.Button();
            this.labelDataFim = new System.Windows.Forms.Label();
            this.dateTimePickerFim = new System.Windows.Forms.DateTimePicker();
            this.groupBoxAlugueres.SuspendLayout();
            this.groupBoxCarrosAluguer.SuspendLayout();
            this.groupBoxClientes.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxClientes
            // 
            this.listBoxClientes.FormattingEnabled = true;
            this.listBoxClientes.HorizontalScrollbar = true;
            this.listBoxClientes.Location = new System.Drawing.Point(8, 19);
            this.listBoxClientes.Name = "listBoxClientes";
            this.listBoxClientes.Size = new System.Drawing.Size(259, 511);
            this.listBoxClientes.TabIndex = 0;
            this.listBoxClientes.SelectedIndexChanged += new System.EventHandler(this.listBoxClientes_SelectedIndexChanged);
            // 
            // buttonGestaoCarroDeAluguer
            // 
            this.buttonGestaoCarroDeAluguer.BackColor = System.Drawing.Color.Wheat;
            this.buttonGestaoCarroDeAluguer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGestaoCarroDeAluguer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGestaoCarroDeAluguer.Location = new System.Drawing.Point(6, 440);
            this.buttonGestaoCarroDeAluguer.Margin = new System.Windows.Forms.Padding(0);
            this.buttonGestaoCarroDeAluguer.Name = "buttonGestaoCarroDeAluguer";
            this.buttonGestaoCarroDeAluguer.Size = new System.Drawing.Size(244, 40);
            this.buttonGestaoCarroDeAluguer.TabIndex = 2;
            this.buttonGestaoCarroDeAluguer.Text = "Gerir Carro de Aluguer";
            this.buttonGestaoCarroDeAluguer.UseVisualStyleBackColor = false;
            this.buttonGestaoCarroDeAluguer.Click += new System.EventHandler(this.buttonGestaoCarroDeAluguer_Click);
            // 
            // buttonAddCarroDeAluguer
            // 
            this.buttonAddCarroDeAluguer.BackColor = System.Drawing.Color.Aquamarine;
            this.buttonAddCarroDeAluguer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddCarroDeAluguer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddCarroDeAluguer.Location = new System.Drawing.Point(6, 396);
            this.buttonAddCarroDeAluguer.Margin = new System.Windows.Forms.Padding(0);
            this.buttonAddCarroDeAluguer.Name = "buttonAddCarroDeAluguer";
            this.buttonAddCarroDeAluguer.Size = new System.Drawing.Size(244, 40);
            this.buttonAddCarroDeAluguer.TabIndex = 1;
            this.buttonAddCarroDeAluguer.Text = "Adicionar Carro de Aluguer";
            this.buttonAddCarroDeAluguer.UseVisualStyleBackColor = false;
            this.buttonAddCarroDeAluguer.Click += new System.EventHandler(this.buttonAddCarro_Click);
            // 
            // listBoxCarros
            // 
            this.listBoxCarros.FormattingEnabled = true;
            this.listBoxCarros.HorizontalScrollbar = true;
            this.listBoxCarros.Location = new System.Drawing.Point(6, 19);
            this.listBoxCarros.Name = "listBoxCarros";
            this.listBoxCarros.Size = new System.Drawing.Size(244, 368);
            this.listBoxCarros.TabIndex = 0;
            this.listBoxCarros.SelectedIndexChanged += new System.EventHandler(this.listBoxCarros_SelectedIndexChanged);
            // 
            // buttonCriarAluguer
            // 
            this.buttonCriarAluguer.BackColor = System.Drawing.Color.Aquamarine;
            this.buttonCriarAluguer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCriarAluguer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.buttonCriarAluguer.Location = new System.Drawing.Point(6, 359);
            this.buttonCriarAluguer.Name = "buttonCriarAluguer";
            this.buttonCriarAluguer.Size = new System.Drawing.Size(304, 35);
            this.buttonCriarAluguer.TabIndex = 1;
            this.buttonCriarAluguer.Text = "Criar Aluguer";
            this.buttonCriarAluguer.UseVisualStyleBackColor = false;
            this.buttonCriarAluguer.Click += new System.EventHandler(this.buttonCriarAluguer_Click);
            // 
            // buttonEliminarAluguer
            // 
            this.buttonEliminarAluguer.BackColor = System.Drawing.Color.Red;
            this.buttonEliminarAluguer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEliminarAluguer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.buttonEliminarAluguer.Location = new System.Drawing.Point(6, 402);
            this.buttonEliminarAluguer.Name = "buttonEliminarAluguer";
            this.buttonEliminarAluguer.Size = new System.Drawing.Size(304, 35);
            this.buttonEliminarAluguer.TabIndex = 2;
            this.buttonEliminarAluguer.Text = "Eliminar Aluguer";
            this.buttonEliminarAluguer.UseVisualStyleBackColor = false;
            this.buttonEliminarAluguer.Click += new System.EventHandler(this.buttonEliminarAluguer_Click);
            // 
            // listBoxAlugueres
            // 
            this.listBoxAlugueres.FormattingEnabled = true;
            this.listBoxAlugueres.HorizontalScrollbar = true;
            this.listBoxAlugueres.Location = new System.Drawing.Point(6, 19);
            this.listBoxAlugueres.Name = "listBoxAlugueres";
            this.listBoxAlugueres.Size = new System.Drawing.Size(304, 329);
            this.listBoxAlugueres.TabIndex = 0;
            this.listBoxAlugueres.SelectedIndexChanged += new System.EventHandler(this.listBoxAlugueres_SelectedIndexChanged);
            // 
            // labelDataInicio
            // 
            this.labelDataInicio.AutoSize = true;
            this.labelDataInicio.Location = new System.Drawing.Point(553, 130);
            this.labelDataInicio.Name = "labelDataInicio";
            this.labelDataInicio.Size = new System.Drawing.Size(78, 13);
            this.labelDataInicio.TabIndex = 2;
            this.labelDataInicio.Text = "Data de Início:";
            // 
            // labelKms
            // 
            this.labelKms.AutoSize = true;
            this.labelKms.Location = new System.Drawing.Point(553, 233);
            this.labelKms.Name = "labelKms";
            this.labelKms.Size = new System.Drawing.Size(33, 13);
            this.labelKms.TabIndex = 6;
            this.labelKms.Text = "Kms :";
            // 
            // labelValor
            // 
            this.labelValor.AutoSize = true;
            this.labelValor.Location = new System.Drawing.Point(553, 288);
            this.labelValor.Name = "labelValor";
            this.labelValor.Size = new System.Drawing.Size(37, 13);
            this.labelValor.TabIndex = 8;
            this.labelValor.Text = "Valor :";
            // 
            // textBoxKms
            // 
            this.textBoxKms.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.textBoxKms.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBoxKms.Location = new System.Drawing.Point(556, 249);
            this.textBoxKms.MaxLength = 9;
            this.textBoxKms.Name = "textBoxKms";
            this.textBoxKms.Size = new System.Drawing.Size(200, 20);
            this.textBoxKms.TabIndex = 7;
            this.textBoxKms.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxKms_KeyPress);
            // 
            // textBoxValor
            // 
            this.textBoxValor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.textBoxValor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBoxValor.Location = new System.Drawing.Point(556, 304);
            this.textBoxValor.MaxLength = 9;
            this.textBoxValor.Name = "textBoxValor";
            this.textBoxValor.Size = new System.Drawing.Size(200, 20);
            this.textBoxValor.TabIndex = 9;
            this.textBoxValor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxValor_KeyPress);
            // 
            // dateTimePickerInicio
            // 
            this.dateTimePickerInicio.Location = new System.Drawing.Point(556, 149);
            this.dateTimePickerInicio.Name = "dateTimePickerInicio";
            this.dateTimePickerInicio.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerInicio.TabIndex = 3;
            // 
            // labelMoradaCliente
            // 
            this.labelMoradaCliente.AutoSize = true;
            this.labelMoradaCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMoradaCliente.Location = new System.Drawing.Point(312, 80);
            this.labelMoradaCliente.Name = "labelMoradaCliente";
            this.labelMoradaCliente.Size = new System.Drawing.Size(13, 18);
            this.labelMoradaCliente.TabIndex = 13;
            this.labelMoradaCliente.Text = "-";
            // 
            // labelNumeroCliente
            // 
            this.labelNumeroCliente.AutoSize = true;
            this.labelNumeroCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumeroCliente.Location = new System.Drawing.Point(312, 50);
            this.labelNumeroCliente.Name = "labelNumeroCliente";
            this.labelNumeroCliente.Size = new System.Drawing.Size(13, 18);
            this.labelNumeroCliente.TabIndex = 12;
            this.labelNumeroCliente.Text = "-";
            // 
            // labelNomeCliente
            // 
            this.labelNomeCliente.AutoSize = true;
            this.labelNomeCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNomeCliente.Location = new System.Drawing.Point(312, 12);
            this.labelNomeCliente.Name = "labelNomeCliente";
            this.labelNomeCliente.Size = new System.Drawing.Size(278, 29);
            this.labelNomeCliente.TabIndex = 11;
            this.labelNomeCliente.Text = "Sem cliente selecionado";
            // 
            // groupBoxAlugueres
            // 
            this.groupBoxAlugueres.Controls.Add(this.buttonImprimir);
            this.groupBoxAlugueres.Controls.Add(this.buttonCriarAluguer);
            this.groupBoxAlugueres.Controls.Add(this.buttonEliminarAluguer);
            this.groupBoxAlugueres.Controls.Add(this.listBoxAlugueres);
            this.groupBoxAlugueres.Location = new System.Drawing.Point(762, 130);
            this.groupBoxAlugueres.Name = "groupBoxAlugueres";
            this.groupBoxAlugueres.Size = new System.Drawing.Size(316, 486);
            this.groupBoxAlugueres.TabIndex = 10;
            this.groupBoxAlugueres.TabStop = false;
            this.groupBoxAlugueres.Text = "Alugueres";
            // 
            // buttonImprimir
            // 
            this.buttonImprimir.BackColor = System.Drawing.Color.Silver;
            this.buttonImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonImprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.buttonImprimir.Location = new System.Drawing.Point(6, 445);
            this.buttonImprimir.Name = "buttonImprimir";
            this.buttonImprimir.Size = new System.Drawing.Size(304, 35);
            this.buttonImprimir.TabIndex = 3;
            this.buttonImprimir.Text = "Imprimir Recibo";
            this.buttonImprimir.UseVisualStyleBackColor = false;
            this.buttonImprimir.Click += new System.EventHandler(this.buttonImprimir_Click);
            // 
            // groupBoxCarrosAluguer
            // 
            this.groupBoxCarrosAluguer.Controls.Add(this.buttonGestaoCarroDeAluguer);
            this.groupBoxCarrosAluguer.Controls.Add(this.buttonAddCarroDeAluguer);
            this.groupBoxCarrosAluguer.Controls.Add(this.listBoxCarros);
            this.groupBoxCarrosAluguer.Location = new System.Drawing.Point(291, 130);
            this.groupBoxCarrosAluguer.Name = "groupBoxCarrosAluguer";
            this.groupBoxCarrosAluguer.Size = new System.Drawing.Size(256, 486);
            this.groupBoxCarrosAluguer.TabIndex = 1;
            this.groupBoxCarrosAluguer.TabStop = false;
            this.groupBoxCarrosAluguer.Text = "Carros de Aluguer";
            // 
            // groupBoxClientes
            // 
            this.groupBoxClientes.Controls.Add(this.textBoxFiltrar);
            this.groupBoxClientes.Controls.Add(this.buttonFiltrar);
            this.groupBoxClientes.Controls.Add(this.listBoxClientes);
            this.groupBoxClientes.Location = new System.Drawing.Point(12, 12);
            this.groupBoxClientes.Name = "groupBoxClientes";
            this.groupBoxClientes.Size = new System.Drawing.Size(273, 604);
            this.groupBoxClientes.TabIndex = 0;
            this.groupBoxClientes.TabStop = false;
            this.groupBoxClientes.Text = "Clientes";
            // 
            // textBoxFiltrar
            // 
            this.textBoxFiltrar.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.textBoxFiltrar.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBoxFiltrar.Location = new System.Drawing.Point(7, 534);
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
            this.buttonFiltrar.Location = new System.Drawing.Point(33, 557);
            this.buttonFiltrar.Margin = new System.Windows.Forms.Padding(0);
            this.buttonFiltrar.Name = "buttonFiltrar";
            this.buttonFiltrar.Size = new System.Drawing.Size(207, 40);
            this.buttonFiltrar.TabIndex = 2;
            this.buttonFiltrar.Text = "Filtrar por Nome";
            this.buttonFiltrar.UseVisualStyleBackColor = false;
            this.buttonFiltrar.Click += new System.EventHandler(this.buttonFiltrar_Click);
            // 
            // labelDataFim
            // 
            this.labelDataFim.AutoSize = true;
            this.labelDataFim.Location = new System.Drawing.Point(553, 185);
            this.labelDataFim.Name = "labelDataFim";
            this.labelDataFim.Size = new System.Drawing.Size(67, 13);
            this.labelDataFim.TabIndex = 4;
            this.labelDataFim.Text = "Data de Fim:";
            // 
            // dateTimePickerFim
            // 
            this.dateTimePickerFim.Location = new System.Drawing.Point(556, 201);
            this.dateTimePickerFim.Name = "dateTimePickerFim";
            this.dateTimePickerFim.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerFim.TabIndex = 5;
            // 
            // AlugueresPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 626);
            this.Controls.Add(this.labelDataFim);
            this.Controls.Add(this.labelDataInicio);
            this.Controls.Add(this.labelKms);
            this.Controls.Add(this.labelValor);
            this.Controls.Add(this.textBoxKms);
            this.Controls.Add(this.textBoxValor);
            this.Controls.Add(this.dateTimePickerFim);
            this.Controls.Add(this.dateTimePickerInicio);
            this.Controls.Add(this.labelMoradaCliente);
            this.Controls.Add(this.labelNumeroCliente);
            this.Controls.Add(this.labelNomeCliente);
            this.Controls.Add(this.groupBoxAlugueres);
            this.Controls.Add(this.groupBoxCarrosAluguer);
            this.Controls.Add(this.groupBoxClientes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "AlugueresPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestão de Alugueres";
            this.Load += new System.EventHandler(this.AlugueresPrincipal_Load);
            this.groupBoxAlugueres.ResumeLayout(false);
            this.groupBoxCarrosAluguer.ResumeLayout(false);
            this.groupBoxClientes.ResumeLayout(false);
            this.groupBoxClientes.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxClientes;
        private System.Windows.Forms.Button buttonGestaoCarroDeAluguer;
        private System.Windows.Forms.Button buttonAddCarroDeAluguer;
        private System.Windows.Forms.ListBox listBoxCarros;
        private System.Windows.Forms.Button buttonCriarAluguer;
        private System.Windows.Forms.Button buttonEliminarAluguer;
        private System.Windows.Forms.ListBox listBoxAlugueres;
        private System.Windows.Forms.Label labelDataInicio;
        private System.Windows.Forms.Label labelKms;
        private System.Windows.Forms.Label labelValor;
        private System.Windows.Forms.TextBox textBoxKms;
        private System.Windows.Forms.TextBox textBoxValor;
        private System.Windows.Forms.DateTimePicker dateTimePickerInicio;
        private System.Windows.Forms.Label labelMoradaCliente;
        private System.Windows.Forms.Label labelNumeroCliente;
        private System.Windows.Forms.Label labelNomeCliente;
        private System.Windows.Forms.GroupBox groupBoxAlugueres;
        private System.Windows.Forms.GroupBox groupBoxCarrosAluguer;
        private System.Windows.Forms.GroupBox groupBoxClientes;
        private System.Windows.Forms.Label labelDataFim;
        private System.Windows.Forms.DateTimePicker dateTimePickerFim;
        private System.Windows.Forms.TextBox textBoxFiltrar;
        private System.Windows.Forms.Button buttonFiltrar;
        private System.Windows.Forms.Button buttonImprimir;
    }
}