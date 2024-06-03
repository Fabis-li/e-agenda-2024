namespace eAgenda.WinApp.ModuloTarefa
{
    partial class TelaCadastroItemTarefa
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
            lblItemTarefa = new Label();
            lblItemTitulo = new Label();
            btnAdicionarItem = new Button();
            cmbItemTitulo = new ComboBox();
            listItensTarefa = new ListBox();
            btnGravar = new Button();
            btnCancelar = new Button();
            lblTarefaItem = new Label();
            SuspendLayout();
            // 
            // lblItemTarefa
            // 
            lblItemTarefa.AutoSize = true;
            lblItemTarefa.Font = new Font("Segoe UI", 11.25F);
            lblItemTarefa.Location = new Point(22, 22);
            lblItemTarefa.Name = "lblItemTarefa";
            lblItemTarefa.Size = new Size(52, 20);
            lblItemTarefa.TabIndex = 8;
            lblItemTarefa.Text = "Tarefa:";
            // 
            // lblItemTitulo
            // 
            lblItemTitulo.AutoSize = true;
            lblItemTitulo.Font = new Font("Segoe UI", 11.25F);
            lblItemTitulo.Location = new Point(22, 63);
            lblItemTitulo.Name = "lblItemTitulo";
            lblItemTitulo.Size = new Size(50, 20);
            lblItemTitulo.TabIndex = 10;
            lblItemTitulo.Text = "Título:";
            // 
            // btnAdicionarItem
            // 
            btnAdicionarItem.BackColor = SystemColors.Control;
            btnAdicionarItem.Location = new Point(315, 56);
            btnAdicionarItem.Name = "btnAdicionarItem";
            btnAdicionarItem.Size = new Size(79, 29);
            btnAdicionarItem.TabIndex = 12;
            btnAdicionarItem.Text = "Adicionar";
            btnAdicionarItem.UseVisualStyleBackColor = false;
            btnAdicionarItem.Click += btnAdicionarItem_Click;
            // 
            // cmbItemTitulo
            // 
            cmbItemTitulo.FormattingEnabled = true;
            cmbItemTitulo.Location = new Point(78, 60);
            cmbItemTitulo.Name = "cmbItemTitulo";
            cmbItemTitulo.Size = new Size(231, 23);
            cmbItemTitulo.TabIndex = 13;            
            // 
            // listItensTarefa
            // 
            listItensTarefa.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listItensTarefa.FormattingEnabled = true;
            listItensTarefa.ItemHeight = 20;
            listItensTarefa.Location = new Point(22, 104);
            listItensTarefa.Name = "listItensTarefa";
            listItensTarefa.Size = new Size(372, 184);
            listItensTarefa.TabIndex = 14;
            // 
            // btnGravar
            // 
            btnGravar.DialogResult = DialogResult.OK;
            btnGravar.Font = new Font("Segoe UI", 11.25F);
            btnGravar.Location = new Point(188, 311);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(100, 37);
            btnGravar.TabIndex = 25;
            btnGravar.Text = "Gravar";
            btnGravar.UseVisualStyleBackColor = true;
            btnGravar.Click += btnGravar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Font = new Font("Segoe UI", 11.25F);
            btnCancelar.Location = new Point(294, 311);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(100, 37);
            btnCancelar.TabIndex = 26;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // lblTarefaItem
            // 
            lblTarefaItem.AutoSize = true;
            lblTarefaItem.Font = new Font("Segoe UI", 11.5F, FontStyle.Bold);
            lblTarefaItem.Location = new Point(78, 21);
            lblTarefaItem.Name = "lblTarefaItem";
            lblTarefaItem.Size = new Size(126, 21);
            lblTarefaItem.TabIndex = 27;
            lblTarefaItem.Text = "[ Titulo Tarefa ]";
            // 
            // TelaCadastroItemTarefa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(424, 353);
            Controls.Add(lblTarefaItem);
            Controls.Add(btnGravar);
            Controls.Add(btnCancelar);
            Controls.Add(listItensTarefa);
            Controls.Add(cmbItemTitulo);
            Controls.Add(btnAdicionarItem);
            Controls.Add(lblItemTitulo);
            Controls.Add(lblItemTarefa);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TelaCadastroItemTarefa";
            Text = "Cadastro de Itens da Tarefa";
            Load += TelaCadastroItemTarefa_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblItemTarefa;
        private Label lblItemTitulo;
        private Button btnAdicionarItem;
        private ComboBox cmbItemTitulo;
        private ListBox listItensTarefa;
        private Button btnGravar;
        private Button btnCancelar;
        private Label lblTarefaItem;
    }
}