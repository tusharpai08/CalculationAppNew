using System;
using static CalculationAppNew.Model;
namespace CalculationAppNew
{
	public class listValues
	{
        /// <summary>
        /// Calls the logic to check a list based on type selected by user
        /// </summary>
        /// <param name="listType">Expense or Income</param>
		public listValues(string listType)
		{
            if (listType == "Expense" | listType == "expense")
			{
                using (var db = new DBCreationBase())
                {
                    // Read
                    Console.WriteLine("=====EXPENSE LIST======");
                    List<Expense> exp = new List<Expense>();
                    exp = db.Expenses.ToList();
                    foreach(Expense x in exp)
                    {
                        Console.WriteLine($"Expense Name: {x.ExpenseName}   | Expense Value: {x.ExpenseAmount}");
                    }
                    Console.WriteLine("=======================");
                }
            }
            else if (listType == "Income" | listType == "income")
            {
                using (var db = new DBCreationBase())
                {
                    Console.WriteLine("=====INCOME LIST======");
                    List<Income> inc = new List<Income>();
                    inc = db.Incomes.ToList();
                    foreach (Income i in inc)
                    {
                        Console.WriteLine($"Income Name: {i.IncomeName}      | Income Value: {i.IncomeAmount}");
                    }
                    Console.WriteLine("=======================");
                }
            }
            else
            {
                Console.WriteLine("Command not recognised");
            }
        }
	}
}

