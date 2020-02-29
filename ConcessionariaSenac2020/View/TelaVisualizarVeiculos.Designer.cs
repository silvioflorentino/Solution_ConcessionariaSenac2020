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
            this.buttonBuscaCodigoVeiculo = new System.Windows.Forms.Button();
            this.textBoxBuscaCodigoVeiculo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxPlaca = new System.Windows.Forms.TextBox();
            this.textBoxModelo = new System.Windows.Forms.TextBox();
            this.textBoxCor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxMarca = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTodosVeiculos)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBuscaPlaca)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.groupBox1.SuspendLayout();
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
            this.tabControl1.Size = new System.Drawing.Size(570, 418);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.buttonBuscarTodosVeiculos);
            this.tabPage1.Controls.Add(this.dataGridViewTodosVeiculos);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(562, 389);
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
            this.tabPage2.Size = new System.Drawing.Size(562, 389);
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
            this.tabPage3.Controls.Add(this.groupBox1);
            this.tabPage3.Controls.Add(this.buttonBuscaCodigoVeiculo);
            this.tabPage3.Controls.Add(this.textBoxBuscaCodigoVeiculo);
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(562, 389);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Código";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // buttonBuscaCodigoVeiculo
            // 
            this.buttonBuscaCodigoVeiculo.Location = new System.Drawing.Point(367, 28);
            this.buttonBuscaCodigoVeiculo.Name = "buttonBuscaCodigoVeiculo";
            this.buttonBuscaCodigoVeiculo.Size = new System.Drawing.Size(75, 30);
            this.buttonBuscaCodigoVeiculo.TabIndex = 2;
            this.buttonBuscaCodigoVeiculo.Text = "Buscar";
            this.buttonBuscaCodigoVeiculo.UseVisualStyleBackColor = true;
            this.buttonBuscaCodigoVeiculo.Click += new System.EventHandler(this.buttonBuscaCodigoVeiculo_Click);
            // 
            // textBoxBuscaCodigoVeiculo
            // 
            this.textBoxBuscaCodigoVeiculo.Location = new System.Drawing.Point(191, 32);
            this.textBoxBuscaCodigoVeiculo.Name = "textBoxBuscaCodigoVeiculo";
            this.textBoxBuscaCodigoVeiculo.Size = new System.Drawing.Size(130, 22);
            this.textBoxBuscaCodigoVeiculo.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Digite o Código:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxMarca);
            this.groupBox1.Controls.Add(this.textBoxPlaca);
            this.groupBox1.Controls.Add(this.textBoxModelo);
            this.groupBox1.Controls.Add(this.textBoxCor);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(78, 81);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(415, 280);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Visualizar Veículos";
            // 
            // textBoxPlaca
            // 
            this.textBoxPlaca.Location = new System.Drawing.Point(142, 222);
            this.textBoxPlaca.Name = "textBoxPlaca";
            this.textBoxPlaca.Size = new System.Drawing.Size(222, 28);
            this.textBoxPlaca.TabIndex = 9;
            // 
            // textBoxModelo
            // 
            this.textBoxModelo.Location = new System.Drawing.Point(142, 113);
            this.textBoxModelo.Name = "textBoxModelo";
            this.textBoxModelo.Size = new System.Drawing.Size(222, 28);
            this.textBoxModelo.TabIndex = 8;
            // 
            // textBoxCor
            // 
            this.textBoxCor.Location = new System.Drawing.Point(142, 171);
            this.textBoxCor.Name = "textBoxCor";
            this.textBoxCor.Size = new System.Drawing.Size(222, 28);
            this.textBoxCor.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(31, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Modelo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(31, 223);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Placa:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(31, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 25);
            this.label5.TabIndex = 0;
            this.label5.Text = "Marca:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(31, 171);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 25);
            this.label6.TabIndex = 2;
            this.label6.Text = "Cor:";
            // 
            // textBoxMarca
            // 
            this.textBoxMarca.Location = new System.Drawing.Point(142, 63);
            this.textBoxMarca.Name = "textBoxMarca";
            this.textBoxMarca.Size = new System.Drawing.Size(222, 28);
            this.textBoxMarca.TabIndex = 10;
            // 
            // TelaVisualizarVeiculos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 502);
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
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.Button buttonBuscaCodigoVeiculo;
        private System.Windows.Forms.TextBox textBoxBuscaCodigoVeiculo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxMarca;
        private System.Windows.Forms.TextBox textBoxPlaca;
        private System.Windows.Forms.TextBox textBoxModelo;
        private System.Windows.Forms.TextBox textBoxCor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}