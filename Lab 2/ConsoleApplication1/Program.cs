using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApplication1
{

    class Program
    {
        const int CheckNum = 14;
        static int SumDigit(int Num)
        {
            int Sum = 0;
            while (Num > 9)
            {
                Sum += Num % 10;
                Num /= 10;
            }
            Sum += Num;
            return Sum;
        }

        static void Main(string[] args)
        {
            int sizeLineNumber = Convert.ToInt32(Console.ReadLine());
            List<int> LineNumber = new List<int>();
            bool isNeedToBeSort = false;
            for (int i=0; i<sizeLineNumber; i++)
            {
                LineNumber.Add(Convert.ToInt32(Console.ReadLine()));
                if (SumDigit(LineNumber[i]) == CheckNum)
                {
                    isNeedToBeSort = true;
                }
            }

            if (isNeedToBeSort)
            {
                LineNumber.Sort();
            }
            Console.WriteLine();
            for (int i = 0; i < sizeLineNumber; i++)
            {
                Console.WriteLine("{0} ", LineNumber[i]);
            }
            Console.ReadKey();
        }
    }
}
