using System;

namespace GADS2014M06InfnetGrid04.Domain.Entities
{
    public class Cha
    {
        #region construtores
        /// <summary>
        /// construtor padrão sem argumentos
        /// Inicializa toda as propriedades com valor padrão
        /// </summary>
        public Cha() { }
        /// <summary>
        /// construtor com argumentos
        /// Inicializa todas as propriedades com o sabor passado por argumento 
        /// </summary>
        /// <param name="sabor"></param>
        public Cha(string sabor) // 
        {
            Sabor = sabor;
        }
        #endregion

        #region propriedades
        public Guid ChaId { get; set; } = Guid.NewGuid(); // alternativa em C# 6 para inicializar uma propriedade
        public string Sabor { get; set; }
        #endregion

        public override string ToString()
        {
            return $"Chá Id: {ChaId}\nSabor:{Sabor}"; //usando string interpolation
        }
    }
}
