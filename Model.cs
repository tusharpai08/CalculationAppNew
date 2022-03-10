using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace CalculationAppNew
{
	public class Model
	{
        public class DBCreationBase : DbContext
        {
            public DbSet<Expense> Expenses { get; set; }
            public DbSet<Income> Incomes { get; set; }

            public string DbPath { get; }

            public DBCreationBase()
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
            public string ExpenseName { get; set; }
        }

        /// <summary>
        /// Income Class
        /// </summary>
        public class Income
        {
            public int IncomeID { get; set; }
            public int IncomeAmount { get; set; }
            public string IncomeName { get; set; }
        }
    }
}

