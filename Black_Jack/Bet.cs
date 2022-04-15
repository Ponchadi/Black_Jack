using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Black_Jack
{
    // Без правильной реализации LAST
    internal class Bet
    {
        public int BudgetAfter { get; set; }
        private int MyBet;
        public string? MyOwnBet { get; set; }
        public int yourBet(int budget, string stringBet, string myLastBet = "", int intBet = 0)
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
                    MyOwnBet = Console.ReadLine();

                    bool result = int.TryParse(MyOwnBet, out MyBet);
                    if (result == true)
                    {
                        if (MyBet < 10 || MyBet > 500)
                        {
                            Console.WriteLine("Недопустимая ставка. Ваша ставка должна быть в диапазоне [10,500]");
                            goto case "MYOWN";
                        }
                        BudgetAfter = BudgetAfter - MyBet;
                        Console.WriteLine($"Ваша ставка: {MyBet}. На счету осталось: {BudgetAfter}");
                        
                    }
                    else
                    {
                        Console.WriteLine("Вы не написали ставку!");
                        goto case "MYOWN";
                    }
                    return BudgetAfter;

                case "LAST":
                    if (myLastBet == "" || myLastBet == null)
                        goto default;
                    else if (myLastBet == "MAX")
                        goto case "MAX";
                    else if (myLastBet == "MIN")
                        goto case "MIN";
                    else if (myLastBet == "MYOWN")
                        goto case "MYOWN";
                        break;
                default:
                    Console.WriteLine("Вы не написали команду ставки!"); 
                    break;
            }
            return BudgetAfter;
        }
        public string your_Bet(string myBet = "")
        {
            return myBet;
        }
    } 
}
