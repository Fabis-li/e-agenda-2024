namespace eAgenda.WinApp.ModuloCompromisso
{
    partial class FiltroCompromissoForm
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
            groupBox1 = new GroupBox();
            rdbFuturosCompromissos = new RadioButton();
            rdbPassadosCompromissos = new RadioButton();
            rdbTodosCompromissos = new RadioButton();
            btnCancelar = new Button();
            btnGravar = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rdbFuturosCompromissos);
            groupBox1.Controls.Add(rdbPassadosCompromissos);
            groupBox1.Controls.Add(rdbTodosCompromissos);
            groupBox1.Font = new Font("Segoe UI", 11.5F);
            groupBox1.Location = new Point(12, 24);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(434, 127);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Selecione um Filtro";
            groupBox1.UseWaitCursor = true;
            // 
            // rdbFuturosCompromissos
            // 
            rdbFuturosCompromissos.AutoSize = true;
            rdbFuturosCompromissos.Location = new Point(25, 94);
            rdbFuturosCompromissos.Name = "rdbFuturosCompromissos";
            rdbFuturosCompromissos.Size = new Size(190, 25);
            rdbFuturosCompromissos.TabIndex = 2;
            rdbFuturosCompromissos.TabStop = true;
            rdbFuturosCompromissos.Text = "Compromissos Futuros";
            rdbFuturosCompromissos.UseVisualStyleBackColor = true;
            rdbFuturosCompromissos.UseWaitCursor = true;
            // 
            // rdbPassadosCompromissos
            // 
            rdbPassadosCompromissos.AutoSize = true;
            rdbPassadosCompromissos.Location = new Point(25, 63);
            rdbPassadosCompromissos.Name = "rdbPassadosCompromissos";
            rdbPassadosCompromissos.Size = new Size(200, 25);
            rdbPassadosCompromissos.TabIndex = 1;
            rdbPassadosCompromissos.TabStop = true;
            rdbPassadosCompromissos.Text = "Compromissos Passados";
            rdbPassadosCompromissos.UseVisualStyleBackColor = true;
            rdbPassadosCompromissos.UseWaitCursor = true;
            // 
            // rdbTodosCompromissos
            // 
            rdbTodosCompromissos.AutoSize = true;
            rdbTodosCompromissos.Location = new Point(25, 32);
            rdbTodosCompromissos.Name = "rdbTodosCompromissos";
            rdbTodosCompromissos.Size = new Size(197, 25);
            rdbTodosCompromissos.TabIndex = 0;
            rdbTodosCompromissos.TabStop = true;
            rdbTodosCompromissos.Text = "Todos os Compromissos";
            rdbTodosCompromissos.UseVisualStyleBackColor = true;
            rdbTodosCompromissos.UseWaitCursor = true;
            rdbTodosCompromissos.CheckedChanged += rdbTodosCompromissos_CheckedChanged;
            // 
            // btnCancelar
            // 
            btnCancelar.DialogResult = DialogResult.OK;
            btnCancelar.Font = new Font("Segoe UI", 11.25F);
            btnCancelar.Location = new Point(346, 157);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(100, 37);
            btnCancelar.TabIndex = 16;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnGravar
            // 
            btnGravar.DialogResult = DialogResult.OK;
            btnGravar.Font = new Font("Segoe UI", 11.25F);
            btnGravar.Location = new Point(240, 157);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(100, 37);
            btnGravar.TabIndex = 15;
            btnGravar.Text = "Gravar";
            btnGravar.UseVisualStyleBackColor = true;
            btnGravar.Click += btnGravar_Click;
            // 
            // FiltroCompromissoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(458, 202);
            Controls.Add(btnCancelar);
            Controls.Add(btnGravar);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FiltroCompromissoForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Filtro de Compromissos";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private RadioButton rdbFuturosCompromissos;
        private RadioButton rdbPassadosCompromissos;
        private RadioButton rdbTodosCompromissos;
        private Button btnCancelar;
        private Button btnGravar;
    }
}