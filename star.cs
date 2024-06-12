using System;
class hello{
    static void Main(string [] args){
for (int i = 1; i <= 4; i++)
        {
            for (int j = 3; j >= i - 1; j--)
            {
                Console.Write(" ");
            }
            for (int j = 1; j <= i; j++)
            {
                Console.Write("*" + " ");
            }
            Console.WriteLine();
        }
        for (int i = 5; i >= 1; i--)
        {
            for (int j = 1; j <= 5 - i; j++)
            {
                Console.Write(" ");
            }
            for (int j = 1; j <= i; j++)
            {
                Console.Write("*" + " ");
            }
            Console.WriteLine();
        }
    }
}