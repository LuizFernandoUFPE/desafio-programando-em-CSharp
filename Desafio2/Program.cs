using System;
class Dio
{
    static void Main(string[] args) 
    { 
        int n = Convert.ToInt32(Console.ReadLine());
        if(n>5 && n<2000)
        {
            for (int i = 1; i <=n; i++)
            {
                int verifica = i%2;
                if (verifica ==0)
                {
                    Console.WriteLine($"{i}^{2} = {(long)Math.Pow(i, 2)}");
                }
            }
        }
    }
}


