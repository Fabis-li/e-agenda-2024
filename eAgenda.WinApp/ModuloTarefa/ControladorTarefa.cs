using eAgenda.WinApp.Compartilhado;

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
            throw new NotImplementedException();
        }

        public override void Excluir()
        {
            throw new NotImplementedException();
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
