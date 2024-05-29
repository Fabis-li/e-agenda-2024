namespace eAgenda.WinApp.ModuloTarefa
{
    public partial class TelaTarefaForm : Form
    {
        private Tarefa tarefa;
        public Tarefa Tarefa 
        {
            get
            {
                return tarefa;
            }
        }

        public TelaTarefaForm()
        {
            InitializeComponent();
        }

        private void TelaTarefaForm_Load(object sender, EventArgs e)
        {

        }
    }
}
