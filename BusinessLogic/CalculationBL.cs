﻿using System;

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

			///Print out the calculation bracket
			var DEA = bankedAmount * 0.45;
			var SA = bankedAmount * 0.05;
			var FEA = bankedAmount * 0.20;
			var SML = bankedAmount * 0.10;
			var MA = "Roll";
			var GA = bankedAmount * 0.20;

			var sb = new System.Text.StringBuilder();
			customTextColor.SuccessMessage("Account balances based on Expenses(E-Expected, A-Actual)");
			sb.Append(String.Format("  {0,13} | {1,7} | {2,17} | {3,7} | {4,7} | {5,7}\n", "DailyExpense", "Splurge", "FireExtinguisher", "Smile", "Mojo", "Grow"));
			sb.Append(String.Format("  {0,13} | {1,7} | {2,17} | {3,7} | {4,7} | {5,7}\n", "45%", "5%", "20%", "10%", "Roll", "20%"));
			sb.Append(String.Format("E-{0,13:F2} | {1,7:F2} | {2,17:F2} | {3,7:F2} | {4,7} | {5,7:F2}\n", DEA, SA, FEA, SML, MA, GA));
			sb.Append(String.Format("  {0,13} | {1,7} | {2,17} | {3,7} | {4,7} | {5,7}\n", "-----", "-----", "-----", "-----", "-----", "-----"));
			sb.Append(String.Format("A-{0,13:F2} | {1,7:F2} | {2,17:F2} | {3,7:F2} | {4,7} | {5,7:F2}\n", DEA-x, SA, FEA, SML, MA, GA));
			Console.WriteLine(sb);
		}
	}
}

