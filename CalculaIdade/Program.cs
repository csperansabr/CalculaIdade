using System;
using System.Globalization;
using System.Collections.Generic;

//isso é um teste

class Program
{
    static void Main()
    {
        Console.WriteLine("=== Cadastro de Usuário ===");

        while (true)
        {
            Console.Write("\nDigite a data de nascimento (dd/MM/yyyy) ou 'sair' para encerrar: ");
            string entrada = Console.ReadLine()!;

            if (entrada.Trim().ToLower() == "sair")
            {
                Console.WriteLine("Programa encerrado. Até logo!");
                break;
            }

            if (DateTime.TryParseExact(entrada, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime dataNascimento))
            {
                DateTime dataAtual = DateTime.Today;

                if (dataNascimento > dataAtual)
                {
                    Console.WriteLine("Data de nascimento inválida. Está no futuro!");
                    continue;
                }

                TimeSpan diferenca = dataAtual - dataNascimento;

                int anos = dataAtual.Year - dataNascimento.Year;
                int meses = dataAtual.Month - dataNascimento.Month;
                int dias = dataAtual.Day - dataNascimento.Day;

                if (dias < 0)
                {
                    meses--;
                    int mesAnterior = dataAtual.Month - 1 == 0 ? 12 : dataAtual.Month - 1;
                    int anoMesAnterior = mesAnterior == 12 ? dataAtual.Year - 1 : dataAtual.Year;
                    dias += DateTime.DaysInMonth(anoMesAnterior, mesAnterior);
                }

                if (meses < 0)
                {
                    anos--;
                    meses += 12;
                }

                if (diferenca.Days == 1 && dias == 0)
                    dias = 1;

                List<string> partesIdade = new();

                if (anos > 0)
                    partesIdade.Add(anos == 1 ? "1 ano" : $"{anos} anos");

                if (meses > 0)
                    partesIdade.Add(meses == 1 ? "1 mês" : $"{meses} meses");

                if (dias > 0)
                    partesIdade.Add(dias == 1 ? "1 dia" : $"{dias} dias");

                if (partesIdade.Count > 0)
                {
                    string idadeFormatada = partesIdade.Count > 1
                        ? string.Join(", ", partesIdade.GetRange(0, partesIdade.Count - 1)) + " e " + partesIdade[^1]
                        : partesIdade[0];

                    Console.WriteLine($"Idade: {idadeFormatada}.");
                }
                else
                {
                    Console.WriteLine("Idade: Recém-nascido.");
                }
            }
            else
            {
                Console.WriteLine("Formato de data inválido. Use dd/MM/yyyy.");
            }
        }
    }
}