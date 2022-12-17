using System;

namespace HackingProgram2
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();
            char[] letters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890abcdefghijklmnopqrstuvwxyz-+/|?.><*,#$@%^&()_=:;`~''".ToCharArray();
            bool Flag = true;
            for (int v = 0; Flag && v < letters.Length; v++) { 
            int m = letters.Length, n = v;
            for (int i = 0; Flag && i < Math.Pow(m, n); i++)
            {
                string s = "";
                int ii = i;
                for (int j = 0; j < n; j++)
                {
                    s = letters[ii % m] + s;
                    ii /= m;
                }
                    
                    
                    Console.WriteLine(s);
                    if(s == password)
                    {
                        Flag = false;
                        Console.WriteLine($"password was detected:{s}");
                    }
            }
            }
            Console.ReadKey();
        }
    }

    }

