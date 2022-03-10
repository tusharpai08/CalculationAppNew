using System;

namespace CalculationAppNew
{
    internal class Program
    {
        private static void Main()
        {
            var flag = 0;
            do
            {
                Console.WriteLine("");
                Console.WriteLine("======MAIN MENU======");
                Console.WriteLine("1: Add values to DB");
                Console.WriteLine("2: List values from DB");
                Console.WriteLine("3: Truncate Table");
                Console.WriteLine("4: Exit");
                Console.WriteLine("=====================");
                
                var userInput = Convert.ToInt32(Console.ReadLine());
                switch (userInput)
                {
                    case 1:
                        Console.WriteLine("Input the type of value: (Expense|Income) ");
                        string userValueType = Console.ReadLine();
                        addValues av = new addValues(userValueType);
                        break;

                    case 2:
                        Console.WriteLine("Input the type of list: (Expense|Income) ");
                        string userListType = Console.ReadLine();
                        listValues lv = new listValues(userListType);
                        break;

                    case 3:
                        Console.WriteLine("Truncate: (Expense|Income)");
                        string userTableName = Console.ReadLine();
                        truncateTable tt = new truncateTable(userTableName);
                        break;

                    case 4:
                        flag = 1;
                        break;

                    default:
                        break;
                }

            } while (flag != 1);
        }
    }
}