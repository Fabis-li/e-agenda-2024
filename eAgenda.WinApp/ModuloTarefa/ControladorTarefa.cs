using eAgenda.WinApp.Compartilhado;
using eAgenda.WinApp.ModuloContato;

namespace eAgenda.WinApp.ModuloTarefa
{
    public class ControladorTarefa : ControladorBase
    {
        
        private TabelaTarefaControl listTarefa;

        private RepositorioTarefa repositorioTarefa;
        public override string TipoCadastro { get { return "Tarefas"; } }

        public override string ToolTipAdicionar { get { return "Cadastrar uma nova tarefa"; } }

        public override string ToolTipEditar { get { return "Editar uma tarefa existente"; } }

        public override string ToolTipExcluir { get { return "Excluir uma tarefa existente"; } }

        public ControladorTarefa(RepositorioTarefa repositorio)
        {
            repositorioTarefa = repositorio;
        }
        public override void Adicionar()
        {            
            TelaTarefaForm telaTarefa = new TelaTarefaForm();            

            DialogResult resultado = telaTarefa.ShowDialog();

            if (resultado == DialogResult.OK)
                return;

            Tarefa novaTarefa = telaTarefa.Tarefa;

            repositorioTarefa.Cadastrar(novaTarefa);

            CarregarTarefas();

            TelaPrincipalForm
                .Instancia
                .AtualizarRodape($"O registro \"{novaTarefa.Titulo}\" foi criado com sucesso!");
        }

        public override void Editar()
        {
            TelaTarefaForm telaTarefa = new TelaTarefaForm();

            int idSelecionado = listTarefa.ObterIdSelecionado();

            Tarefa tarefaSelecionada = repositorioTarefa.SelecionarPorId(idSelecionado);

            if (tarefaSelecionada == null)
            {
                MessageBox.Show(
                    "Não é possivel realiza esta ação sem um registro selecionado.",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            telaTarefa.Tarefa = tarefaSelecionada;

            DialogResult resultado = telaTarefa.ShowDialog();

            if (resultado != DialogResult.OK)
                return;

            Tarefa tarefaEditada = telaTarefa.Tarefa;

            repositorioTarefa.Editar(tarefaSelecionada.Id, tarefaEditada);

            CarregarTarefas();

            TelaPrincipalForm
                .Instancia
                .AtualizarRodape($"O registro \"{tarefaEditada.Titulo}\" foi editado com sucesso!");
        }

        public override void Excluir()
        {
            int idSelecionado = listTarefa.ObterIdSelecionado();

            Tarefa tarefaSelecionada = repositorioTarefa.SelecionarPorId(idSelecionado);

            if (tarefaSelecionada == null)
            {
                MessageBox.Show(
                    "Não é possivel realiza esta ação sem um registro selecionado.",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }


            DialogResult resposta = MessageBox.Show(
                $"Você deseja realmente excluir o registro \"{tarefaSelecionada.Titulo}\"?",
                "Confirmar Exclusão",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (resposta != DialogResult.Yes)
                return;

            repositorioTarefa.Excluir(tarefaSelecionada.Id);

            CarregarTarefas();

            TelaPrincipalForm
                .Instancia
                .AtualizarRodape($"O registro \"{tarefaSelecionada.Titulo}\" foi excluído com sucesso!");
        }
        private void CarregarTarefas()
        {
            List<Tarefa> tarefas = repositorioTarefa.SelecionarTodos();

            listTarefa.AtualizarRegistros(tarefas);
        }

        public override UserControl ObterListagem()
        {
            if(listTarefa == null)
                listTarefa = new TabelaTarefaControl();

            CarregarTarefas();

            return listTarefa;
        }

    }
}
