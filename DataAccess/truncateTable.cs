using System;
using System.Linq;
using static CalculationAppNew.Model;
using Microsoft.EntityFrameworkCore;

namespace CalculationAppNew
{
	public class truncateTable
	{
		public truncateTable(string tableName)
		{
			customTextColor ct = new();
			using (var db = new DBCreationBase())
            {
                if (tableName == "Expense")
				{
					ct.PrintWarning("Truncating Expense");
					db.Database.ExecuteSqlRaw("DELETE FROM Expenses");
                    ct.SuccessMessage("Expense Table Truncated");
				}
				else if (tableName == "Income")
                {
                    ct.PrintWarning("Truncating Income");
					db.Database.ExecuteSqlRaw("DELETE FROM Incomes");
					ct.SuccessMessage("Income Table Truncated");
				}
				else
                    ct.PrintWarning("Command not recognised");
			}
		}
	}
}

