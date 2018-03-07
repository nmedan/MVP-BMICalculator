using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BMICalculator.View;
using BMICalculator.Model;
namespace BMICalculator.Presenter
{
    public class PersonPresenter
    {
        IPersonView personView;

        public PersonPresenter(IPersonView PersonView)
        {
            this.personView = PersonView;
        }

        public void IzracunajBMI()
        {
            PersonView pw = new PersonView();
            pw.Weight = double.Parse(personView.Weight);
            pw.Height = double.Parse(personView.Height);
            pw.Gender = personView.Gender;
            personView.BMIIndex = pw.CalculateBMI().ToString("00.00");
            personView.Comment = pw.BMIComment();
        }
        
    }
}
