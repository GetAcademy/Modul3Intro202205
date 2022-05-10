using System;

namespace Modul3Intro202205
{
    internal class MyConsole
    {
        public static string Ask(string question)
        {
            Console.Write(question);
            return Console.ReadLine();
        }

        public static int AskForInt(string question)
        {
            var answer = Ask(question);
            return Convert.ToInt32(answer);
        }

        public static bool AskForBool(string question)
        {
            var answer = Ask(question + " (j/n)? ");
            return answer == "j";
        }
    }
}
