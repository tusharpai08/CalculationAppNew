using System;
using System.Linq;
using static CalculationAppNew.Model;
using Microsoft.EntityFrameworkCore;

namespace CalculationAppNew
{
	public class truncateTable
	{
		public static void truncate(string tableName)
		{
			using (var db = new DBCreationBase())
            {
                if (tableName == "Expense")
				{
					customTextColor.PrintWarning("Truncating Expense");
					customTextColor.PrintWarning("Are you sure about this? (Y|N)");
					var i = Console.ReadLine();
                    if (i == "Y")
                    {
						db.Database.ExecuteSqlRaw("DELETE FROM Expenses");
						customTextColor.SuccessMessage("Expense Table Truncated");
					}
				}
				else if (tableName == "Income")
                {
                    customTextColor.PrintWarning("Truncating Income");
					customTextColor.PrintWarning("Are you sure about this? (Y|N)");
					var i = Console.ReadLine();
					if (i == "Y")
					{
						db.Database.ExecuteSqlRaw("DELETE FROM Incomes");
						customTextColor.SuccessMessage("Income Table Truncated");
					}
				}
				else if (tableName == "CalcHistory")
				{
					customTextColor.PrintWarning("Truncating CalculationHistory");
					customTextColor.PrintWarning("Are you sure about this? (Y|N)");
					var i = Console.ReadLine();
					if (i == "Y")
					{
						db.Database.ExecuteSqlRaw("DELETE FROM CalculationHistories");
						customTextColor.SuccessMessage("CalculationHistory Table Truncated");
					}
				}
				else
                    customTextColor.PrintWarning("Command not recognised");
			}
		}
	}
}

