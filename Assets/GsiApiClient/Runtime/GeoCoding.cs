using System;

namespace GsiApiClient.Runtime
{
    [Serializable]
    public struct MunicdJson
    {
        public AddressJsonData[] array;
    }

    [Serializable]
    public struct AddressJsonData
    {
        public int id;
        public int n;
        public string prefecture;
        public int muniCd;
        public string city;
    }

    [Serializable]
    public struct Address
    {
        public int CityCode;
        public string Prefecture;
        public string City;
        public string Lv01Nm;
    }
}