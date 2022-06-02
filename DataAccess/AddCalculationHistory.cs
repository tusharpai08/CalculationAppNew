using static CalculationAppNew.Model;

namespace CalculationAppNew.DataAccess
{
    public class AddCalculationHistory
    {
        /// <summary>
        /// This funciton adds the calculated to the CalculationHistoryDB
        /// </summary>
        /// <param name="DEA"></param>
        /// <param name="SA"></param>
        /// <param name="FEA"></param>
        /// <param name="SML"></param>
        /// <param name="MA"></param>
        /// <param name="GA"></param>
        public static void AddCalcHistoryToDB(double DEA, double SA, double FEA, double SML, string MA, double GA)
        {
            using (var db = new DBCreationBase())
            {
                var now = DateTime.Now.ToString("dddd, dd MMMM yyyy");

                db.Add(new CalculationHistory { DailyExpense = DEA, Splurge = SA, FireExtinguisher = FEA, Smile = SML, Mojo = MA, Grow = GA, WhenAdded = now });
                db.SaveChanges();
            }
            customTextColor.SuccessMessage("Calculations have been added to DB");
        }
    }
}

