
namespace Win_Banco01
{
    partial class FrmBanco1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBanco1));
            this.label1 = new System.Windows.Forms.Label();
            this.dgvDados = new System.Windows.Forms.DataGridView();
            this.CodProd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomeProd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescProd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodFor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnExibir = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(107, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(359, 78);
            this.label1.TabIndex = 0;
            this.label1.Text = "Virtualdc";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dgvDados
            // 
            this.dgvDados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvDados.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodProd,
            this.NomeProd,
            this.DescProd,
            this.Valor,
            this.CodFor});
            this.dgvDados.Location = new System.Drawing.Point(12, 103);
            this.dgvDados.Name = "dgvDados";
            this.dgvDados.Size = new System.Drawing.Size(552, 313);
            this.dgvDados.TabIndex = 1;
            // 
            // CodProd
            // 
            this.CodProd.HeaderText = "Código";
            this.CodProd.Name = "CodProd";
            this.CodProd.Width = 83;
            // 
            // NomeProd
            // 
            this.NomeProd.HeaderText = "Nome";
            this.NomeProd.Name = "NomeProd";
            this.NomeProd.Width = 75;
            // 
            // DescProd
            // 
            this.DescProd.HeaderText = "Depto";
            this.DescProd.Name = "DescProd";
            this.DescProd.Width = 76;
            // 
            // Valor
            // 
            this.Valor.HeaderText = "Função";
            this.Valor.Name = "Valor";
            this.Valor.Width = 86;
            // 
            // CodFor
            // 
            this.CodFor.HeaderText = "Salário";
            this.CodFor.Name = "CodFor";
            this.CodFor.Width = 83;
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.White;
            this.btnSair.Image = global::Win_Banco01.Properties.Resources._312;
            this.btnSair.Location = new System.Drawing.Point(444, 436);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(120, 50);
            this.btnSair.TabIndex = 3;
            this.btnSair.Text = "&Sair";
            this.btnSair.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click_1);
            // 
            // btnExibir
            // 
            this.btnExibir.BackColor = System.Drawing.Color.White;
            this.btnExibir.Image = global::Win_Banco01.Properties.Resources._359;
            this.btnExibir.Location = new System.Drawing.Point(12, 436);
            this.btnExibir.Name = "btnExibir";
            this.btnExibir.Size = new System.Drawing.Size(120, 50);
            this.btnExibir.TabIndex = 2;
            this.btnExibir.Text = "&Exibir";
            this.btnExibir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExibir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExibir.UseVisualStyleBackColor = false;
            this.btnExibir.Click += new System.EventHandler(this.btnExibir_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.White;
            this.btnCancelar.Image = global::Win_Banco01.Properties.Resources._103;
            this.btnCancelar.Location = new System.Drawing.Point(237, 436);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(120, 50);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click_1);
            // 
            // FrmBanco1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.ClientSize = new System.Drawing.Size(606, 508);
            this.Controls.Add(this.btnExibir);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.dgvDados);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSair);
            this.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmBanco1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listagem de Produtos";
            this.Load += new System.EventHandler(this.FrmBanco1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvDados;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodProd;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeProd;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescProd;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodFor;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnExibir;
        private System.Windows.Forms.Button btnCancelar;
    }
}

