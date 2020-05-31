using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula19
{
    class Program
    {
        static void Main(string[] args)
        {
           double largura, comprimento, preçoMetroQuadrado, area, preço;

            largura = double.Parse(Console.ReadLine());
            comprimento = double.Parse(Console.ReadLine());
            preçoMetroQuadrado = double.Parse(Console.ReadLine());

            area = largura * comprimento;
            preço = area * preçoMetroQuadrado;

            Console.WriteLine("AREA = " + area.ToString("f2"));
            Console.WriteLine("PREÇO = " + preço.ToString("f2"));
             
            Console.ReadLine("arroz");
            Console.ReadLine();
        }
    }
}
