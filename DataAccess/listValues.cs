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
        
		public static void list(string listType)
		{
            var sb = new System.Text.StringBuilder();
            if (listType == "Expense" | listType == "expense")
			{
                using (var db = new DBCreationBase())
                {
                    // Read
                    Console.WriteLine("========================EXPENSE LIST==========================");
                    List<Expense> exp = new List<Expense>();
                    exp = db.Expenses.ToList();
                    foreach(Expense e in exp)
                    {
                        sb.Append(String.Format("Expense Name: {0,20} | Expense Amount: {1,5} \n", e.ExpenseName, e.ExpenseAmount));
                    }
                    Console.WriteLine(sb);
                    Console.WriteLine("==============================================================");
                }
            }
            else if (listType == "Income" | listType == "income")
            {
                using (var db = new DBCreationBase())
                {
                    Console.WriteLine("========================INCOME LIST==========================");
                    List<Income> inc = new List<Income>();
                    inc = db.Incomes.ToList();
                    foreach (Income i in inc)
                    {
                        sb.Append(String.Format("Income Name: {0,20} | Income Amount: {1,5} \n", i.IncomeName, i.IncomeAmount));
                    }
                    Console.WriteLine(sb);
                    Console.WriteLine("==============================================================");
                }
            }
            else if (listType == "CalcHistory" | listType == "calchistory")
            {
                using (var db = new DBCreationBase())
                {
                    Console.WriteLine("========================CALCULATION LIST==========================");
                    List<CalculationHistory> calc = new List<CalculationHistory>();
                    calc = db.CalculationHistories.ToList();
                    foreach (CalculationHistory c in calc)
                    {
                        sb.Append(String.Format("  {0,13} | {1,10} | {2,17} | {3,7} | {4,10} | {5,7} | {6,20}\n", "DailyExpense", "Splurge", "FireExtinguisher", "Smile", "Mojo", "Grow", "WhenAdded"));
                        sb.Append(String.Format("  {0,13:F2} | {1,10:F2} | {2,17:F2} | {3,7:F2} | {4,10} | {5,7:F2} | {6,20}\n", c.DailyExpense, c.Splurge, c.FireExtinguisher, c.Smile, c.Mojo, c.Grow, c.WhenAdded));
                    }
                    Console.WriteLine(sb);
                    Console.WriteLine("==============================================================");
                }
            }
            else
                customTextColor.PrintWarning("Command not recognised");
        }
	}
}

