using eAgenda.WinApp.Compartilhado;
using eAgenda.WinApp.ModuloContato;

namespace eAgenda.WinApp.ModuloCompromisso
{
    public class ControladorCompromisso : ControladorBase, IControladorFiltravel
    {
        private RepositorioCompromisso repositorioCompromisso;
        private TabelaCompromissoControl tabelaCompromisso;
        private RepositorioContato repositorioContato;

        public override string TipoCadastro { get { return "Compromissos"; } }

        public override string ToolTipAdicionar { get { return "Cadastrar umm novo compromisso"; } }

        public override string ToolTipEditar { get { return "Editar um compromisso existente"; } }

        public override string ToolTipExcluir { get { return "Excluir um compromisso existente"; } }

        public string ToolTipFiltrar { get { return "Filtrar um comprommissos"; } }

        public ControladorCompromisso(RepositorioCompromisso repositorioCompromisso, RepositorioContato repositorioContato)
        {
            this.repositorioCompromisso = repositorioCompromisso;
            this.repositorioContato = repositorioContato;
        }

        public override void Adicionar()
        {
            TelaCompromissoForm telaCommpromisso = new TelaCompromissoForm();

            DialogResult resultado = telaCommpromisso.ShowDialog();

            if (resultado != DialogResult.OK)
                return;

            Compromisso novoCompromisso = telaCommpromisso.Compromisso;

            repositorioCompromisso.Cadastrar(novoCompromisso);

            CarregarCompromissos();

            TelaPrincipalForm
                .Instancia
                .AtualizarRodape($"O registro \"{novoCompromisso.Assunto}\" foi editado com sucesso!");
        }

        public override void Editar()
        {
            TelaCompromissoForm telaCompromisso = new TelaCompromissoForm();

            List<Contato> contatoCadastrados = repositorioContato.SelecionarTodos();

            telaCompromisso.carregarContatos(contatoCadastrados);

            int idSelecionado = tabelaCompromisso.ObterRegistradoSelecionado();

            Compromisso compromissoSelecionado = repositorioCompromisso.SelecionarPorId(idSelecionado);

            if (compromissoSelecionado == null)
            {
                MessageBox.Show(
                    "Não é possivel realiza esta ação sem um registro selecionado.",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            telaCompromisso.Compromisso = compromissoSelecionado;

            DialogResult resultado = telaCompromisso.ShowDialog();

            if (resultado != DialogResult.OK)
                return;

            Compromisso compromissoEditado = telaCompromisso.Compromisso;           

            repositorioCompromisso.Editar(compromissoSelecionado.Id, compromissoEditado);

            CarregarCompromissos();

            TelaPrincipalForm
               .Instancia
               .AtualizarRodape($"O registro \"{compromissoEditado.Assunto}\" foi editado com sucesso!");
        }

        public override void Excluir()
        {
            int idSelecionado = tabelaCompromisso.ObterRegistradoSelecionado();
           
            Compromisso compromissoSelecionado = repositorioCompromisso.SelecionarPorId(idSelecionado);

            if (compromissoSelecionado == null)
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
                $"Você deseja realmente excluir o registro \"{compromissoSelecionado.Assunto}\"?",
                "Confirmar Exclusão",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if( resposta != DialogResult.Yes )
                return;

            repositorioCompromisso.Excluir(compromissoSelecionado.Id);

            CarregarCompromissos();

            TelaPrincipalForm
                .Instancia
                .AtualizarRodape($"O registro \"{compromissoSelecionado.Assunto}\" foi excluído com sucesso!");
        }

        public override UserControl ObterListagem()
        {
            if(tabelaCompromisso == null)
                tabelaCompromisso = new TabelaCompromissoControl();

            CarregarCompromissos();

            return tabelaCompromisso;
        }
        private void CarregarCompromissos()
        {
            List<Compromisso> compromissos = repositorioCompromisso.SelecionarTodos();

            tabelaCompromisso.AtualizarRegistros(compromissos);
        }

        public void Filtrar()
        {
            FiltroCompromissoForm filtro = new FiltroCompromissoForm();

            DialogResult resultado = filtro.ShowDialog();            

            TipoFiltroCompromissoEnum filtroSelecionado = filtro.FiltroEscolhido;

            List<Compromisso> compromissosSelecionados;

            if (filtroSelecionado == TipoFiltroCompromissoEnum.Passados)
                compromissosSelecionados = repositorioCompromisso.SelecionarCompromissoSPassados();

            else if (filtroSelecionado == TipoFiltroCompromissoEnum.Futuro)
                compromissosSelecionados = repositorioCompromisso.SelecionarCompromissoSFuturo();

            else if (filtroSelecionado == TipoFiltroCompromissoEnum.Periodo)
            {
                DateTime dataInicio = filtro.InicioPeriodo;
                DateTime dataTermino = filtro.TerminoPeriodo;

                compromissosSelecionados = repositorioCompromisso.SelecionarCompromissosPorPeriodo(dataInicio, dataTermino);
            }
            else
                compromissosSelecionados = repositorioCompromisso.SelecionarTodos();               

            tabelaCompromisso.AtualizarRegistros(compromissosSelecionados);

            TelaPrincipalForm.Instancia.AtualizarRodape($"Visualizando {compromissosSelecionados.Count} registro...");
        }

       

       
    }
}
