using eAgenda.WinApp.Compartilhado;
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
            TelaDespesaCategoriaForm telaCategoria = new TelaDespesaCategoriaForm();

            int idSelecionado = listCategoria.ObterIdSelecionado();

            Categoria categoriaSelecionada = repositorioCategoria.SelecionarPorId(idSelecionado);

            if (categoriaSelecionada == null)
            {
                MessageBox.Show(
                    "Não é possivel realiza esta ação sem um registro selecionado.",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            telaCategoria.Categoria = categoriaSelecionada;

            DialogResult resultado = telaCategoria.ShowDialog();

            if (resultado != DialogResult.OK)
                return;

            Categoria categoriaEditada = telaCategoria.Categoria;

            repositorioCategoria.Editar(categoriaSelecionada.Id, categoriaEditada);

            CarregarCategorias();

            TelaPrincipalForm
                .Instancia
                .AtualizarRodape($"O registro \"{categoriaEditada.NomeCategoria}\" foi editado com sucesso!");
        }

        public override void Excluir()
        {
            int idSelecionado = listCategoria.ObterIdSelecionado();

            Categoria categoriaSelecionada = repositorioCategoria.SelecionarPorId(idSelecionado);

            if (categoriaSelecionada == null)
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
                $"Você deseja realmente excluir o registro \"{categoriaSelecionada.NomeCategoria}\"?",
                "Confirmar Exclusão",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (resposta != DialogResult.Yes)
                return;

            repositorioCategoria.Excluir(categoriaSelecionada.Id);

            CarregarCategorias();

            TelaPrincipalForm
                .Instancia
                .AtualizarRodape($"O registro \"{categoriaSelecionada.NomeCategoria}\" foi excluído com sucesso!");
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
