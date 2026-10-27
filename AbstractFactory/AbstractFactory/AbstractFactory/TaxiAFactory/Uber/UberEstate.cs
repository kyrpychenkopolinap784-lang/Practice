using AbstractFactory.TaxiAFactory.ALevel;
using System.Drawing;

namespace AbstractFactory.TaxiAFactory.Uber
{
    public class UberEstate : IEstate
    {
        public Image Appearance => Properties.Resources.uber_estate;

        public string TaxiType => "Uber Estate";
    }
}
