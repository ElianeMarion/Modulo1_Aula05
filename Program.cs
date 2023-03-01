using System.Globalization;
using System.Security.Cryptography;

namespace Aula05
{
	internal class Program
	{
		static void Main(string[] args)
		{

			//Matrizes multidimensionais / bidimensionais
			/*Elabore um programa que leia 6 números inteiros em uma matriz 3x2 (3 linhas e 2 colunas).
			 * Ao término da leitura, percorra a matriz e exiba a quantidade de números pares inseridos 
			 * na matriz*/

			/*int[,] matriz = new int[3, 2];
			int qtdPares = 0;
			
			for (int l = 0; l < 3; l++) //variavel para controle da linha
			{
				for (int c = 0; c < 2; c++) //variavel para controle da coluna
				{
					Console.WriteLine("Digite um valor para a posição[ " + l + "," + c +"]: ");
					matriz[l, c] = Convert.ToInt32(Console.ReadLine());
				}
			}

			for (int l = 0; l < 3; l++) //variavel para controle da linha
			{
				for (int c = 0; c < 2; c++) //variavel para controle da coluna
				{
					//Console.WriteLine("Digite um valor para a posição[ " + l + "," + c + "]: " + matriz[l,c]);
					if (matriz[l, c] % 2 == 0)
						qtdPares++;
				}
			}
			Console.WriteLine("A quantidade de pares na matriz é: " + qtdPares);

			int[,] numeros = new int[3, 2] { { 1, 2 }, { 3, 4 }, { 5, 6 } }; 
			string[,] amigos = new string[2, 2] { { "Mac", "Jan" }, { "Mimi", "Jeff" } };


			int[,] numero = new int[,] { { 1, 2 }, { 3, 4 }, { 5, 6 } }; 
			string[,] amigo = new string[, ] { { "Mac", "Jan" }, { "Mimi", "Jeff" } };

			int[,] numers = { { 1, 2 }, { 3, 4 }, { 5, 6 } }; 
			string[,] amigs = { { "Mac", "Jan" }, { "Mimi", "Jeff" } };
			*/
			//Length - Sort - Busca
			string[] cores = { "vermelho", "branco", "azul", "laranja", "preto" };
			Console.WriteLine("Tamanho do array: " + cores.Length);
			int i;
			Array.Reverse(cores);
			Console.WriteLine("Exibindo o array em ordem inversa: ");
			for (i = 0; i < cores.Length; i++)
			{
				Console.WriteLine(cores[i]);
			}

			Array.Sort(cores);
			Console.WriteLine("Exibindo o array ordenado: ");
			for ( int ind = 0; ind < cores.Length; ind++)
			{
				Console.WriteLine(cores[ind]);
			}

			Console.WriteLine("Digite uma cor para buscar no array: ");
			string cor = Console.ReadLine();
			int resposta = Array.BinarySearch(cores, cor);
			if(resposta >= 0 ) {
				Console.WriteLine("Encontrei a cor no indice" + resposta);
			}
			else
			{
				Console.WriteLine("Não encontrei a cor no indice");
			}

			Console.WriteLine("Digite uma outra cor para buscar no array: ");
			string cor2 = Console.ReadLine();
			 i = Array.IndexOf(cores, cor2);
			
				Console.WriteLine("Encontrei a cor no indice" + i);
			
			
			//Leitura de 10 notas e média
			/*double[] notas = new double[5];
			double media, soma = 0;

			for (int i = 0; i < notas.Length; i++)
			{
				Console.WriteLine("Digite a " + Convert.ToInt16(i + 1) + " nota[ " + i + "]: ");
				notas[i] = Convert.ToDouble(Console.ReadLine());
				soma += notas[i]; // soma = soma + notas[i]
			}
			media = soma / notas.Length;
			Console.WriteLine("Média: " + media);

			/*double[] v = new double[5];
			double total = 0;
			for(int i = 0; i < v.Length; i++) //for(int i = 0; i < 5; i++)
			{
				//i+1 != i=i+1
				Console.WriteLine("Digite o valor de vendas do vendedor " + i);
				v[i] = Convert.ToDouble(Console.ReadLine());
				total += v[i];
			}
			Console.WriteLine("Total das vendas; R$ " + total);
			/**for (int i = 0; i < v.Length; i++) //for(int i = 0; i < 5; i++)
			{
				Console.WriteLine("Vendedor[" + i + "] = " + v[i]);
			}*/

			//Definindo o tamanho e usando o operador new
			/*int[] numeros = new int[5] { 1, 2, 3, 4, 5 }; 
			string[] nomes = new string[3] { "Mac", "Jessica", "MiMi" };
			for (int i = 0; i < numeros.Length; i++) //for(int i = 0; i < 5; i++)
			{
				Console.WriteLine("Numeros[" + i + "] = " + numeros[i]);
			}*/

			//Omitindo o tamanho do array
			//int[] numeros = new int[] { 1, 2, 3, 4, 5 };
			//string[] nomes = new string[] {"Mac", "Jessica", "MiMi"};

			//Omitindo o operador new
			//int[] numero = { 1, 2, 3, 4, 5 }; 
			//[] nome = { "Mac", "Jessica", "MiMi" };

			/*Leia 15 elementos para um vetor A. Crie o vetor B, de mesma dimensão, 
			 * contendo os elementos do vetor A em ordem inversa*/
			/*int[] vetA = new int[5];
			int[] vetB = new int[5];
			/*
				i=0 => vetB[4-0] = vetA[0]
				i=1 => vetB[4-1] = vetA[1]
				i=2 => vetB[4-2] = vetA[2]
				 */
			/*for (int i = 0; i < vetA.Length; i++) // posso substituir o vetA.Length por 5
			{
				Console.WriteLine("Digite um valor para o vetorA[ " + i + "]:");
				vetA[i] = Convert.ToInt32(Console.ReadLine());
				vetB[4-i] = vetA[i];
			}
			/*int j = 4;
			for (int i = 0; i < vetA.Length; i++) // posso substituir o vetA.Length por 5
			{
				Console.WriteLine("Digite um valor para o vetorA[ " + i + "]:");
				vetA[i] = Convert.ToInt32(Console.ReadLine());
				vetB[j] = vetA[i];
				j--;
			}*/
			/*for (int i = 0; i < vetB.Length; i++)
				Console.WriteLine("VetB[" + i + "] = " + vetB[i]);*/
		}
	}
}