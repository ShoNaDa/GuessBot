using System;
using System.Collections.Generic;
using System.Text;

namespace bot.Games
{
    public class NumberGame
    {
        public bool IsPlaying;
        int number;
        public void Start()
        {
            IsPlaying = true;
            Random r = new Random();
            number = r.Next(1, 100);
            Console.WriteLine("Игра началась. Я загадал число от 1 до 100, угадай какое");
        }
        public void Finish()
        {
            IsPlaying = false;
            Console.WriteLine("Игра окончена");
        }
        public void MakeTurn(string message)
        {
            try
            {
                int guess = Convert.ToInt32(message);
                if (guess == number)
                {
                    Console.WriteLine($"Угадал, я загадал число {number}");
                    Finish();
                    return;
                }
                if (guess < number)
                {
                    Console.WriteLine("Нет! Мое число больше");
                }
                else
                {
                    Console.WriteLine("Нет! Мое число меньше");
                }
            }
            catch
            {
                Console.WriteLine("Нет, введи число!");
            }
        }
    }
}
