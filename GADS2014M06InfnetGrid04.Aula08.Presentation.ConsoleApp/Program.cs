using System;
using GADS2014M06InfnetGrid04.Aula08.Domain.Entidades;
using GADS2014M06InfnetGrid04.Aula08.Domain.Interfaces;

namespace GADS2014M06InfnetGrid04.Aula08.Presentation.ConsoleApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            Aluno aluno = new Aluno();
            aluno.AlunoId = Guid.NewGuid();
            aluno.Nome = "PauloMau";
            aluno.Cpf = "12345678909";
            aluno.DataDeNascimento = DateTime.Parse("24/10/1967");
            Console.WriteLine("Id: {0}, Nome: {1} - CPF: {2}, Nasceu em: {3} ",
                    aluno.AlunoId,
                    aluno.Nome,
                    aluno.Cpf,
                    aluno.DataDeNascimento.ToString()
            );

            aluno.FazAlgumaCoisaExclusivoDaClasseAluno();
            bool temIdade = aluno.TemIdadeMinimaParaMatricula();

            // Reparem no código abaixo... Tudo que estiver com a linha vermelha, é porque não está definido na Interface IAluno
            // Solução para as propriedades... Definá-las na Interface.
            // Solução para o método FazAlgumaCoisaExclusivoDaClasseAluno, não chamá-lo.

            IAluno aluno2 = new Aluno();
            aluno2.AlunoId = Guid.NewGuid();
            aluno2.Nome = "PauloMau";
            aluno2.Cpf = "12345678909";
            aluno2.DataDeNascimento = DateTime.Parse("24/10/1967");
            Console.WriteLine("Id: {0}, Nome: {1} - CPF: {2}, Nasceu em: {3} ",
                    aluno2.AlunoId,
                    aluno2.Nome,
                    aluno2.Cpf,
                    aluno2.DataDeNascimento.ToString()
            );

            aluno2.FazAlgumaCoisaExclusivoDaClasseAluno();
            bool temIdade2 = aluno2.TemIdadeMinimaParaMatricula();


        }
    }
}
