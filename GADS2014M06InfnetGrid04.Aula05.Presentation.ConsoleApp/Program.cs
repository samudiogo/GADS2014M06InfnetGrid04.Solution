using System;
using GADS2014M06InfnetGrid04.Aula05.Domain;

namespace GADS2014M06InfnetGrid04.Aula05.Presentation.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Dando um título à janela do console
            Console.Title = "Tipo valor e Tipo referência";

            // Instanciando um primeiro objeto
            ClasseAluno aluno1 = new ClasseAluno();
            // Imprimindo a valor do número após a instanciação: valor deve ser zero
            Console.WriteLine("Aluno 1 após ser instanciado: {0}", aluno1.numero);
            // Instanciando um segundo objeto, atribuindo o primeiro a este
            ClasseAluno aluno2 = aluno1;
            // É natura que o número do segundo seja igual ao do primeiro
            Console.WriteLine("Aluno 2 após ser instanciado: {0}", aluno2.numero);
            Console.ReadLine();
            Console.WriteLine("---------------------");
            Console.WriteLine("");
            // Alterando o valor do número do objeto aluno1
            aluno1.numero = 50;
            // Apresentando o valor alterado para ambos os objetos
            Console.WriteLine("Aluno 1 após ter seu número modificado: {0}", aluno1.numero);
            Console.WriteLine("Aluno 2 após aluno1 modificar o número: {0}", aluno2.numero);
            Console.ReadLine();
            Console.WriteLine("---------------------");
            Console.WriteLine("");
            // Alterando o valor do número do objeto aluno2
            aluno2.numero = 71;
            // Apresentando o valor alterado para ambos os objetos
            Console.WriteLine("Aluno 1 após aluno2 modificar o número: {0}", aluno1.numero);
            Console.WriteLine("Aluno 2 após ter seu número modificado: {0}", aluno2.numero);
            Console.ReadLine();
            Console.WriteLine("---------------------");
            Console.WriteLine("");
            Console.ReadLine();

            EstruturaAluno estruturaAluno1 = new EstruturaAluno();
            Console.WriteLine("Estrutura Aluno 1 após ser instanciada: {0}", estruturaAluno1.numero);
            EstruturaAluno estruturaAluno2 = estruturaAluno1;
            Console.WriteLine("Estrutura Aluno 2 após ser instanciada: {0}", estruturaAluno2.numero);
            Console.ReadLine();
            Console.WriteLine("---------------------");
            Console.WriteLine("");
            estruturaAluno1.numero = 50;
            Console.WriteLine("Estrutura Aluno 1 após ter seu número modificado: {0}", estruturaAluno1.numero);
            Console.WriteLine("Estrutura Aluno 2 após estruturaAluno1 modificar o número: {0}", estruturaAluno2.numero);
            Console.ReadLine();
            Console.WriteLine("---------------------");
            Console.WriteLine("");
            estruturaAluno2.numero = 71;
            Console.WriteLine("Estrutura Aluno 1 após estruturaAluno2 modificar o número: {0}", estruturaAluno1.numero);
            Console.WriteLine("Estrutura Aluno 2 após ter seu número modificado: {0}", estruturaAluno2.numero);
            Console.ReadLine();
            Console.WriteLine("---------------------");
            Console.WriteLine("");
            Console.ReadLine();
        }
    }
}
