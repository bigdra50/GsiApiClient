using System;
using Cysharp.Threading.Tasks;
using UnityEngine;

namespace GsiApiClient.Runtime.Requests
{
    internal class DistanceRequest : RequestBase
    {
        private const string BaseUrl = "https://vldb.gsi.go.jp/sokuchi/surveycalc/surveycalc/bl2st_calc.pl";
        private const int RequestCapacity = 10;
        private const int RequestInterval = 10;

        internal DistanceRequest() : base(RequestCapacity, RequestInterval)
        {
        }

        public async UniTask<(bool ok, DistanceResponse value)> GetAsync(
            double fromLat, double fromLgt,
            double toLat, double toLgt,
            Ellipsoid ellipsoid = Ellipsoid.Grs80)
        {
            try
            {
                var requestParams = new RequestDistanceParams(OutputType.Json, ellipsoid, fromLat, fromLgt, toLat, toLgt);
                var request = await RequestGetAsync($"{BaseUrl}{requestParams.ToQuery()}");
                if (!request.ok) return (false, default);
                var distance = JsonUtility.FromJson<ResponseRoot>(request.json);
                return (true, distance.OutputData);
            }
            catch (Exception)
            {
                return (false, default);
            }
        }

        [Serializable]
        private struct ResponseRoot
        {
            public DistanceResponse OutputData;
        }
    }

    [Serializable]
    public struct DistanceResponse
    {
        /// <summary>
        /// meter
        /// 距離が0の場合(出発点と到着点が一致する場合)､ 空の文字列となる
        /// </summary>
        public string geoLength;

        /// <summary>
        /// 方位角
        /// </summary>
        public string azimuth1;

        public string azimuth2;
    }
}