namespace ProjetoFinal
{
    partial class OficinaParcelaAdicionar
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
            this.groupBoxInformacaoParcela = new System.Windows.Forms.GroupBox();
            this.textBoxValor = new System.Windows.Forms.TextBox();
            this.textBoxDescricao = new System.Windows.Forms.TextBox();
            this.labelDescricao = new System.Windows.Forms.Label();
            this.labelValor = new System.Windows.Forms.Label();
            this.buttonAdicionar = new System.Windows.Forms.Button();
            this.groupBoxInformacaoParcela.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxInformacaoParcela
            // 
            this.groupBoxInformacaoParcela.Controls.Add(this.textBoxValor);
            this.groupBoxInformacaoParcela.Controls.Add(this.textBoxDescricao);
            this.groupBoxInformacaoParcela.Controls.Add(this.labelDescricao);
            this.groupBoxInformacaoParcela.Controls.Add(this.labelValor);
            this.groupBoxInformacaoParcela.Controls.Add(this.buttonAdicionar);
            this.groupBoxInformacaoParcela.Location = new System.Drawing.Point(8, 6);
            this.groupBoxInformacaoParcela.Name = "groupBoxInformacaoParcela";
            this.groupBoxInformacaoParcela.Size = new System.Drawing.Size(319, 144);
            this.groupBoxInformacaoParcela.TabIndex = 0;
            this.groupBoxInformacaoParcela.TabStop = false;
            this.groupBoxInformacaoParcela.Text = "Informação da Parcela";
            // 
            // textBoxValor
            // 
            this.textBoxValor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.textBoxValor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBoxValor.Location = new System.Drawing.Point(76, 35);
            this.textBoxValor.MaxLength = 9;
            this.textBoxValor.Name = "textBoxValor";
            this.textBoxValor.Size = new System.Drawing.Size(235, 20);
            this.textBoxValor.TabIndex = 0;
            this.textBoxValor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxValor_KeyPress);
            // 
            // textBoxDescricao
            // 
            this.textBoxDescricao.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.textBoxDescricao.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBoxDescricao.Location = new System.Drawing.Point(76, 62);
            this.textBoxDescricao.Name = "textBoxDescricao";
            this.textBoxDescricao.Size = new System.Drawing.Size(235, 20);
            this.textBoxDescricao.TabIndex = 1;
            // 
            // labelDescricao
            // 
            this.labelDescricao.Location = new System.Drawing.Point(8, 62);
            this.labelDescricao.Name = "labelDescricao";
            this.labelDescricao.Size = new System.Drawing.Size(62, 20);
            this.labelDescricao.TabIndex = 4;
            this.labelDescricao.Text = "Descrição:";
            this.labelDescricao.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelValor
            // 
            this.labelValor.Location = new System.Drawing.Point(8, 34);
            this.labelValor.Name = "labelValor";
            this.labelValor.Size = new System.Drawing.Size(62, 20);
            this.labelValor.TabIndex = 3;
            this.labelValor.Text = "Valor:";
            this.labelValor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // buttonAdicionar
            // 
            this.buttonAdicionar.BackColor = System.Drawing.Color.Aquamarine;
            this.buttonAdicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdicionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdicionar.Location = new System.Drawing.Point(109, 101);
            this.buttonAdicionar.Margin = new System.Windows.Forms.Padding(0);
            this.buttonAdicionar.Name = "buttonAdicionar";
            this.buttonAdicionar.Size = new System.Drawing.Size(100, 40);
            this.buttonAdicionar.TabIndex = 2;
            this.buttonAdicionar.Text = "Adicionar";
            this.buttonAdicionar.UseVisualStyleBackColor = false;
            this.buttonAdicionar.Click += new System.EventHandler(this.buttonAdicionar_Click);
            // 
            // OficinaParcelaAdicionar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 156);
            this.Controls.Add(this.groupBoxInformacaoParcela);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "OficinaParcelaAdicionar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adicionar Parcela";
            this.groupBoxInformacaoParcela.ResumeLayout(false);
            this.groupBoxInformacaoParcela.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxInformacaoParcela;
        private System.Windows.Forms.TextBox textBoxDescricao;
        private System.Windows.Forms.Label labelDescricao;
        private System.Windows.Forms.Label labelValor;
        private System.Windows.Forms.Button buttonAdicionar;
        private System.Windows.Forms.TextBox textBoxValor;
    }
}