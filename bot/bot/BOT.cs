using bot.Games;
using System;
using System.Collections.Generic;
using System.Text;

namespace bot
{
    class BOT
    {
        bool IsGreeted = false;
        public bool IsWorking = false;
        public string name;
        NumberGame game = new NumberGame();
        public void Greetings()
        {
            Console.WriteLine("Привет, меня зовут " + name);
            Console.WriteLine("Очень рад тебя видеть!");
            IsGreeted = true;
        }
        public void StartMainLoop()
        {
            game.Start();
            IsWorking = true;
            while (IsWorking)
            {
                var message = Console.ReadLine();
                if (game.IsPlaying)
                {
                    game.MakeTurn(message);
                }
                else
                {
                    Console.WriteLine("лол");
                }
            }
        }
    }
}
