using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Black_Jack
{
    internal class Start
    {
        public int Budget { get; set; } = 2000;
        Bet bet = new Bet();
        public string? Login { get; set; }
        public string? myBet { get; set; }
        private int budgetAfter = 1;
        public void Show()
        {
            Console.WriteLine("Введите ваше имя:");
            Login = Console.ReadLine();
            Console.WriteLine($"Мы дарим вам 5000 монет. Ваш бюджет: {Budget}");
            Console.WriteLine("Информация о ставке:\nMin - минимальная ставка(10). Max - максимальная ставка(500). MyOwn - своя ставка. Last - Последняя ставка");
            for (int i = 0; budgetAfter > 0; i++)
            {
                myBet = Console.ReadLine().ToUpper();
                if (!string.IsNullOrEmpty(myBet))
                {
                    budgetAfter = bet.yourBet(Budget, myBet);
                }
            }

        }
    }
}
