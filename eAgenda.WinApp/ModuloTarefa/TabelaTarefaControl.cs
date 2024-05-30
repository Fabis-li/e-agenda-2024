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

            foreach (var grupo in tarefasAgrupadas)
            {
                ListViewGroup listViewGroup =
                    new ListViewGroup($"Prioridade {grupo.Key}", HorizontalAlignment.Left);

                listTarefas.Groups.Add(listViewGroup);

                foreach (Tarefa t in grupo)
                {
                    ListViewItem item = new ListViewItem(t.Id.ToString())
                    {
                        Tag = t,
                    };

                    item.SubItems.Add(t.Titulo);
                    item.SubItems.Add(t.DataCriacao.ToShortDateString());
                    item.SubItems.Add(t.PercentualConcluido + "%");

                    item.Group = listViewGroup;

                    listTarefas.Items.Add(item);
                }
            }
            ConfigurarAparenciaColunas();
        }       

        private void ConfigurarListView()
        {
            listTarefas.MultiSelect = false;
            listTarefas.FullRowSelect = true; //seleciona a linha inteira da tabela
            listTarefas.GridLines = true; //exibe as linhas da tabela (grid)

            listTarefas.View = View.Details;
        }

        public int ObterIdSelecionado()
        {
            if(listTarefas.SelectedItems.Count == 0)
                return -1;

            var tarefaSelecionada = (Tarefa)listTarefas.SelectedItems[0].Tag;

            return tarefaSelecionada.Id;
        }

        private void ConfigurarColunas()
        {
            ColumnHeader[] colunas = new ColumnHeader[]
            {
                new ColumnHeader() {Text = "Id"},
                new ColumnHeader() {Text = "Título" },
                new ColumnHeader() {Text = "Data de Criação"},
                new ColumnHeader() {Text = "% Concluído", TextAlign = HorizontalAlignment.Right},
            };

            listTarefas.Columns.AddRange(colunas);
        }

        private void ConfigurarAparenciaColunas()
        {
            listTarefas.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

            listTarefas.Columns[0].Width = 80;// definindo o width como padrão para a primeira coluna
        }
    }
}
