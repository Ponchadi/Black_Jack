﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Black_Jack
{
    // Без правильной реализации LAST
    internal class Start
    {
        public int Budget { get; set; } = 5000;
        Bet bet = new Bet();
        public string? Login { get; set; }
        public string? myBet { get; set; }
        private string? myLastBet;
        private int budgetAfter = 1;
        public void Show()
        {
            Console.Write("Введите ваше имя: ");
            Login = Console.ReadLine();
            if (Login == null || Login == "")
            {
                    Login = "Guest";   
                    Console.WriteLine(Login);
            }
            Console.WriteLine($"Мы дарим вам 5000 монет. Ваш бюджет: {Budget}");
            Console.WriteLine("Информация о командах для ставки:\nMin - минимальная ставка(10). Max - максимальная ставка(500). MyOwn - своя ставка. Last - Последняя ставка");
            for (int i = 0; budgetAfter > 0; i++)
            {
                myBet = Console.ReadLine().ToUpper();
                if (!string.IsNullOrEmpty(myBet))
                {
                    Budget = bet.yourBet(Budget, myBet,myLastBet);
                    myLastBet = bet.your_Bet(myBet);
                }
                else
                {
                    Console.WriteLine("Напишите команду ставки!");
                }
                if (Budget <= 0) break;
            }

        }
    }
}
