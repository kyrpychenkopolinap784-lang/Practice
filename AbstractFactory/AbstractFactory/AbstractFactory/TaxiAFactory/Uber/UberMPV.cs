using AbstractFactory.TaxiAFactory.ALevel;

namespace AbstractFactory.TaxiAFactory.Uber
{
    public class UberMPV : IMPV
    {
        public System.Drawing.Image Appearance => Properties.Resources.uber_mpv;
        public string TaxiType => "Uber MPV";
    }
}
