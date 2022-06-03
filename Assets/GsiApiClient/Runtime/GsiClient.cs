using System;
using Cysharp.Threading.Tasks;
using GsiApiClient.Runtime.DeserializedJson;
using UnityEngine;
using UnityEngine.Networking;

namespace GsiApiClient.Runtime
{
    /// <summary>
    /// 国土地理院(Geospatial Information Authority)のAPIクライアント
    /// </summary>
    public class GsiClient
    {
        private static string LonLat2AddressUrl(double latitude, double longitude) =>
            $"https://mreversegeocoder.gsi.go.jp/reverse-geocoder/LonLatToAddress?lat={latitude}&lon={longitude}";

        private static string GeoidHeightUrl(double latitude, double longitude) =>
            $"https://vldb.gsi.go.jp/sokuchi/surveycalc/geoid/calcgh/cgi/geoidcalc.pl?outputType=json&latitude={latitude}&longitude={longitude}";

        private static string DistanceBaseUrl() => "https://vldb.gsi.go.jp/sokuchi/surveycalc/surveycalc/bl2st_calc.pl";

        public static async UniTask<(int municd, string lv01Nm)> RequestLonLat2AddressAsync(double latitude, double longitude)
        {
            return await RequestGetAsync(LonLat2AddressUrl(latitude, longitude))
                .ContinueWith(json =>
                {
                    var deserialized = JsonUtility.FromJson<LonLat2Address>(json).results;
                    return (deserialized.muniCd, deserialized.lv01Nm);
                });
        }

        /// <summary>
        /// 指定した地点のジオイド高を取得する｡
        /// リクエストは10秒に10回までの制限あり
        /// </summary>
        /// <param name="latitude"></param>
        /// <param name="longitude"></param>
        /// <returns></returns>
        public static async UniTask<double> RequestGeoidHeight(double latitude, double longitude)
        {
            return await RequestGetAsync(GeoidHeightUrl(latitude, longitude))
                .ContinueWith(json =>
                {
                    var result = JsonUtility.FromJson<GeoidHeightJson>(json);
                    return result.OutputData.geoidHeight;
                });
        }

        public static async UniTask<DistanceOutputData> RequestDistanceAsync(
            double fromLat, double fromLgt,
            double toLat, double toLgt,
            Ellipsoid ellipsoid = Ellipsoid.Grs80)
        {
            var reqParams = new RequestDistanceParams(OutputType.Json, ellipsoid, fromLat, fromLgt, toLat, toLgt);
            var url = $"{DistanceBaseUrl()}{reqParams.ToQuery()}";
            var json = await RequestGetAsync(url);
            var distance = JsonUtility.FromJson<DistanceJson>(json);
            return distance.OutputData;
        }


        public static async UniTask<string> RequestGetAsync(string url)
        {
            var request = UnityWebRequest.Get(url);
            try
            {
                var result = await request.SendWebRequest();
                return result.downloadHandler.text;
            }
            catch (Exception e)
            {
                Debug.LogError($"{e}");
                return request.error;
            }
        }
    }
}