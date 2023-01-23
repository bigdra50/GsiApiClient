using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using Cysharp.Threading.Tasks;
using UnityEngine;

namespace GsiApiClient.Runtime.Requests
{
    internal class AddressRequest : RequestBase
    {
        private const string BaseUrl = "https://mreversegeocoder.gsi.go.jp/reverse-geocoder/LonLatToAddress";
        private string _municdJson;
        private AddressJsonData[] _municdData;

        internal async UniTask<(bool ok, Address value)> GetAsync(double latitude, double longitude, CancellationToken ct = default)
        {
            try
            {
                using var http = new HttpClient();
                var parameters = new Dictionary<string, string>
                {
                    { "lat", latitude.ToString() },
                    { "lon", longitude.ToString() },
                };
                var paramAsString = await new FormUrlEncodedContent(parameters).ReadAsStringAsync();
                var url = $"{BaseUrl}?{paramAsString}";
                var response = await http.GetAsync(url, ct);
                var json = await response.Content.ReadAsStringAsync();
                var addressResults = JsonUtility.FromJson<ResponseRoot>(json).results;
                var cityCode = addressResults.muniCd;
                var lv01Nm = addressResults.lv01Nm;
                if (string.IsNullOrEmpty(_municdJson))
                {
                    _municdJson = Resources.Load<TextAsset>("municd").ToString();
                    _municdData = JsonUtility.FromJson<MunicdJson>(_municdJson).array;
                }

                var addressData = _municdData.FirstOrDefault(x => cityCode == x.muniCd);
                return (true, new Address
                {
                    CityCode = cityCode,
                    Prefecture = addressData.prefecture,
                    City = addressData.city,
                    Lv01Nm = lv01Nm
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