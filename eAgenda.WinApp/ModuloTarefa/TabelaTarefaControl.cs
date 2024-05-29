namespace eAgenda.WinApp.ModuloTarefa
{
    public partial class TabelaTarefaControl : UserControl
    {
        public TabelaTarefaControl()
        {
            InitializeComponent();

            ConfigurarColunas();
            ConfigurarListView();
        }

        public void AtualizarRegistros(List<Tarefa> tarefas)
        {
            listTarefas.Items.Clear();
            listTarefas.Groups.Clear();//limpando grupo

             var tarefasAgrupadas = tarefas.GroupBy(t => t.Prioridade);//agrupando por Prioridade

            foreach(var grupo in tarefasAgrupadas)
            {
                ListViewGroup listViewGroup =
                    new ListViewGroup($"Prioridade {grupo.Key}", HorizontalAlignment.Left);

                listTarefas.Groups.Add(listViewGroup);

                foreach (Tarefa t in grupo)
                {
                    ListViewItem item = new ListViewItem(t.Id.ToString());

                    item.SubItems.Add(t.Titulo);
                    item.SubItems.Add(t.DataCriacao.ToShortDateString());

                    item.Group = listViewGroup;

                    listTarefas.Items.Add(item);
                }
            }              
        }

        private void ConfigurarListView()
        {
            listTarefas.MultiSelect = false;
            listTarefas.FullRowSelect = true; //seleciona a linha inteira da tabela
            listTarefas.GridLines = true; //exibe as linhas da tabela (grid)

            listTarefas.View = View.Details;
        }

        private void ConfigurarColunas()
        {
            ColumnHeader[] colunas = new ColumnHeader[]
            {
                new ColumnHeader() {Text = "Id", Width = 80},
                new ColumnHeader() {Text = "Título", Width = 200},
                new ColumnHeader() {Text = "Data de Criação", Width = 100},
            };

            listTarefas.Columns.AddRange(colunas);
        }
    }
}
