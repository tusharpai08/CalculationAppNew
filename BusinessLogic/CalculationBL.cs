using System;

namespace CalculationAppNew.BusinessLogic
{
	public class CalculationBL
	{
		public static void calculate(string ListType)
        {
			///Get total of all amounts
			var x = GetTotal.GetListOfAmounts(ListType);
			Console.WriteLine("\nPlease enter banked amount:");
			var bankedAmount = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("\nPlease enter the rolling Mojo Balance from Last Month: ");
			var roll = Console.ReadLine();

            ///Print out the calculation bracket4
            var DEA = bankedAmount * 0.47;
			var SA = bankedAmount * 0.03;
			var FEA = bankedAmount * 0.20;
			var SML = bankedAmount * 0.10;
			var MA = "FE->Roll";
			var GA = bankedAmount * 0.20;

            customTextColor.NotificationMessage($"Move rolling amount of last month of ${roll} from FireExtinguisher to Mojo\n");

			///Initialise String Builder
			var sb = new System.Text.StringBuilder();

			///Print out the calculation bracket
			customTextColor.SuccessMessage("Account balances based on Expenses(E-Expected, A-Actual)");
			sb.Append(String.Format("  {0,13} | {1,10} | {2,17} | {3,7} | {4,10} | {5,7}\n", "DailyExpense", "Splurge", "FireExtinguisher", "Smile", "Mojo", "Grow"));
			sb.Append(String.Format("  {0,13} | {1,10} | {2,17} | {3,7} | {4,10} | {5,7}\n", "47%", "3%", "20%", "10%", "Roll", "20%"));
			sb.Append(String.Format("E-{0,13:F2} | {1,10:F2} | {2,17:F2} | {3,7:F2} | {4,10} | {5,7:F2}\n", DEA, SA, FEA, SML, MA, GA));
			sb.Append(String.Format("  {0,13} | {1,10} | {2,17} | {3,7} | {4,10} | {5,7}\n", "-----", "-----", "-----", "-----", "-----", "-----"));
			sb.Append(String.Format("A-{0,13:F2} | {1,10:F2} | {2,17:F2} | {3,7:F2} | {4,10} | {5,7:F2}\n", x, SA, FEA, SML, MA, GA));
			Console.WriteLine(sb);

			///Adding the calculation to the CalculationHistoryDB
			DataAccess.AddCalculationHistory.AddCalcHistoryToDB(x, SA, FEA, SML, MA, GA);

		}
	}
}

