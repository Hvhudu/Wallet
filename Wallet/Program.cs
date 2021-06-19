using System;
using System.Collections.Generic;
using WalletLibrary;

namespace Wallet
{
    class Program
    {
        static void Main()
        {
            CLI.CLI.Welcome();

            string select;
            var wallet = new WalletLibrary.Wallet();
            double money;
            var date = new DateTime();
            List<string> history = null;
            List<double> i = null;

            if (CLI.File.Exist())
            {
                CLI.CLI.StartMenu();
                select = Console.ReadLine();
                if (select is "Y" or "y" or "Д" or "д")
                {
                    money = CLI.CLI.InputMoney("Введите начальную сумму в кошельке ");
                    wallet.Init(money);
                }
                else
                {
                    money = CLI.File.Import();
                    wallet.Init(money);
                }
            }
            else
            {
                money = CLI.CLI.InputMoney("Введите начальную сумму в кошельке ");
                wallet.Init(money);
            }

            do
            {
                CLI.CLI.Menu();
                select = Console.ReadLine();
                switch (select)
                {
                    case "1": // 1 - Сколько денег в кошельке
                        Console.WriteLine($"Денег в кошельке - {wallet.Money()}");
                        break;
                    case "2": // 2 - Внести доход
                        date = CLI.CLI.InputDate("Введите дату дохода - ");
                        money = CLI.CLI.InputMoney("Введите доход - ");
                        CLI.CLI.InputIncome(out var income);
                        wallet.Income(date, income, money);
                        break;
                    case "3": // 3 - Учесть расходы
                        date = CLI.CLI.InputDate("Введите дату расхода - ");
                        foreach (var item in history)
                        {
                            Console.ReadLine();
                        }

                        money = CLI.CLI.InputMoney("Введите расход - ");
                        foreach (var item in i)
                        {
                            Console.ReadLine();
                        }

                        expenditure expenditure = null;
                        wallet.Outgo(date,expenditure,money); 
                        break;
                    case "4":
                        Console.WriteLine($"{history}-{i}");
                        break;
                    case "0": // 0 - Выйти из программы
                        CLI.CLI.Bye();
                        CLI.File.Export(wallet.Money());
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Введите правильный вариант работй!");
                        Console.ResetColor();
                        break;
                }
            } while (select != "0");
        }
    }
}