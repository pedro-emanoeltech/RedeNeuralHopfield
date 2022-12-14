using System.Windows.Forms;
using RedeNeuralHopfieldDomain.Entity;
using System.IO;
using RedeNeuralHopfieldDomain.Interfaces.Services;
using System.Data;
using RedeNeuralHopfieldDomain.Interfaces.Repository;

namespace RedeNeuralHopfieldDomain.Services
{
    public class ProcessarArquivoServices : IProcessarArquivoServices
    {
        private readonly IArquivoDadosRepository _repository;
        public ProcessarArquivoServices(IArquivoDadosRepository repository)
        {
            _repository = repository;
        }
        public ArquivoDados BuscarArquivo()
        {
            ArquivoDados arquivoDados = new ArquivoDados();
            OpenFileDialog caminhoArquivo = new OpenFileDialog
            {
                Title = "Procurar Arquivos de Texto",
                Filter = "arquivos Execel (*.xlsx;*.xls)|*.xlsx;*.xls",
               
                CheckFileExists = true,
                CheckPathExists = true
            };
            caminhoArquivo.ShowDialog();
           
            if (caminhoArquivo.FileName.Length > 0 )
            {
                arquivoDados.Caminho = caminhoArquivo.FileName;
                arquivoDados.Tipo = Path.GetExtension(caminhoArquivo.FileName);
                arquivoDados.Nome= caminhoArquivo.SafeFileName;

                return arquivoDados;
            }

            return arquivoDados;
        }

        public DataTable CarregarArquivo(ArquivoDados arquivoDados)
        {
            return _repository.CarregarArquivo(arquivoDados);
        }
    }
}
