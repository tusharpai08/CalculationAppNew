using System;

namespace CalculationAppNew
{
	public class customTextColor
	{
		/// <summary>
        /// Print the recieved text in Red as a warning message 
        /// </summary>
        /// <param name="messageText">string</param>
		public static void PrintWarning(string messageText)
        {
			Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Waring: {messageText}");
			Console.ResetColor();
        }

		/// <summary>
        /// Print the received text in Green as a success message 
        /// </summary>
        /// <param name="messageText">string</param>
		public static void SuccessMessage(string messageText)
		{
			Console.ForegroundColor = ConsoleColor.Green;
			Console.WriteLine($"Success: {messageText}");
			Console.ResetColor();
		}
	}
}

