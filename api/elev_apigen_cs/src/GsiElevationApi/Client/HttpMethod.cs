/*
 * 国土地理院標高API
 *
 * 指定した緯度経度の位置の標高値を取得するAPIです。 2013年3月14日より試験公開されています。  ## リクエストレート制限 サーバに過度の負担を与えないでください。過度の負担を与えると判断したアクセスについて、 国土地理院は予告なく遮断を行う場合があります。具体的な制限値は公開されていませんが、 アプリケーションの設計時には適切なレート制限を実装することを強く推奨します。 
 *
 * The version of the OpenAPI document: 1.0.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


namespace GsiElevationApi.Client
{
    /// <summary>
    /// Http methods supported by swagger
    /// </summary>
    public enum HttpMethod
    {
        /// <summary>HTTP GET request.</summary>
        Get,
        /// <summary>HTTP POST request.</summary>
        Post,
        /// <summary>HTTP PUT request.</summary>
        Put,
        /// <summary>HTTP DELETE request.</summary>
        Delete,
        /// <summary>HTTP HEAD request.</summary>
        Head,
        /// <summary>HTTP OPTIONS request.</summary>
        Options,
        /// <summary>HTTP PATCH request.</summary>
        Patch
    }
}
