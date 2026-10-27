using AbstractFactory.TaxiAFactory.ALevel;

namespace AbstractFactory.TaxiAFactory.Uber
{
    public class UberTaxiFactory : ITaxiFactory
    {
        public ISedan CreateSedan()
        {
            return new UberSedan();
        }

        public IEstate CreateEstate()
        {
            return new UberEstate();
        }

        public IMPV CreateMPV()
        {
            return new UberMPV();
        }
    }
}
