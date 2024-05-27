
using eAgenda.ConsoleApp.Compartilhado;
using eAgenda.WinApp.Compartilhado;

namespace eAgenda.WinApp.ModuloCompromisso
{
    public class RepositorioCompromisso : RepositorioBase<Compromisso>
    {
        public List<Compromisso> SelecionarCompromissosPorPeriodo(DateTime dataInicio, DateTime dataTermino)
        {
            return registros
                .FindAll(c => c.DataCompromisso >= dataInicio && c.DataCompromisso <= dataTermino);
        }
        public List<Compromisso> SelecionarCompromissoSFuturo()
        {
            return registros.FindAll(c => c.DataCompromisso >= DateTime.Today);
        }

        public List<Compromisso> SelecionarCompromissoSPassados()
        {            
            return registros.FindAll(c => c.DataCompromisso < DateTime.Now);
        }


        
    }
}
