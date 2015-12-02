using System;
using GADS2014M06InfnetGrid04.Aula07.Domain.Interfaces;

namespace GADS2014M06InfnetGrid04.Aula07.Domain.Entidades
{
    public class Aluno: IPessoa, IAluno
    {
        public int AlunoId { get; set; }
        public string Nome { get; set; }

        public void EstudarMuito()
        {
            Console.WriteLine("Estou estudando 10 horas por fim de semana.");
        }

        public void FazerProvaSemColar()
        {
            Console.WriteLine("Fazer a prova com atenção para não cair na pegadinha completo/correto.");
        }
    }
}