using System;
using static CalculationAppNew.Model;

namespace CalculationAppNew.DataAccess
{
	public class updateListRow
	{
        public static void update(string listType)
        {
            if (listType == "Expense" | listType == "expense")
            {
                using var db = new DBCreationBase();
                var repeat = "Y";
                //Add expense to DB in recursive
                do
                {
                    //Display the existing list
                    listValues.list(listType);

                    //Accept user input
                    Console.WriteLine("Please enter expense name you would like to update:");
                    var exName = Console.ReadLine();
                    Console.WriteLine("Please enter the new expense name:");
                    var exNewName = Console.ReadLine();
                    Console.WriteLine("Please enter the new expense Amount:");
                    var exNewAmount = Convert.ToInt32(Console.ReadLine());

                    //update DB
                    var updateRecord = db.Expenses.Where(d => d.ExpenseName == exName.ToString()).First();
                    updateRecord.ExpenseName = exNewName;
                    updateRecord.ExpenseAmount = exNewAmount;
                    db.SaveChanges();

                    //Recurse 
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
                customTextColor.SuccessMessage("Value(s) updated successfully...!");
            }
            else if (listType == "Income" | listType == "income")
            {
                using var db = new DBCreationBase();
                var repeat = "Y";
                //Add expense to DB in recursive
                do
                {
                    //Display the existing list
                    listValues.list(listType);

                    //Accept user input
                    Console.WriteLine("Please enter income name you would like to update:");
                    var inName = Console.ReadLine();
                    Console.WriteLine("Please enter the new income name:");
                    var inNewName = Console.ReadLine();
                    Console.WriteLine("Please enter the new income Amount:");
                    var inNewAmount = Convert.ToInt32(Console.ReadLine());

                    //update DB
                    var updateRecord = db.Incomes.Where(d => d.IncomeName == inName.ToString()).First();
                    updateRecord.IncomeName = inNewName;
                    updateRecord.IncomeAmount = inNewAmount;
                    db.SaveChanges();

                    //Recurse 
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
                customTextColor.SuccessMessage("Value(s) updated successfully...!");
            }
            else
                customTextColor.PrintWarning("Input not recognised");
        }
    }
}

