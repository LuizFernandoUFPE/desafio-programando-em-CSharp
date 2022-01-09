using System;
using System.Collections.Generic;
using System.Text;

namespace Dio
{
    class Xenlongao
    {
        static void Main(string[] args)
        {
            
            int C = Convert.ToInt32(Console.ReadLine());
            if(C>=1){
            for(int contador = 0; contador < C; contador++)
            {
                int N = Convert.ToInt32(Console.ReadLine());
                int resposta = 0;
                while(N<=109 && N>=2)
                {
                    int numDeDiv = 0;
                    for(int i=1; i<=N;i++)
                    {
                        int value = N % i;
                        if(value == 0)
                        {
                            numDeDiv++;  
                        }
                    }
                    int verifica = numDeDiv %2;
                    if(verifica == 0)
                    {
                        resposta++;
                    }
                    N--;
                }
                System.Console.WriteLine(resposta);
                }

            
            }
        }
    }
}

