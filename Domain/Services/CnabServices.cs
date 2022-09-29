using Domain.Exceptions;
using Domain.ExtensionMethods;
using Infrastructure.Entities;

namespace Domain.Services
{
    public class CnabServices
    {
        private readonly string _path;

        public CnabServices(string path)
        {
            _path = path;
        }

        //VALIDA SE O ARQUIVO POSSUI LINHAS
        public void ValidarRetorno()
        {
            List<string> lines = new List<string>();
            using (StreamReader file = new StreamReader(_path))
            {
                while (!file.EndOfStream)
                    lines.Add(file.ReadLine());
            }

            if (lines == null)
                throw new DomainExceptions("Dados do arquivo de retorno estão nulos. Impossível processar.");

            if (lines.Count <= 0)
                throw new DomainExceptions("Dados do arquivo de retorno não estão corretos. Impossível processar.");

            if (lines.Count < 4)
                throw new DomainExceptions("Dados do arquivo de retorno não contém o mínimo de 3 linhas. Impossível processar.");
        }

        //OBTEM DETALHES DOS SEGMENTOS 'T' - 'U' DE CADA BOLETO
        public List<Boleto> ObterDetalhesSegmetos()
        {
            List<Boleto> boletos = new List<Boleto>();
            Boleto boleto = null;
            string line;

            using (StreamReader file = new StreamReader(_path))
            {
                while ((line = file.ReadLine()) != null)
                {
                    switch (line[13])
                    {
                        case 'T':
                            boleto = new Boleto();
                            boleto.Nome = line.ExtrairNome();
                            boleto.Cpf = line.ExtrairCpf();
                            boleto.DataVencimento = line.ExtrairDataVencimento();
                            boleto.ValorNominal = line.ExtrairValorNominal();
                            break;
                        case 'U':
                            boleto.Juros = line.ExtrairJuros();
                            boleto.ValorPago = line.ExtrairValorPago();
                            boleto.DataPagamento = line.ExtrairDataPagamento();
                            boletos.Add(boleto);
                            break;
                    }
                }
            }
            return boletos;
        }
    }
}
