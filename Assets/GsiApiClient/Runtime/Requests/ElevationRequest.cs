using System;
using System.Threading;
using Cysharp.Threading.Tasks;
using UnityEngine;

namespace GsiApiClient.Runtime.Requests
{
    internal class ElevationRequest : RequestBase
    {
        private const string BaseUrl = "https://cyberjapandata2.gsi.go.jp/general/dem/scripts/getelevation.php";
        private const int RequestCapacity = 10;
        private const int RequestInterval = 10;

        internal ElevationRequest() : base(RequestCapacity, RequestInterval)
        {
        }

        public async UniTask<(bool ok, double value)> GetAsync(double lat, double lng, CancellationToken ct)
        {
            try
            {
                var requestParams = new RequestElevationParams(OutputType.Json, lat, lng).ToQuery();
                var request = await RequestGetAsync($"{BaseUrl}{requestParams}", ct: ct);
                if (!request.ok) return (false, default);
                var response = JsonUtility.FromJson<GsiElevationJson>(request.json);
                return (true, response.elevation);
            }
            catch (Exception)
            {
                return (false, default);
            }
        }
    }

    [Serializable]
    public struct GsiElevationJson
    {
        public double elevation;
        public string hsrc;
    }
}