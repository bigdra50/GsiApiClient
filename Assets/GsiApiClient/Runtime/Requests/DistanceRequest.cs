using System;
using Cysharp.Threading.Tasks;
using UnityEngine;

namespace GsiApiClient.Runtime.Requests
{
    internal class DistanceRequest : RequestBase
    {
        private const string BaseUrl = "https://vldb.gsi.go.jp/sokuchi/surveycalc/surveycalc/bl2st_calc.pl";

        public static async UniTask<DistanceResponse> GetAsync(
            double fromLat, double fromLgt,
            double toLat, double toLgt,
            Ellipsoid ellipsoid = Ellipsoid.Grs80)
        {
            var reqParams = new RequestDistanceParams(OutputType.Json, ellipsoid, fromLat, fromLgt, toLat, toLgt);
            var json = await RequestGetAsync($"{BaseUrl}{reqParams.ToQuery()}");
            var distance = JsonUtility.FromJson<ResponseRoot>(json);
            return distance.OutputData;
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