namespace eAgenda.WinApp.ModuloCompromisso
{
    partial class TelaCompromissoForm
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
            label1 = new Label();
            txtAssunto = new TextBox();
            txtId = new TextBox();
            label3 = new Label();
            groupBox1 = new GroupBox();
            txtLocalOnline = new TextBox();
            txtLocalPresencial = new TextBox();
            rdbOnline = new RadioButton();
            rdbPrensencial = new RadioButton();
            label2 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            chkContato = new CheckBox();
            label7 = new Label();
            btnGravar = new Button();
            btnCancelar = new Button();
            dtpData = new DateTimePicker();
            dtpHoraInicio = new DateTimePicker();
            dtpHoraFinal = new DateTimePicker();
            cmbListaContato = new ComboBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F);
            label1.Location = new Point(52, 59);
            label1.Name = "label1";
            label1.Size = new Size(64, 20);
            label1.TabIndex = 0;
            label1.Text = "Assunto:";
            // 
            // txtAssunto
            // 
            txtAssunto.Location = new Point(122, 56);
            txtAssunto.Name = "txtAssunto";
            txtAssunto.Size = new Size(269, 23);
            txtAssunto.TabIndex = 1;
            // 
            // txtId
            // 
            txtId.Enabled = false;
            txtId.Location = new Point(122, 27);
            txtId.Name = "txtId";
            txtId.Size = new Size(93, 23);
            txtId.TabIndex = 5;
            txtId.Text = "0";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F);
            label3.Location = new Point(91, 27);
            label3.Name = "label3";
            label3.Size = new Size(25, 20);
            label3.TabIndex = 4;
            label3.Text = "Id:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtLocalOnline);
            groupBox1.Controls.Add(txtLocalPresencial);
            groupBox1.Controls.Add(rdbOnline);
            groupBox1.Controls.Add(rdbPrensencial);
            groupBox1.Font = new Font("Segoe UI", 11.25F);
            groupBox1.Location = new Point(52, 177);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(509, 138);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Local";
            // 
            // txtLocalOnline
            // 
            txtLocalOnline.Location = new Point(115, 70);
            txtLocalOnline.Name = "txtLocalOnline";
            txtLocalOnline.Size = new Size(384, 27);
            txtLocalOnline.TabIndex = 3;
            // 
            // txtLocalPresencial
            // 
            txtLocalPresencial.Location = new Point(115, 28);
            txtLocalPresencial.Name = "txtLocalPresencial";
            txtLocalPresencial.Size = new Size(384, 27);
            txtLocalPresencial.TabIndex = 2;
            // 
            // rdbOnline
            // 
            rdbOnline.AutoSize = true;
            rdbOnline.Font = new Font("Segoe UI", 11.25F);
            rdbOnline.Location = new Point(15, 73);
            rdbOnline.Name = "rdbOnline";
            rdbOnline.Size = new Size(70, 24);
            rdbOnline.TabIndex = 1;
            rdbOnline.TabStop = true;
            rdbOnline.Text = "Online";
            rdbOnline.UseVisualStyleBackColor = true;
            rdbOnline.CheckedChanged += rdbOnline_CheckedChanged;
            // 
            // rdbPrensencial
            // 
            rdbPrensencial.AutoSize = true;
            rdbPrensencial.Font = new Font("Segoe UI", 11.25F);
            rdbPrensencial.Location = new Point(16, 31);
            rdbPrensencial.Name = "rdbPrensencial";
            rdbPrensencial.Size = new Size(93, 24);
            rdbPrensencial.TabIndex = 0;
            rdbPrensencial.TabStop = true;
            rdbPrensencial.Text = "Presencial";
            rdbPrensencial.UseVisualStyleBackColor = true;
            rdbPrensencial.CheckedChanged += rdbPrensencial_CheckedChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F);
            label2.Location = new Point(68, 85);
            label2.Name = "label2";
            label2.Size = new Size(44, 20);
            label2.TabIndex = 7;
            label2.Text = "Data:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F);
            label4.Location = new Point(57, 119);
            label4.Name = "label4";
            label4.Size = new Size(103, 20);
            label4.TabIndex = 8;
            label4.Text = "Horário Início:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11.25F);
            label5.Location = new Point(332, 114);
            label5.Name = "label5";
            label5.Size = new Size(98, 20);
            label5.TabIndex = 9;
            label5.Text = "Horário Final:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11.25F);
            label6.Location = new Point(57, 158);
            label6.Name = "label6";
            label6.Size = new Size(214, 20);
            label6.TabIndex = 10;
            label6.Text = "Deseja selecionar um Contato?";
            // 
            // chkContato
            // 
            chkContato.AutoSize = true;
            chkContato.Location = new Point(277, 164);
            chkContato.Name = "chkContato";
            chkContato.Size = new Size(15, 14);
            chkContato.TabIndex = 11;
            chkContato.UseVisualStyleBackColor = true;
            chkContato.CheckedChanged += chkContato_CheckedChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11.25F);
            label7.Location = new Point(340, 156);
            label7.Name = "label7";
            label7.Size = new Size(65, 20);
            label7.TabIndex = 12;
            label7.Text = "Contato:";
            // 
            // btnGravar
            // 
            btnGravar.DialogResult = DialogResult.OK;
            btnGravar.Font = new Font("Segoe UI", 11.25F);
            btnGravar.Location = new Point(330, 332);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(100, 37);
            btnGravar.TabIndex = 13;
            btnGravar.Text = "Gravar";
            btnGravar.UseVisualStyleBackColor = true;
            btnGravar.Click += btnGravar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.DialogResult = DialogResult.OK;
            btnCancelar.Font = new Font("Segoe UI", 11.25F);
            btnCancelar.Location = new Point(436, 332);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(100, 37);
            btnCancelar.TabIndex = 14;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // dtpData
            // 
            dtpData.CustomFormat = "";
            dtpData.Format = DateTimePickerFormat.Custom;
            dtpData.Location = new Point(122, 83);
            dtpData.Name = "dtpData";
            dtpData.Size = new Size(97, 23);
            dtpData.TabIndex = 16;
            // 
            // dtpHoraInicio
            // 
            dtpHoraInicio.CustomFormat = "HH:mm";
            dtpHoraInicio.Format = DateTimePickerFormat.Custom;
            dtpHoraInicio.Location = new Point(166, 116);
            dtpHoraInicio.Name = "dtpHoraInicio";
            dtpHoraInicio.ShowUpDown = true;
            dtpHoraInicio.Size = new Size(105, 23);
            dtpHoraInicio.TabIndex = 17;
            // 
            // dtpHoraFinal
            // 
            dtpHoraFinal.CustomFormat = "HH:mm";
            dtpHoraFinal.Format = DateTimePickerFormat.Custom;
            dtpHoraFinal.Location = new Point(436, 112);
            dtpHoraFinal.Name = "dtpHoraFinal";
            dtpHoraFinal.ShowUpDown = true;
            dtpHoraFinal.Size = new Size(105, 23);
            dtpHoraFinal.TabIndex = 18;
            // 
            // cmbListaContato
            // 
            cmbListaContato.FormattingEnabled = true;
            cmbListaContato.Items.AddRange(new object[] { "a", "b", "c", "d" });
            cmbListaContato.Location = new Point(411, 153);
            cmbListaContato.Name = "cmbListaContato";
            cmbListaContato.Size = new Size(138, 23);
            cmbListaContato.TabIndex = 19;
            // 
            // TelaCompromissoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(573, 381);
            Controls.Add(cmbListaContato);
            Controls.Add(dtpHoraFinal);
            Controls.Add(dtpHoraInicio);
            Controls.Add(dtpData);
            Controls.Add(btnCancelar);
            Controls.Add(btnGravar);
            Controls.Add(label7);
            Controls.Add(chkContato);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(groupBox1);
            Controls.Add(txtId);
            Controls.Add(label3);
            Controls.Add(txtAssunto);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TelaCompromissoForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Cadastro de Compromissos";
            Load += TelaCompromissoForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtAssunto;
        private TextBox txtId;
        private Label label3;
        private GroupBox groupBox1;
        private TextBox txtLocalOnline;
        private TextBox txtLocalPresencial;
        private RadioButton rdbOnline;
        private RadioButton rdbPrensencial;
        private Label label2;
        private Label label4;
        private Label label5;
        private Label label6;
        private CheckBox chkContato;
        private Label label7;
        private Button btnGravar;
        private Button btnCancelar;
        private DateTimePicker dtpData;
        private DateTimePicker dtpHoraInicio;
        private DateTimePicker dtpHoraFinal;
        private ComboBox cmbListaContato;
    }
}