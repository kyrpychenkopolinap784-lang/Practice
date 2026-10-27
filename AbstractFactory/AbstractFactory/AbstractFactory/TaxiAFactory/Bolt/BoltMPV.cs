using AbstractFactory.TaxiAFactory.ALevel;
using System.Drawing;

namespace AbstractFactory.TaxiAFactory.Bolt
{
    public class BoltMPV : IMPV
    {
        public Image Appearance => Properties.Resources.bolt_mpv;

        public string TaxiType => "Bolt MPV";
    }
}
