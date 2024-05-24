
namespace eAgenda.WinApp.ModuloCompromisso
{
    public partial class FiltroCompromissoForm : Form
    {
        public TipoFiltroCompromissoEnum FiltroEscolhido { get; private set; }
        public FiltroCompromissoForm()
        {
            InitializeComponent();
        }

        private void rdbTodosCompromissos_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            if (rdbTodosCompromissos.Checked)
                FiltroEscolhido = TipoFiltroCompromissoEnum.Todos;

            else if (rdbPassadosCompromissos.Checked)
                FiltroEscolhido = TipoFiltroCompromissoEnum.Passados;

            else if (rdbFuturosCompromissos.Checked)
                FiltroEscolhido = TipoFiltroCompromissoEnum.Futuro;
        }
    }

}
