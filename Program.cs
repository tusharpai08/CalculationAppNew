using System;
using System.Linq;
using static CalculationAppNew.Model;

namespace CalculationAppNew
{
    internal class Program
    {
        private static void Main()
        {
            using (var db = new DBCreationBase())
            {
                // Note: This sample requires the database to be created before running.
                Console.WriteLine($"Database path: {db.DbPath}.");

                // Create
                Console.WriteLine("Inserting a new Expense");
                db.Add(new Expense { ExpenseAmount = 100, ExpenseName = "Car" });
                db.SaveChanges();

                Console.WriteLine("Inserting a new Income");
                db.Add(new Income { IncomeAmount = 100, IncomeName = "Crypto" });
                db.SaveChanges();

                // Read
                Console.WriteLine("Querying for a Expense");
                var y = db.Expenses
                    .OrderBy(b => b.ExpenseID)
                    .First();
                Console.WriteLine($"{y.ExpenseName} costs {y.ExpenseAmount}");

                Console.WriteLine("Querying for a Income");
                var x = db.Incomes
                    .OrderBy(b => b.IncomeID)
                    .First();
                Console.WriteLine($"{x.IncomeName} costs {x.IncomeAmount}");
            }
        }
    }
}