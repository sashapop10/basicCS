using System;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading;

namespace hackingSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] letters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890abcdefghijklmnopqrstuvwxyz".ToCharArray();

            
            while (true)
            {

                Random rand = new Random();

                   int num_letters = rand.Next(100, letters.Length - 1 + 100);
                for (int j = 0; j <= num_letters; j++)
                    {
                    
                        int latter_num = rand.Next(0, letters.Length - 1);

                    int Timer = rand.Next(0, 1);
                        System.Threading.Thread.Sleep(Timer);
                        if (j != num_letters)
                        {
                            Console.Write(letters[latter_num]);
                        }
                        else
                        {
                            Console.WriteLine();
                        }
                    }
                
                
                
                
                
                
            }

        }
        

    }
}
