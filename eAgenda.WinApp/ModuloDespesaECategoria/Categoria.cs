using eAgenda.ConsoleApp.Compartilhado;

namespace eAgenda.WinApp.ModuloDespesaECategoria
{
    public class Categoria : EntidadeBase
    {
        public string NomeCategoria { get; set; }  
        public List<Despesa> Despesas { get; set; }

        public Categoria(string nomeCategoria)
        {
            NomeCategoria = nomeCategoria;

            Despesas = new List<Despesa>();
        }

        public override void AtualizarRegistro(EntidadeBase novoRegistro)
        {
            Categoria atualizada = (Categoria)novoRegistro;

            NomeCategoria = atualizada.NomeCategoria;            
        }

        public override List<string> Validar()
        {
            List<string> erros = new List<string>();

            if (string.IsNullOrEmpty(NomeCategoria.Trim()))
                erros.Add("O campo \"nomeCategoria\" é obrigatório");

            return erros;
        }
    }
}
