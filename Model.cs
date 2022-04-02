using Microsoft.EntityFrameworkCore;

namespace CalculationAppNew
{
	public class Model
	{
        public class DBCreationBase : DbContext
        {
            public DbSet<Expense> Expenses { get; set; }
            public DbSet<Income> Incomes { get; set; }
            public DbSet<CalculationHistory> CalculationHistories { get; set; }

            public string DbPath { get; }

#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
            public DBCreationBase()
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
            {
                var folder = Environment.SpecialFolder.LocalApplicationData;
                var path = Environment.GetFolderPath(folder);
                DbPath = System.IO.Path.Join(path, "ExpenseIncome.db");
            }

            // The following configures EF to create a Sqlite database file in the
            // special "local" folder for your platform.
            protected override void OnConfiguring(DbContextOptionsBuilder options)
                => options.UseSqlite($"Data Source={DbPath}");
        }

        /// <summary>
        /// Expense Class
        /// </summary>
        public class Expense
        {
            public int ExpenseID { get; set; }
            public int ExpenseAmount { get; set; }
            public string? ExpenseName { get; set; }
        }

        /// <summary>
        /// Income Class
        /// </summary>
        public class Income
        {
            public int IncomeID { get; set; }
            public int IncomeAmount { get; set; }
            public string? IncomeName { get; set; }
        }

        /// <summary>
        /// Calculation History 
        /// </summary>
        public class CalculationHistory
        {
            public int ID { get; set; }
            public double DailyExpense { get; set; }
            public double Splurge { get; set; }
            public double FireExtinguisher { get; set; }
            public double Smile { get; set; }
            public string? Mojo { get; set; }
            public double Grow { get; set; }
            public DateTime WhenAdded { get; set; }
        }
    }
}

