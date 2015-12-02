using System;
using GADS2014M06InfnetGrid04.Aula07.Domain.Interfaces;

namespace GADS2014M06InfnetGrid04.Aula07.Domain.Entidades
{
    public class Professor: IPessoa, IProfessor
    {
        public int ProfessorId { get; set; }
        public string Nome { get; set; }

        public void EstudarMuito()
        {
            Console.WriteLine("Estou estudando muito. 18 horas por fim de semana");
        }

        public void PrepararProva()
        {
            Console.WriteLine("Preparar prova escutando Tropa de Elite."); ;
        }

        public void CorrigirProva()
        {
            Console.WriteLine("Corrigindo prova Ouvindo Dire Straits");
        }
    }
}