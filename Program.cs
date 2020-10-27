using System;

namespace OneToTenMessage
{
    class Program
    {
        static void Main(string[] args)
        {

            while(true) 
            {
                Console.WriteLine("Choose a number between 1-10");
                int num = Int32.Parse(Console.ReadLine());

                while(num<=10)
                {
                     for (int message=0; num>message; num--)
            {
                Console.WriteLine("Great");
            }
                }
            
            }
        }
    }
}
