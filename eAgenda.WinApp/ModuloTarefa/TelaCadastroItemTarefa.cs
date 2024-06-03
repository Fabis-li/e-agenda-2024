

namespace eAgenda.WinApp.ModuloTarefa
{
    public partial class TelaCadastroItemTarefa : Form
    {
        private Tarefa tarefa;

        private Tarefa Tarefa
        {
            get
            {
                return tarefa;
            }
            set
            {
                tarefa = value;
            }
        }
        public List<ItemTarefa> ItensAdicionados
        {
            get
            {
                //List<ItemTarefa> itensAdicionados = new List<ItemTarefa>();

                //foreach (ItemTarefa item in listItensTarefa.Items)
                //{
                //    itensAdicionados.Add(item);
                //}
                //return itensAdicionados;

                return listItensTarefa.Items.Cast<ItemTarefa>().ToList();
            }

        }

        public TelaCadastroItemTarefa(Tarefa tarefaSelecionada)
        {
            InitializeComponent();

            Tarefa = tarefaSelecionada;

            lblTarefaItem.Text = tarefaSelecionada.Titulo; //pegando o titulo da tarefa

            foreach (ItemTarefa item in tarefaSelecionada.Itens)
                listItensTarefa.Items.Add(item);
        }

        private void btnAdicionarItem_Click(object sender, EventArgs e)
        {
            List<string> titulos = ItensAdicionados.Select(x => x.Titulo).ToList(); // pegando titulo do item

            if (titulos.Contains(cmbItemTitulo.Text)) //validando para não adicionar o mesmo item 2x
                return;

            ItemTarefa itemTarefa = new ItemTarefa(cmbItemTitulo.Text);

            listItensTarefa.Items.Add(itemTarefa);
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            return;
        }

        private void TelaCadastroItemTarefa_Load(object sender, EventArgs e)
        {

        }

    }
}
