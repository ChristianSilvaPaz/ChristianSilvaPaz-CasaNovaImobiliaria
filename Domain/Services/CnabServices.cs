using Domain.ExtensionMethods;
using Infrastructure.Entities;
using System;
using System.Reflection.PortableExecutable;

namespace Domain.Services
{
    public class CnabServices
    {
        string path = @"C:\Users\chris\Documents\CasaNovaImobiliaria-Arquivos\cnab.ret";

        public List<Boleto> iterar()
        {
            StreamReader file = new StreamReader(path);
            List<Boleto> boletos = new List<Boleto>();
            Boleto boleto = null;
            string line;

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
            return boletos;
            file.Close();
        }
    }
}

/*
                if (line[13] != 'T' && line[13] != 'U')
                {
                    boleto = null;
                }
                else
                {
                    if (line[13] == 'T')
                    {
                        boleto = new Boleto();
                        boleto.Nome = line.ExtrairNome();
                        boleto.Cpf = line.ExtrairCpf();
                        boleto.DataVencimento = line.ExtrairDataVencimento();
                        boleto.ValorNominal = line.ExtrairValorNominal();
                    }
                    if (line[13] == 'U')
                    {
                        boleto.Juros = line.ExtrairJuros();
                        boleto.ValorPago = line.ExtrairValorPago();
                        boleto.DataPagamento = line.ExtrairDataPagamento();
                        boletos.Add(boleto);
                        boleto = null;
                    }
                }*/