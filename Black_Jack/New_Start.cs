using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Black_Jack
{
    internal class New_Start
    {
        private (int,string) Budget_Bet = (5000, "");
        New_Bet bet = new New_Bet();
        public string? Login { get; set; }
        public string? myBet { get; set; }
        private string? myLastBet = "!";
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
            Console.WriteLine($"Мы дарим вам 5000 монет. Ваш бюджет: {Budget_Bet.Item1}");
            Console.WriteLine("Информация о командах для ставки:\nMin - минимальная ставка(10). Max - максимальная ставка(500). MyOwn - своя ставка. Last - Последняя ставка");
            for (int i = 0; budgetAfter > 0; i++)
            {
                myBet = Console.ReadLine().ToUpper();
                if (!string.IsNullOrEmpty(myBet))
                {
                    if (!string.IsNullOrEmpty(myLastBet))
                    {
                        if (Budget_Bet.Item2 == "LAST")
                            Budget_Bet.Item2 = myLastBet;
                    }
                    Budget_Bet = bet.yourBet(Budget_Bet.Item1, myBet, Budget_Bet.Item2);
                    if (Budget_Bet.Item2 != "LAST")
                        myLastBet = bet.yourLastBet(Budget_Bet.Item2);
                }
                else
                {
                    Console.WriteLine("Напишите команду ставки!");
                }
                if (Budget_Bet.Item1 <= 0) break;
            }

        }
    }
}
