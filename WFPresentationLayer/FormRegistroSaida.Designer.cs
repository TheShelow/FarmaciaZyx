﻿namespace WFPresentationLayer
{
    partial class FormRegistroSaida
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRegistroSaida));
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbCliente = new System.Windows.Forms.ComboBox();
            this.btnRetirarProduto = new System.Windows.Forms.Button();
            this.btnAdicionarProduto = new System.Windows.Forms.Button();
            this.txtUnidade = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nudQtde = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbProduto = new System.Windows.Forms.ComboBox();
            this.dgvProdutosSaida = new System.Windows.Forms.DataGridView();
            this.ProdutosSaidaID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProdutosSaidaNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProdutosSaidaUn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProdutosSaidaQtde = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProdutosSaidaValor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.nudQtde)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutosSaida)).BeginInit();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(664, 200);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 15);
            this.label10.TabIndex = 35;
            this.label10.Text = "Total Pago";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(664, 157);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 15);
            this.label9.TabIndex = 34;
            this.label9.Text = "n itens";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(661, 103);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 15);
            this.label8.TabIndex = 33;
            this.label8.Text = "Desconto(R$)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(664, 55);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 15);
            this.label7.TabIndex = 32;
            this.label7.Text = "Desconto(%)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(664, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 15);
            this.label6.TabIndex = 31;
            this.label6.Text = "Valor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(119, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 15);
            this.label2.TabIndex = 22;
            this.label2.Text = "Data Entrada";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(119, 47);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 23);
            this.dateTimePicker1.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(353, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 15);
            this.label1.TabIndex = 19;
            this.label1.Text = "Cliente";
            // 
            // cmbCliente
            // 
            this.cmbCliente.FormattingEnabled = true;
            this.cmbCliente.Location = new System.Drawing.Point(353, 47);
            this.cmbCliente.Name = "cmbCliente";
            this.cmbCliente.Size = new System.Drawing.Size(121, 23);
            this.cmbCliente.TabIndex = 18;
            // 
            // btnRetirarProduto
            // 
            this.btnRetirarProduto.Location = new System.Drawing.Point(406, 120);
            this.btnRetirarProduto.Name = "btnRetirarProduto";
            this.btnRetirarProduto.Size = new System.Drawing.Size(122, 24);
            this.btnRetirarProduto.TabIndex = 49;
            this.btnRetirarProduto.Text = "Retirar Produto";
            this.btnRetirarProduto.UseVisualStyleBackColor = true;
            this.btnRetirarProduto.Click += new System.EventHandler(this.btnRetirarProduto_Click);
            // 
            // btnAdicionarProduto
            // 
            this.btnAdicionarProduto.Location = new System.Drawing.Point(406, 146);
            this.btnAdicionarProduto.Name = "btnAdicionarProduto";
            this.btnAdicionarProduto.Size = new System.Drawing.Size(122, 24);
            this.btnAdicionarProduto.TabIndex = 48;
            this.btnAdicionarProduto.Text = "Adicionar Produto";
            this.btnAdicionarProduto.UseVisualStyleBackColor = true;
            this.btnAdicionarProduto.Click += new System.EventHandler(this.btnAdicionarProduto_Click);
            // 
            // txtUnidade
            // 
            this.txtUnidade.Location = new System.Drawing.Point(232, 148);
            this.txtUnidade.Name = "txtUnidade";
            this.txtUnidade.ReadOnly = true;
            this.txtUnidade.Size = new System.Drawing.Size(44, 23);
            this.txtUnidade.TabIndex = 47;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(232, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(22, 15);
            this.label5.TabIndex = 46;
            this.label5.Text = "Un";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(155, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 15);
            this.label4.TabIndex = 45;
            this.label4.Text = "Qtde.";
            // 
            // nudQtde
            // 
            this.nudQtde.Location = new System.Drawing.Point(155, 148);
            this.nudQtde.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.nudQtde.Name = "nudQtde";
            this.nudQtde.Size = new System.Drawing.Size(74, 23);
            this.nudQtde.TabIndex = 44;
            this.nudQtde.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(279, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 15);
            this.label3.TabIndex = 43;
            this.label3.Text = "Produto";
            // 
            // cmbProduto
            // 
            this.cmbProduto.FormattingEnabled = true;
            this.cmbProduto.Location = new System.Drawing.Point(279, 148);
            this.cmbProduto.Name = "cmbProduto";
            this.cmbProduto.Size = new System.Drawing.Size(121, 23);
            this.cmbProduto.TabIndex = 42;
            // 
            // dgvProdutosSaida
            // 
            this.dgvProdutosSaida.AllowUserToAddRows = false;
            this.dgvProdutosSaida.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdutosSaida.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProdutosSaidaID,
            this.ProdutosSaidaNome,
            this.ProdutosSaidaUn,
            this.ProdutosSaidaQtde,
            this.ProdutosSaidaValor});
            this.dgvProdutosSaida.Location = new System.Drawing.Point(27, 177);
            this.dgvProdutosSaida.Name = "dgvProdutosSaida";
            this.dgvProdutosSaida.ReadOnly = true;
            this.dgvProdutosSaida.RowTemplate.Height = 25;
            this.dgvProdutosSaida.Size = new System.Drawing.Size(501, 147);
            this.dgvProdutosSaida.TabIndex = 50;
            // 
            // ProdutosSaidaID
            // 
            this.ProdutosSaidaID.HeaderText = "ID";
            this.ProdutosSaidaID.Name = "ProdutosSaidaID";
            this.ProdutosSaidaID.ReadOnly = true;
            // 
            // ProdutosSaidaNome
            // 
            this.ProdutosSaidaNome.HeaderText = "Nome";
            this.ProdutosSaidaNome.Name = "ProdutosSaidaNome";
            this.ProdutosSaidaNome.ReadOnly = true;
            // 
            // ProdutosSaidaUn
            // 
            this.ProdutosSaidaUn.HeaderText = "Un";
            this.ProdutosSaidaUn.Name = "ProdutosSaidaUn";
            this.ProdutosSaidaUn.ReadOnly = true;
            // 
            // ProdutosSaidaQtde
            // 
            this.ProdutosSaidaQtde.HeaderText = "Qtde";
            this.ProdutosSaidaQtde.Name = "ProdutosSaidaQtde";
            this.ProdutosSaidaQtde.ReadOnly = true;
            // 
            // ProdutosSaidaValor
            // 
            this.ProdutosSaidaValor.HeaderText = "Valor";
            this.ProdutosSaidaValor.Name = "ProdutosSaidaValor";
            this.ProdutosSaidaValor.ReadOnly = true;
            // 
            // FormRegistroSaida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvProdutosSaida);
            this.Controls.Add(this.btnRetirarProduto);
            this.Controls.Add(this.btnAdicionarProduto);
            this.Controls.Add(this.txtUnidade);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nudQtde);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbProduto);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbCliente);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormRegistroSaida";
            this.Text = "Registro Saida";
            this.Load += new System.EventHandler(this.FormRegistroSaida_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudQtde)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutosSaida)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label2;
        private DateTimePicker dateTimePicker1;
        private Label label1;
        private ComboBox cmbCliente;
        private Button btnRetirarProduto;
        private Button btnAdicionarProduto;
        private TextBox txtUnidade;
        private Label label5;
        private Label label4;
        private NumericUpDown nudQtde;
        private Label label3;
        private ComboBox cmbProduto;
        private DataGridView dgvProdutosSaida;
        private DataGridViewTextBoxColumn ProdutosSaidaID;
        private DataGridViewTextBoxColumn ProdutosSaidaNome;
        private DataGridViewTextBoxColumn ProdutosSaidaUn;
        private DataGridViewTextBoxColumn ProdutosSaidaQtde;
        private DataGridViewTextBoxColumn ProdutosSaidaValor;
    }
}