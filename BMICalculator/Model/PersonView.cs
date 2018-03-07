using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BMICalculator.View;
namespace BMICalculator.Model
{
    
    public class PersonView
    {
        public double Height { get; set; }
        public double Weight { get; set; }
        public int Gender { get; set; }

        public double CalculateBMI ()
        {
            return Math.Round(Weight/(Height*Height) * 10000, 2);
        }

        public string BMIComment()
        {
            double BMI = CalculateBMI();
            
            if (Gender == 1)
            {
                if (BMI < 20.7)
                {
                    return "You are underweight";
                }
                else if (BMI >= 20.7 && BMI <= 26.4)
                {
                    return "You have normal weight";
                }
                else if (BMI >= 26.5 && BMI <= 27.8)
                {
                    return "You are overweight";
                }
                else if (BMI >= 27.9 && BMI <= 31.1)
                {
                    return "You are obese";
                }
                else 
                {
                    return "You are extremely obese";
                }
                
            }
            else
            {
                if (BMI < 19.1)
                {
                    return "You are underweight";
                }
                else if (BMI >= 19.1 && BMI <= 25.8)
                {
                    return "You have normal weight";
                }
                else if (BMI >= 25.9 && BMI <= 27.3)
                {
                    return "You are overweight";
                }
                else if (BMI >= 27.4 && BMI <= 32.3)
                {
                    return "You are obese";
                }
                else
                {
                    return "You are extremely obese";
                }
               
            }
        }
    }
}
