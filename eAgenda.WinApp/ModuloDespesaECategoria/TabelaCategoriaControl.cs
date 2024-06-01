using eAgenda.WinApp.ModuloTarefa;

namespace eAgenda.WinApp.ModuloDespesaECategoria
{
    public partial class TabelaCategoriaControl : UserControl
    {
        public TabelaCategoriaControl()
        {
            InitializeComponent();

           

        }

        public void AtualizarRegistros(List<Categoria> categorias)
        {
            listCategorias.Items.Clear();
            listCategorias.Groups.Clear();//limpando grupo

            var categoriasAgrupadas = categorias.GroupBy(c => c.NomeCategoria);//agrupando por Prioridade

            foreach (var grupo in categoriasAgrupadas)
            {
                ListViewGroup listViewGroup =
                    new ListViewGroup($" {grupo.Key}", HorizontalAlignment.Left);

                listCategorias.Groups.Add(listViewGroup);

                foreach (Categoria c in grupo)
                {
                    ListViewItem item = new ListViewItem(c.Id.ToString())
                    {
                        Tag = c,
                    };

                    item.SubItems.Add(c.NomeCategoria);

                    item.Group = listViewGroup;

                    listCategorias.Items.Add(item);
                }
            }
            ConfigurarAparenciaColunas();
        }

        private void ConfigurarListView()
        {
            listCategorias.MultiSelect = false;
            listCategorias.FullRowSelect = true; //seleciona a linha inteira da tabela
            listCategorias.GridLines = true; //exibe as linhas da tabela (grid)

            listCategorias.View = View.Details;
        }

        public int ObterIdSelecionado()
        {
            if (listCategorias.SelectedItems.Count == 0)
                return -1;

            var tarefaSelecionada = (Categoria)listCategorias.SelectedItems[0].Tag;

            return tarefaSelecionada.Id;
        }

        private void ConfigurarColunas()
        {
            ColumnHeader[] colunas = new ColumnHeader[]
            {
                new ColumnHeader() {Text = "Id"},
                new ColumnHeader() {Text = "Nome da Categoria" },
                //new ColumnHeader() {Text = "Data de Criação"},
                //new ColumnHeader() {Text = "% Concluído", TextAlign = HorizontalAlignment.Right},
            };

            listCategorias.Columns.AddRange(colunas);
        }

        private void ConfigurarAparenciaColunas()
        {
            listCategorias.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

            //listCategorias.Columns[0].Width = 80;// definindo o width como padrão para a primeira coluna
        }
    }
}
