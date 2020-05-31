using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios_Aula
{
    class Program
    {
        private static int length;

        static void Main(string[] args)
        {
            exe();
        }

        static void _aula19()
        {
            double largura, comprimento, preçoMetroQuadrado, area, preço;

            largura = double.Parse(Console.ReadLine());
            comprimento = double.Parse(Console.ReadLine());
            preçoMetroQuadrado = double.Parse(Console.ReadLine());

            area = largura * comprimento;
            preço = area * preçoMetroQuadrado;

            Console.WriteLine("AREA = " + area.ToString("f2"));
            Console.WriteLine("PREÇO = " + preço.ToString("f2"));

            Console.WriteLine("arroz");
            Console.ReadLine();
        }

        static void _aula58()
        {
            int nTeste = int.Parse(Console.ReadLine());
            int iddMenores = 0;
            double media = 0;

            for (int i = 0; i < nTeste; i++)
            {
                string[] nome = new string[nTeste];
                int[] idade = new int[nTeste];
                double[] altura = new double[nTeste];
                string[] linha = Console.ReadLine().Split(' ');
                nome[i] = linha[0];
                idade[i] = int.Parse(linha[1]);
                altura[i] = double.Parse(linha[2]);
                media += altura[i] / nTeste;

                if (idade[i] < 16)
                    iddMenores++;
            }
            Console.WriteLine("Altura media: " + media.ToString("F2"));
            Console.WriteLine("Pessoas com menos de 16 anos: " + (iddMenores * 100 / nTeste).ToString("F1") + "%");
            Console.ReadLine();
        }

        static void exe_1_Proposto_1()
        {
            double maior = 0;
            int cont = 0;
            int n = int.Parse(Console.ReadLine());
            string[] linha = Console.ReadLine().Split(' ');
            for (int i = 0; i < n; i++)
            {
                double[] valores = new double[n];
                valores[i] = double.Parse(linha[i]);
                if (maior < valores[i])
                {
                    maior = valores[i];
                    cont = i;
                }
            }
            Console.WriteLine(maior.ToString("F1"));
            Console.WriteLine(cont);
            Console.ReadLine();
        }

        static void exe_1_Proposto_2()
        {
            int cont = 0;
            int n = int.Parse(Console.ReadLine());
            string[] linha = Console.ReadLine().Split(' ');
            for (int i = 0; i < n; i++)
            {
                int[] valores = new int[n];
                valores[i] = int.Parse(linha[i]);
                if (valores[i] % 2 == 0)
                {
                    Console.Write(valores[i] + " ");
                    cont++;
                }
            }
            Console.WriteLine();
            Console.WriteLine(cont);
            Console.ReadLine();
        }

        static void exe_1_Proposto_3()
        {
            int soma = 0;
            int n = int.Parse(Console.ReadLine());
            int[] valoresA = new int[n];
            int[] valoresB = new int[n];
            string[] linha;
            linha = Console.ReadLine().Split(' ');
            for (int t = 0; t < n; t++)
                valoresA[t] = int.Parse(linha[t]);
            linha = Console.ReadLine().Split(' ');
            for (int y = 0; y < n; y++)
                valoresB[y] = int.Parse(linha[y]);
            for (int i = 0; i < n; i++)
            {
                soma = valoresA[i] + valoresB[i];
                Console.Write(soma + " ");
            }
            Console.ReadLine();
        }

        static void exe_1_Proposto_4()
        {
            double media = 0;
            int n = int.Parse(Console.ReadLine());
            string[] linha = Console.ReadLine().Split(' ');
            double[] valores = new double[n];
            for (int i = 0; i < n; i++)
            {
                valores[i] = double.Parse(linha[i]);
                media += valores[i] / n;
            }
            Console.WriteLine(media.ToString("F3"));
            foreach (double x in valores)
                if (x < media)
                    Console.WriteLine(x.ToString("F1"));
            Console.ReadLine();
        }

        static void exe_1_Proposto_5()
        {
            double media = 0;
            int cont = 0;
            int n = int.Parse(Console.ReadLine());
            string[] linha = Console.ReadLine().Split(' ');
            int[] valores = new int[n];
            for (int i = 0; i < n; i++)
            {
                valores[i] = int.Parse(linha[i]);
                if (valores[i] % 2 == 0)
                {
                    media += valores[i];
                    cont++;
                }
            }
            media = media / cont;
            Console.WriteLine(media.ToString("F1"));
            Console.ReadLine();
        }

        static void exe_1_Proposto_6()
        {
            int maior = 0;
            string nomeMaior = "";
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] linha = Console.ReadLine().Split(' ');
                string[] nome = new string[n];
                int[] idade = new int[n];
                nome[i] = linha[0];
                idade[i] = int.Parse(linha[1]);
                if (maior < idade[i])
                {
                    maior = idade[i];
                    nomeMaior = nome[i];
                }
            }
            Console.WriteLine("Pessoa mais velha: " + nomeMaior);
            Console.ReadLine();
        }

        static void exe_1_Proposto_7()
        {
            int n = int.Parse(Console.ReadLine());
            double[] media = new double[n];
            string[] nome = new string[n];
            double[] nota1 = new double[n];
            double[] nota2 = new double[n];
            for (int i = 0; i < n; i++)
            {
                string[] linha = Console.ReadLine().Split(' ');
                nome[i] = linha[0];
                nota1[i] = double.Parse(linha[1]);
                nota2[i] = double.Parse(linha[2]);
                media[i] = (nota1[i] + nota2[i]) / 2.0;
            }
            Console.WriteLine("Alunos Aprovados:");
            for (int i = 0; i < n; i++)
                if (media[i] >= 6.0)
                    Console.WriteLine(nome[i]);
            Console.ReadLine();
        }

        static void exe_1_Proposto_8()
        {
            int n = int.Parse(Console.ReadLine());
            double menor = 10.0;
            double maior = 0.0;
            int Feminino = 0;
            int Masculino = 0;
            double media = 0;
            double[] altura = new double[n];
            char[] sexo = new char[n];
            for (int i = 0; i < n; i++)
            {
                string[] linha = Console.ReadLine().Split(' ');
                altura[i] = double.Parse(linha[0]);
                if (altura[i] < menor)
                    menor = altura[i];
                else if (altura[i] > maior)
                    maior = altura[i];
                sexo[i] = char.Parse(linha[1]);
                if (sexo[i] == 'F')
                    Feminino++;
                else
                    Masculino++;
            }
            for (int i = 0; i < n; i++)
                if (sexo[i] == 'F')
                    media = media + altura[i] / Feminino;
            Console.WriteLine("Menor altura = " + menor);
            Console.WriteLine("Maior altura = " + maior);
            Console.WriteLine("Media das alturas das mulheres = " + media.ToString("F2"));
            Console.WriteLine("Numero de homens = " + Masculino);
            Console.ReadLine();
        }

        static void exe_1_Proposto_9()
        {
            int qtdMercadorias = int.Parse(Console.ReadLine());
            double[] precoCompra = new double[qtdMercadorias];
            double[] precoVenda = new double[qtdMercadorias];
            double[] lucro = new double[qtdMercadorias];
            double lucroTotal = 0;
            double totalCompra = 0;
            double totalVenda = 0;
            int lucroBaixo = 0;
            int lucroMedio = 0;
            int lucroAlto = 0;

            for (int i = 0; i < qtdMercadorias; i++)
            {
                string[] linha = Console.ReadLine().Split(' ');
                string[] mercadoria = new string[qtdMercadorias];
                mercadoria[i] = linha[0];
                precoCompra[i] = double.Parse(linha[1]);
                precoVenda[i] = double.Parse(linha[2]);
                lucro[i] = (precoVenda[i] - precoCompra[i]) / precoCompra[i];
            }
            for (int i = 0; i < qtdMercadorias; i++)
            {
                if (lucro[i] < 0.1)
                    lucroBaixo++;
                else if (lucro[i] > 0.2)
                    lucroAlto++;
                else
                    lucroMedio++;
                totalCompra += precoCompra[i];
                totalVenda += precoVenda[i];
                lucroTotal += precoVenda[i] - precoCompra[i];
            }
            Console.WriteLine("Lucro abaixo de 10%: " + lucroBaixo);
            Console.WriteLine("Lucro entre 10% e 20%: " + lucroMedio);
            Console.WriteLine("Lucro acima de 20%: " + lucroAlto);
            Console.WriteLine("Valor total de compra: " + totalCompra.ToString("F2"));
            Console.WriteLine("Valor total de venda: " + totalVenda.ToString("F2"));
            Console.WriteLine("Lucro total: " + lucroTotal.ToString("F2"));
            Console.ReadLine();
        }



        static void exe_2_Proposto_1()
        {
            string[] texto = Console.ReadLine().Split(' ');
            int linha = int.Parse(texto[0]);
            int coluna = int.Parse(texto[1]);
            int[,] mat = new int[linha, coluna];

            for (int i = 0; i < linha; i++)
            {
                texto = Console.ReadLine().Split(' ');
                for (int t = 0; t < coluna; t++)
                    mat[i, t] = int.Parse(texto[t]);
            }
            Console.WriteLine("VALORES NEGATIVOS:");
            for (int i = 0; i < linha; i++)
            {
                int negativo;
                for (int t = 0; t < coluna; t++)
                    if (mat[i, t] < 0)
                    {
                        negativo = mat[i, t];
                        Console.WriteLine(negativo);
                    }
            }
            Console.ReadLine();
        }

        static void exe_2_Proposto_2()
        {
            int n = int.Parse(Console.ReadLine());
            string[] valores;
            int[,] mat = new int[n, n];
            for (int i = 0; i < n; i++)
            {
                valores = Console.ReadLine().Split(' ');
                for (int t = 0; t < n; t++)
                    mat[i, t] = int.Parse(valores[t]);
            }
            for (int i = 0; i < n; i++)
            {
                int soma = 0;
                for (int t = 0; t < n; t++)
                    soma += mat[i, t];
                Console.WriteLine(soma);
            }
            Console.ReadLine();
        }

        static void exe_2_Proposto_3()
        {
            int n = int.Parse(Console.ReadLine());
            int[,] mat = new int[n, n];
            for (int i = 0; i < n; i++)
            {
                string[] valores = Console.ReadLine().Split(' ');
                for (int t = 0; t < n; t++)
                    mat[i, t] = int.Parse(valores[t]);
            }
            for (int i = 0; i < n; i++)
            {
                int[] maior = new int[n];
                for (int t = 0; t < n; t++)
                    if (mat[i, t] > maior[i])
                        maior[i] = mat[i, t];
                Console.WriteLine(maior[i]);
            }
            Console.ReadLine();
        }

        static void exe_2_Proposto_4()
        {
            int n = int.Parse(Console.ReadLine());
            int soma = 0;
            int[,] mat = new int[n, n];
            for (int i = 0; i < n; i++)
            {
                string[] valores = Console.ReadLine().Split(' ');
                for (int t = 0; t < n; t++)
                {
                    mat[i, t] = int.Parse(valores[t]);
                    if (t > i)
                        soma += mat[i, t];
                }
            }
            Console.WriteLine(soma);
            Console.ReadLine();
        }

        static void exe_2_Proposto_5()
        {
            string[] texto = Console.ReadLine().Split(' ');
            int m = int.Parse(texto[0]);
            int n = int.Parse(texto[1]);
            int[,] mat0 = new int[m, n];
            int[,] mat1 = new int[m, n];
            for (int i = 0; i < m; i++)
            {
                texto = Console.ReadLine().Split(' ');
                for (int t = 0; t < n; t++)
                    mat0[i, t] = int.Parse(texto[t]);
            }
            for (int i = 0; i < m; i++)
            {
                texto = Console.ReadLine().Split(' ');
                for (int t = 0; t < n; t++)
                    mat1[i, t] = int.Parse(texto[t]) + mat0[i, t];
            }
            for (int i = 0; i < m; i++)
            {
                for (int t = 0; t < n; t++)
                    Console.Write($"{mat1[i, t]} ");
                Console.WriteLine();
            }
            Console.ReadLine();
        }

        static void exe_2_Proposto_6()
        {

            int n = int.Parse(Console.ReadLine());
            double[] linha = new double[n];
            double[] coluna = new double[n];
            double[,] mat = new double[n, n];
            double soma = 0;
            double[] diagonal = new double[n];
            for (int i = 0; i < n; i++)
            {
                string[] valores = Console.ReadLine().Split(' ');
                for (int t = 0; t < n; t++)
                {
                    mat[i, t] = double.Parse(valores[t]);
                    if (mat[i, t] >= 0)
                        soma += mat[i, t];
                    if (i == t)
                        diagonal[i] = mat[i, t];
                }
            }
            int linhaDesejada = int.Parse(Console.ReadLine());
            int colunaDesejada = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
                for (int t = 0; t < n; t++)
                    linha[t] = mat[linhaDesejada, t];
            for (int i = 0; i < n; i++)
                coluna[i] = mat[i, colunaDesejada];

            Console.WriteLine($"SOMA DOS POSITIVOS: {soma.ToString("F1")}");
            Console.Write("LINHA ESCOLHIDA: ");
            foreach (double x in linha)
                Console.Write($"{x.ToString("F1")} ");
            Console.WriteLine();
            Console.Write("COLUNA ESCOLHIDA: ");
            foreach (double x in coluna)
                Console.Write($"{x.ToString("F1")} ");
            Console.WriteLine();
            Console.Write("DIAGONAL PRINCIPAL: ");
            foreach (double x in diagonal)
                Console.Write($"{x.ToString("F1")} ");
            Console.WriteLine();

            Console.WriteLine("MATRIZ ALTERADA:");
            for (int i = 0; i < n; i++)
            {
                for (int t = 0; t < n; t++)
                {
                    if (mat[i, t] < 0)
                        Console.Write($"{Math.Pow(mat[i, t], 2.0).ToString("F1")} ");
                    else
                        Console.Write($"{mat[i, t].ToString("F1")} ");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }

        static void exe()
        {
            int filas = int.Parse(Console.ReadLine());
            int colunas = int.Parse(Console.ReadLine());
            int[,] mat = new int[filas, colunas];
            for (int i = 0; i < filas; i++)
            {
                string[] valores = Console.ReadLine().Split(' ');
                for (int t = 0; t < colunas; t++)
                {
                    mat[i, t] = int.Parse(valores[t]);
                }
            }
            int nFila = int.Parse(Console.ReadLine()) - 1;
            int last = mat[nFila, colunas - 1];
            for (int i = colunas - 1; i > 0;)
            {
                mat[nFila, i] = mat[nFila, --i];
            }
            mat[nFila, 0] = last;
            for (int i = 0; i < filas; i++)
            {
                for (int t = 0; t < colunas; t++)
                {
                    Console.Write($"{mat[i, t]} ");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
