using System;

namespace GADS2014M06InfnetGrid04.Aula08.Domain.Interfaces
{
    public interface IAluno
    {
        DateTime DataDeNascimento { get; set; }
        bool TemIdadeMinimaParaMatricula();
    }
}