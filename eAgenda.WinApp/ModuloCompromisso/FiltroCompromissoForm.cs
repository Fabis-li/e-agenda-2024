
namespace eAgenda.WinApp.ModuloCompromisso
{
    public partial class FiltroCompromissoForm : Form
    {
        public TipoFiltroCompromissoEnum FiltroEscolhido { get; private set; }

        public DateTime InicioPeriodo
        { 
            get
            {
                return dtpInicioPeriodo.Value;
            }                
        }

        public DateTime TerminoPeriodo
        {
            get
            {
                return dtpTerminoPeriodo.Value;
            }
        }
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

            else if (rdbCompromissoPeriodo.Checked)
                FiltroEscolhido = TipoFiltroCompromissoEnum.Periodo;
        }

        private void rdbCompromissoPeriodo_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbCompromissoPeriodo.Checked)
            {
                dtpInicioPeriodo.Enabled = true;
                dtpTerminoPeriodo.Enabled = true;
            }
            else
            {
                dtpInicioPeriodo.Enabled = false;
                dtpTerminoPeriodo.Enabled = false;
            }
        }
    }

}
