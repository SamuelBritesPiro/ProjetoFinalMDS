namespace ProjetoFinal
{
    partial class OficinaServicoAdicionar
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
            this.labelDataSaida = new System.Windows.Forms.Label();
            this.labelTipo = new System.Windows.Forms.Label();
            this.labelDataEntrada = new System.Windows.Forms.Label();
            this.buttonAdicionar = new System.Windows.Forms.Button();
            this.groupBoxInformacaoServico.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxInformacaoServico
            // 
            this.groupBoxInformacaoServico.Controls.Add(this.dateTimePickerEntrada);
            this.groupBoxInformacaoServico.Controls.Add(this.dateTimePickerSaida);
            this.groupBoxInformacaoServico.Controls.Add(this.textBoxTipo);
            this.groupBoxInformacaoServico.Controls.Add(this.labelDataSaida);
            this.groupBoxInformacaoServico.Controls.Add(this.labelTipo);
            this.groupBoxInformacaoServico.Controls.Add(this.labelDataEntrada);
            this.groupBoxInformacaoServico.Controls.Add(this.buttonAdicionar);
            this.groupBoxInformacaoServico.Location = new System.Drawing.Point(12, 12);
            this.groupBoxInformacaoServico.Name = "groupBoxInformacaoServico";
            this.groupBoxInformacaoServico.Size = new System.Drawing.Size(371, 168);
            this.groupBoxInformacaoServico.TabIndex = 0;
            this.groupBoxInformacaoServico.TabStop = false;
            this.groupBoxInformacaoServico.Text = "Informação do Serviço";
            // 
            // dateTimePickerEntrada
            // 
            this.dateTimePickerEntrada.Checked = false;
            this.dateTimePickerEntrada.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerEntrada.Location = new System.Drawing.Point(113, 36);
            this.dateTimePickerEntrada.Name = "dateTimePickerEntrada";
            this.dateTimePickerEntrada.Size = new System.Drawing.Size(235, 20);
            this.dateTimePickerEntrada.TabIndex = 0;
            // 
            // dateTimePickerSaida
            // 
            this.dateTimePickerSaida.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerSaida.Location = new System.Drawing.Point(113, 90);
            this.dateTimePickerSaida.Name = "dateTimePickerSaida";
            this.dateTimePickerSaida.Size = new System.Drawing.Size(235, 20);
            this.dateTimePickerSaida.TabIndex = 2;
            // 
            // textBoxTipo
            // 
            this.textBoxTipo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.textBoxTipo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBoxTipo.Location = new System.Drawing.Point(113, 62);
            this.textBoxTipo.Name = "textBoxTipo";
            this.textBoxTipo.Size = new System.Drawing.Size(235, 20);
            this.textBoxTipo.TabIndex = 1;
            // 
            // labelDataSaida
            // 
            this.labelDataSaida.Location = new System.Drawing.Point(6, 90);
            this.labelDataSaida.Name = "labelDataSaida";
            this.labelDataSaida.Size = new System.Drawing.Size(101, 20);
            this.labelDataSaida.TabIndex = 6;
            this.labelDataSaida.Text = "Data de Saída:";
            this.labelDataSaida.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelTipo
            // 
            this.labelTipo.Location = new System.Drawing.Point(6, 62);
            this.labelTipo.Name = "labelTipo";
            this.labelTipo.Size = new System.Drawing.Size(101, 20);
            this.labelTipo.TabIndex = 5;
            this.labelTipo.Text = "Tipo:";
            this.labelTipo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelDataEntrada
            // 
            this.labelDataEntrada.Location = new System.Drawing.Point(6, 34);
            this.labelDataEntrada.Name = "labelDataEntrada";
            this.labelDataEntrada.Size = new System.Drawing.Size(101, 20);
            this.labelDataEntrada.TabIndex = 4;
            this.labelDataEntrada.Text = "Data de Entrada:";
            this.labelDataEntrada.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // buttonAdicionar
            // 
            this.buttonAdicionar.BackColor = System.Drawing.Color.Aquamarine;
            this.buttonAdicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdicionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdicionar.Location = new System.Drawing.Point(135, 125);
            this.buttonAdicionar.Margin = new System.Windows.Forms.Padding(0);
            this.buttonAdicionar.Name = "buttonAdicionar";
            this.buttonAdicionar.Size = new System.Drawing.Size(100, 40);
            this.buttonAdicionar.TabIndex = 3;
            this.buttonAdicionar.Text = "Adicionar";
            this.buttonAdicionar.UseVisualStyleBackColor = false;
            this.buttonAdicionar.Click += new System.EventHandler(this.buttonAdicionar_Click);
            // 
            // OficinaServicoAdicionar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 181);
            this.Controls.Add(this.groupBoxInformacaoServico);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "OficinaServicoAdicionar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adicionar Serviço";
            this.groupBoxInformacaoServico.ResumeLayout(false);
            this.groupBoxInformacaoServico.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxInformacaoServico;
        private System.Windows.Forms.DateTimePicker dateTimePickerEntrada;
        private System.Windows.Forms.DateTimePicker dateTimePickerSaida;
        private System.Windows.Forms.TextBox textBoxTipo;
        private System.Windows.Forms.Label labelDataSaida;
        private System.Windows.Forms.Label labelTipo;
        private System.Windows.Forms.Label labelDataEntrada;
        private System.Windows.Forms.Button buttonAdicionar;
    }
}