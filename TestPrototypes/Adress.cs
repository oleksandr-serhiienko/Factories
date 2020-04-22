using System;

namespace TestPrototypes
{
    public class Adress : ICloneable
    {
        public string StreetName;

        public int HouseNumber;

        public Adress(string streetName, int houseNUmber)
        {
            StreetName = streetName;
            HouseNumber = houseNUmber;
        }

        public object Clone()
        {
            return new Adress(StreetName, HouseNumber);
        }

        public override string ToString()
        {
            return $"{nameof(StreetName)} : {StreetName}, {nameof(HouseNumber)} : {HouseNumber}";
        }
    }
}