using System;

namespace Exercicio_Proposto
{
    class Program
    {
        static void Main(string[] args)
        {
            uri();
        }

        static void uri1006()
        {
            double A, B, C, MEDIA;

            A = double.Parse(Console.ReadLine());
            B = double.Parse(Console.ReadLine());
            C = double.Parse(Console.ReadLine());

            MEDIA = (A * 2 + B * 3 + C * 5) / 10;

            Console.WriteLine("MEDIA = " + MEDIA.ToString("f1"));
            Console.ReadLine();
        }
        static void uri1004()
        {
            int X, Y, PROD;

            X = int.Parse(Console.ReadLine());
            Y = int.Parse(Console.ReadLine());

            PROD = X * Y;

            Console.WriteLine("PROD = " + PROD);
        }
        static void uri1007()
        {
            int A, B, C, D, DIFERENCA;

            A = int.Parse(Console.ReadLine());
            B = int.Parse(Console.ReadLine());
            C = int.Parse(Console.ReadLine());
            D = int.Parse(Console.ReadLine());

            DIFERENCA = A * B - C * D;

            Console.WriteLine("DIFERENCA = " + DIFERENCA);
            Console.ReadLine();

        }
        static void uri1008()
        {
            int NUMBER, quantidadeHoraTrabalho;
            double ganhoHora, SALARY;

            NUMBER = int.Parse(Console.ReadLine());
            quantidadeHoraTrabalho = int.Parse(Console.ReadLine());
            ganhoHora = double.Parse(Console.ReadLine());

            SALARY = quantidadeHoraTrabalho * ganhoHora;

            Console.WriteLine("NUMBER = " + NUMBER);
            Console.WriteLine("SALARY = U$ " + SALARY.ToString("f2"));
            Console.ReadLine();
        }
        static void uri1010()
        {
            int codigoPeça, numeroPeça, codigoPeça1, numeroPeça1;
            double valorPeça, valorPeça1, valorPagar;

            string[] vet = Console.ReadLine().Split(' ');
            string[] vet1 = Console.ReadLine().Split(' ');

            codigoPeça = int.Parse(vet[0]);
            numeroPeça = int.Parse(vet[1]);
            valorPeça = double.Parse(vet[2]);

            codigoPeça1 = int.Parse(vet1[0]);
            numeroPeça1 = int.Parse(vet1[1]);
            valorPeça1 = double.Parse(vet1[2]);


            valorPagar = numeroPeça * valorPeça + numeroPeça1 * valorPeça1;

            Console.WriteLine("VALOR A PAGAR: R$ " + valorPagar.ToString("f2"));
            Console.ReadLine();
        }
        static void uri1014()
        {
            int X;
            double Y, kmPorLitro;

            X = int.Parse(Console.ReadLine());
            Y = double.Parse(Console.ReadLine());

            kmPorLitro = X / Y;

            Console.WriteLine(kmPorLitro.ToString("F3") + " km/l");
            Console.ReadLine();
        }
        static void uri1016()
        {
            double X, MIN;

            X = double.Parse(Console.ReadLine());

            MIN = X * 2;

            Console.WriteLine(MIN + " minutos");
        }
        static void uri1017()
        {
            int tempoViagem, velocidadeMedia, distanciaViagem;
            double litrosGasolina;

            tempoViagem = int.Parse(Console.ReadLine());
            velocidadeMedia = int.Parse(Console.ReadLine());

            distanciaViagem = tempoViagem * velocidadeMedia;
            litrosGasolina = (double)distanciaViagem / 12;

            Console.WriteLine(litrosGasolina.ToString("f3"));
            Console.ReadLine();
        }
        static void uri1009()
        {
            string nome;
            double salarioFixo, vendas, total;

            nome = Console.ReadLine();
            salarioFixo = double.Parse(Console.ReadLine());
            vendas = double.Parse(Console.ReadLine());

            total = (double)salarioFixo + vendas * 0.15;

            Console.WriteLine("TOTAL = R$ " + total.ToString("F2"));
            Console.ReadLine();
        }
        static void uri1011()
        {
            double R, pi, volume;

            R = double.Parse(Console.ReadLine());
            pi = 3.14159;

            volume = (4.0 / 3) * pi * R * R * R;

            Console.WriteLine("VOLUME = " + volume.ToString("F3"));
            Console.ReadLine();
        }
        static void uri1012()
        {
            double A, B, C, triangulo, circulo, trapezio, quadrado, retangulo;

            string[] vet = Console.ReadLine().Split(' ');

            A = double.Parse(vet[0]);
            B = double.Parse(vet[1]);
            C = double.Parse(vet[2]);

            triangulo = (A * C) / 2;
            circulo = C * C * 3.14159;
            trapezio = ((A + B) * C / 2);
            quadrado = Math.Pow(B, 2.0);
            retangulo = A * B;

            Console.WriteLine("TRIANGULO: " + triangulo.ToString("f3"));
            Console.WriteLine("CIRCULO: " + circulo.ToString("f3"));
            Console.WriteLine("TRAPEZIO: " + trapezio.ToString("f3"));
            Console.WriteLine("QUADRADO: " + quadrado.ToString("f3"));
            Console.WriteLine("RETANGULO: " + retangulo.ToString("f3"));

            Console.ReadLine();

        }
        static void uri1015()
        {
            double x1, y1, x2, y2, distancia;

            string[] vet = Console.ReadLine().Split(' ');
            x1 = double.Parse(vet[0]);
            y1 = double.Parse(vet[1]);

            vet = Console.ReadLine().Split(' ');
            x2 = double.Parse(vet[0]);
            y2 = double.Parse(vet[1]);

            distancia = Math.Sqrt(Math.Pow(x2 - x1, 2.0) + Math.Pow(y2 - y1, 2.0));

            Console.WriteLine(distancia.ToString("F4"));
            Console.ReadLine();
        }
        static void uri1018()
        {
            int N, divisao, nota, resto;

            N = int.Parse(Console.ReadLine());
            Console.WriteLine(N);

            resto = N;

            nota = 100;
            divisao = resto / nota;
            Console.WriteLine(divisao + " nota(s) de R$ " + nota + ",00");
            resto = resto % nota;

            nota = 50;
            divisao = resto / nota;
            Console.WriteLine(divisao + " nota(s) de R$ " + nota + ",00");
            resto = resto % nota;

            nota = 20;
            divisao = resto / nota;
            Console.WriteLine(divisao + " nota(s) de R$ " + nota + ",00");
            resto = resto % nota;

            nota = 10;
            divisao = resto / nota;
            Console.WriteLine(divisao + " nota(s) de R$ " + nota + ",00");
            resto = resto % nota;

            nota = 5;
            divisao = resto / nota;
            Console.WriteLine(divisao + " nota(s) de R$ " + nota + ",00");
            resto = resto % nota;

            nota = 2;
            divisao = resto / nota;
            Console.WriteLine(divisao + " nota(s) de R$ " + nota + ",00");
            resto = resto % nota;

            nota = 1;
            divisao = resto / nota;
            Console.WriteLine(divisao + " nota(s) de R$ " + nota + ",00");
            resto = resto % nota;

            Console.ReadLine();
        }
        static void uri1020()
        {
            int idade, resto, tempo;

            idade = int.Parse(Console.ReadLine());

            resto = idade;

            tempo = resto / 365;
            Console.WriteLine(tempo + " ano(s)");
            resto = resto % 365;

            tempo = resto / 30;
            Console.WriteLine(tempo + " mes(es)");
            resto = resto % 30;

            tempo = resto;
            Console.WriteLine(tempo + " dia(s)");

            Console.ReadLine();
        }
        static void uri1021()
        {
            double N;
            int quociente, resto, nota, moeda;

            N = double.Parse(Console.ReadLine());

            resto = (int)(N * 100.0 + 0.5);

            Console.WriteLine("NOTAS:");

            nota = 100;
            quociente = resto / (nota * 100);
            Console.WriteLine(quociente + " nota(s) de R$ " + nota + ".00");
            resto = resto % (nota * 100);

            nota = 50;
            quociente = resto / (nota * 100);
            Console.WriteLine(quociente + " nota(s) de R$ " + nota + ".00");
            resto = resto % (nota * 100);

            nota = 20;
            quociente = resto / (nota * 100);
            Console.WriteLine(quociente + " nota(s) de R$ " + nota + ".00");
            resto = resto % (nota * 100);

            nota = 10;
            quociente = resto / (nota * 100);
            Console.WriteLine(quociente + " nota(s) de R$ " + nota + ".00");
            resto = resto % (nota * 100);

            nota = 5;
            quociente = resto / (nota * 100);
            Console.WriteLine(quociente + " nota(s) de R$ " + nota + ".00");
            resto = resto % (nota * 100);

            nota = 2;
            quociente = resto / (nota * 100);
            Console.WriteLine(quociente + " nota(s) de R$ " + nota + ".00");
            resto = resto % (nota * 100);

            Console.WriteLine("MOEDAS:");

            moeda = 100;
            quociente = resto / moeda;
            Console.WriteLine(quociente + " moeda(s) de R$ 1.00");
            resto = resto % moeda;

            moeda = 50;
            quociente = resto / moeda;
            Console.WriteLine(quociente + " moeda(s) de R$ 0.50");
            resto = resto % moeda;

            moeda = 25;
            quociente = resto / moeda;
            Console.WriteLine(quociente + " moeda(s) de R$ 0.25");
            resto = resto % moeda;

            moeda = 10;
            quociente = resto / moeda;
            Console.WriteLine(quociente + " moeda(s) de R$ 0.10");
            resto = resto % moeda;

            moeda = 5;
            quociente = resto / moeda;
            Console.WriteLine(quociente + " moeda(s) de R$ 0.05");
            resto = resto % moeda;

            Console.WriteLine(resto + " moeda(s) de R$ 0.01");

            Console.ReadLine();
        }
        static void uri1114()
        {
            int senhaEntrada, senhaAcesso;

            senhaEntrada = int.Parse(Console.ReadLine());
            senhaAcesso = 2002;

            while (senhaEntrada != senhaAcesso)
            {
                Console.WriteLine("Senha Invalida");
                senhaEntrada = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Acesso Permitido");
            Console.ReadLine();
        }
        static void uri1117()
        {
            double nota1, nota2, media;

            nota1 = double.Parse(Console.ReadLine());
            while (nota1 < 0.0 || nota1 > 10.0)
            {
                Console.WriteLine("nota invalida");
                nota1 = double.Parse(Console.ReadLine());
            }
            nota2 = double.Parse(Console.ReadLine());
            while (nota2 < 0.0 || nota2 > 10.0)
            {
                Console.WriteLine("nota invalida");
                nota2 = double.Parse(Console.ReadLine());
            }

            media = (nota1 + nota2) / 2;
            Console.WriteLine("media = " + media.ToString("F2"));
            Console.ReadLine();
        }
        static void uri1134()
        {
            int combustivel, alcool, gasolina, diesel;

            alcool = 0;
            gasolina = 0;
            diesel = 0;

            combustivel = int.Parse(Console.ReadLine());
            while (combustivel != 4)
            {
                switch (combustivel)
                {
                    case 1:
                        alcool++;
                        break;
                    case 2:
                        gasolina++;
                        break;
                    case 3:
                        diesel++;
                        break;
                }
                combustivel = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("MUITO OBRIGADO");
            Console.WriteLine("Alcool: " + alcool);
            Console.WriteLine("Gasolina: " + gasolina);
            Console.WriteLine("Diesel: " + diesel);


            Console.ReadLine();
        }
        static void uri1154()
        {
            int somaIdades, idadeDigitada;
            double media;

            int cont = 0;
            somaIdades = 0;
            idadeDigitada = int.Parse(Console.ReadLine());
            while (idadeDigitada > 0)
            {
                somaIdades += idadeDigitada;
                cont++;
                idadeDigitada = int.Parse(Console.ReadLine());
            }
            media = (double)somaIdades / cont;
            Console.WriteLine(media.ToString("F2"));
            Console.ReadLine();
        }
        static void uri1159()
        {
            int x, y;

            x = int.Parse(Console.ReadLine());
            while (x != 0)
            {
                if (x % 2 == 0)
                {
                    y = x + (x + 2) + (x + 4) + (x + 6) + (x + 8);
                }
                else
                {
                    y = (x + 1) + (x + 3) + (x + 5) + (x + 7) + (x + 9);
                }
                Console.WriteLine(y);
                x = int.Parse(Console.ReadLine());
            }
        }
        static void uri1118()
        {
            double nota1, nota2, media;
            int pergunta = 1;

            while (pergunta == 1)
            {
                nota1 = double.Parse(Console.ReadLine());
                while (nota1 < 0.0 || nota1 > 10.0)
                {
                    Console.WriteLine("nota invalida");
                    nota1 = double.Parse(Console.ReadLine());
                }
                nota2 = double.Parse(Console.ReadLine());
                while (nota2 < 0.0 || nota2 > 10.0)
                {
                    Console.WriteLine("nota invalida");
                    nota2 = double.Parse(Console.ReadLine());
                }

                media = (nota1 + nota2) / 2;
                Console.WriteLine("media = " + media.ToString("F2"));

                pergunta = 0;

                while (pergunta != 1 && pergunta != 2)
                {
                    Console.WriteLine("novo calculo (1-sim 2-nao)");
                    pergunta = int.Parse(Console.ReadLine());
                }
            }
        }
        static void uri1131()
        {
            int placar1 = 0;
            int placar2 = 0;
            int gremio = 0;
            int inter = 0;
            int empate = 0;
            int pergunta = 1;
            int somaGrenal = 0;

            while (pergunta == 1)
            {
                string[] vet = Console.ReadLine().Split(' ');

                placar1 = int.Parse(vet[0]);
                placar2 = int.Parse(vet[1]);

                if (placar1 > placar2)
                    inter++;
                else if (placar1 < placar2)
                    gremio++;
                else
                    empate++;

                somaGrenal++;
                Console.WriteLine("Novo grenal (1-sim 2-nao)");
                pergunta = int.Parse(Console.ReadLine());
            }
            Console.WriteLine(somaGrenal + " grenais");
            Console.WriteLine("Inter:" + inter);
            Console.WriteLine("Gremio:" + gremio);
            Console.WriteLine("Empates:" + empate);
            if (inter > gremio)
                Console.WriteLine("Inter venceu mais");
            else if (inter < gremio)
                Console.WriteLine("Gremio venceu mais");
            else
                Console.WriteLine("Nao houve vencedor");
            Console.ReadLine();
        }
        static void uri1067()
        {
            int x;

            x = int.Parse(Console.ReadLine());
            for (int i = 1; i <= x; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
        static void uri1071()
        {
            int x, y, min, max, soma;

            x = int.Parse(Console.ReadLine());
            y = int.Parse(Console.ReadLine());

            if (x < y)
            {
                min = x;
                max = y;
            }
            else
            {
                min = y;
                max = x;
            }
            soma = 0;
            for (int i = min + 1; i < max; i++)
            {
                if (i % 2 != 0)
                {
                    soma += i;
                }
            }
            Console.WriteLine(soma);
            Console.ReadLine();
        }
        static void uri1072()
        {
            int x, y;
            int dentro = 0, fora = 0;

            x = int.Parse(Console.ReadLine());
            for (int i = 1; i <= x; i++)
            {
                y = int.Parse(Console.ReadLine());
                if (y >= 10 && y <= 20)
                    dentro++;
                else
                    fora++;
            }
            Console.WriteLine(dentro + " in");
            Console.WriteLine(fora + " out");
            Console.ReadLine();
        }
        static void uri1073()
        {
            int x;
            int[] intervalo = new int[] { 5, 2000 };

            x = int.Parse(Console.ReadLine());
            if (x >= intervalo[0] && x <= intervalo[1])
                for (int i = 2; i <= x; i++)
                    if (i % 2 == 0)
                        Console.WriteLine(i + "^2 = " + Math.Pow(i, 2.0));
            Console.ReadLine();
        }
        static void uri1074()
        {
            int x, y;

            x = int.Parse(Console.ReadLine());
            for (int i = 1; i <= x; i++)
            {
                y = int.Parse(Console.ReadLine());
                if (y > 0 && y % 2 == 0)
                    Console.WriteLine("EVEN POSITIVE");
                else if (y < 0 && y % 2 == 0)
                    Console.WriteLine("EVEN NEGATIVE");
                else if (y > 0 && y % 2 != 0)
                    Console.WriteLine("ODD POSITIVE");
                else if (y < 0 && y % 2 != 0)
                    Console.WriteLine("ODD NEGATIVE");
                else
                    Console.WriteLine("NULL");
            }
            Console.ReadLine();
        }
        static void uri1075()
        {
            int x, mod;

            x = int.Parse(Console.ReadLine());
            for (int i = 1; x > 0 && i < 10000; i++)
            {
                mod = i % x;
                if (mod == 2)
                    Console.WriteLine(i);
            }
            Console.ReadLine();
        }
        static void uri1079()
        {
            int nTeste;
            double nota1, nota2, nota3, media;

            nTeste = int.Parse(Console.ReadLine());

            for (int i = 1; i <= nTeste; i++)
            {
                string[] vet = Console.ReadLine().Split(' ');
                nota1 = double.Parse(vet[0]);
                nota2 = double.Parse(vet[1]);
                nota3 = double.Parse(vet[2]);

                media = (nota1 * 2 + nota2 * 3 + nota3 * 5) / 10;

                Console.WriteLine(media.ToString("F1"));
            }
            Console.ReadLine();
        }
        static void uri1080()
        {
            int posicao = 0, maior = 0;

            for (int i = 1; i <= 100; i++)
            {
                int valorAtual = int.Parse(Console.ReadLine());
                if (valorAtual > maior)
                {
                    maior = valorAtual;
                    posicao = i;
                }
            }
            Console.WriteLine(maior);
            Console.WriteLine(posicao);
            Console.ReadLine();
        }
        static void uri1094()
        {
            int experimentos;
            int qtdRatos = 0;
            int qtdCoelhos = 0;
            int qtdSapos = 0;
            int qtdTotal = 0;

            experimentos = int.Parse(Console.ReadLine());
            for (int i = 0; i < experimentos; i++)
            {
                string[] animal = Console.ReadLine().Split(' ');
                int qtd = int.Parse(animal[0]);
                switch (animal[1])
                {
                    case "C":
                        qtdCoelhos += qtd;
                        break;
                    case "R":
                        qtdRatos += qtd;
                        break;
                    case "S":
                        qtdSapos += qtd;
                        break;
                }
                qtdTotal += qtd;
            }
            Console.WriteLine("Total: " + qtdTotal + " cobaias");
            Console.WriteLine("Total de coelhos: " + qtdCoelhos);
            Console.WriteLine("Total de ratos: " + qtdRatos);
            Console.WriteLine("Total de sapos: " + qtdSapos);
            Console.WriteLine("Percentual de coelhos: " + ((qtdCoelhos * 100.0) / qtdTotal).ToString("F2") + " %");
            Console.WriteLine("Percentual de ratos: " + ((qtdRatos * 100.0) / qtdTotal).ToString("F2") + " %");
            Console.WriteLine("Percentual de sapos: " + ((qtdSapos * 100.0) / qtdTotal).ToString("F2") + " %");
        }
        static void uri1096()
        {
            int x = 7;

            for (int i = 0; i <= 9; i++)
            {
                if (i % 2 != 0)
                {
                    Console.Write("I=" + i);
                    Console.WriteLine(" J=" + x);
                    x--;
                    Console.Write("I=" + i);
                    Console.WriteLine(" J=" + x);
                    x--;
                    Console.Write("I=" + i);
                    Console.WriteLine(" J=" + x);
                    x--;
                }
                x = 7;
            }
            Console.ReadLine();
        }
        static void uri1097()
        {
            int x = 7;

            for (int i = 1; i <= 9; i++)
            {

                if (i % 2 != 0)
                {
                    Console.Write("I=" + i);
                    Console.WriteLine(" J=" + x);
                    x--;
                    Console.Write("I=" + i);
                    Console.WriteLine(" J=" + x);
                    x--;
                    Console.Write("I=" + i);
                    Console.WriteLine(" J=" + x);
                    x += 4;
                }
            }
            Console.ReadLine();
        }
        static void uri1116()
        {
            int n, x, y;
            double divisao;

            n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] vet = Console.ReadLine().Split(' ');
                x = int.Parse(vet[0]);
                y = int.Parse(vet[1]);
                if (y == 0)
                {
                    Console.WriteLine("divisao impossivel");
                }
                else
                {
                    divisao = (double)x / y;
                    Console.WriteLine(divisao.ToString("F1"));
                }
            }
            Console.ReadLine();
        }
        static void uri1132()
        {
            int x, y, min, max;
            int somaMult = 0;

            x = int.Parse(Console.ReadLine());
            y = int.Parse(Console.ReadLine());

            if (x > y)
            {
                min = y;
                max = x;
            }
            else
            {
                min = x;
                max = y;
            }

            for (int i = min; i <= max; i++)
            {
                if (i % 13 != 0)
                {
                    somaMult += i;
                }
            }
            Console.WriteLine(somaMult);
            Console.ReadLine();
        }
        static void uri1133()
        {
            int x, y, min, max, divisao;

            x = int.Parse(Console.ReadLine());
            y = int.Parse(Console.ReadLine());

            if (x > y)
            {
                min = y;
                max = x;
            }
            else
            {
                min = x;
                max = y;
            }

            for (int i = ++min; i < max; i++)
            {
                if (i % 5 == 2 || i % 5 == 3)
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadLine();
        }
        static void uri1142()
        {
            int x;
            int pum = 1;

            x = int.Parse(Console.ReadLine());

            for (int i = 1; pum <= x; i++)
            {
                if (i % 4 != 0)
                {
                    Console.Write(i + " ");
                }
                else
                {
                    Console.WriteLine("PUM");
                    pum++;
                }
            }
            Console.ReadLine();
        }
        static void uri1143()
        {
            int nTeste;

            nTeste = int.Parse(Console.ReadLine());
            for (int i = 1; i <= nTeste; i++)
            {
                Console.Write(i + " ");
                Console.Write(Math.Pow(i, 2.0) + " ");
                Console.WriteLine(Math.Pow(i, 3.0));
            }
            Console.ReadLine();
        }
        static void uri144()
        {
            int NTeste;

            NTeste = int.Parse(Console.ReadLine());
            for (int i = 1; i <= NTeste; i++)
            {
                Console.Write(i + " ");
                Console.Write(Math.Pow(i, 2.0) + " ");
                Console.WriteLine(Math.Pow(i, 3.0));
                Console.Write(i + " ");
                Console.Write(Math.Pow(i, 2.0) + 1 + " ");
                Console.WriteLine(Math.Pow(i, 3.0) + 1 + " ");
            }
            Console.ReadLine();
        }
        static void uri1151()
        {
            int qtdSaida;

            qtdSaida = int.Parse(Console.ReadLine());
            if (qtdSaida == 1)
            {
                Console.WriteLine("0");
            }
            else if (qtdSaida == 2)
            {
                Console.WriteLine("0 1");
            }
            else if (qtdSaida > 2 && qtdSaida < 46)
            {
                int soma;
                int valor1 = 0;
                int valor2 = 1;
                string saida = "0 1";
                for (int i = 2; i < qtdSaida; i++)
                {
                    soma = valor1 + valor2;
                    valor1 = valor2;
                    valor2 = soma;
                    saida = saida + " " + soma;

                }
                Console.WriteLine(saida);
            }

            Console.ReadLine();
        }
        static void uri1153()
        {
            int n, resultado;
            resultado = n = int.Parse(Console.ReadLine());
            for (int i = 1; i < n; i++)
                resultado = resultado * (n - i);
            Console.WriteLine(resultado);
            Console.ReadLine();
        }
        static void uri1155()
        {
            double s;
            double soma = 0;

            for (int i = 1; i <= 100; i++)
            {
                s = 1.0 / i;
                soma = soma + s;
            }
            Console.WriteLine(soma.ToString("F2"));
            Console.ReadLine();
        }
        static void uri1156()
        {
            double s;
            double n = 1;
            double soma = 0;

            for (int i = 1; i <= 39; i = i + 2)
            {
                s = i / n;
                n = n * 2;
                soma += s;
            }
            Console.WriteLine(soma.ToString("F2"));
            Console.ReadLine();
        }
        static void uri1157()
        {
            int x;

            x = int.Parse(Console.ReadLine());
            for (int i = 1; i <= x; i++)
            {
                if (x % i == 0)
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadLine();
        }
        static void uri1099J()
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] intervalo = Console.ReadLine().Split(' ');
                int x = int.Parse(intervalo[0]);
                int y = int.Parse(intervalo[1]);
                if (x > y)
                {
                    int z = x;
                    x = y;
                    y = z;
                }
                int soma = 0;
                for (int t = ++x; t < y; t++)
                    if (t % 2 != 0)
                        soma += t;
                Console.WriteLine(soma);
            }
            Console.ReadLine();
        }
        static void uri1099G()
        {
            int n, x, y, min, max;

            n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] vet = Console.ReadLine().Split(' ');
                x = int.Parse(vet[0]);
                y = int.Parse(vet[1]);

                if (x > y)
                {
                    min = y + 1;
                    max = x;
                }
                else
                {
                    min = x + 1;
                    max = y;
                }
                int soma = 0;
                for (int t = min; t < max; t++)
                {
                    if (t % 2 != 0)
                        soma += t;
                }
                Console.WriteLine(soma);
            }
            Console.ReadLine();
        }
        static void uri1101()
        {
            int m, n;
            int soma;

            string[] vet = Console.ReadLine().Split(' ');
            m = int.Parse(vet[0]);
            n = int.Parse(vet[1]);

            while (m > 0 && n > 0)
            {
                if (m > n)
                {
                    int z = m;
                    m = n;
                    n = z;
                }
                soma = 0;
                for (int i = m; i <= n; i++)
                {
                    Console.Write(i + " ");
                    soma += i;
                }
                Console.WriteLine("Sum=" + soma);
                vet = Console.ReadLine().Split(' ');
                m = int.Parse(vet[0]);
                n = int.Parse(vet[1]);
            }
        }
        static void uri1145()
        {
            int x, y;

            string[] vet = Console.ReadLine().Split(' ');
            x = int.Parse(vet[0]);
            y = int.Parse(vet[1]);

            for (int i = 1; i <= y; i++)
            {
                if (i % x == 0)
                {
                    Console.WriteLine(i);
                }
                else
                {
                    Console.Write(i + " ");
                }
            }
            Console.ReadLine();
        }
        static void uri1150()
        {
            int x, y;
            int soma = 0;
            int i = 0;

            x = int.Parse(Console.ReadLine());
            y = int.Parse(Console.ReadLine());
            int z = x;

            while (x >= y)
            {
                y = int.Parse(Console.ReadLine());
            }

            for (i = 1; y > soma; i++)
            {
                soma = z + (x + i);
                z = soma;
            }
            Console.WriteLine(i);
            Console.ReadLine();
        }
        static void uri1158()
        {
            int nTeste;

            nTeste = int.Parse(Console.ReadLine());

            for (int i = 0; i < nTeste; i++)
            {
                string[] vet = Console.ReadLine().Split(' ');
                int x = int.Parse(vet[0]);
                int y = int.Parse(vet[1]);

                int soma = 0;
                for (int t = 0; t < y;)
                {
                    if (x % 2 != 0)
                    {
                        soma += x;
                        t++;
                    }
                    x++;
                }
                Console.WriteLine(soma);
            }
            Console.ReadLine();
        }
        static void uri1160()
        {
            int nTeste = int.Parse(Console.ReadLine());
            for (int i = 0; i < nTeste; i++)
            {
                int anos;
                string[] vet = Console.ReadLine().Split(' ');
                int populacaoA = int.Parse(vet[0]);
                int populacaoB = int.Parse(vet[1]);
                double crescimentoA = double.Parse(vet[2]);
                double crescimentoB = double.Parse(vet[3]);
                for (anos = 0; populacaoA <= populacaoB; anos++)
                {
                    populacaoA = (int)(populacaoA + populacaoA * (crescimentoA / 100));
                    populacaoB = (int)(populacaoB + populacaoB * (crescimentoB / 100));
                    if (anos > 100)
                        break;
                }
                if (anos > 100)
                    Console.WriteLine("Mais de 1 seculo.");
                else
                    Console.WriteLine(anos + " anos.");
            }
            Console.ReadLine();
        }
        static void uri()
        {
            int nTeste = int.Parse(Console.ReadLine());
            for (int i = 0; i < nTeste; i++)
            {
                bool primo = true;
                int num = int.Parse(Console.ReadLine());
                for (int t = 2; t < num; t++)
                {
                    if (num % t == 0)
                    {
                        Console.WriteLine(num + " nao eh primo");
                        primo = false;
                        break;
                    }
                }
                if (primo == true)
                    Console.WriteLine(num + " eh primo");
            }
            Console.ReadLine();
        }
    }
}
