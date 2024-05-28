using eAgenda.ConsoleApp.Compartilhado;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace eAgenda.WinApp.ModuloTarefa
{
    public class Tarefa : EntidadeBase
    {
        public string Titulo { get; set; }
        public DateTime DataCriacao { get; set; }
        public DateTime DataConclusao { get; set; }
        public decimal PercentualConclusao { get; set; }

        public Tarefa(string titulo, DateTime dataCriacao, DateTime dataConclusao, decimal percentualConclusao)
        {
            Titulo = titulo;
            DataCriacao = dataCriacao;
            DataConclusao = dataConclusao;
            PercentualConclusao = percentualConclusao;
        }

        public override List<string> Validar()
        {
            List<string> erros = new List<string>();

            if (string.IsNullOrEmpty(Titulo.Trim()))
                erros.Add("O campo \"titulo\" é obrigatório");

            if (DataCriacao < DateTime.Now)
                erros.Add("O campo \" data\"não pode ser menor doque dia atual");

            if (DataConclusao < DataCriacao)
                erros.Add("O campo \"conclusão\" não pode ser menor que iniciar");           

            return erros;
        }

        public override void AtualizarRegistro(EntidadeBase novoRegistro)
        {
            throw new NotImplementedException();
        }
    }
}
