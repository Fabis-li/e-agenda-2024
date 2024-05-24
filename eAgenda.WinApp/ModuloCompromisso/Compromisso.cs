using eAgenda.ConsoleApp.Compartilhado;
using eAgenda.WinApp.ModuloContato;
using static System.Windows.Forms.LinkLabel;

namespace eAgenda.WinApp.ModuloCompromisso
{
    public class Compromisso : EntidadeBase
    {
        public string Assunto { get; set; }
        public string Local {  get; set; }
        public DateTime DataCompromisso { get; set; }
        public TimeSpan HorarioInicio { get; set; }
        public TimeSpan HorarioFinal {  get; set; }
        public Contato Contato { get; set; }
        public string Online { get; set; }
        public TipoCompromissoEnum TipoCompromisso
        {
            get
            {
                TipoCompromissoEnum tipoSelecionado;

                if(Local.Length > 0)
                    tipoSelecionado = TipoCompromissoEnum.Presencial;
                else
                    tipoSelecionado = TipoCompromissoEnum.Online;

                return tipoSelecionado;
            }
        }



        public Compromisso(string assunto, string local, string online, DateTime dataCompromisso, TimeSpan horarioInicio, TimeSpan horarioFinal, Contato contato)
        {
            Assunto = assunto;
            Local = local;
            Online = online;
            DataCompromisso = dataCompromisso;
            HorarioInicio = horarioInicio;
            HorarioFinal = horarioFinal;
            Contato = contato;
        }

        public override List<string> Validar()
        {
            List<string> erros = new List<string>();

            if (string.IsNullOrEmpty(Assunto.Trim()))
                erros.Add("O campo \"assunto\" é obrigatório");

            if (string.IsNullOrEmpty(Local.Trim()) && string.IsNullOrEmpty(Online.Trim()))
                erros.Add("O campo \"local / link\" é obrigatório");

            if (!string.IsNullOrEmpty(Local.Trim()) && !string.IsNullOrEmpty(Online.Trim()))
                erros.Add("Os campos \"local\" e \"link\" são mutualmente exclusivos, preencha apenas um");

            if (HorarioInicio > HorarioFinal)
                erros.Add("A hora de início não pode ser depois da hora de término.");

            if (HorarioFinal < HorarioInicio)
                erros.Add("A hora de término não pode ser antes da hora de início.");

            return erros;
        }

        public override void AtualizarRegistro(EntidadeBase novoRegistro)
        {
            Compromisso atualizado = (Compromisso)novoRegistro;

            Assunto = atualizado.Assunto;
            Local = atualizado.Local;
            Online = atualizado.Online;
            DataCompromisso = atualizado.DataCompromisso;
            HorarioInicio = atualizado.HorarioInicio;
            HorarioFinal = atualizado.HorarioFinal;
            Contato = atualizado.Contato;
        }

        public override string ToString()
        {

            string nomeContato = Contato == null ? string.Empty : Contato.Nome;

            return $"Id: {Id}," +
                $"Assunto: {Assunto}," +
                $"Local: {Local}," +
                $" Data: {DataCompromisso.ToShortDateString()}," +
                $"Inico: {HorarioInicio.ToString(@"hh\:mm")}," +
                $"HorarioFinal: {HorarioFinal.ToString(@"hh\:mm")}," +
                $"Contato: {nomeContato}," +
                $"Tipo: {TipoCompromisso.ToString()}";
        }
    }
}
