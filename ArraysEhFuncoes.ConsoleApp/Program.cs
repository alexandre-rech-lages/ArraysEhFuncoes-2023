/**
*  Encontrar o Maior Valor da sequência [x]
*  Encontrar o Menor Valor da sequência [x]
*  Encontrar o Valor Médio da sequência [x]
*  Encontrar os 3 maiores valores da sequência [x]
*  Encontrar os valores negativos da sequência [x]    
*  Remover itens da sequência [x]
*  Mostrar na Tela os valores da sequência [x]
*/

using System.Collections;

namespace ArraysEhFuncoes.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /** Exemplos ArrayList
             * 
            //Console.WriteLine("Digite um nome: ");

            ArrayList listaDeNomes = new ArrayList();

            //listaDeNomes.Add(Console.ReadLine());

            listaDeNomes.Add("Gabriel");
            listaDeNomes.Add("Tiago");
            listaDeNomes.Add("Camila");            

            foreach (string nome in listaDeNomes)
            {
                Console.WriteLine(nome);
            }

            listaDeNomes.Remove("Camila");

            Console.WriteLine( "Sem a Camila" );

            foreach (string nome in listaDeNomes)
            {
                Console.WriteLine(nome);
            }

            ArrayList listaDeNumeros = new ArrayList();

            listaDeNumeros.Add(10);
            listaDeNumeros.Add(20);
            listaDeNumeros.Add(30);
            listaDeNumeros.Add(40);

            listaDeNumeros.Add(50);

            int posicaoDoNumero50 = listaDeNumeros.IndexOf(50);
           
            Console.WriteLine("Mostrando números com foreach");

            for (int i = 0; i < listaDeNumeros.Count; i++)
            {
                Console.WriteLine(listaDeNumeros[i]);
            }

            */
            
            ArrayList sequenciaNumeros = ObterNumeros();

            Console.WriteLine("\nMaior Valor: " + EncontrarMaiorValor(sequenciaNumeros));

            Console.WriteLine("\nMenor Valor: " + EncontrarMenorValor(sequenciaNumeros));

            Console.WriteLine("\nValor Médio: " + CalcularValorMedio(sequenciaNumeros));

            Console.Write("\nTrês Maiores: ");

            MostrarSequenciaNumeros(EncontrarTresMaiores(sequenciaNumeros));

            Console.Write("\nValores Negativos: ");

            MostrarSequenciaNumeros(EncontrarValoresNegativos(sequenciaNumeros));

            int numeroParaRemover = ObterNumeroParaRemover();

            ArrayList novaSequenciaNumeros = RemoverElemento(sequenciaNumeros, numeroParaRemover);

            Console.WriteLine();

            MostrarSequenciaNumeros(novaSequenciaNumeros);

            Console.ReadLine();            
        }

        static int ObterNumeroParaRemover()
        {
            Console.WriteLine();

            Console.Write("Digite o número para remover: ");

            int numeroParaRemover = Convert.ToInt32(Console.ReadLine());

            return numeroParaRemover;
        }

        static ArrayList ObterNumeros()
        {
            Console.Write("Digite os números separados por espaços: ");

            string[] sequenciaNumeros = Console.ReadLine().Trim().Split(" ");
            
            ArrayList numeros = new ArrayList();

            foreach (string numero in sequenciaNumeros)
            {
                numeros.Add(Convert.ToInt32(numero));
            }          

            return numeros;
        }

        static void MostrarSequenciaNumeros(ArrayList numeros)
        {
            for (int i = 0; i < numeros.Count; i++)
            {
                Console.Write(numeros[i]);

                if (i != numeros.Count - 1)
                    Console.Write(", ");
            }

            Console.WriteLine();
        }

        static int EncontrarMaiorValor(ArrayList numeros)
        {
            int maiorValor = (int)numeros[0];

            foreach (int numero in numeros)
            {
                if (numero > maiorValor)
                {
                    maiorValor = numero;
                }
            }           

            return maiorValor;
        }

        static int EncontrarMenorValor(ArrayList numeros)
        {
            int menorValor = (int)numeros[0];

            foreach (int numero in numeros)
            {
                if (numero < menorValor)
                {
                    menorValor = numero;
                }
            }

            return menorValor;
        }

        static decimal CalcularValorMedio(ArrayList numeros)
        {
            int valorTotal = 0;

            foreach (int numero in numeros)
            {
                valorTotal = valorTotal + numero;
            }

            decimal valorMedio = valorTotal / numeros.Count; //16

            return Math.Round(valorMedio, 2);
        }

        static ArrayList EncontrarTresMaiores(ArrayList numeros)
        {
            numeros.Sort();

            numeros.Reverse();

            return numeros.GetRange(0, 3);
        }

        static ArrayList EncontrarValoresNegativos(ArrayList numeros)
        {
            numeros.Reverse();

            ArrayList valoresNegativos = new ArrayList();

            foreach (int numero in numeros)
            {
                if (numero < 0)
                {
                    valoresNegativos.Add(numero);
                }
            }

            return valoresNegativos;
        }

        static ArrayList RemoverElemento(ArrayList numeros, int numeroParaRemover)
        {
            while (numeros.Contains(numeroParaRemover))
            {
                numeros.Remove(numeroParaRemover);
            }

            return numeros;
        }
    }
}