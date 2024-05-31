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
            lblTarefaItem = new Label();
            btnGravar = new Button();
            btnCancelar = new Button();
            listDespesas = new ListBox();
            cmbNomeDespesa = new ComboBox();
            btnAdicionarItem = new Button();
            lblItemTitulo = new Label();
            lblItemTarefa = new Label();
            SuspendLayout();
            // 
            // lblTarefaItem
            // 
            lblTarefaItem.AutoSize = true;
            lblTarefaItem.Font = new Font("Segoe UI", 11.5F, FontStyle.Bold);
            lblTarefaItem.Location = new Point(110, 10);
            lblTarefaItem.Name = "lblTarefaItem";
            lblTarefaItem.Size = new Size(100, 21);
            lblTarefaItem.TabIndex = 35;
            lblTarefaItem.Text = "[ Categoria]";
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
            listDespesas.Location = new Point(27, 110);
            listDespesas.Name = "listDespesas";
            listDespesas.Size = new Size(398, 184);
            listDespesas.TabIndex = 32;
            // 
            // cmbNomeDespesa
            // 
            cmbNomeDespesa.FormattingEnabled = true;
            cmbNomeDespesa.Location = new Point(110, 49);
            cmbNomeDespesa.Name = "cmbNomeDespesa";
            cmbNomeDespesa.Size = new Size(231, 23);
            cmbNomeDespesa.TabIndex = 31;
            // 
            // btnAdicionarItem
            // 
            btnAdicionarItem.BackColor = SystemColors.Control;
            btnAdicionarItem.Location = new Point(347, 45);
            btnAdicionarItem.Name = "btnAdicionarItem";
            btnAdicionarItem.Size = new Size(79, 29);
            btnAdicionarItem.TabIndex = 30;
            btnAdicionarItem.Text = "Adicionar";
            btnAdicionarItem.UseVisualStyleBackColor = false;
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
            // TelaCadastroDespesa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(437, 341);
            Controls.Add(lblTarefaItem);
            Controls.Add(btnGravar);
            Controls.Add(btnCancelar);
            Controls.Add(listDespesas);
            Controls.Add(cmbNomeDespesa);
            Controls.Add(btnAdicionarItem);
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

        private Label lblTarefaItem;
        private Button btnGravar;
        private Button btnCancelar;
        private ListBox listDespesas;
        private ComboBox cmbNomeDespesa;
        private Button btnAdicionarItem;
        private Label lblItemTitulo;
        private Label lblItemTarefa;
    }
}