namespace eAgenda.WinApp.ModuloTarefa
{
    partial class TelaAtualizacaoItemTarefa
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
            lblItemTarefa = new Label();
            btnGravar = new Button();
            btnCancelar = new Button();
            listItensTarefa = new CheckedListBox();
            SuspendLayout();
            // 
            // lblTarefaItem
            // 
            lblTarefaItem.AutoSize = true;
            lblTarefaItem.Font = new Font("Segoe UI", 11.5F, FontStyle.Bold);
            lblTarefaItem.Location = new Point(80, 23);
            lblTarefaItem.Name = "lblTarefaItem";
            lblTarefaItem.Size = new Size(126, 21);
            lblTarefaItem.TabIndex = 29;
            lblTarefaItem.Text = "[ Titulo Tarefa ]";
            // 
            // lblItemTarefa
            // 
            lblItemTarefa.AutoSize = true;
            lblItemTarefa.Font = new Font("Segoe UI", 11.25F);
            lblItemTarefa.Location = new Point(24, 24);
            lblItemTarefa.Name = "lblItemTarefa";
            lblItemTarefa.Size = new Size(52, 20);
            lblItemTarefa.TabIndex = 28;
            lblItemTarefa.Text = "Tarefa:";
            // 
            // btnGravar
            // 
            btnGravar.DialogResult = DialogResult.OK;
            btnGravar.Font = new Font("Segoe UI", 11.25F);
            btnGravar.Location = new Point(200, 283);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(100, 37);
            btnGravar.TabIndex = 30;
            btnGravar.Text = "Gravar";
            btnGravar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Font = new Font("Segoe UI", 11.25F);
            btnCancelar.Location = new Point(306, 283);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(100, 37);
            btnCancelar.TabIndex = 31;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // listItensTarefa
            // 
            listItensTarefa.CheckOnClick = true;
            listItensTarefa.FormattingEnabled = true;
            listItensTarefa.Location = new Point(24, 57);
            listItensTarefa.Name = "listItensTarefa";
            listItensTarefa.Size = new Size(384, 220);
            listItensTarefa.TabIndex = 0;
            // 
            // TelaAtualizacaoItemTarefa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(418, 325);
            Controls.Add(listItensTarefa);
            Controls.Add(btnGravar);
            Controls.Add(btnCancelar);
            Controls.Add(lblTarefaItem);
            Controls.Add(lblItemTarefa);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TelaAtualizacaoItemTarefa";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Atualização dos Itens da Tarefa";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTarefaItem;
        private Label lblItemTarefa;
        private Button btnGravar;
        private Button btnCancelar;
        private CheckedListBox listItensTarefa;
    }
}