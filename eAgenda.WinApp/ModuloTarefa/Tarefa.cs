﻿using eAgenda.ConsoleApp.Compartilhado;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace eAgenda.WinApp.ModuloTarefa
{
    public class Tarefa : EntidadeBase
    {
        public string Titulo { get; set; }
        public TipoTarefaEnum Prioridade { get; set; }
        public DateTime DataCriacao { get; set; }
        public DateTime DataConclusao { get; set; }
        public decimal PercentualConclusao { get; set; }
        public string Itens {  get; set; }

        public Tarefa(string titulo, TipoTarefaEnum prioridade)
        {
            Titulo = titulo;
            Prioridade = prioridade;
            DataCriacao = DateTime.Now;            
        }

        public override List<string> Validar()
        {
            List<string> erros = new List<string>();

            if (string.IsNullOrEmpty(Titulo.Trim()))
                erros.Add("O campo \"titulo\" é obrigatório");                       

            return erros;
        }

        public override void AtualizarRegistro(EntidadeBase novoRegistro)
        {
            Tarefa atualizada = (Tarefa)novoRegistro;

            Titulo = atualizada.Titulo;
            Prioridade = atualizada.Prioridade;
            DataCriacao = atualizada.DataCriacao;
            DataConclusao = atualizada.DataConclusao;
            PercentualConclusao = atualizada.PercentualConclusao;
            Itens = atualizada.Itens;
        }
    }
}
