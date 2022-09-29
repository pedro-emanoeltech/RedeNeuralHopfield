using RedeNeuralHopfieldDomain.Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedeNeuralHopfieldDomain.Interfaces.Services
{
    public interface IProcessarArquivoServices
    {
        ArquivoDados BuscarArquivo();
        DataTable CarregarArquivo(ArquivoDados arquivoDados);
    }
}
