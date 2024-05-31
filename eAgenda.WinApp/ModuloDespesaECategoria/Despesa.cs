namespace eAgenda.WinApp.ModuloDespesaECategoria
{
    public class Despesa
    {
        public int Valor { get; set; }
        public DateTime Data { get; set; }
        public FormaPagamentoEnum FormaPagamento { get; set;}

        public Despesa(int valor, DateTime data, FormaPagamentoEnum formaPagamento)
        {
            Valor = valor;
            Data = DateTime.Now;
            FormaPagamento = formaPagamento;
        }
    }

}
