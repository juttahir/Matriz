using System;

namespace Matrizes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Entre apenas com os números de linhas e colunas da matriz separando por espaço: ");

            string[] line = Console.ReadLine().Split(' '); //faz a leitura de 2 numeros ao reconhecer o espaço
            int linha = int.Parse(line[0]); //converte o primeiro número e armazena na variável "linha"
            int coluna = int.Parse(line[1]); //converte o segundo número e armazena na variável "linha"

            int[,] mat = new int[linha, coluna]; //reconhece o vetor e o converte em matriz armazenando os valores na variável "mat"

            Console.WriteLine(); //pula linha
            Console.WriteLine("Digite " + coluna + " números na linha separando por espaços, repita isso " + linha + " vezes"); //da a instrução ao usuário

            for (int i = 0; i < linha; i++) //comando de repetição que reconhece o primeiro número e acrescenta linhas
            {
                string[] values = Console.ReadLine().Split(' '); //faz a leitura de 2 numeros ao reconhecer o espaço
                for (int j = 0; j < coluna; j++) //comando de repetição que reconhece o segundo número e acrescenta colunas
                {
                    mat[i,j] = int.Parse(values[j]); //converte os números digitados em inteiros e utiliza apenas o J, saindo dessa repetição retorna ao I e o ciclo se repete até formar a matriz
                }
            }

            Console.WriteLine("------------------------------------------"); //linha de seperação no terminal
            Console.Write("Escolha um dos números digitados: "); //instrulção ao usuário
            Console.WriteLine(); //pula linha

            int leitura = int.Parse(Console.ReadLine()); //recebe o valor digitado e o armazena na variável "leitura"
            for(int i = 0; i < linha; i++) //comando de repetição que reconhece o primeiro número e acrescenta linhas
            {
                for(int j = 0; j < coluna; j++)//comando de repetição que reconhece o segundo número e acrescenta colunas
                {
                    if (mat[i,j] == leitura) //se o número digitado for igual um número da matriz
                    {
                        Console.WriteLine("Posição " + i + ", " + j + ": "); //escreva sua posição na matriz
                        if (j > 0) //se o número da coluna for maior que 0 "tbm poderia ter sido feito como (j != null)"
                        {
                            Console.WriteLine("Número a esquerda: " + mat[i, j - 1]); //escreva o número a esquerda
                        }
                        if (i > 0)  //se o número da linha for maior que 0 "tbm poderia ter sido feito como (j != null)"
                        {
                            Console.WriteLine("Número acima: " + mat[i -1,j ]); //escreva o número acima
                        }
                        if (j < coluna -1) //Se tiver um número anterior na coluna
                        {
                            Console.WriteLine("Número a direita: " + mat[i, j + 1]); //escreva o número a direita
                        }
                        if (i < linha -1) //Se tiver um número abaixo
                        {
                            Console.WriteLine("Número abaixo: " + mat[i +1, j]); //escreva o número abaixo
                        }
                    }
                }
            }
        }
    }
}
