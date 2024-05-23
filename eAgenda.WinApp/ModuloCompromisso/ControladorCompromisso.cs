using eAgenda.WinApp.Compartilhado;
using eAgenda.WinApp.ModuloContato;

namespace eAgenda.WinApp.ModuloCompromisso
{
    public class ControladorCompromisso : ControladorBase
    {
        private RepositorioCompromisso repositorioCompromisso;
        private ListagemCompromissoControl listagemCompromisso;
        private RepositorioContato repositorioContato;

        public override string TipoCadastro { get { return "Compromissos"; } }

        public override string ToolTipAdicionar { get { return "Cadastrar umm novo compromisso"; } }

        public override string ToolTipEditar { get { return "Editar um compromisso existente"; } }

        public override string ToolTipExcluir { get { return "Excluir umm compromisso existente"; } }

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

            Compromisso compromissoSelecionado = listagemCompromisso.ObterRegistradoSelecionado();

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
            Compromisso compromissoSelecionado = listagemCompromisso.ObterRegistradoSelecionado();

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
            if(listagemCompromisso == null)
                listagemCompromisso = new ListagemCompromissoControl();

            CarregarCompromissos();

            return listagemCompromisso;
        }
        private void CarregarCompromissos()
        {
            List<Compromisso> compromissos = repositorioCompromisso.SelecionarTodos();

            listagemCompromisso.AtualizarRegistros(compromissos);
        }
    }
}
