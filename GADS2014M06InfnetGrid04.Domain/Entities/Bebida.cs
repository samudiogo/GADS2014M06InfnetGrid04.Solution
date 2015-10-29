using System;

namespace GADS2014M06InfnetGrid04.Domain.Entities
{
    public class Bebida
    {
        #region Propriedades
        // Java = propriedade e que possui métodos
        //acessores get e set, exemplo: getBebidaId()
        //no C# = campo (field)
        //que no final das contas, é uma variavel interna da classe
        private Guid bebidaId;

        //No C# uma proporiedade é equivalente aos 
        //metodos acessores ao get e set do Java

        public Guid BebidaId
        {
            get { return bebidaId; }
            set { bebidaId = value; }
        }

        #region exemplo no java
        public Guid Terere
        { set { bebidaId = value; } }


        public void JavaSetBebidaId(Guid id)
        {
            bebidaId = id;
        }
        #endregion

        public string Nome { get; set; }
        public DateTime DataDeValidade { get; set; }
        public int Temperatura { get; set; }
        #endregion


        #region Metodos
        public int ObterTemperaturaParaServir()
        {
            return 1;
        }

        public void Gelar()
        {

        }
        #endregion
    }

}
