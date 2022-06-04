using System;
using Cysharp.Threading.Tasks;
using UnityEngine;

namespace GsiApiClient.Runtime.Requests
{
    public class GeoidRequest : RequestBase
    {
        private const string BaseUrl = "https://vldb.gsi.go.jp/sokuchi/surveycalc/geoid/calcgh/cgi/geoidcalc.pl";

        public static async UniTask<double> GetAsync(double latitude, double longitude) =>
            await RequestGetAsync(
                    $"{BaseUrl}{new RequestGeoidParams(OutputType.Json, latitude, longitude).ToQuery()}"
                )
                .ContinueWith(json =>
                {
                    var result = JsonUtility.FromJson<ResponseRoot>(json);
                    return result.OutputData.geoidHeight;
                });

        [Serializable]
        private struct ResponseRoot
        {
            public GeoidResponse OutputData;
        }

        [Serializable]
        private struct GeoidResponse
        {
            public double latitude;
            public double longitude;
            public double geoidHeight;
        }
    }
}