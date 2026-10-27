using AbstractFactory.TaxiAFactory.ALevel;

namespace AbstractFactory.TaxiAFactory.Uklon
{
    public class UklonTaxiFactory : ITaxiFactory
    {
        public IMPV CreateMPV()
        {
            return new UklonMPV();
        }

        public IEstate CreateEstate()
        {
            return new UklonEstate();
        }

        public ISedan CreateSedan()
        {
            return new UklonSedan();
        }
    }
}
