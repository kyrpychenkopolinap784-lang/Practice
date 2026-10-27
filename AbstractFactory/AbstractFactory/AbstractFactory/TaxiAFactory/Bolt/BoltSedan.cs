using AbstractFactory.TaxiAFactory.ALevel;
using AbstractFactory.Properties;
using System.Drawing;

namespace AbstractFactory.TaxiAFactory.Bolt
{
    public class BoltSedan : ISedan
    {
        public Image Appearance => Properties.Resources.bolt_sedan;

        public string TaxiType => "Bolt Sedan";
    }
}
