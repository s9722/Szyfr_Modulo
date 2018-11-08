using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Szyfr_Modulo
{
    class Program
    {
        static void Main(string[] args)
        {
            string slowo = "słowo";
            int i;
            Console.Write("podaj hasło: ");

            int klucz = Convert.ToInt32(Console.ReadLine());
            char znak = new char();

            if (klucz == 2 || klucz == 4)
            {
                Console.WriteLine(slowo);
                Console.Write("wybierz a, b, c lub d: ");
                znak = Convert.ToChar(Console.Read());

                if (znak == 'a')
                {
                    for (i = 1; i <= 400; i++)
                    {
                        if (i % 2 == 0)
                            Console.WriteLine(i);
                        else continue;
                    }
                }
                else if (znak == 'b')
                {
                    for (i = 1; i <= 400; i++)
                    {
                        if (i % 5 == 0)
                            Console.WriteLine(i);
                        else continue;
                    }
                }
                else if (znak == 'c')
                {
                    for (i = 1; i <= 400; i++)
                    {
                        if ((i % 2 == 0) || (i % 5 == 0))
                            Console.WriteLine(i);
                        else continue;
                    }
                }
                else if (znak == 'd')
                {
                    for (i = 1; i <= 400; i++)
                    {
                        if ((i % 4 == 0) && (i % 7 == 0))
                            Console.WriteLine(i);
                        else continue;
                    }
                }
            }
            else Console.WriteLine("złe hasło");

            Console.ReadKey();
        }
    }
}
