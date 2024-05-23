namespace eAgenda.WinApp.ModuloCompromisso
{
    public partial class ListagemCompromissoControl : UserControl
    {
        public ListagemCompromissoControl()
        {
            InitializeComponent();
        }

        public void AtualizarRegistros(List<Compromisso> compromissos)
        {
            listCompromisso.Items.Clear();

            foreach (Compromisso compromisso in compromissos)
            {
                listCompromisso.Items.Add(compromisso);
            }            
        }

        public Compromisso ObterRegistradoSelecionado()
        {
            if (listCompromisso.SelectedItem == null)
                return null;

            return (Compromisso)listCompromisso.SelectedItem;
        }
    }
}
