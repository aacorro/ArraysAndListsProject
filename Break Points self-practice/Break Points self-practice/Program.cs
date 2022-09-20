using System;

namespace Break_Points_self_practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for(int i = 0; i < 100; i+=4)
            {
                if(i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
                
            }
       
        }
    }
}
