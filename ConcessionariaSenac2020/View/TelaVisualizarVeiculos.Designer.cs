namespace ConcessionariaSenac2020.View
{
    partial class TelaVisualizarVeiculos
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.buttonBuscarTodosVeiculos = new System.Windows.Forms.Button();
            this.dataGridViewTodosVeiculos = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Marca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Modelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Placa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxBuscaPlaca = new System.Windows.Forms.TextBox();
            this.buttonBuscaPlaca = new System.Windows.Forms.Button();
            this.dataGridViewBuscaPlaca = new System.Windows.Forms.DataGridView();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodigoPlaca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dataGridViewBuscaCodigoVeiculo = new System.Windows.Forms.DataGridView();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonBuscaCodigoVeiculo = new System.Windows.Forms.Button();
            this.textBoxBuscaCodigoVeiculo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTodosVeiculos)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBuscaPlaca)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBuscaCodigoVeiculo)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(79, 40);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(576, 339);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.buttonBuscarTodosVeiculos);
            this.tabPage1.Controls.Add(this.dataGridViewTodosVeiculos);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(568, 310);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Completo";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // buttonBuscarTodosVeiculos
            // 
            this.buttonBuscarTodosVeiculos.Location = new System.Drawing.Point(163, 43);
            this.buttonBuscarTodosVeiculos.Name = "buttonBuscarTodosVeiculos";
            this.buttonBuscarTodosVeiculos.Size = new System.Drawing.Size(243, 33);
            this.buttonBuscarTodosVeiculos.TabIndex = 1;
            this.buttonBuscarTodosVeiculos.Text = "Buscar Todos os Veículos";
            this.buttonBuscarTodosVeiculos.UseVisualStyleBackColor = true;
            // 
            // dataGridViewTodosVeiculos
            // 
            this.dataGridViewTodosVeiculos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewTodosVeiculos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTodosVeiculos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Marca,
            this.Modelo,
            this.Cor,
            this.Placa});
            this.dataGridViewTodosVeiculos.Location = new System.Drawing.Point(32, 107);
            this.dataGridViewTodosVeiculos.Name = "dataGridViewTodosVeiculos";
            this.dataGridViewTodosVeiculos.RowHeadersVisible = false;
            this.dataGridViewTodosVeiculos.RowHeadersWidth = 51;
            this.dataGridViewTodosVeiculos.RowTemplate.Height = 24;
            this.dataGridViewTodosVeiculos.Size = new System.Drawing.Size(506, 167);
            this.dataGridViewTodosVeiculos.TabIndex = 0;
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Código";
            this.Codigo.MinimumWidth = 6;
            this.Codigo.Name = "Codigo";
            // 
            // Marca
            // 
            this.Marca.HeaderText = "Marca";
            this.Marca.MinimumWidth = 6;
            this.Marca.Name = "Marca";
            // 
            // Modelo
            // 
            this.Modelo.HeaderText = "Modelo";
            this.Modelo.MinimumWidth = 6;
            this.Modelo.Name = "Modelo";
            // 
            // Cor
            // 
            this.Cor.HeaderText = "Cor";
            this.Cor.MinimumWidth = 6;
            this.Cor.Name = "Cor";
            // 
            // Placa
            // 
            this.Placa.HeaderText = "Placa";
            this.Placa.MinimumWidth = 6;
            this.Placa.Name = "Placa";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.textBoxBuscaPlaca);
            this.tabPage2.Controls.Add(this.buttonBuscaPlaca);
            this.tabPage2.Controls.Add(this.dataGridViewBuscaPlaca);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(568, 310);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Placa";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Digite a Placa:";
            // 
            // textBoxBuscaPlaca
            // 
            this.textBoxBuscaPlaca.Location = new System.Drawing.Point(180, 47);
            this.textBoxBuscaPlaca.Name = "textBoxBuscaPlaca";
            this.textBoxBuscaPlaca.Size = new System.Drawing.Size(156, 22);
            this.textBoxBuscaPlaca.TabIndex = 2;
            // 
            // buttonBuscaPlaca
            // 
            this.buttonBuscaPlaca.Location = new System.Drawing.Point(382, 46);
            this.buttonBuscaPlaca.Name = "buttonBuscaPlaca";
            this.buttonBuscaPlaca.Size = new System.Drawing.Size(75, 31);
            this.buttonBuscaPlaca.TabIndex = 1;
            this.buttonBuscaPlaca.Text = "Buscar";
            this.buttonBuscaPlaca.UseVisualStyleBackColor = true;
            // 
            // dataGridViewBuscaPlaca
            // 
            this.dataGridViewBuscaPlaca.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewBuscaPlaca.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBuscaPlaca.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column3,
            this.Column1,
            this.Column4,
            this.Column2,
            this.CodigoPlaca});
            this.dataGridViewBuscaPlaca.Location = new System.Drawing.Point(54, 112);
            this.dataGridViewBuscaPlaca.Name = "dataGridViewBuscaPlaca";
            this.dataGridViewBuscaPlaca.RowHeadersVisible = false;
            this.dataGridViewBuscaPlaca.RowHeadersWidth = 51;
            this.dataGridViewBuscaPlaca.RowTemplate.Height = 24;
            this.dataGridViewBuscaPlaca.Size = new System.Drawing.Size(433, 150);
            this.dataGridViewBuscaPlaca.TabIndex = 0;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Placa";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Marca";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Modelo";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Cor";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            // 
            // CodigoPlaca
            // 
            this.CodigoPlaca.HeaderText = "Código";
            this.CodigoPlaca.MinimumWidth = 6;
            this.CodigoPlaca.Name = "CodigoPlaca";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dataGridViewBuscaCodigoVeiculo);
            this.tabPage3.Controls.Add(this.buttonBuscaCodigoVeiculo);
            this.tabPage3.Controls.Add(this.textBoxBuscaCodigoVeiculo);
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(568, 310);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Código";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dataGridViewBuscaCodigoVeiculo
            // 
            this.dataGridViewBuscaCodigoVeiculo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewBuscaCodigoVeiculo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBuscaCodigoVeiculo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9});
            this.dataGridViewBuscaCodigoVeiculo.Location = new System.Drawing.Point(48, 110);
            this.dataGridViewBuscaCodigoVeiculo.Name = "dataGridViewBuscaCodigoVeiculo";
            this.dataGridViewBuscaCodigoVeiculo.RowHeadersVisible = false;
            this.dataGridViewBuscaCodigoVeiculo.RowHeadersWidth = 51;
            this.dataGridViewBuscaCodigoVeiculo.RowTemplate.Height = 24;
            this.dataGridViewBuscaCodigoVeiculo.Size = new System.Drawing.Size(475, 150);
            this.dataGridViewBuscaCodigoVeiculo.TabIndex = 3;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Código";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Marca";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Modelo";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Cor";
            this.Column8.MinimumWidth = 6;
            this.Column8.Name = "Column8";
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Placa";
            this.Column9.MinimumWidth = 6;
            this.Column9.Name = "Column9";
            // 
            // buttonBuscaCodigoVeiculo
            // 
            this.buttonBuscaCodigoVeiculo.Location = new System.Drawing.Point(334, 45);
            this.buttonBuscaCodigoVeiculo.Name = "buttonBuscaCodigoVeiculo";
            this.buttonBuscaCodigoVeiculo.Size = new System.Drawing.Size(75, 30);
            this.buttonBuscaCodigoVeiculo.TabIndex = 2;
            this.buttonBuscaCodigoVeiculo.Text = "Buscar";
            this.buttonBuscaCodigoVeiculo.UseVisualStyleBackColor = true;
            // 
            // textBoxBuscaCodigoVeiculo
            // 
            this.textBoxBuscaCodigoVeiculo.Location = new System.Drawing.Point(174, 49);
            this.textBoxBuscaCodigoVeiculo.Name = "textBoxBuscaCodigoVeiculo";
            this.textBoxBuscaCodigoVeiculo.Size = new System.Drawing.Size(130, 22);
            this.textBoxBuscaCodigoVeiculo.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Digite o Código:";
            // 
            // TelaVisualizarVeiculos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "TelaVisualizarVeiculos";
            this.ShowIcon = false;
            this.Text = "Concessionária Senac 2020";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTodosVeiculos)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBuscaPlaca)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBuscaCodigoVeiculo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button buttonBuscarTodosVeiculos;
        private System.Windows.Forms.DataGridView dataGridViewTodosVeiculos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Marca;
        private System.Windows.Forms.DataGridViewTextBoxColumn Modelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Placa;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxBuscaPlaca;
        private System.Windows.Forms.Button buttonBuscaPlaca;
        private System.Windows.Forms.DataGridView dataGridViewBuscaPlaca;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoPlaca;
        private System.Windows.Forms.DataGridView dataGridViewBuscaCodigoVeiculo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.Button buttonBuscaCodigoVeiculo;
        private System.Windows.Forms.TextBox textBoxBuscaCodigoVeiculo;
        private System.Windows.Forms.Label label2;
    }
}