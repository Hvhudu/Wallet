using System;

namespace CLI
{
    public static class CLI
    {
        public static void Welcome()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("++++++++++++++++++++");
            Console.WriteLine("+++ Wallet v 0.0 +++");
            Console.WriteLine("++++++++++++++++++++");
            Console.WriteLine();
            Console.ResetColor();
        }

        public static void StartMenu()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Хотите создать новый кошелёк?");
            Console.WriteLine("Y/Д - Да, хочу");
            Console.WriteLine("N/Н - Нет, не хочу");
            Console.ResetColor();
        }

        public static void Menu()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Варианты работы:");
            Console.WriteLine("1 - Сколько денег в кошельке");
            Console.WriteLine("2 - Внести доход");
            Console.WriteLine("3 - Учесть расходы");
            Console.WriteLine("4 - История расходов");
            Console.WriteLine("0 - Выйти из программы");
            Console.ResetColor();
        }

        public static void Bye()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("До свидания...");
            Console.ResetColor();
        }

        public static double InputMoney(string message)
        {
            Console.Write(message);
            var temp = Convert.ToDouble(Console.ReadLine());
            return temp;
        }

        public static DateTime InputDate(string message)
        {
            Console.Write(message);
            var temp = Convert.ToDateTime(Console.ReadLine());
            return temp;
        }

        public static void InputIncome(out WalletLibrary.IncomeEnum income)
        {
            Console.Write("Выберите тип дохода:");
            Console.WriteLine("1 - Зарплата");
            Console.WriteLine("2 - Дивиденды");
            var select = Console.ReadLine();
            income = select switch
            {
                "1" => WalletLibrary.IncomeEnum.Salary,
                "2" => WalletLibrary.IncomeEnum.Dividends,
                _ => WalletLibrary.IncomeEnum.Unknown
            };
        }
    }
}