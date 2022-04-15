using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Black_Jack
{
    internal class New_Bet
    {
        public int BudgetAfter { get; set; }
        private int MyBet;
        private string? myOwnLastBet;
        public string? MyOwnBet { get; set; }
        (int, string) result = (0,"");
        private string? lastBet = "!";
        public (int,string) yourBet(int budget, string stringBet, string myLastBet = "", int intBet = 0)
        {
            BudgetAfter = budget;
            switch (stringBet)
            {
                case "MAX":
                    MyBet = 500;
                    BudgetAfter = BudgetAfter - MyBet;
                    Console.WriteLine($"Ваша ставка: {MyBet}. На счету осталось: {BudgetAfter}");
                    result = (BudgetAfter, stringBet);
                    return result;

                case "MIN":
                    MyBet = 10;
                    BudgetAfter = BudgetAfter - MyBet;
                    Console.WriteLine($"Ваша ставка: {MyBet}. На счету осталось: {BudgetAfter}");
                    result = (BudgetAfter, stringBet);
                    return result;

                case "MYOWN":
                    if (stringBet == "MYOWN")
                    {
                        MyOwnBet = null;
                    }
                    if (MyOwnBet == null || MyOwnBet == "")
                    {
                        Console.WriteLine("Напишите вашу ставку:");
                        MyOwnBet = Console.ReadLine();
                    }
                    else
                    {
                        MyOwnBet = myOwnLastBet;
                    }
                    bool result_1 = int.TryParse(MyOwnBet, out MyBet);
                    if (result_1 == true)
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
                    myOwnLastBet = MyOwnBet;
                    result = (BudgetAfter, stringBet);
                    return result;

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
            return result;
        }
        public string yourLastBet(string Budget_Bet_item2)
        {
            if (!string.IsNullOrEmpty(lastBet))
            {
                if (Budget_Bet_item2 != "LAST")
                {
                    lastBet = Budget_Bet_item2;
                    return lastBet;
                }
            }
            else
            {
                lastBet = "!";
            }
            return lastBet;
        }
    }
}
