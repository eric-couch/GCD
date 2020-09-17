using System;

namespace GCD
{
    class Program
    {
        static void Main(string[] args)
        {
            int q, r;
            Console.Write("Enter Number: ");
            int fNum = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Second Number: ");
            int sNum = Convert.ToInt32(Console.ReadLine());
            int N1 = fNum;
            int N2 = sNum;
            Console.WriteLine("N1=" + fNum);
            Console.WriteLine("N2=" + sNum);
            while (fNum % sNum != 0)
            {
                q = (fNum / sNum);
                r = (fNum % sNum);
                fNum = sNum;
                sNum = r;
                Console.WriteLine(fNum + "/" +sNum + "=" + q + " r " + r );
            }
            Console.WriteLine(fNum + "/" + sNum + "=" + (fNum / sNum) + " r " + (fNum % sNum));
            Console.WriteLine("The GCD of " + N1 + " and " + N2 + " is " + sNum );
        }
    }
}
