using System; 

class DIO {

    static void Main(string[] args) 
    { 
        int x = Convert.ToInt32((Console.ReadLine()));
        x += 1;
        if (x % 2 == 0)
        {
            System.Console.WriteLine(x);
        }
        else
        {
            System.Console.WriteLine(x+1);
        }
    }
}