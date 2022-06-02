using System;

namespace GsiApiClient.Runtime.DeserializedJson
{
    [Serializable]
    public struct LonLat2Address
    {
        public AddressResults results;
    }

    [Serializable]
    public struct AddressResults
    {
        public int muniCd;
        public string lv01Nm;
    }

    [Serializable]
    public struct DistanceOutputData
    {
        /// <summary>
        /// 距離が0の場合(出発点と到着点が一致する場合)､ 空の文字列となる
        /// </summary>
        public string geoLength { get; set; }

        public string azimuth1 { get; set; }
        public string azimuth2 { get; set; }
    }

    [Serializable]
    public struct DistanceJson
    {
        public DistanceOutputData OutputData { get; set; }
    }

    [Serializable]
    public struct GeoidHeightJson
    {
        public GeoidOutputData OutputData;
    }

    [Serializable]
    public struct GeoidOutputData
    {
        public double latitude;
        public double longitude;
        public double geoidHeight;
    }
}