using System.Threading;
using Cysharp.Threading.Tasks;
using GsiApiClient.Runtime.Requests;

namespace GsiApiClient.Runtime
{
    /// <summary>
    /// 国土地理院(Geospatial Information Authority)のAPIクライアント
    /// 同一IPアドレスからのリクエストは､ 10秒間で10回(ただしTKY2JGDとPatchJGDは負荷が大きいため10秒間で3回)まで
    /// </summary>
    public class GsiClient
    {
        public static GsiClient Instance => _instance ??= new GsiClient();
        private static GsiClient _instance;
        private readonly AddressRequest _addressRequest = new();

        /// <summary>
        /// 指定した地点の住所を取得する
        /// </summary>
        /// <param name="latitude">緯度</param>
        /// <param name="longitude">経度</param>
        /// <returns>住所</returns>
        public async UniTask<(bool ok, Address value)> RequestLonLat2AddressAsync(double latitude, double longitude) =>
            await _addressRequest.GetAsync(latitude, longitude);

    }
}