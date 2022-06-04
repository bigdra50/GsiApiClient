using Cysharp.Threading.Tasks;
using GsiApiClient.Runtime.Requests;

namespace GsiApiClient.Runtime
{
    /// <summary>
    /// 国土地理院(Geospatial Information Authority)のAPIクライアント
    /// 同一IPアドレスからのリクエストは､ 10秒間で10回(ただしTKY2JGDとPatchJGDは負荷が大きいため10秒間で3回)まで
    /// </summary>
    public static class GsiClient
    {
        /// <summary>
        /// 指定した地点の住所を取得する
        /// </summary>
        /// <param name="latitude">緯度</param>
        /// <param name="longitude">経度</param>
        /// <returns>住所</returns>
        public static async UniTask<Address> RequestLonLat2AddressAsync(double latitude, double longitude) =>
            await AddressRequest.GetAsync(latitude, longitude);

        /// <summary>
        /// 指定した地点のジオイド高を取得する｡
        /// </summary>
        /// <param name="latitude"></param>
        /// <param name="longitude"></param>
        /// <returns></returns>
        public static async UniTask<double> RequestGeoidHeight(double latitude, double longitude) =>
            await GeoidRequest.GetAsync(latitude, longitude);

        /// <summary>
        /// 2点間の距離(meter)を求める
        /// </summary>
        /// <param name="fromLat"></param>
        /// <param name="fromLgt"></param>
        /// <param name="toLat"></param>
        /// <param name="toLgt"></param>
        /// <param name="ellipsoid"></param>
        /// <returns></returns>
        public static async UniTask<DistanceResponse> RequestDistanceAsync(
            double fromLat, double fromLgt, double toLat, double toLgt,
            Ellipsoid ellipsoid = Ellipsoid.Grs80) =>
            await DistanceRequest.GetAsync(fromLat, fromLgt, toLat, toLgt);
    }
}