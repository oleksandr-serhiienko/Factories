namespace TestPrototypes
{
    public class Adress
    {
        public string StreetName;

        public int HouseNumber;

        public Adress(string streetName, int houseNUmber)
        {
            StreetName = streetName;
            HouseNumber = houseNUmber;
        }

        public override string ToString()
        {
            return $"{nameof(StreetName)} : {StreetName}, {nameof(HouseNumber)} : {HouseNumber}";
        }
    }
}