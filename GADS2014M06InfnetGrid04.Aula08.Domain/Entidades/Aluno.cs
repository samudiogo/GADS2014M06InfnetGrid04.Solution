using System;
using GADS2014M06InfnetGrid04.Aula08.Domain.Interfaces;

namespace GADS2014M06InfnetGrid04.Aula08.Domain.Entidades
{
    public class Aluno : IAluno
    {
        #region Propriedades
        public Guid AlunoId { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public DateTime DataDeNascimento { get; set; }
        #endregion

        #region Métodos públicos
        public bool TemIdadeMinimaParaMatricula()
        {
            int idadeMinima = 18;
            int anoAtual = DateTime.Now.Year;
            int anoNascimento = DataDeNascimento.Year;

            /* Primeira forma de fazer o "if".
            if ((anoAtual - anoNascimento) < idadeMinima)
            {
                return false;
            }
            else
            {
                return true;
            }
            */

            // Segunda forma de escrever o mesmo "if".
            // return ((anoAtual - anoNascimento) < idadeMinima) ? false : true;

            // Terceira e melhor forma de escrever este "if".
            // O uso do operado ! (not) é necessário para inverter o valor de retorno, 
            // já que o método espera um retorno true, preferencialemente.
            return !((anoAtual - anoNascimento) < idadeMinima);
        }
        public void FazAlgumaCoisaExclusivoDaClasseAluno()
        {
            // código da lógica do método
        }
        #endregion
    }
}