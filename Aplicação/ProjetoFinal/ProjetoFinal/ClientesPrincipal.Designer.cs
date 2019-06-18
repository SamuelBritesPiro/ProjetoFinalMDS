namespace ProjetoFinal
{
    partial class ClientesPrincipal
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
            this.textBoxNIF = new System.Windows.Forms.TextBox();
            this.textBoxMorada = new System.Windows.Forms.TextBox();
            this.textBoxContacto = new System.Windows.Forms.TextBox();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.labelNifCliente = new System.Windows.Forms.Label();
            this.labelMoradaCliente = new System.Windows.Forms.Label();
            this.labelContactoCliente = new System.Windows.Forms.Label();
            this.labelNomeCliente = new System.Windows.Forms.Label();
            this.listBoxClientes = new System.Windows.Forms.ListBox();
            this.groupBoxListaClientes = new System.Windows.Forms.GroupBox();
            this.textBoxFiltrar = new System.Windows.Forms.TextBox();
            this.buttonFiltrar = new System.Windows.Forms.Button();
            this.groupBoxInformacaoCliente = new System.Windows.Forms.GroupBox();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.buttonEditar = new System.Windows.Forms.Button();
            this.buttonAdicionar = new System.Windows.Forms.Button();
            this.groupBoxListaClientes.SuspendLayout();
            this.groupBoxInformacaoCliente.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxNIF
            // 
            this.textBoxNIF.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.textBoxNIF.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBoxNIF.Location = new System.Drawing.Point(75, 196);
            this.textBoxNIF.MaxLength = 9;
            this.textBoxNIF.Name = "textBoxNIF";
            this.textBoxNIF.Size = new System.Drawing.Size(295, 20);
            this.textBoxNIF.TabIndex = 3;
            this.textBoxNIF.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNIF_KeyPress);
            // 
            // textBoxMorada
            // 
            this.textBoxMorada.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.textBoxMorada.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBoxMorada.Location = new System.Drawing.Point(75, 149);
            this.textBoxMorada.Name = "textBoxMorada";
            this.textBoxMorada.Size = new System.Drawing.Size(295, 20);
            this.textBoxMorada.TabIndex = 2;
            // 
            // textBoxContacto
            // 
            this.textBoxContacto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.textBoxContacto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBoxContacto.Location = new System.Drawing.Point(75, 102);
            this.textBoxContacto.MaxLength = 9;
            this.textBoxContacto.Name = "textBoxContacto";
            this.textBoxContacto.Size = new System.Drawing.Size(295, 20);
            this.textBoxContacto.TabIndex = 1;
            this.textBoxContacto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxContacto_KeyPress);
            // 
            // textBoxNome
            // 
            this.textBoxNome.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.textBoxNome.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBoxNome.Location = new System.Drawing.Point(75, 55);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(295, 20);
            this.textBoxNome.TabIndex = 0;
            // 
            // labelNifCliente
            // 
            this.labelNifCliente.Location = new System.Drawing.Point(13, 196);
            this.labelNifCliente.Name = "labelNifCliente";
            this.labelNifCliente.Size = new System.Drawing.Size(57, 20);
            this.labelNifCliente.TabIndex = 6;
            this.labelNifCliente.Text = "NIF:";
            this.labelNifCliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelMoradaCliente
            // 
            this.labelMoradaCliente.Location = new System.Drawing.Point(13, 149);
            this.labelMoradaCliente.Name = "labelMoradaCliente";
            this.labelMoradaCliente.Size = new System.Drawing.Size(57, 20);
            this.labelMoradaCliente.TabIndex = 4;
            this.labelMoradaCliente.Text = "Morada: ";
            this.labelMoradaCliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelContactoCliente
            // 
            this.labelContactoCliente.Location = new System.Drawing.Point(13, 102);
            this.labelContactoCliente.Name = "labelContactoCliente";
            this.labelContactoCliente.Size = new System.Drawing.Size(57, 20);
            this.labelContactoCliente.TabIndex = 2;
            this.labelContactoCliente.Text = "Contacto: ";
            this.labelContactoCliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelNomeCliente
            // 
            this.labelNomeCliente.Location = new System.Drawing.Point(13, 55);
            this.labelNomeCliente.Name = "labelNomeCliente";
            this.labelNomeCliente.Size = new System.Drawing.Size(57, 20);
            this.labelNomeCliente.TabIndex = 0;
            this.labelNomeCliente.Text = "Nome: ";
            this.labelNomeCliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // listBoxClientes
            // 
            this.listBoxClientes.FormattingEnabled = true;
            this.listBoxClientes.HorizontalScrollbar = true;
            this.listBoxClientes.Location = new System.Drawing.Point(6, 22);
            this.listBoxClientes.Name = "listBoxClientes";
            this.listBoxClientes.Size = new System.Drawing.Size(356, 238);
            this.listBoxClientes.TabIndex = 0;
            this.listBoxClientes.TabStop = false;
            this.listBoxClientes.SelectedIndexChanged += new System.EventHandler(this.listBoxClientes_SelectedIndexChanged);
            // 
            // groupBoxListaClientes
            // 
            this.groupBoxListaClientes.Controls.Add(this.textBoxFiltrar);
            this.groupBoxListaClientes.Controls.Add(this.buttonFiltrar);
            this.groupBoxListaClientes.Controls.Add(this.listBoxClientes);
            this.groupBoxListaClientes.Location = new System.Drawing.Point(12, 10);
            this.groupBoxListaClientes.Name = "groupBoxListaClientes";
            this.groupBoxListaClientes.Size = new System.Drawing.Size(369, 310);
            this.groupBoxListaClientes.TabIndex = 0;
            this.groupBoxListaClientes.TabStop = false;
            this.groupBoxListaClientes.Text = "Lista de Clientes";
            // 
            // textBoxFiltrar
            // 
            this.textBoxFiltrar.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.textBoxFiltrar.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBoxFiltrar.Location = new System.Drawing.Point(6, 273);
            this.textBoxFiltrar.Name = "textBoxFiltrar";
            this.textBoxFiltrar.Size = new System.Drawing.Size(253, 20);
            this.textBoxFiltrar.TabIndex = 1;
            this.textBoxFiltrar.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBoxFiltrar_KeyUp);
            // 
            // buttonFiltrar
            // 
            this.buttonFiltrar.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.buttonFiltrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFiltrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFiltrar.Location = new System.Drawing.Point(262, 263);
            this.buttonFiltrar.Margin = new System.Windows.Forms.Padding(0);
            this.buttonFiltrar.Name = "buttonFiltrar";
            this.buttonFiltrar.Size = new System.Drawing.Size(100, 40);
            this.buttonFiltrar.TabIndex = 2;
            this.buttonFiltrar.Text = "Filtrar por Nome";
            this.buttonFiltrar.UseVisualStyleBackColor = false;
            this.buttonFiltrar.Click += new System.EventHandler(this.buttonFiltrar_Click);
            // 
            // groupBoxInformacaoCliente
            // 
            this.groupBoxInformacaoCliente.Controls.Add(this.buttonEliminar);
            this.groupBoxInformacaoCliente.Controls.Add(this.buttonEditar);
            this.groupBoxInformacaoCliente.Controls.Add(this.buttonAdicionar);
            this.groupBoxInformacaoCliente.Controls.Add(this.textBoxNIF);
            this.groupBoxInformacaoCliente.Controls.Add(this.textBoxMorada);
            this.groupBoxInformacaoCliente.Controls.Add(this.textBoxContacto);
            this.groupBoxInformacaoCliente.Controls.Add(this.textBoxNome);
            this.groupBoxInformacaoCliente.Controls.Add(this.labelNifCliente);
            this.groupBoxInformacaoCliente.Controls.Add(this.labelMoradaCliente);
            this.groupBoxInformacaoCliente.Controls.Add(this.labelContactoCliente);
            this.groupBoxInformacaoCliente.Controls.Add(this.labelNomeCliente);
            this.groupBoxInformacaoCliente.Location = new System.Drawing.Point(387, 10);
            this.groupBoxInformacaoCliente.Name = "groupBoxInformacaoCliente";
            this.groupBoxInformacaoCliente.Size = new System.Drawing.Size(382, 310);
            this.groupBoxInformacaoCliente.TabIndex = 1;
            this.groupBoxInformacaoCliente.TabStop = false;
            this.groupBoxInformacaoCliente.Text = "Informação do Cliente";
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.BackColor = System.Drawing.Color.Red;
            this.buttonEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEliminar.Location = new System.Drawing.Point(279, 262);
            this.buttonEliminar.Margin = new System.Windows.Forms.Padding(0);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(100, 40);
            this.buttonEliminar.TabIndex = 6;
            this.buttonEliminar.Text = "Eliminar";
            this.buttonEliminar.UseVisualStyleBackColor = false;
            this.buttonEliminar.Click += new System.EventHandler(this.buttonEliminar_Click);
            // 
            // buttonEditar
            // 
            this.buttonEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.buttonEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEditar.Location = new System.Drawing.Point(141, 263);
            this.buttonEditar.Margin = new System.Windows.Forms.Padding(0);
            this.buttonEditar.Name = "buttonEditar";
            this.buttonEditar.Size = new System.Drawing.Size(100, 40);
            this.buttonEditar.TabIndex = 5;
            this.buttonEditar.Text = "Editar";
            this.buttonEditar.UseVisualStyleBackColor = false;
            this.buttonEditar.Click += new System.EventHandler(this.buttonEditar_Click);
            // 
            // buttonAdicionar
            // 
            this.buttonAdicionar.BackColor = System.Drawing.Color.Aquamarine;
            this.buttonAdicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdicionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdicionar.Location = new System.Drawing.Point(3, 262);
            this.buttonAdicionar.Margin = new System.Windows.Forms.Padding(0);
            this.buttonAdicionar.Name = "buttonAdicionar";
            this.buttonAdicionar.Size = new System.Drawing.Size(100, 40);
            this.buttonAdicionar.TabIndex = 4;
            this.buttonAdicionar.Text = "Adicionar";
            this.buttonAdicionar.UseVisualStyleBackColor = false;
            this.buttonAdicionar.Click += new System.EventHandler(this.buttonAdicionar_Click);
            // 
            // ClientesPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 326);
            this.Controls.Add(this.groupBoxListaClientes);
            this.Controls.Add(this.groupBoxInformacaoCliente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ClientesPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestão de Clientes";
            this.Load += new System.EventHandler(this.GestaoDeClientesPrincipal_Load);
            this.groupBoxListaClientes.ResumeLayout(false);
            this.groupBoxListaClientes.PerformLayout();
            this.groupBoxInformacaoCliente.ResumeLayout(false);
            this.groupBoxInformacaoCliente.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxNIF;
        private System.Windows.Forms.TextBox textBoxMorada;
        private System.Windows.Forms.TextBox textBoxContacto;
        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.Label labelNifCliente;
        private System.Windows.Forms.Label labelMoradaCliente;
        private System.Windows.Forms.Label labelContactoCliente;
        private System.Windows.Forms.Label labelNomeCliente;
        private System.Windows.Forms.ListBox listBoxClientes;
        private System.Windows.Forms.GroupBox groupBoxListaClientes;
        private System.Windows.Forms.GroupBox groupBoxInformacaoCliente;
        private System.Windows.Forms.Button buttonAdicionar;
        private System.Windows.Forms.Button buttonEliminar;
        private System.Windows.Forms.Button buttonEditar;
        private System.Windows.Forms.Button buttonFiltrar;
        private System.Windows.Forms.TextBox textBoxFiltrar;
    }
}