namespace eAgenda.WinApp.ModuloDespesaECategoria
{
    public class Despesa
    {
        public int Id { get; set; }
        public int Valor { get; set; }
        public string NomeDespesa { get; set; }
        public DateTime Data { get; set; }
        public FormaPagamentoEnum FormaPagamento { get; set;}
        public Categoria Categoria { get; set;}

        public Despesa(string nomeDespesa, int valor, FormaPagamentoEnum formaPagamento)
        {
            NomeDespesa = nomeDespesa;
            Valor = valor;
            FormaPagamento = formaPagamento;
            Data = DateTime.Now;
        }

        public override string ToString()
        {
            return $"Despesa: {NomeDespesa}, Valor: {Valor}, Forma de Pagamento: {FormaPagamento}";
        }

    }

}
