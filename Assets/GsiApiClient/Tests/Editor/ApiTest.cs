using System.Collections;
using Cysharp.Threading.Tasks;
using GsiApiClient.Runtime;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace GsiApiClient.Tests.Editor
{
    public class ApiTest
    {
        private static (double lat, double lgt, double geoid)[] _values =
        {
            (43.06417, 141.34694, 31.9865), // 北海道札幌市
            (35.68944, 139.69167, 37.0044), // 東京都新宿区
            (35.658584, 139.7454316, 36.5945), // 東京タワー
            (36.66069805149894, 138.53522707144214, 43.3085), // 群馬県吾妻郡中之条町入山(日本国道最高地点碑)
            (35.3607800273112, 138.7273941461917, 42.5080) // 富士山山頂
        };

        [UnityTest]
        public IEnumerator RequestGeoidTest([ValueSource(nameof(_values))] (double lat, double lgt, double geoid) value) =>
            UniTask.ToCoroutine(async () =>
            {
                var actualGeoid = await GsiClient.Instance.RequestGeoidHeight(value.lat, value.lgt);
                Assert.IsTrue(actualGeoid.ok);
                var delta = .00001d;
                Assert.AreEqual(value.geoid, actualGeoid.value, delta);
            });

        [UnityTest]
        public IEnumerator RequestAddressTest([ValueSource(nameof(_values))] (double lat, double lgt, double geoid) value) =>
            UniTask.ToCoroutine(async () =>
            {
                var result = await GsiClient.Instance.RequestLonLat2AddressAsync(value.lat, value.lgt);
                Assert.IsTrue(result.ok);
                Debug.Log($"{result.value.Prefecture},{result.value.City},{result.value.Lv01Nm}");
            });

        [UnityTest]
        public IEnumerator RequestDistanceTest([ValueSource(nameof(_values))] (double lat, double lgt, double geoid) value) =>
            UniTask.ToCoroutine(async () =>
            {
                var request = await GsiClient.Instance.RequestDistanceAsync(value.lat, value.lgt, 35.658584, 139.7454316);
                Assert.IsTrue(request.ok);
                Debug.Log($"{request.response.azimuth1},{request.response.azimuth2}, {request.response.geoLength}");
            });
    }
}