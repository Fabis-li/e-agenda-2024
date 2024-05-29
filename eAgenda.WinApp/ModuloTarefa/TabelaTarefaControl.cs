﻿namespace eAgenda.WinApp.ModuloTarefa
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

            foreach (Tarefa t in tarefas)
                listTarefas.Items.Add(t.Titulo);
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
