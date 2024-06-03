using eAgenda.WinApp.Compartilhado;
using eAgenda.WinApp.ModuloCompromisso;
using eAgenda.WinApp.ModuloContato;
using eAgenda.WinApp.ModuloDespesaECategoria;
using eAgenda.WinApp.ModuloTarefa;

namespace eAgenda.WinApp
{
    public partial class TelaPrincipalForm : Form
    {
        ControladorBase controlador;        

        RepositorioContato repositorioContato;
        RepositorioCompromisso repositorioCompromisso;
        RepositorioTarefa repositorioTarefa;
        RepositorioCategoria repositorioCategoria;       

        public static TelaPrincipalForm Instancia { get; private set; }

        public TelaPrincipalForm()
        {
            InitializeComponent();
            lblTipoCadastro.Text = string.Empty;

            repositorioContato = new RepositorioContato();
            repositorioCompromisso = new RepositorioCompromisso();
            repositorioTarefa = new RepositorioTarefa();
            repositorioCategoria = new RepositorioCategoria();

            Instancia = this;

            CadastrarRegistrosTeste();
        }
        public void AtualizarRodape(string texto)
        {
            statusLabelPrincipal.Text = texto;
        }

        private void contatosMenuItem_Click(object sender, EventArgs e)
        {
            controlador = new ControladorContato(repositorioContato);

            ConfigurarTelaPrincipal(controlador);
        }
        private void compromissosMenuItem_Click(object sender, EventArgs e)
        {
            controlador = new ControladorCompromisso(repositorioCompromisso, repositorioContato);

            ConfigurarTelaPrincipal(controlador);
        }

        private void tarefasMenuItem_Click(object sender, EventArgs e)
        {
            controlador = new ControladorTarefa(repositorioTarefa);

            ConfigurarTelaPrincipal(controlador);
        }
        private void despesasECategoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            controlador = new ControladorCategoria(repositorioCategoria);

            ConfigurarTelaPrincipal(controlador);
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            controlador.Adicionar();
        }
        private void btnEditar_Click(object sender, EventArgs e)
        {
            controlador.Editar();
        }
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            controlador.Excluir();
        }

        private void ConfigurarTelaPrincipal(ControladorBase controladorSelecionado)
        {
            lblTipoCadastro.Text = "Cadastro de " + controlador.TipoCadastro;

            ConfigurarToolBox(controladorSelecionado);
            ConfigurarListagem(controladorSelecionado);
        }

        private void ConfigurarToolBox(ControladorBase controladorSelecionado)
        {
            btnAdicionar.Enabled = controladorSelecionado is ControladorBase;
            btnEditar.Enabled = controladorSelecionado is ControladorBase;
            btnExcluir.Enabled = controladorSelecionado is ControladorBase;

            btnFiltrar.Enabled = controladorSelecionado is IControladorFiltravel;
            btnAdicionarItens.Enabled = controladorSelecionado is IControladorSubItens;
            btnConcluirItens.Enabled = controladorSelecionado is IControladorSubItens;

            btnAdicionarItens.Enabled = controladorSelecionado is IControladorDepesas;

           


            ConfigurarToolTips(controladorSelecionado);
        }

        private void ConfigurarToolTips(ControladorBase controladorSelecionado)
        {
            btnAdicionar.ToolTipText = controladorSelecionado.ToolTipAdicionar;
            btnEditar.ToolTipText = controladorSelecionado.ToolTipEditar;
            btnExcluir.ToolTipText = controladorSelecionado.ToolTipExcluir;

            if (controladorSelecionado is IControladorFiltravel controladorFiltravel)
                btnFiltrar.ToolTipText = controladorFiltravel.ToolTipFiltrar;

            if (controlador is IControladorSubItens controladorSubItens)
            {
                btnAdicionarItens.ToolTipText = controladorSubItens.ToolTipAdicionarItens;
                btnConcluirItens.ToolTipText = controladorSubItens.ToolTipConcluirItens;
            }
            else if (controlador is IControladorDepesas controladorDepesas)
            {
                btnAdicionarItens.ToolTipText = controladorDepesas.ToolTipAdicionarDespesas;

            }
            
               

        }
        private void ConfigurarListagem(ControladorBase controladorSelecionado)
        {
            UserControl listagemContato = controladorSelecionado.ObterListagem();
            listagemContato.Dock = DockStyle.Fill;

            pnlRegistros.Controls.Clear();
            pnlRegistros.Controls.Add(listagemContato);
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            if (controlador is IControladorFiltravel controladorFiltravel)
                controladorFiltravel.Filtrar();
        }
        private void btnAdicionarItens_Click(object sender, EventArgs e)
        {
            if (controlador is IControladorSubItens controladorSubItens)
                controladorSubItens.AdicionarItens();

            if (controlador is IControladorDepesas controladorDespesas)
                controladorDespesas.AdicionarDespesas();
        }

        private void btnConcluirItens_Click(object sender, EventArgs e)
        {
            if (controlador is IControladorSubItens controladorSubItens)
                controladorSubItens.AtualizarItens();

        }


        private void CadastrarRegistrosTeste()
        {
            List<Contato> contatos = new List<Contato>()
            {
                new("Rogerio", "49 99833-2123", "rogerio@gmail.com", "Academia do Programador", "CEO"),
                new("Marcelo", "49 98505-6251", "marcelo@gmail.com", "Academia do Programador", "Professor"),
                new("Fabio", "49 98404-6020", "fabio@gmail.com", "Cronos Solu��es de Inform�tica", "Vendedor")
            };

            repositorioContato.CadastrarVarios(contatos);

            DateTime data = DateTime.Today.AddDays(-3);
            TimeSpan horaInicio = new TimeSpan(09, 00, 00);
            TimeSpan horaTermino = new TimeSpan(10, 00, 00);

            DateTime dataFuturo = DateTime.Today.AddDays(5);

            List<Compromisso> compromissos = new List<Compromisso>()
            {
                new("Reuni�o", "", "www.discord.com", data, horaInicio, horaTermino, contatos.First()),
                new("Lavar o Cachorro", "Casa", "", dataFuturo, new TimeSpan(10, 00, 00), new TimeSpan(10, 30, 00), null),
                new("Criar scripts de automatiza��o", "Casa", "", dataFuturo.AddDays(10), new TimeSpan(19, 00, 00), new TimeSpan(23, 59, 00), null)
            };

            repositorioCompromisso.CadastrarVarios(compromissos);

            List<Tarefa> tarefas = new List<Tarefa>()
            {
                new Tarefa("Testar c�digo da aula", TipoTarefaEnum.Alta),
                new Tarefa("Estudar para a prova", TipoTarefaEnum.Normal),
                new Tarefa("Fazer o desafio", TipoTarefaEnum.Baixa)

            };

            repositorioTarefa.CadastrarVarios(tarefas);

            List<Categoria> categorias = new List<Categoria>()
            {
                new("Alimenta��o"),
                new("Lazer"),
                new("Transporte")
            };

            repositorioCategoria.CadastrarVarios(categorias);
        }

    }
}
