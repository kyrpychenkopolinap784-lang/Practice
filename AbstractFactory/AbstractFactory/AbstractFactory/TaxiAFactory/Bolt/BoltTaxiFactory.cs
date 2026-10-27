using AbstractFactory.TaxiAFactory.ALevel;

namespace AbstractFactory.TaxiAFactory.Bolt
{
    public class BoltTaxiFactory : ITaxiFactory
    {
        public IMPV CreateMPV()
        {
            return new BoltMPV();
        }

        public IEstate CreateEstate()
        {
            return new BoltEstate();
        }

        public ISedan CreateSedan()
        {
            return new BoltSedan();
        }
    }
}
