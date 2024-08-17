using System.Collections;
using System.Net;
using Cysharp.Threading.Tasks;
using GsiApi.Api;
using GsiApiClient.Runtime;
using GsiElevationApi.Api;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace GsiApiClient.Tests.Editor
{
    public class ApiTest
    {
        private IElevationApi _elevationApi = new ElevationApi();
        private ISurveyCalcApiAsync _surveyCalcApi = new SurveyCalcApi();


        internal static (double lat, double lgt, double geoid)[] Values =
        {
            (43.06417, 141.34694, 31.9865), // 北海道札幌市
            (35.68944, 139.69167, 37.0044), // 東京都新宿区
            (35.658584, 139.7454316, 36.5945), // 東京タワー
            (36.66069805149894, 138.53522707144214, 43.3085), // 群馬県吾妻郡中之条町入山(日本国道最高地点碑)
            (35.3607800273112, 138.7273941461917, 42.5080) // 富士山山頂
        };

        [UnityTest]
        public IEnumerator
            RequestGeoidTest(
                [ValueSource(nameof(Values))] (double lat, double lgt, double geoid) value) =>
            UniTask.ToCoroutine(async () =>
            {
                var geoidApi = new GeoidApi();
                var actualGeoid =
                    await geoidApi.GeoidCalcghCgiGeoidcalcPlGetWithHttpInfoAsync("json", value.lat, value.lgt);
                Assert.IsTrue(actualGeoid.StatusCode == HttpStatusCode.OK, $"{actualGeoid.StatusCode}");
                var delta = .00001d;
                Assert.AreEqual(value.geoid, actualGeoid.Data.OutputData.GeoidHeight, delta);
            });

        [UnityTest]
        public IEnumerator RequestAddressTest(
            [ValueSource(nameof(Values))] (double lat, double lgt, double geoid) value) =>
            UniTask.ToCoroutine(async () =>
            {
                var result = await GsiClient.Instance.RequestLonLat2AddressAsync(value.lat, value.lgt);
                Assert.IsTrue(result.ok);
                Debug.Log($"{result.value.Prefecture},{result.value.City},{result.value.Lv01Nm}");
            });

        [UnityTest]
        public IEnumerator RequestDistanceTest(
            [ValueSource(nameof(Values))] (double lat, double lgt, double geoid) value) =>
            UniTask.ToCoroutine(async () =>
            {
                var request = await _surveyCalcApi.SurveycalcBl2stCalcPlGetWithHttpInfoAsync("json", "GRS80", value.lat,
                    value.lgt, 35.658584,
                    139.7454316);
                Assert.IsTrue(request.StatusCode == HttpStatusCode.OK, $"{request.StatusCode}");
                var response = request.Data;
                Debug.Log(
                    $"{response.OutputData.Azimuth1},{response.OutputData.Azimuth2}, {response.OutputData.GeoLength}");
            });

        [UnityTest]
        public IEnumerator RequestElevationTest(
            [ValueSource(nameof(Values))] (double lat, double lgt, double geoid) value) =>
            UniTask.ToCoroutine(async () =>
            {
                var request = await _elevationApi.GetelevationPhpGetWithHttpInfoAsync(value.lgt, value.lat);
                Assert.IsTrue(request.StatusCode == HttpStatusCode.OK, $"{request.StatusCode}");
                Assert.NotNull(request.Data, "request.Data != null");
                Debug.Log($"{value.lat},{value.lgt},{request.Data?.Elevation}");
            });
    }
}
