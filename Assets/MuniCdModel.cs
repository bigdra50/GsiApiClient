using System;

namespace GsiApiClient.Runtime.Scripts
{
    [Serializable]
    public struct MuniCdModel
    {
        public string MuniCd;
        public string Prefecture;
        public string Municipality;
    }
    //[Serializable]
    //public class MuniDictionary: SerializableDictionary<int,MuniCdModel>{}
}