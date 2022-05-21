using System;
using CalculationAppNew.BusinessLogic;
using CalculationAppNew.DataAccess;

namespace CalculationAppNew
{
    internal class Program
    {
        private static void Main()
        {
            var flag = 0;
            do
            {
                
                Console.WriteLine("\n======MAIN MENU======");
                Console.WriteLine("1: Add values");
                Console.WriteLine("2: Update values");
                Console.WriteLine("3: List values");
                Console.WriteLine("4: Truncate Table");
                Console.WriteLine("5: Calculate");
                Console.WriteLine("6: Exit");
                Console.WriteLine("=====================");
                
                var userInput = Convert.ToInt32(Console.ReadLine());
                switch (userInput)
                {
                    case 1:
                        Console.WriteLine("Input the type of value: (Expense|Income) ");
                        string userValueType = Console.ReadLine();
                        addValues.add(userValueType);
                        break;

                    case 2:
                        Console.WriteLine("Input the type of value: (Expense|Income) ");
                        string userUpdateValueType = Console.ReadLine();
                        updateListRow.update(userUpdateValueType);
                        break;

                    case 3:
                        Console.WriteLine("Input the type of list: (Expense|Income|CalcHistory) ");
                        string userListType = Console.ReadLine();
                        listValues.list(userListType);
                        break;

                    case 4:
                        Console.WriteLine("Truncate: (Expense|Income|CalcHistory)");
                        string userTableName = Console.ReadLine();
                        truncateTable.truncate(userTableName);
                        break;

                    case 5:
                        Console.WriteLine("Calculate: (Expense|Income)");
                        string userCalcTable = Console.ReadLine();
                        CalculationBL.calculate(userCalcTable);
                        break;
                        
                    case 6:
                        flag = 1;
                        break;

                    default:
                        break;
                }

            } while (flag != 1);
        }
    }
}