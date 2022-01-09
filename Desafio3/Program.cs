using System; 

class DIO {

    static void Main(string[] args) { 

      double c, S= 0;
            for (double a = 1;a<=100;a++)
            {
                c = 1 /a;
                S += c;
            }
            var x=Math.Round(S,2);
            Console.WriteLine(x);

    }

}
