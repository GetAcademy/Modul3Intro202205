using System;

namespace Modul3Intro202205
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var name = MyConsole.Ask("Hva heter du? ");
            Console.WriteLine($"Hei, {name}!");

            var year = MyConsole.AskForInt("I hvilket år er du født? ");
            var age = 2022 - year;

            var hadBirthday = MyConsole.AskForBool("Har du hatt bursdag");
            if (!hadBirthday) age--;

            Console.WriteLine($"Da er du {age} år gammel.");
        }




        //static int Main(string[] args)
        //{
        //    Console.WriteLine($"args sin lengde er {args.Length}");
        //    for (int i = 0; i < args.Length; i++)
        //    {
        //        Console.WriteLine($"Indeks {i} => {args[i]}");
        //    }

        //    Console.WriteLine(GetTerje());

        //    return 5;
        //}

        //static string GetTerje()
        //{
        //    return "Terje!";
        //}

        //static void GetTerje2()
        //{
        //    Console.WriteLine("Terje!");
        //}
    }
}
