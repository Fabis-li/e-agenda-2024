namespace eAgenda.WinApp.ModuloDespesaECategoria
{
    partial class TelaCadastroDespesa
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
            lblDespesa = new Label();
            btnGravar = new Button();
            btnCancelar = new Button();
            listDespesas = new ListBox();
            btnAdicionarDespesa = new Button();
            lblItemTitulo = new Label();
            lblItemTarefa = new Label();
            label1 = new Label();
            cmbFormaPagamento = new ComboBox();
            label2 = new Label();
            cmbNomeDespesa = new ComboBox();
            txtValorDespesa = new TextBox();
            SuspendLayout();
            // 
            // lblDespesa
            // 
            lblDespesa.AutoSize = true;
            lblDespesa.Font = new Font("Segoe UI", 11.5F, FontStyle.Bold);
            lblDespesa.Location = new Point(110, 10);
            lblDespesa.Name = "lblDespesa";
            lblDespesa.Size = new Size(100, 21);
            lblDespesa.TabIndex = 35;
            lblDespesa.Text = "[ Categoria]";
            // 
            // btnGravar
            // 
            btnGravar.DialogResult = DialogResult.OK;
            btnGravar.Font = new Font("Segoe UI", 11.25F);
            btnGravar.Location = new Point(220, 300);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(100, 37);
            btnGravar.TabIndex = 33;
            btnGravar.Text = "Gravar";
            btnGravar.UseVisualStyleBackColor = true;
            btnGravar.Click += btnGravar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Font = new Font("Segoe UI", 11.25F);
            btnCancelar.Location = new Point(326, 300);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(100, 37);
            btnCancelar.TabIndex = 34;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // listDespesas
            // 
            listDespesas.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listDespesas.FormattingEnabled = true;
            listDespesas.ItemHeight = 20;
            listDespesas.Location = new Point(27, 170);
            listDespesas.Name = "listDespesas";
            listDespesas.Size = new Size(398, 124);
            listDespesas.TabIndex = 32;
            // 
            // btnAdicionarDespesa
            // 
            btnAdicionarDespesa.BackColor = SystemColors.Control;
            btnAdicionarDespesa.Location = new Point(347, 45);
            btnAdicionarDespesa.Name = "btnAdicionarDespesa";
            btnAdicionarDespesa.Size = new Size(79, 100);
            btnAdicionarDespesa.TabIndex = 30;
            btnAdicionarDespesa.Text = "Adicionar";
            btnAdicionarDespesa.UseVisualStyleBackColor = false;
            btnAdicionarDespesa.Click += btnAdicionarDespesa_Click;
            // 
            // lblItemTitulo
            // 
            lblItemTitulo.AutoSize = true;
            lblItemTitulo.Font = new Font("Segoe UI", 11.25F);
            lblItemTitulo.Location = new Point(36, 52);
            lblItemTitulo.Name = "lblItemTitulo";
            lblItemTitulo.Size = new Size(68, 20);
            lblItemTitulo.TabIndex = 29;
            lblItemTitulo.Text = "Despesa:";
            // 
            // lblItemTarefa
            // 
            lblItemTarefa.AutoSize = true;
            lblItemTarefa.Font = new Font("Segoe UI", 11.25F);
            lblItemTarefa.Location = new Point(27, 11);
            lblItemTarefa.Name = "lblItemTarefa";
            lblItemTarefa.Size = new Size(77, 20);
            lblItemTarefa.TabIndex = 28;
            lblItemTarefa.Text = "Categoria:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F);
            label1.Location = new Point(58, 87);
            label1.Name = "label1";
            label1.Size = new Size(46, 20);
            label1.TabIndex = 36;
            label1.Text = "Valor:";
            // 
            // cmbFormaPagamento
            // 
            cmbFormaPagamento.FormattingEnabled = true;
            cmbFormaPagamento.Location = new Point(196, 122);
            cmbFormaPagamento.Name = "cmbFormaPagamento";
            cmbFormaPagamento.Size = new Size(145, 23);
            cmbFormaPagamento.TabIndex = 39;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F);
            label2.Location = new Point(36, 125);
            label2.Name = "label2";
            label2.Size = new Size(154, 20);
            label2.TabIndex = 38;
            label2.Text = "Forma de Pagamento:";
            // 
            // cmbNomeDespesa
            // 
            cmbNomeDespesa.FormattingEnabled = true;
            cmbNomeDespesa.Location = new Point(110, 52);
            cmbNomeDespesa.Name = "cmbNomeDespesa";
            cmbNomeDespesa.Size = new Size(231, 23);
            cmbNomeDespesa.TabIndex = 42;
            // 
            // txtValorDespesa
            // 
            txtValorDespesa.Font = new Font("Segoe UI", 11.25F);
            txtValorDespesa.Location = new Point(110, 81);
            txtValorDespesa.Name = "txtValorDespesa";
            txtValorDespesa.Size = new Size(231, 27);
            txtValorDespesa.TabIndex = 43;
            // 
            // TelaCadastroDespesa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(437, 341);
            Controls.Add(txtValorDespesa);
            Controls.Add(cmbNomeDespesa);
            Controls.Add(cmbFormaPagamento);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblDespesa);
            Controls.Add(btnGravar);
            Controls.Add(btnCancelar);
            Controls.Add(listDespesas);
            Controls.Add(btnAdicionarDespesa);
            Controls.Add(lblItemTitulo);
            Controls.Add(lblItemTarefa);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TelaCadastroDespesa";
            ShowIcon = false;
            Text = "Cadastro de Despesas";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblDespesa;
        private Button btnGravar;
        private Button btnCancelar;
        private ListBox listDespesas;
        private Button btnAdicionarDespesa;
        private Label lblItemTitulo;
        private Label lblItemTarefa;
        private Label label1;
        private ComboBox cmbFormaPagamento;
        private Label label2;
        private ComboBox cmbNomeDespesa;
        private TextBox txtValorDespesa;
    }
}