using System;

namespace bot
{
    class Program
    {
        static void Main(string[] args)
        {
            BOT serezha = new BOT();
            serezha.name = "Сережа";
            serezha.Greetings();
            serezha.StartMainLoop();
        }
    }
}
