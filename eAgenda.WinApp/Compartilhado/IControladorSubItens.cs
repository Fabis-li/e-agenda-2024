using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eAgenda.WinApp.Compartilhado
{
    public interface IControladorSubItens
    {
        string ToolTipAdicionarItens { get; }
        void AdicionarItens();
    }
}
