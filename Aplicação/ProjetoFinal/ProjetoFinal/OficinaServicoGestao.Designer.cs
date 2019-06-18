namespace ProjetoFinal
{
    partial class OficinaServicoGestao
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
            this.groupBoxInformacaoServico = new System.Windows.Forms.GroupBox();
            this.dateTimePickerEntrada = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerSaida = new System.Windows.Forms.DateTimePicker();
            this.textBoxTipo = new System.Windows.Forms.TextBox();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.buttonEditar = new System.Windows.Forms.Button();
            this.labelDataSaida = new System.Windows.Forms.Label();
            this.labelTipo = new System.Windows.Forms.Label();
            this.labelDataEntrada = new System.Windows.Forms.Label();
            this.groupBoxInformacaoServico.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxInformacaoServico
            // 
            this.groupBoxInformacaoServico.Controls.Add(this.labelDataSaida);
            this.groupBoxInformacaoServico.Controls.Add(this.labelTipo);
            this.groupBoxInformacaoServico.Controls.Add(this.labelDataEntrada);
            this.groupBoxInformacaoServico.Controls.Add(this.dateTimePickerEntrada);
            this.groupBoxInformacaoServico.Controls.Add(this.dateTimePickerSaida);
            this.groupBoxInformacaoServico.Controls.Add(this.textBoxTipo);
            this.groupBoxInformacaoServico.Controls.Add(this.buttonEliminar);
            this.groupBoxInformacaoServico.Controls.Add(this.buttonEditar);
            this.groupBoxInformacaoServico.Location = new System.Drawing.Point(12, 12);
            this.groupBoxInformacaoServico.Name = "groupBoxInformacaoServico";
            this.groupBoxInformacaoServico.Size = new System.Drawing.Size(355, 169);
            this.groupBoxInformacaoServico.TabIndex = 0;
            this.groupBoxInformacaoServico.TabStop = false;
            this.groupBoxInformacaoServico.Text = "Informação do Serviço";
            // 
            // dateTimePickerEntrada
            // 
            this.dateTimePickerEntrada.Checked = false;
            this.dateTimePickerEntrada.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerEntrada.Location = new System.Drawing.Point(113, 34);
            this.dateTimePickerEntrada.Name = "dateTimePickerEntrada";
            this.dateTimePickerEntrada.Size = new System.Drawing.Size(235, 20);
            this.dateTimePickerEntrada.TabIndex = 0;
            // 
            // dateTimePickerSaida
            // 
            this.dateTimePickerSaida.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerSaida.Location = new System.Drawing.Point(113, 88);
            this.dateTimePickerSaida.Name = "dateTimePickerSaida";
            this.dateTimePickerSaida.Size = new System.Drawing.Size(235, 20);
            this.dateTimePickerSaida.TabIndex = 2;
            // 
            // textBoxTipo
            // 
            this.textBoxTipo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.textBoxTipo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBoxTipo.Location = new System.Drawing.Point(113, 61);
            this.textBoxTipo.Name = "textBoxTipo";
            this.textBoxTipo.Size = new System.Drawing.Size(235, 20);
            this.textBoxTipo.TabIndex = 1;
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.BackColor = System.Drawing.Color.Red;
            this.buttonEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEliminar.Location = new System.Drawing.Point(252, 126);
            this.buttonEliminar.Margin = new System.Windows.Forms.Padding(0);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(100, 40);
            this.buttonEliminar.TabIndex = 4;
            this.buttonEliminar.Text = "Eliminar";
            this.buttonEliminar.UseVisualStyleBackColor = false;
            this.buttonEliminar.Click += new System.EventHandler(this.buttonEliminar_Click);
            // 
            // buttonEditar
            // 
            this.buttonEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.buttonEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEditar.Location = new System.Drawing.Point(3, 126);
            this.buttonEditar.Margin = new System.Windows.Forms.Padding(0);
            this.buttonEditar.Name = "buttonEditar";
            this.buttonEditar.Size = new System.Drawing.Size(100, 40);
            this.buttonEditar.TabIndex = 3;
            this.buttonEditar.Text = "Editar";
            this.buttonEditar.UseVisualStyleBackColor = false;
            this.buttonEditar.Click += new System.EventHandler(this.buttonEditar_Click);
            // 
            // labelDataSaida
            // 
            this.labelDataSaida.Location = new System.Drawing.Point(6, 88);
            this.labelDataSaida.Name = "labelDataSaida";
            this.labelDataSaida.Size = new System.Drawing.Size(101, 20);
            this.labelDataSaida.TabIndex = 7;
            this.labelDataSaida.Text = "Data de Saída:";
            this.labelDataSaida.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelTipo
            // 
            this.labelTipo.Location = new System.Drawing.Point(6, 61);
            this.labelTipo.Name = "labelTipo";
            this.labelTipo.Size = new System.Drawing.Size(101, 20);
            this.labelTipo.TabIndex = 6;
            this.labelTipo.Text = "Tipo:";
            this.labelTipo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelDataEntrada
            // 
            this.labelDataEntrada.Location = new System.Drawing.Point(6, 34);
            this.labelDataEntrada.Name = "labelDataEntrada";
            this.labelDataEntrada.Size = new System.Drawing.Size(101, 20);
            this.labelDataEntrada.TabIndex = 5;
            this.labelDataEntrada.Text = "Data de Entrada:";
            this.labelDataEntrada.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // OficinaServicoGestao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 186);
            this.Controls.Add(this.groupBoxInformacaoServico);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "OficinaServicoGestao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestão de Serviços";
            this.Load += new System.EventHandler(this.OficinaServicoGestao_Load);
            this.groupBoxInformacaoServico.ResumeLayout(false);
            this.groupBoxInformacaoServico.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBoxInformacaoServico;
        private System.Windows.Forms.Button buttonEliminar;
        private System.Windows.Forms.Button buttonEditar;
        private System.Windows.Forms.DateTimePicker dateTimePickerEntrada;
        private System.Windows.Forms.DateTimePicker dateTimePickerSaida;
        private System.Windows.Forms.TextBox textBoxTipo;
        private System.Windows.Forms.Label labelDataSaida;
        private System.Windows.Forms.Label labelTipo;
        private System.Windows.Forms.Label labelDataEntrada;
    }
}