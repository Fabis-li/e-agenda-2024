

namespace eAgenda.WinApp.Compartilhado
{
    public interface IControladorDepesas
    {
        string ToolTipAdicionarDespesas { get; }       
        void AdicionarDespesas();
        void AtualizarDepesas();
    }
}
