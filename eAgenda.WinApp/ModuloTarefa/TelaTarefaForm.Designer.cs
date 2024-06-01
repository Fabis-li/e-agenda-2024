namespace eAgenda.WinApp.ModuloTarefa
{
    partial class TelaDespesaCategoriaForm
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
            txtTitulo = new TextBox();
            label2 = new Label();
            txtId = new TextBox();
            label1 = new Label();
            btnGravar = new Button();
            btnCancelar = new Button();
            label5 = new Label();
            cmbPrioridades = new ComboBox();
            SuspendLayout();
            // 
            // txtTitulo
            // 
            txtTitulo.Font = new Font("Segoe UI", 11.25F);
            txtTitulo.Location = new Point(133, 63);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(344, 27);
            txtTitulo.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F);
            label2.Location = new Point(12, 66);
            label2.Name = "label2";
            label2.Size = new Size(115, 20);
            label2.TabIndex = 6;
            label2.Text = "Título da Tarefa:";
            // 
            // txtId
            // 
            txtId.Enabled = false;
            txtId.Font = new Font("Segoe UI", 11.25F);
            txtId.Location = new Point(133, 30);
            txtId.Name = "txtId";
            txtId.Size = new Size(100, 27);
            txtId.TabIndex = 5;
            txtId.Text = "0";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F);
            label1.Location = new Point(102, 33);
            label1.Name = "label1";
            label1.Size = new Size(25, 20);
            label1.TabIndex = 4;
            label1.Text = "Id:";
            // 
            // btnGravar
            // 
            btnGravar.DialogResult = DialogResult.OK;
            btnGravar.Font = new Font("Segoe UI", 11.25F);
            btnGravar.Location = new Point(271, 153);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(100, 37);
            btnGravar.TabIndex = 23;
            btnGravar.Text = "Gravar";
            btnGravar.UseVisualStyleBackColor = true;
            btnGravar.Click += btnGravar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Font = new Font("Segoe UI", 11.25F);
            btnCancelar.Location = new Point(377, 153);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(100, 37);
            btnCancelar.TabIndex = 24;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11.25F);
            label5.Location = new Point(46, 102);
            label5.Name = "label5";
            label5.Size = new Size(81, 20);
            label5.TabIndex = 25;
            label5.Text = "Prioridade:";
            // 
            // cmbPrioridades
            // 
            cmbPrioridades.FormattingEnabled = true;
            cmbPrioridades.Location = new Point(133, 103);
            cmbPrioridades.Name = "cmbPrioridades";
            cmbPrioridades.Size = new Size(144, 23);
            cmbPrioridades.TabIndex = 26;
            // 
            // TelaTarefaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(507, 202);
            Controls.Add(cmbPrioridades);
            Controls.Add(label5);
            Controls.Add(btnGravar);
            Controls.Add(btnCancelar);
            Controls.Add(txtTitulo);
            Controls.Add(label2);
            Controls.Add(txtId);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TelaTarefaForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = " Cadastro de Tarefa";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtTitulo;
        private Label label2;
        private TextBox txtId;
        private Label label1;
        private Button btnGravar;
        private Button btnCancelar;
        private Label label5;
        private ComboBox cmbPrioridades;
    }
}