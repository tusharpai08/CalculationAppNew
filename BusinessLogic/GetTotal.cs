using System;
using static CalculationAppNew.Model;

namespace CalculationAppNew.BusinessLogic
{
	public class GetTotal
	{
        /// <summary>
        /// Gets the total of all amounts from the passed table.
        /// </summary>
        /// <param name="ListType">Expense or Income</param>
        /// <returns>Integer value - total</returns>
		public static int GetListOfAmounts(string ListType)
        {
            var t = 0;
            int count = 0;
			using (var db = new DBCreationBase())
            {
                if (ListType == "Expense")
                {
                    List<Expense> exp = new List<Expense>();
                    exp = db.Expenses.ToList();
                    foreach (Expense e in exp)
                    {
                        Console.WriteLine($"Expense Name: {e.ExpenseName}      | Expense Value: {e.ExpenseAmount}");
                        t += e.ExpenseAmount;
                        count += 1;
                    }
                    Console.WriteLine($"Total of {count} expenses = ${t}");
                }
                if (ListType == "Income")
                {
                    List<Income> inc = new List<Income>();
                    inc = db.Incomes.ToList();
                    foreach (Income i in inc)
                    {
                        Console.WriteLine($"Expense Name: {i.IncomeName}      | Income Value: {i.IncomeAmount}");
                        t += i.IncomeAmount;
                        count += 1;
                    }
                    Console.WriteLine($"Total of {count} incomes = ${t}");
                }
                return t;
            }
        }
	}
}

