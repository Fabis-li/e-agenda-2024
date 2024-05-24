
using eAgenda.ConsoleApp.Compartilhado;
using eAgenda.WinApp.Compartilhado;

namespace eAgenda.WinApp.ModuloCompromisso
{
    public class RepositorioCompromisso : RepositorioBase<Compromisso>
    {
        public List<Compromisso> SelecionarCompromissoSFuturo()
        {
            List<Compromisso> compromissosFuturos = new List<Compromisso>();

            foreach (Compromisso compromisso in registros)
            {
                if(compromisso.DataCompromisso >= DateTime.Today)
                    compromissosFuturos.Add(compromisso);
            }

            return compromissosFuturos;
        }

        public List<Compromisso> SelecionarCompromissoSPassados()
        {
            List<Compromisso> compromissosPassados = new List<Compromisso>();

            foreach (Compromisso compromisso in registros)
            {
                if (compromisso.DataCompromisso < DateTime.Today)
                    compromissosPassados.Add(compromisso);
            }

            return compromissosPassados;
        }
    }
}
