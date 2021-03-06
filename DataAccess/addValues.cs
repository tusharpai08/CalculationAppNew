using System;
using static CalculationAppNew.Model;

namespace CalculationAppNew
{
	public class addValues
	{
        /// <summary>
        /// Function to add values to DB for the given List Type
        /// </summary>
        /// <param name="listType">Expense or Income</param>
        
        public static void add(string listType)
		{
            if (listType == "Expense" | listType == "expense")
            {
                using (var db = new DBCreationBase())
                {
                    var repeat = "Y";
                    //Add expense to DB in recursive
                    do
                    {
                        Console.WriteLine("Please enter expense name:");
                        var exName = Console.ReadLine();
                        Console.WriteLine("Please enter expense amount:");
                        var exAmount = Convert.ToInt32(Console.ReadLine());
                        db.Add(new Expense { ExpenseName = exName, ExpenseAmount = exAmount });
                        db.SaveChanges();
                        Console.WriteLine("Add more expense ?(Y|N)");
                        Console.WriteLine();
                        repeat = Console.ReadLine();
                    } while (repeat != "N");

                    //Show progress bar status
                        progressBar.WriteProgressBar(0);
                    for (var i = 0; i <= 100; ++i)
                    {
                        progressBar.WriteProgressBar(i, true);
                        Thread.Sleep(30);
                    }
                    Console.WriteLine();
                    progressBar.WriteProgress(0);
                    for (var i = 0; i <= 100; ++i)
                    {
                        progressBar.WriteProgress(i, true);
                        Thread.Sleep(50);
                    }
                    customTextColor.SuccessMessage("Value(s) added & DB updated successfully...!");
                }
            }
            else if (listType == "Income" | listType == "income")
            {
                using (var db = new DBCreationBase())
                {
                    // Create
                    Console.WriteLine("Please enter income name:");
                    var inName = Console.ReadLine();
                    Console.WriteLine("Please enter income amount:");
                    var inAmount = Convert.ToInt32(Console.ReadLine());
                    db.Add(new Income { IncomeName = inName, IncomeAmount = inAmount });
                    db.SaveChanges();

                    //Show progress bar status
                    progressBar.WriteProgressBar(0);
                    for (var i = 0; i <= 100; ++i)
                    {
                        progressBar.WriteProgressBar(i, true);
                        Thread.Sleep(30);
                    }
                    Console.WriteLine();
                    progressBar.WriteProgress(0);
                    for (var i = 0; i <= 100; ++i)
                    {
                        progressBar.WriteProgress(i, true);
                        Thread.Sleep(50);
                    }
                    customTextColor.SuccessMessage("Value added & DB updated successfully...!");
                }
            }
            else
                customTextColor.PrintWarning("Input not recognised");
        }
    }
}

