# GsiElevationApi.Api.ElevationApi

All URIs are relative to *https://cyberjapandata2.gsi.go.jp/general/dem/scripts*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetelevationPhpGet**](ElevationApi.md#getelevationphpget) | **GET** /getelevation.php | 標高値を取得 |

<a id="getelevationphpget"></a>
# **GetelevationPhpGet**
> GetelevationPhpGet200Response GetelevationPhpGet (double lon, double lat, string outtype = null)

標高値を取得

指定した緯度経度の位置の標高値を取得します。

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using GsiElevationApi.Api;
using GsiElevationApi.Client;
using GsiElevationApi.Model;

namespace Example
{
    public class GetelevationPhpGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://cyberjapandata2.gsi.go.jp/general/dem/scripts";
            var apiInstance = new ElevationApi(config);
            var lon = 1.2D;  // double | 経度（度の10進法）
            var lat = 1.2D;  // double | 緯度（度の10進法）
            var outtype = "JSON";  // string | アウトプットの形式 (optional) 

            try
            {
                // 標高値を取得
                GetelevationPhpGet200Response result = apiInstance.GetelevationPhpGet(lon, lat, outtype);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ElevationApi.GetelevationPhpGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetelevationPhpGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 標高値を取得
    ApiResponse<GetelevationPhpGet200Response> response = apiInstance.GetelevationPhpGetWithHttpInfo(lon, lat, outtype);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ElevationApi.GetelevationPhpGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **lon** | **double** | 経度（度の10進法） |  |
| **lat** | **double** | 緯度（度の10進法） |  |
| **outtype** | **string** | アウトプットの形式 | [optional]  |

### Return type

[**GetelevationPhpGet200Response**](GetelevationPhpGet200Response.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/javascript


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | 正常なレスポンス |  -  |
| **400** | 不正なリクエスト |  -  |
| **429** | リクエスト数が多すぎます。しばらく時間をおいてから再試行してください。 |  -  |
| **500** | サーバーエラー |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

