/*
 * 国土地理院標高API
 *
 * 指定した緯度経度の位置の標高値を取得するAPIです。 2013年3月14日より試験公開されています。  ## リクエストレート制限 サーバに過度の負担を与えないでください。過度の負担を与えると判断したアクセスについて、 国土地理院は予告なく遮断を行う場合があります。具体的な制限値は公開されていませんが、 アプリケーションの設計時には適切なレート制限を実装することを強く推奨します。 
 *
 * The version of the OpenAPI document: 1.0.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using Newtonsoft.Json.Converters;

namespace GsiElevationApi.Client
{
    /// <summary>
    /// Formatter for 'date' openapi formats ss defined by full-date - RFC3339
    /// see https://github.com/OAI/OpenAPI-Specification/blob/master/versions/3.0.0.md#data-types
    /// </summary>
    public class OpenAPIDateConverter : IsoDateTimeConverter
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OpenAPIDateConverter" /> class.
        /// </summary>
        public OpenAPIDateConverter()
        {
            // full-date   = date-fullyear "-" date-month "-" date-mday
            DateTimeFormat = "yyyy-MM-dd";
        }
    }
}
