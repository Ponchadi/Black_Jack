using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Black_Jack
{
    internal class Bet
    {
        // Ставка проходит только один раз. Нужен цикл ?
        public int BudgetAfter { get; set; }
        public int MyBet { get; set; }
        public int yourBet(int budget, string stringBet = "", int intBet = 0)
        {
            BudgetAfter = budget;
            switch (stringBet)
            {
                case "MAX":
                    MyBet = 500;
                    BudgetAfter = BudgetAfter - MyBet;
                    Console.WriteLine($"Ваша ставка: {MyBet}. На счету осталось: {BudgetAfter}");
                    return BudgetAfter;
                    
                case "MIN":
                    MyBet = 10;
                        BudgetAfter = BudgetAfter - MyBet;
                        Console.WriteLine($"Ваша ставка: {MyBet}. На счету осталось: {BudgetAfter}");
                    return BudgetAfter;
                    
                case "MYOWN":
                    Console.WriteLine("Напишите вашу ставку:");
                    MyBet = Int32.Parse(Console.ReadLine());
                    if (MyBet < 10 || MyBet > 500)
                    {
                        Console.WriteLine("Недопустимая ставка. Ваша ставка должна быть в диапазоне [10,500]");
                    goto case "MYOWN";
                    }
                    BudgetAfter = BudgetAfter - MyBet;
                    Console.WriteLine($"Ваша ставка: {MyBet}. На счету осталось: {BudgetAfter}");
                    return BudgetAfter;
                    
                case "LAST":
                    for (int i = 0; BudgetAfter > 0; i++)
                    {
                        MyBet = 500;
                        BudgetAfter = BudgetAfter - MyBet;
                        Console.WriteLine($"Ваша ставка: {MyBet}. На счету осталось: {BudgetAfter}");
                    }
                    return BudgetAfter;  
            }
            return BudgetAfter;
        }
    }
}
