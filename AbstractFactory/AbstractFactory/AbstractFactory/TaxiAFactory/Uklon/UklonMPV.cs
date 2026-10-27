using AbstractFactory.TaxiAFactory.ALevel;
using AbstractFactory.Properties;
using System.Drawing;

namespace AbstractFactory.TaxiAFactory.Uklon
{
    public class UklonMPV : IMPV
    {
        public Image Appearance => Resources.uklon_mpv;

        public string TaxiType => "Uklon MPV";
    }
}
