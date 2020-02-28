using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SalarioBonus
{
    class Program
    {
        static void Main(string[] args)
        {

            /*double SalarioT,comissao;
            string Nome = Console.ReadLine();
            double Salario = double.Parse(Console.ReadLine());
            double Venda = double.Parse(Console.ReadLine());


            comissao= Venda * 0.15;
            SalarioT = Salario + comissao;

            Console.WriteLine(comissao.ToString("#0.00"));
            Console.WriteLine("TOTAL = R$ {0:F2}", SalarioT);

    */


            string a = Console.ReadLine();

            double b = double.Parse(Console.ReadLine());

            double c = double.Parse(Console.ReadLine());

            double r = (c * 0.15) + b;

            Console.WriteLine("TOTAL = R$ {0:F2}", r);
            Console.ReadKey();

        }
    }
}
