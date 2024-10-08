/*
 * 国土地理院標高API
 *
 * 指定した緯度経度の位置の標高値を取得するAPIです。 2013年3月14日より試験公開されています。  ## リクエストレート制限 サーバに過度の負担を与えないでください。過度の負担を与えると判断したアクセスについて、 国土地理院は予告なく遮断を行う場合があります。具体的な制限値は公開されていませんが、 アプリケーションの設計時には適切なレート制限を実装することを強く推奨します。 
 *
 * The version of the OpenAPI document: 1.0.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;

namespace GsiElevationApi.Client
{
    /// <summary>
    /// A delegate to ExceptionFactory method
    /// </summary>
    /// <param name="methodName">Method name</param>
    /// <param name="response">Response</param>
    /// <returns>Exceptions</returns>
    public delegate Exception ExceptionFactory(string methodName, IApiResponse response);
}
