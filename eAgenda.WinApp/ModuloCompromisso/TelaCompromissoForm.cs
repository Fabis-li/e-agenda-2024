using eAgenda.WinApp.ModuloContato;

namespace eAgenda.WinApp.ModuloCompromisso
{
    public partial class TelaCompromissoForm : Form
    {
        private Compromisso compromisso;
        public Compromisso Compromisso
        {
            set
            {
                txtId.Text = value.Id.ToString();
                txtAssunto.Text = value.Assunto;
                dtpData.Value = value.DataCompromisso;
                dtpHoraInicio.Value = value.DataCompromisso.Date + value.HorarioInicio;
                dtpHoraFinal.Value = value.DataCompromisso.Date + value.HorarioFinal;
                txtLocalOnline.Text = value.Local;
                txtLocalPresencial.Text = value.Local;

                chkContato.Checked = value.Contato != null;

                cmbListaContato.Enabled = value.Contato != null;
                cmbListaContato.SelectedItem = value.Contato;

                if(value.TipoCompromisso == TipoCompromissoEnum.Presencial)
                {
                    rdbPrensencial.Checked = true;
                    txtLocalPresencial.Text = value.Local;
                }
                else
                {
                    rdbOnline.Checked = true;
                    txtLocalOnline.Text = value.Online;
                }

            }
            get
            {
                return compromisso;
            }
        }


        public TelaCompromissoForm()
        {
            InitializeComponent();
        }
        public void carregarContatos(List<Contato> contatos)
        {
            cmbListaContato.Items.Clear();

            foreach (Contato contato in contatos)
            {
                cmbListaContato.Items.Add(contato);
            }
        }

        private void TelaCompromissoForm_Load(object sender, EventArgs e)
        {

        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            string assunto = txtAssunto.Text;
            DateTime data = dtpData.Value;
            TimeSpan horarioInicio = dtpData.Value.TimeOfDay;
            TimeSpan horarioFinal = dtpData.Value.TimeOfDay;
            Contato contato = (Contato)cmbListaContato.SelectedItem;

            string local = txtLocalPresencial.Text;
            string online = txtLocalOnline.Text;

            compromisso = new Compromisso(assunto, local, online, data, horarioInicio, horarioFinal, contato);

            List<string> erros = compromisso.Validar();

            if(erros.Count > 0 )
            {
                TelaPrincipalForm.Instancia.AtualizarRodape(erros[0]);

                DialogResult = DialogResult.None;
            }
        }

        private void chkContato_CheckedChanged(object sender, EventArgs e)
        {
            if (chkContato.Checked)
                cmbListaContato.Enabled = true;
            else
            {
                cmbListaContato.SelectedItem = null;
                cmbListaContato.Enabled = false;
            }
        }
        private void rdbPrensencial_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbPrensencial.Checked)
            {
                txtLocalOnline.Text = string.Empty;
                txtLocalOnline.Enabled = false;
            }
            else
            {
                txtLocalOnline.Enabled = true;
            }
        }

        private void rdbOnline_CheckedChanged(object sender, EventArgs e)
        {
            if(rdbOnline.Checked)
            {
                txtLocalPresencial.Text = string.Empty;
                txtLocalPresencial.Enabled = false;
            }
            else
            {
                txtLocalPresencial.Enabled = true;
            }
        }
    }
}
