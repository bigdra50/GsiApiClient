using System;
using System.Threading;
using Cysharp.Threading.Tasks;
using UnityEngine;

namespace GsiApiClient.Runtime.Requests
{
    internal class GeoidRequest : RequestBase
    {
        private const string BaseUrl = "https://vldb.gsi.go.jp/sokuchi/surveycalc/geoid/calcgh/cgi/geoidcalc.pl";
        private const int RequestCapacity = 10;
        private const int RequestInterval = 10;

        internal GeoidRequest() : base(RequestCapacity, RequestInterval)
        {
        }

        internal async UniTask<(bool ok, double value)> GetAsync(double latitude, double longitude, CancellationToken ct = default)
        {
            try
            {
                var requestParams = new RequestGeoidParams(OutputType.Json, latitude, longitude).ToQuery();
                var request = await RequestGetAsync($"{BaseUrl}{requestParams}", ct: ct);
                if (!request.ok) return (false, default);
                var response = JsonUtility.FromJson<ResponseRoot>(request.json);
                return (true, response.OutputData.geoidHeight);
            }
            catch (Exception)
            {
                return (false, default);
            }
        }

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