using System;

namespace TestPrototypes
{
    [Serializable]
    public class Adress 
    {
        public string StreetName;

        public int HouseNumber;
        private Adress adress;

        public Adress(Adress otherAdress)
        {
            StreetName = otherAdress.StreetName;
            HouseNumber = otherAdress.HouseNumber;
        }

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