namespace ConcessionariaSenac2020.View
{
    partial class TelaVisualizarClientes
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
            this.buttonBuscarTodosClientes = new System.Windows.Forms.Button();
            this.dataGridViewTodosClientes = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxBuscaNome = new System.Windows.Forms.TextBox();
            this.buttonBuscaNome = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.buttonBuscaCpfClientes = new System.Windows.Forms.Button();
            this.textBoxBuscaCpfClientes = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewClientesNome = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewClientesCpf = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTodosClientes)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClientesNome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClientesCpf)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(112, 56);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(576, 339);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.buttonBuscarTodosClientes);
            this.tabPage1.Controls.Add(this.dataGridViewTodosClientes);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(568, 310);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Completo";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // buttonBuscarTodosClientes
            // 
            this.buttonBuscarTodosClientes.Location = new System.Drawing.Point(163, 43);
            this.buttonBuscarTodosClientes.Name = "buttonBuscarTodosClientes";
            this.buttonBuscarTodosClientes.Size = new System.Drawing.Size(243, 33);
            this.buttonBuscarTodosClientes.TabIndex = 1;
            this.buttonBuscarTodosClientes.Text = "Buscar Todos os Clientes";
            this.buttonBuscarTodosClientes.UseVisualStyleBackColor = true;
            // 
            // dataGridViewTodosClientes
            // 
            this.dataGridViewTodosClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewTodosClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTodosClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column10,
            this.Column11,
            this.Column12,
            this.Column13});
            this.dataGridViewTodosClientes.Location = new System.Drawing.Point(32, 107);
            this.dataGridViewTodosClientes.Name = "dataGridViewTodosClientes";
            this.dataGridViewTodosClientes.RowHeadersVisible = false;
            this.dataGridViewTodosClientes.RowHeadersWidth = 51;
            this.dataGridViewTodosClientes.RowTemplate.Height = 24;
            this.dataGridViewTodosClientes.Size = new System.Drawing.Size(506, 167);
            this.dataGridViewTodosClientes.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridViewClientesNome);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.textBoxBuscaNome);
            this.tabPage2.Controls.Add(this.buttonBuscaNome);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(568, 310);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Nome";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Digite o Nome:";
            // 
            // textBoxBuscaNome
            // 
            this.textBoxBuscaNome.Location = new System.Drawing.Point(180, 47);
            this.textBoxBuscaNome.Name = "textBoxBuscaNome";
            this.textBoxBuscaNome.Size = new System.Drawing.Size(156, 22);
            this.textBoxBuscaNome.TabIndex = 2;
            // 
            // buttonBuscaNome
            // 
            this.buttonBuscaNome.Location = new System.Drawing.Point(382, 46);
            this.buttonBuscaNome.Name = "buttonBuscaNome";
            this.buttonBuscaNome.Size = new System.Drawing.Size(75, 31);
            this.buttonBuscaNome.TabIndex = 1;
            this.buttonBuscaNome.Text = "Buscar";
            this.buttonBuscaNome.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dataGridViewClientesCpf);
            this.tabPage3.Controls.Add(this.buttonBuscaCpfClientes);
            this.tabPage3.Controls.Add(this.textBoxBuscaCpfClientes);
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(568, 310);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "CPF";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // buttonBuscaCpfClientes
            // 
            this.buttonBuscaCpfClientes.Location = new System.Drawing.Point(334, 45);
            this.buttonBuscaCpfClientes.Name = "buttonBuscaCpfClientes";
            this.buttonBuscaCpfClientes.Size = new System.Drawing.Size(75, 30);
            this.buttonBuscaCpfClientes.TabIndex = 2;
            this.buttonBuscaCpfClientes.Text = "Buscar";
            this.buttonBuscaCpfClientes.UseVisualStyleBackColor = true;
            // 
            // textBoxBuscaCpfClientes
            // 
            this.textBoxBuscaCpfClientes.Location = new System.Drawing.Point(174, 49);
            this.textBoxBuscaCpfClientes.Name = "textBoxBuscaCpfClientes";
            this.textBoxBuscaCpfClientes.Size = new System.Drawing.Size(130, 22);
            this.textBoxBuscaCpfClientes.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Digite o CPF:";
            // 
            // Column10
            // 
            this.Column10.HeaderText = "CPF";
            this.Column10.MinimumWidth = 6;
            this.Column10.Name = "Column10";
            // 
            // Column11
            // 
            this.Column11.HeaderText = "Nome";
            this.Column11.MinimumWidth = 6;
            this.Column11.Name = "Column11";
            // 
            // Column12
            // 
            this.Column12.HeaderText = "Fone";
            this.Column12.MinimumWidth = 6;
            this.Column12.Name = "Column12";
            // 
            // Column13
            // 
            this.Column13.HeaderText = "Endereço";
            this.Column13.MinimumWidth = 6;
            this.Column13.Name = "Column13";
            // 
            // dataGridViewClientesNome
            // 
            this.dataGridViewClientesNome.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewClientesNome.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewClientesNome.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.dataGridViewClientesNome.Location = new System.Drawing.Point(24, 113);
            this.dataGridViewClientesNome.Name = "dataGridViewClientesNome";
            this.dataGridViewClientesNome.RowHeadersVisible = false;
            this.dataGridViewClientesNome.RowHeadersWidth = 51;
            this.dataGridViewClientesNome.RowTemplate.Height = 24;
            this.dataGridViewClientesNome.Size = new System.Drawing.Size(506, 167);
            this.dataGridViewClientesNome.TabIndex = 4;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "CPF";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Nome";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Fone";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Endereço";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewClientesCpf
            // 
            this.dataGridViewClientesCpf.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewClientesCpf.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewClientesCpf.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.dataGridViewClientesCpf.Location = new System.Drawing.Point(40, 112);
            this.dataGridViewClientesCpf.Name = "dataGridViewClientesCpf";
            this.dataGridViewClientesCpf.RowHeadersVisible = false;
            this.dataGridViewClientesCpf.RowHeadersWidth = 51;
            this.dataGridViewClientesCpf.RowTemplate.Height = 24;
            this.dataGridViewClientesCpf.Size = new System.Drawing.Size(506, 167);
            this.dataGridViewClientesCpf.TabIndex = 3;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "CPF";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "Nome";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "Fone";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.HeaderText = "Endereço";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // TelaVisualizarClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "TelaVisualizarClientes";
            this.ShowIcon = false;
            this.Text = "Concessionária Senac 2020";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTodosClientes)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClientesNome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClientesCpf)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button buttonBuscarTodosClientes;
        private System.Windows.Forms.DataGridView dataGridViewTodosClientes;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxBuscaNome;
        private System.Windows.Forms.Button buttonBuscaNome;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button buttonBuscaCpfClientes;
        private System.Windows.Forms.TextBox textBoxBuscaCpfClientes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column13;
        private System.Windows.Forms.DataGridView dataGridViewClientesNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridView dataGridViewClientesCpf;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
    }
}