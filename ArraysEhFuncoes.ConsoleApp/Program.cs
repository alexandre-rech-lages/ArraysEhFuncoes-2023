/**
 * 
 *  Encontrar o Maior Valor da sequência [x]
    Encontrar o Menor Valor da sequência [x]
    Encontrar o Valor Médio da sequência [x]
    Encontrar os 3 maiores valores da sequência [x]
    Encontrar os valores negativos da sequência [x]    
    Remover itens da sequência []
    Mostrar na Tela os valores da sequência [x]

 */
namespace ArraysEhFuncoes.ConsoleApp
{
    internal class Program
    {
        static int ObterNumeroParaRemover()
        {
            Console.WriteLine();

            Console.Write("Digite o número para remover: ");

            int numeroParaRemover = Convert.ToInt32(Console.ReadLine());

            return numeroParaRemover;
        }

        static int[] ObterNumeros()
        {
            int[] numeros = new int[]
            {
                -5, 3, 4, 5, 9, 6, 10, -2, 11, 1, 2, 6, 7, 8, 0, -6
            };

            return numeros;
        }

        static void MostrarSequenciaNumeros(int[] numeros)
        {
            for (int i = 0; i < numeros.Length; i++)
            {
                Console.Write(numeros[i]);

                if (i != numeros.Length - 1)
                    Console.Write(", ");
            }
        }

        static int EncontrarMaiorValor(int[] numeros)
        {
            int maiorValor = numeros[0];

            for (int i = 0; i < numeros.Length; i++)
            {
                if (numeros[i] > maiorValor)
                {
                    maiorValor = numeros[i];
                }
            }

            return maiorValor;
        }

        static int EncontrarMenorValor(int[] numeros)
        {
            int menorValor = numeros[0];

            for (int i = 0; i < numeros.Length; i++)
            {
                if (numeros[i] < menorValor)
                {
                    menorValor = numeros[i];
                }
            }

            return menorValor;
        }

        static decimal CalcularValorMedio(int[] numeros)
        {
            int valorTotal = 0;

            for (int i = 0; i < numeros.Length; i++)
            {
                valorTotal = valorTotal + numeros[i];
            }

            decimal valorMedio = valorTotal / numeros.Length; //16

            return Math.Round(valorMedio, 2);
        }

        static int[] EncontrarTresMaiores(int[] numeros)
        {
            Array.Sort(numeros);

            Array.Reverse(numeros);

            int[] tresMaiores = new int[3];

            for (int i = 0; i < tresMaiores.Length; i++)
            {
                tresMaiores[i] = numeros[i];
            }

            return tresMaiores;
        }

        static int[] EncontrarValoresNegativos(int[] numeros)
        {
            Array.Reverse(numeros);

            int qtdNumerosNegativos = 0;

            for (int i = 0; i < numeros.Length; i++)
            {
                if (numeros[i] < 0)
                    qtdNumerosNegativos++;
            }

            int[] valoresNegativos = new int[qtdNumerosNegativos]; //4

            for (int i = 0; i < numeros.Length; i++)
            {
                if (numeros[i] < 0)
                {
                    valoresNegativos[i] = numeros[i];
                }
            }

            return valoresNegativos;
        }

        static int[] RemoverElemento(int[] numeros, int numeroParaRemover)
        {
            int qtdNumerosParaRemover = 0;

            for (int i = 0; i < numeros.Length; i++)
            {
                if (numeros[i] == numeroParaRemover)
                {
                    qtdNumerosParaRemover++;
                }
            }

            int[] novaSequenciaNumeros = new int[numeros.Length - qtdNumerosParaRemover];

            int j = 0;
            for (int i = 0; i < numeros.Length; i++)
            {
                if (numeros[i] != numeroParaRemover)
                {
                    novaSequenciaNumeros[j] = numeros[i];
                    j++;
                }
            }

            return novaSequenciaNumeros;
        }

        static void Main(string[] args)
        {
            int[] sequenciaNumeros = ObterNumeros();

            MostrarSequenciaNumeros(sequenciaNumeros);

            Console.WriteLine("\nMaior Valor: " + EncontrarMaiorValor(sequenciaNumeros));

            Console.WriteLine("\nMenor Valor: " + EncontrarMenorValor(sequenciaNumeros));

            Console.WriteLine("\nValor Médio: " + CalcularValorMedio(sequenciaNumeros));

            Console.Write("\nTrês Maiores: ");

            MostrarSequenciaNumeros(EncontrarTresMaiores(sequenciaNumeros));

            Console.Write("\nValores Negativos: ");

            MostrarSequenciaNumeros(EncontrarValoresNegativos(sequenciaNumeros));

            int numeroParaRemover = ObterNumeroParaRemover();

            int[] novaSequenciaNumeros = RemoverElemento(sequenciaNumeros, numeroParaRemover);

            MostrarSequenciaNumeros(novaSequenciaNumeros);

            Console.ReadLine();
        }       
    }
}