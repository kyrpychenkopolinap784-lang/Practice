using AbstractFactory.TaxiAFactory.ALevel;
using System.Drawing;

namespace AbstractFactory.TaxiAFactory.Bolt
{
    public class BoltEstate : IEstate
    {
        public Image Appearance => Properties.Resources.bolt_estate;

        public string TaxiType => "Bolt Estate";
    }
}
