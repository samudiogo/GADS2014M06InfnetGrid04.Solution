using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GADS2014M06InfnetGrid04.Domain.Entities;

namespace GADS2014M06InfnetGrid04.Presentation.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Poderia ser Cafe: Tipo "identificador do objeto"
            // new Construtor();
            var cafe = new Cafe();

            cafe.CafeId = Guid.NewGuid();
            cafe.Forca = 3;
            cafe.PaisOrigem = "Brasil";

            Console.WriteLine(cafe.CafeId);
            Console.WriteLine(cafe.Forca);
            Console.WriteLine(cafe.PaisOrigem);

            QuebraLinha();

            Bebida bebida = new Bebida();
            bebida.BebidaId = Guid.NewGuid();
            bebida.DataDeValidade = DateTime.Now;
            bebida.Nome = "Café com Leite";
            bebida.Temperatura = 3;

            int temp = bebida.ObterTemperaturaParaServir();

            Console.WriteLine(temp);
            Console.WriteLine(bebida.Nome);

            QuebraLinha();

            Cha cha = new Cha();
            Console.WriteLine(cha.ChaId);
            Console.WriteLine(cha.Sabor);

            QuebraLinha();

            Console.WriteLine("Café Id: {0} => Forca: {1}: Pais: {2}", cafe.CafeId, cafe.Forca, cafe.PaisOrigem);

            QuebraLinha();
            Console.Write("Entre com o sabor do Chá: ");
            string texto = Console.ReadLine();
            var cha3 = new Cha(texto);

            Console.WriteLine(cha3);


        }

        public static void QuebraLinha()
        {
            Console.WriteLine("\n==================\n");
        }
    }
}
