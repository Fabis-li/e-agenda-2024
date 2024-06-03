using eAgenda.WinApp.ModuloTarefa;

namespace eAgenda.WinApp.ModuloDespesaECategoria
{
    public partial class TelaCadastroDespesa : Form
    {
        private Categoria Categoria;

        public Categoria categoria
        {
            get
            {
                return categoria;
            }
            set
            {
                categoria = value;
            }
        }

        private Despesa Despesa;
        public Despesa despesa
        {
            get
            {
                return despesa;
            }
            set
            {
                
                despesa = value;
            }
        }

        public List<Despesa> DespesasAdicionadas
        {
            get
            {
                return listDespesas.Items.Cast<Despesa>().ToList();
            }
        }
        public TelaCadastroDespesa(Categoria categoriaSelecionada)
        {
            InitializeComponent();

            CarregarFormaPagamento();

            Categoria = categoriaSelecionada;

            lblDespesa.Text = categoriaSelecionada.NomeCategoria;

            foreach (Despesa despesa in categoriaSelecionada.Despesas)
                cmbNomeDespesa.Items.Add(despesa);
           

        }
        private void btnAdicionarDespesa_Click(object sender, EventArgs e)
        {
            //List<string> nome = DespesasAdicionadas.Select(x => x.NomeDespesa).ToList();

            //if (nome.Contains(cmbNomeDespesa.Text))
            //    return;

            int valorDespesa = Convert.ToInt32(txtValorDespesa.Text);
            FormaPagamentoEnum formapag = (FormaPagamentoEnum)cmbFormaPagamento.SelectedItem;

            Despesa despesa = new Despesa(cmbNomeDespesa.Text, valorDespesa, formapag);

            listDespesas.Items.Add(despesa);
        }
        private void btnGravar_Click(object sender, EventArgs e)
        {
            return;
        }

        private void CarregarFormaPagamento()
        {
            Array valoresEnum = Enum.GetValues(typeof(FormaPagamentoEnum));

            foreach (var valor in valoresEnum)
                cmbFormaPagamento.Items.Add(valor);

            cmbFormaPagamento.SelectedItem = FormaPagamentoEnum.Pix;
        }


    }
}
