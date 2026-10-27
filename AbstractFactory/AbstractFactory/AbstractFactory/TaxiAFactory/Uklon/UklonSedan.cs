using AbstractFactory.TaxiAFactory.ALevel;
using System.Drawing;

namespace AbstractFactory.TaxiAFactory.Uklon
{
    public class UklonSedan : ISedan
    {
        public Image Appearance => Properties.Resources.uklon_sedan;

        public string TaxiType => "Uklon Sedan";
    }
}
