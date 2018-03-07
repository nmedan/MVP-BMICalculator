using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BMICalculator.Model;
namespace BMICalculator.View
{
    
    public interface IPersonView
    {
        string Height { get; set; }
        string Weight { get; set; }
        int Gender { get; set; }
        string BMIIndex { get; set; }
        string Comment { get; set; }
    }
}
