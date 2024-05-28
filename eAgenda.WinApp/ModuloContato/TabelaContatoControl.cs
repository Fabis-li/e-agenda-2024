

using eAgenda.WinApp.Compartilhado;

namespace eAgenda.WinApp.ModuloContato
{
    public partial class TabelaContatoControl : UserControl
    {
        public TabelaContatoControl()
        {
            InitializeComponent();
        }

        public void AtualizarRegistros(List<Contato> contatos)
        {
            //limpar linhas
            grid.Rows.Clear();

            foreach(Contato c in contatos) 
            { 
                //adicionando contatos na tabela
                grid.Rows.Add(c.Id, c.Nome, c.Telefone, c.Email, c.Empresa, c.Cargo);
            }

        }

        public int ObterRegistroSelecionado()
        {
            return grid.SelecionarId();
        }
    }
}
