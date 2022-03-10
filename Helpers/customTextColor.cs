using System;
namespace CalculationAppNew
{
	public class customTextColor
	{
		public void PrintWarning(string messageText)
        {
			Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Waring: {messageText}.");
			Console.ResetColor();
        }

		public void SuccessMessage(string messageText)
		{
			Console.ForegroundColor = ConsoleColor.Green;
			Console.WriteLine($"Success: {messageText}.");
			Console.ResetColor();
		}
	}
}

