using System;

namespace ValidadorDeCPF
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1, valor, resposta, PrimeiroDigito, SegundoDigito;
            int CalculoPrimeiroDigitoVerificador;
            int CalculoSegundoDigitoVerificador;
            int continuar = 1;

            do
            {
                int PrimeiroMultiplicador = 10, SegundoMultiplicador = 11;
                int PrimeiroSomador = 0, SegundoSomador = 0;

                Console.Write("Digite o CPF completo sem pontos e hífen: ");
                string CPF = (Console.ReadLine());

                switch (CPF)
                {
                    case "00000000000":
                        Console.WriteLine("CPF Válido, porém não pode ser utilizado");
                        Console.WriteLine("Tecle enter para finalizar");
                        Console.Read();
                        return;
                    case "11111111111":
                        Console.WriteLine("CPF Válido, porém não pode ser utilizado");
                        Console.WriteLine("Tecle enter para finalizar");
                        Console.Read();
                        return;
                    case "22222222222":
                        Console.WriteLine("CPF Válido, porém não pode ser utilizado");
                        Console.WriteLine("Tecle enter para finalizar");
                        Console.Read();
                        return;
                    case "33333333333":
                        Console.WriteLine("CPF Válido, porém não pode ser utilizado");
                        Console.WriteLine("Tecle enter para finalizar");
                        Console.Read();
                        return;
                    case "44444444444":
                        Console.WriteLine("CPF Válido, porém não pode ser utilizado");
                        Console.WriteLine("Tecle enter para finalizar");
                        Console.Read();
                        return;
                    case "55555555555":
                        Console.WriteLine("CPF Válido, porém não pode ser utilizado");
                        Console.WriteLine("Tecle enter para finalizar");
                        Console.Read();
                        return;
                    case "66666666666":
                        Console.WriteLine("CPF Válido, porém não pode ser utilizado");
                        Console.WriteLine("Tecle enter para finalizar");
                        Console.Read();
                        return;
                    case "77777777777":
                        Console.WriteLine("CPF Válido, porém não pode ser utilizado");
                        Console.WriteLine("Tecle enter para finalizar");
                        Console.Read();
                        return;
                    case "88888888888":
                        Console.WriteLine("CPF Válido, porém não pode ser utilizado");
                        Console.WriteLine("Tecle enter para finalizar");
                        Console.Read();
                        return;
                    case "99999999999":
                        Console.WriteLine("CPF Válido, porém não pode ser utilizado");
                        Console.WriteLine("Tecle enter para finalizar");
                        Console.Read();
                        return;
                }

                try
                {
                    for (int i = 0; i < 9; i++)
                    {
                        string numero = CPF.Substring(i, 1);
                        n1 = int.Parse(numero);

                        valor = PrimeiroMultiplicador * n1;
                        PrimeiroMultiplicador--;
                        PrimeiroSomador += valor;
                    }

                    for (int i = 0; i < 10; i++)
                    {
                        string numero = CPF.Substring(i, 1);
                        n1 = int.Parse(numero);
                        valor = SegundoMultiplicador * n1;

                        SegundoMultiplicador--;

                        SegundoSomador += valor;
                    }
                }
                catch (ArgumentOutOfRangeException)
                {
                    Console.WriteLine("CPF incompleto");
                    Console.WriteLine("Inicie uma nova busca");
                    Console.Read();
                    break;
                }

                CalculoPrimeiroDigitoVerificador = PrimeiroSomador % 11;
                PrimeiroDigito = 11 - CalculoPrimeiroDigitoVerificador;

                if (PrimeiroDigito >= 10)
                {
                    PrimeiroDigito = 0;
                }

                CalculoSegundoDigitoVerificador = SegundoSomador % 11;
                SegundoDigito = 11 - CalculoSegundoDigitoVerificador;

                if (SegundoDigito >= 10)
                {
                    SegundoDigito = 0;
                }

                try
                {
                    string P = CPF.Substring(9, 1);
                    // PD = Primeiro Digito Verificador
                    int PD = int.Parse(P);

                    string S = CPF.Substring(10, 1);
                    // SD = Segundo Digito Verificador
                    int SD = int.Parse(S);

                    if (PrimeiroDigito != PD || SegundoDigito != SD)
                    {
                        Console.WriteLine("CPF: " + CPF + " inválido \n");
                    }
                    else
                    {
                        Console.WriteLine("CPF: " + CPF + " Válido \n");
                    }
                }
                catch (ArgumentOutOfRangeException)
                {
                    Console.WriteLine("CPF incompleto");
                    Console.WriteLine("Inicie uma nova busca");
                    Console.Read();
                    break;
                }

                do
                {
                    Console.WriteLine("Deseja realizar nova pesquisa ?");
                    Console.Write("Tecle 1 para SIM ou 0 para NÃO : ");
                    resposta = int.Parse(Console.ReadLine());
                    Console.Clear();

                    Console.WriteLine();

                    if (resposta != 1 && resposta != 0)
                    {
                        Console.Write("Escolha opção válida \n\n");
                    }
                }
                while (resposta < 0 || resposta > 1);
            }
            while (continuar == resposta);
        }
    }
}
