namespace eAgenda.WinApp.ModuloDespesaECategoria
{
    public partial class TelaDespesaCategoriaForm : Form
    { 
        private Categoria categoria; //Categoria

        public Categoria Categoria // propriedade 
        {
            get
            {
                return categoria;
            }
            set
            {
                txtId.Text = value.Id.ToString();
                txtCategoria.Text = value.NomeCategoria;
            }
        }
        public TelaDespesaCategoriaForm()
        {
            InitializeComponent();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            string nomeCategoria = txtCategoria.Text;

            categoria = new Categoria(nomeCategoria);

            List<string> erros = categoria.Validar();

            if (erros.Count > 0)
            {
                TelaPrincipalForm.Instancia.AtualizarRodape(erros[0]);
                DialogResult = DialogResult.None;
            }
        }
    }
}
