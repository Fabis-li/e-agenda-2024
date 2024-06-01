namespace eAgenda.WinApp.ModuloDespesaECategoria
{
    partial class TabelaCategoriaControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            listCategorias = new ListView();
            SuspendLayout();
            // 
            // listCategorias
            // 
            listCategorias.Dock = DockStyle.Fill;
            listCategorias.Location = new Point(0, 0);
            listCategorias.Name = "listCategorias";
            listCategorias.Size = new Size(728, 358);
            listCategorias.TabIndex = 0;
            listCategorias.UseCompatibleStateImageBehavior = false;
            // 
            // TabelaCategoriaControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(listCategorias);
            Name = "TabelaCategoriaControl";
            Size = new Size(728, 358);
            ResumeLayout(false);
        }

        #endregion

        private ListView listCategorias;
    }
}
