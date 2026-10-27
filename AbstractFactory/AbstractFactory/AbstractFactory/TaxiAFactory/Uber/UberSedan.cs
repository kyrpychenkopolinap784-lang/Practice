using AbstractFactory.TaxiAFactory.ALevel;
using System.Drawing;

namespace AbstractFactory.TaxiAFactory.Uber
{
    public class UberSedan : ISedan
    {
        public Image Appearance => Properties.Resources.uber_sedan;

        public string TaxiType => "Uber Sedan";
    }
}
