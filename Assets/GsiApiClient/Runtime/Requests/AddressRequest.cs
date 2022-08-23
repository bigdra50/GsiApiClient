using System;
using System.Linq;
using Cysharp.Threading.Tasks;
using UnityEngine;

namespace GsiApiClient.Runtime.Requests
{
    internal class AddressRequest : RequestBase
    {
        private const string BaseUrl = "https://mreversegeocoder.gsi.go.jp/reverse-geocoder/LonLatToAddress";
        private const int RequestCapacity = 10;
        private const int RequestInterval = 10;
        private string _municdJson;
        private AddressJsonData[] _municdData;

        internal AddressRequest() : base(RequestCapacity, RequestInterval)
        {
        }

        internal async UniTask<(bool ok, Address value)> GetAsync(double latitude, double longitude)
        {
            try
            {
                var requestParams = new RequestAddressParams(latitude, longitude).ToQuery();
                var request = await RequestGetAsync($"{BaseUrl}{requestParams}");
                if (!request.ok) return (false, default);
                var addressResults = JsonUtility.FromJson<ResponseRoot>(request.json).results;
                if (string.IsNullOrEmpty(_municdJson))
                {
                    _municdJson = Resources.Load<TextAsset>("municd").ToString();
                    _municdData = JsonUtility.FromJson<MunicdJson>(_municdJson).array;
                }

                var addressData = _municdData.FirstOrDefault(x => addressResults.muniCd == x.muniCd);
                return (true, new Address
                {
                    Prefecture = addressData.prefecture,
                    City = addressData.city,
                    Lv01Nm = addressResults.lv01Nm
                });
            }
            catch (Exception)
            {
                return (false, default);
            }
        }

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