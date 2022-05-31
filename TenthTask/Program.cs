using System;

namespace TenthTask
{
    public class Program
    {
        static void Main(string[] args)
        {
            double[] chisla = {5, 2, 7, 3.5, 6.5, 8, 1, 9, 1, 3, 1, 2,4};
            double sum = 0;
            for (int i = 0; i < 13; i++)
            {
                sum = sum + chisla[i];
            }
            double vsyovmeste = sum / 10;
            Console.WriteLine(vsyovmeste);
            Console.WriteLine("нажмите <enter> для выхода . . . ");
            Console.Read();
        }
    }
}
