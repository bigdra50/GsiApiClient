using System;
using System.Linq;
using Cysharp.Threading.Tasks;
using UnityEngine;

namespace GsiApiClient.Runtime.Requests
{
    internal class AddressRequest : RequestBase
    {
        private const string BaseUrl = "https://mreversegeocoder.gsi.go.jp/reverse-geocoder/LonLatToAddress";

        internal static async UniTask<Address> GetAsync(double latitude, double longitude) =>
            await RequestGetAsync($"{BaseUrl}{new RequestAddressParams(latitude, longitude).ToQuery()}")
                .ContinueWith(json =>
                {
                    var addressResults = JsonUtility.FromJson<ResponseRoot>(json).results;
                    var municdJson = Resources.Load<TextAsset>("municd").ToString();
                    var addressData = JsonUtility
                        .FromJson<MunicdJson>(municdJson)
                        .array
                        .FirstOrDefault(x => addressResults.muniCd == x.muniCd);
                    return new Address
                    {
                        Prefecture = addressData.prefecture,
                        City = addressData.city,
                        Lv01Nm = addressResults.lv01Nm
                    };
                });

        [Serializable]
        private struct ResponseRoot
        {
            public Lon2LatAddressResponse results;
        }

        [Serializable]
        private struct Lon2LatAddressResponse
        {
            public int muniCd;
            public string lv01Nm;
        }
    }
}