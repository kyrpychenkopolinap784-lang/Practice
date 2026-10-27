using AbstractFactory.TaxiAFactory.ALevel;
using AbstractFactory.Properties;
using System.Drawing;

namespace AbstractFactory.TaxiAFactory.Uklon
{
    public class UklonEstate : IEstate
    {
        public Image Appearance => Resources.uklon_estate;

        public string TaxiType => "Uklon Estate";
    }
}
