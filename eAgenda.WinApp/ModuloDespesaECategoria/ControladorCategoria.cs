using eAgenda.WinApp.Compartilhado;
using eAgenda.WinApp.ModuloContato;
using eAgenda.WinApp.ModuloTarefa;

namespace eAgenda.WinApp.ModuloDespesaECategoria
{
    public class ControladorCategoria : ControladorBase
    {
        private TabelaCategoriaControl listCategoria;

        private RepositorioCategoria repositorioCategoria;
        public override string TipoCadastro { get { return "Categorias"; } }

        public override string ToolTipAdicionar { get { return "Cadastrar uma nova categoria"; } }

        public override string ToolTipEditar { get { return "Editar uma categoria existente"; } }

        public override string ToolTipExcluir { get { return "Excluir uma categoria existente"; } }

        public ControladorCategoria(RepositorioCategoria repositorio)
        {
            this.repositorioCategoria = repositorio;
        }

        public override void Adicionar()
        {
            TelaDespesaCategoriaForm telaCategoria = new TelaDespesaCategoriaForm();

            DialogResult resultado = telaCategoria.ShowDialog();

            if (resultado != DialogResult.OK)
                return;
            
            Categoria novaCategoria = telaCategoria.Categoria;

            repositorioCategoria.Cadastrar(novaCategoria);

            CarregarCategorias();

            TelaPrincipalForm
               .Instancia
               .AtualizarRodape($"O registro \"{novaCategoria.NomeCategoria}\" foi criado com sucesso!");
            
        }

        public override void Editar()
        {
            throw new NotImplementedException();
        }

        public override void Excluir()
        {
            throw new NotImplementedException();
        }

        public override UserControl ObterListagem()
        {
            if (listCategoria == null)
                listCategoria = new TabelaCategoriaControl();

            CarregarCategorias();

            return listCategoria;
        }

        private void CarregarCategorias()
        {
            List<Categoria> categorias = repositorioCategoria.SelecionarTodos();

            listCategoria.AtualizarRegistros(categorias);
        }
    }
}
