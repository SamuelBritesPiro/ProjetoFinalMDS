namespace ProjetoFinal
{
    partial class OficinaCarrosAdicionar
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
            this.textBoxNumeroChassis = new System.Windows.Forms.TextBox();
            this.groupBoxInformacaoCarro = new System.Windows.Forms.GroupBox();
            this.textBoxQuilometros = new System.Windows.Forms.TextBox();
            this.textBoxMatricula = new System.Windows.Forms.TextBox();
            this.textBoxCombustivel = new System.Windows.Forms.TextBox();
            this.textBoxModelo = new System.Windows.Forms.TextBox();
            this.textBoxMarca = new System.Windows.Forms.TextBox();
            this.labelQuilometros = new System.Windows.Forms.Label();
            this.labelMatricula = new System.Windows.Forms.Label();
            this.labelCombustivel = new System.Windows.Forms.Label();
            this.labelModelo = new System.Windows.Forms.Label();
            this.labelMarca = new System.Windows.Forms.Label();
            this.labelNumeroChassis = new System.Windows.Forms.Label();
            this.buttonAdicionar = new System.Windows.Forms.Button();
            this.groupBoxInformacaoCarro.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxNumeroChassis
            // 
            this.textBoxNumeroChassis.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.textBoxNumeroChassis.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBoxNumeroChassis.Location = new System.Drawing.Point(113, 35);
            this.textBoxNumeroChassis.Name = "textBoxNumeroChassis";
            this.textBoxNumeroChassis.Size = new System.Drawing.Size(235, 20);
            this.textBoxNumeroChassis.TabIndex = 0;
            // 
            // groupBoxInformacaoCarro
            // 
            this.groupBoxInformacaoCarro.Controls.Add(this.textBoxQuilometros);
            this.groupBoxInformacaoCarro.Controls.Add(this.textBoxMatricula);
            this.groupBoxInformacaoCarro.Controls.Add(this.textBoxCombustivel);
            this.groupBoxInformacaoCarro.Controls.Add(this.textBoxModelo);
            this.groupBoxInformacaoCarro.Controls.Add(this.textBoxMarca);
            this.groupBoxInformacaoCarro.Controls.Add(this.labelQuilometros);
            this.groupBoxInformacaoCarro.Controls.Add(this.labelMatricula);
            this.groupBoxInformacaoCarro.Controls.Add(this.labelCombustivel);
            this.groupBoxInformacaoCarro.Controls.Add(this.labelModelo);
            this.groupBoxInformacaoCarro.Controls.Add(this.labelMarca);
            this.groupBoxInformacaoCarro.Controls.Add(this.labelNumeroChassis);
            this.groupBoxInformacaoCarro.Controls.Add(this.buttonAdicionar);
            this.groupBoxInformacaoCarro.Controls.Add(this.textBoxNumeroChassis);
            this.groupBoxInformacaoCarro.Location = new System.Drawing.Point(12, 8);
            this.groupBoxInformacaoCarro.Name = "groupBoxInformacaoCarro";
            this.groupBoxInformacaoCarro.Size = new System.Drawing.Size(371, 250);
            this.groupBoxInformacaoCarro.TabIndex = 0;
            this.groupBoxInformacaoCarro.TabStop = false;
            this.groupBoxInformacaoCarro.Text = "Informação do Carro de Oficina";
            // 
            // textBoxQuilometros
            // 
            this.textBoxQuilometros.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.textBoxQuilometros.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBoxQuilometros.Location = new System.Drawing.Point(113, 173);
            this.textBoxQuilometros.MaxLength = 9;
            this.textBoxQuilometros.Name = "textBoxQuilometros";
            this.textBoxQuilometros.Size = new System.Drawing.Size(235, 20);
            this.textBoxQuilometros.TabIndex = 5;
            this.textBoxQuilometros.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxQuilometros_KeyPress);
            // 
            // textBoxMatricula
            // 
            this.textBoxMatricula.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.textBoxMatricula.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBoxMatricula.Location = new System.Drawing.Point(113, 147);
            this.textBoxMatricula.Name = "textBoxMatricula";
            this.textBoxMatricula.Size = new System.Drawing.Size(235, 20);
            this.textBoxMatricula.TabIndex = 4;
            // 
            // textBoxCombustivel
            // 
            this.textBoxCombustivel.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.textBoxCombustivel.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBoxCombustivel.Location = new System.Drawing.Point(113, 119);
            this.textBoxCombustivel.Name = "textBoxCombustivel";
            this.textBoxCombustivel.Size = new System.Drawing.Size(235, 20);
            this.textBoxCombustivel.TabIndex = 3;
            // 
            // textBoxModelo
            // 
            this.textBoxModelo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.textBoxModelo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBoxModelo.Location = new System.Drawing.Point(113, 90);
            this.textBoxModelo.Name = "textBoxModelo";
            this.textBoxModelo.Size = new System.Drawing.Size(235, 20);
            this.textBoxModelo.TabIndex = 2;
            // 
            // textBoxMarca
            // 
            this.textBoxMarca.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.textBoxMarca.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBoxMarca.Location = new System.Drawing.Point(113, 62);
            this.textBoxMarca.Name = "textBoxMarca";
            this.textBoxMarca.Size = new System.Drawing.Size(235, 20);
            this.textBoxMarca.TabIndex = 1;
            // 
            // labelQuilometros
            // 
            this.labelQuilometros.Location = new System.Drawing.Point(6, 174);
            this.labelQuilometros.Name = "labelQuilometros";
            this.labelQuilometros.Size = new System.Drawing.Size(101, 20);
            this.labelQuilometros.TabIndex = 12;
            this.labelQuilometros.Text = "Quilometros:";
            this.labelQuilometros.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelMatricula
            // 
            this.labelMatricula.Location = new System.Drawing.Point(6, 146);
            this.labelMatricula.Name = "labelMatricula";
            this.labelMatricula.Size = new System.Drawing.Size(101, 20);
            this.labelMatricula.TabIndex = 11;
            this.labelMatricula.Text = "Matricula:";
            this.labelMatricula.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelCombustivel
            // 
            this.labelCombustivel.Location = new System.Drawing.Point(6, 118);
            this.labelCombustivel.Name = "labelCombustivel";
            this.labelCombustivel.Size = new System.Drawing.Size(101, 20);
            this.labelCombustivel.TabIndex = 10;
            this.labelCombustivel.Text = "Combustivel:";
            this.labelCombustivel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelModelo
            // 
            this.labelModelo.Location = new System.Drawing.Point(6, 90);
            this.labelModelo.Name = "labelModelo";
            this.labelModelo.Size = new System.Drawing.Size(101, 20);
            this.labelModelo.TabIndex = 9;
            this.labelModelo.Text = "Modelo:";
            this.labelModelo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelMarca
            // 
            this.labelMarca.Location = new System.Drawing.Point(6, 62);
            this.labelMarca.Name = "labelMarca";
            this.labelMarca.Size = new System.Drawing.Size(101, 20);
            this.labelMarca.TabIndex = 8;
            this.labelMarca.Text = "Marca:";
            this.labelMarca.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelNumeroChassis
            // 
            this.labelNumeroChassis.Location = new System.Drawing.Point(6, 34);
            this.labelNumeroChassis.Name = "labelNumeroChassis";
            this.labelNumeroChassis.Size = new System.Drawing.Size(101, 20);
            this.labelNumeroChassis.TabIndex = 7;
            this.labelNumeroChassis.Text = "Número de Chassis:";
            this.labelNumeroChassis.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // buttonAdicionar
            // 
            this.buttonAdicionar.BackColor = System.Drawing.Color.Aquamarine;
            this.buttonAdicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdicionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdicionar.Location = new System.Drawing.Point(135, 203);
            this.buttonAdicionar.Margin = new System.Windows.Forms.Padding(0);
            this.buttonAdicionar.Name = "buttonAdicionar";
            this.buttonAdicionar.Size = new System.Drawing.Size(100, 40);
            this.buttonAdicionar.TabIndex = 6;
            this.buttonAdicionar.Text = "Adicionar";
            this.buttonAdicionar.UseVisualStyleBackColor = false;
            this.buttonAdicionar.Click += new System.EventHandler(this.buttonAdicionar_Click);
            // 
            // OficinaCarrosAdicionar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 266);
            this.Controls.Add(this.groupBoxInformacaoCarro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "OficinaCarrosAdicionar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adicionar Carro de Oficina";
            this.groupBoxInformacaoCarro.ResumeLayout(false);
            this.groupBoxInformacaoCarro.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxNumeroChassis;
        private System.Windows.Forms.GroupBox groupBoxInformacaoCarro;
        private System.Windows.Forms.TextBox textBoxQuilometros;
        private System.Windows.Forms.TextBox textBoxMatricula;
        private System.Windows.Forms.TextBox textBoxCombustivel;
        private System.Windows.Forms.TextBox textBoxModelo;
        private System.Windows.Forms.TextBox textBoxMarca;
        private System.Windows.Forms.Label labelQuilometros;
        private System.Windows.Forms.Label labelMatricula;
        private System.Windows.Forms.Label labelCombustivel;
        private System.Windows.Forms.Label labelModelo;
        private System.Windows.Forms.Label labelMarca;
        private System.Windows.Forms.Label labelNumeroChassis;
        private System.Windows.Forms.Button buttonAdicionar;
    }
}