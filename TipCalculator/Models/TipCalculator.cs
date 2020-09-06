using System.ComponentModel.DataAnnotations;

namespace TipCalculator.Models
{
    public class Calculator
    {
        [Required(ErrorMessage = "Please enter a price.")]
        [Range(0, 1000000000, ErrorMessage = "Price must be > 0")]
        public double? MealCost { get; set; }
        

        //STEP 2:
        /*
        Using the CalculateFutureValue() method from the FutureValueModel class as a guide, 
        create a method called CalculateTip.
        1. It should return a double and take a double as an argument.
        2. The argument should represent the percentage of the tip in 0 <= % <= 1 format.
        3. If MealCost.HasValue is true, return MealCost.Value * the percentage,
        otherwise return 0
        */
        public double CalculateTip(double tipPercent)
        {
            if (MealCost.HasValue)
            {
                //if (tipPercent > 1) //allows user to input tip in 1 < % < 100 as well --commented out, user doesnt get to input custom percents
                //{
                //    tipPercent /= 100;
                //}
                return MealCost.Value * tipPercent;

            }
            else
            {
                return 0;
            }
        }
        //PROCEED TO HomeController.cs NEXT...
    }
}
