﻿namespace eAgenda.WinApp.ModuloTarefa
{
    public partial class TelaDespesaCategoriaForm : Form
    {
        private Tarefa tarefa;
        public Tarefa Tarefa
        {
            get
            {
                return tarefa;
            }
            set 
            {
                txtId.Text = value.Id.ToString();
                txtTitulo.Text = value.Titulo;
                cmbPrioridades.SelectedItem = value.Prioridade;
            }
        }

        public TelaDespesaCategoriaForm()
        {
            InitializeComponent();

            CarregarPrioridades();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            string titulo = txtTitulo.Text;

            TipoTarefaEnum prioridade = (TipoTarefaEnum)cmbPrioridades.SelectedItem;

            tarefa = new Tarefa(titulo, prioridade);

            List<string> erros = tarefa.Validar();

            if(erros.Count > 0 )
            {
                TelaPrincipalForm.Instancia.AtualizarRodape(erros[0]);
                DialogResult = DialogResult.None;
            }
        }

        private void CarregarPrioridades()
        {
            Array valoresEnum = Enum.GetValues(typeof(TipoTarefaEnum));

            foreach (var valor in valoresEnum)
                cmbPrioridades.Items.Add(valor);

            cmbPrioridades.SelectedItem = TipoTarefaEnum.Baixa;
        }       

       
    }
}
