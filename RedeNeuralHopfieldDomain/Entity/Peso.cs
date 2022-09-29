using System.Collections.Generic;


namespace RedeNeuralHopfieldDomain.Entity
{
    public class Peso : Base
    {
        public int? QuantidadePeso { set; get; }
        public IList<double?> Valor { set; get; }
    }
}
