using eAgenda.WinApp.Compartilhado;

namespace eAgenda.WinApp.ModuloTarefa
{
    public partial class TabelaTarefaControl : UserControl
    {
        public TabelaTarefaControl()
        {
            InitializeComponent();

            grid.Columns.AddRange(ObterColunas());

            grid.ConfigurarGridSomenteLeitura();
            grid.ConfigurarGridZebrado();
        }

        public void AtualizarRegistros(List<Tarefa> tarefas)
        {
            grid.Rows.Clear();

            foreach(Tarefa t in tarefas)
            {
                grid.Rows.Add(
                    t.Id,
                    t.Titulo,
                    t.Prioridade,
                    t.DataCriacao.ToShortDateString(),
                    t.DataConclusao.ToShortDateString(),
                    t.PercentualConclusao
                    );
            }
        }

        private DataGridViewColumn[] ObterColunas()
        {
            return new DataGridViewColumn[]
            {
                new DataGridViewTextBoxColumn { DataPropertyName = "Id", HeaderText = "Id" },
                new DataGridViewTextBoxColumn { DataPropertyName = "Titulo", HeaderText = "Titulo" },
                new DataGridViewTextBoxColumn { DataPropertyName = "DataCriacao", HeaderText = "Data Criação" },
                new DataGridViewTextBoxColumn { DataPropertyName = "DataConclusao", HeaderText = "Data Conclusão" },
                new DataGridViewTextBoxColumn { DataPropertyName = "PercentualConcluido", HeaderText = "% Concluido" },
                new DataGridViewTextBoxColumn { DataPropertyName = "Itens", HeaderText = "Descrição Itens" },
            };
        }
    }
}
