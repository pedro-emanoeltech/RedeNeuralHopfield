
using System.Collections.Generic;

namespace RedeNeuralHopfieldDomain.Entity
{
    public class Amostra : Base
    {
        public int? QuantidadeAmostra{ set; get; }
        public IList<double?> Valor { set; get; }
    }
}
