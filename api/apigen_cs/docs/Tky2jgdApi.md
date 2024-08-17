# GsiApi.Api.Tky2jgdApi

All URIs are relative to *https://vldb.gsi.go.jp/sokuchi/surveycalc*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**Tky2jgdTky2jgdPlGet**](Tky2jgdApi.md#tky2jgdtky2jgdplget) | **GET** /tky2jgd/tky2jgd.pl | 世界測地系座標変換（TKY2JGD） |

<a id="tky2jgdtky2jgdplget"></a>
# **Tky2jgdTky2jgdPlGet**
> Object Tky2jgdTky2jgdPlGet (string outputType, int sokuti, int place, double latitude, double longitude, int? zone = null, double? publicX = null, double? publicY = null)

世界測地系座標変換（TKY2JGD）

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using GsiApi.Api;
using GsiApi.Client;
using GsiApi.Model;

namespace Example
{
    public class Tky2jgdTky2jgdPlGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://vldb.gsi.go.jp/sokuchi/surveycalc";
            var apiInstance = new Tky2jgdApi(config);
            var outputType = "xml";  // string | 
            var sokuti = 1;  // int | 
            var place = 1;  // int | 
            var latitude = 1.2D;  // double | 
            var longitude = 1.2D;  // double | 
            var zone = 56;  // int? |  (optional) 
            var publicX = 1.2D;  // double? |  (optional) 
            var publicY = 1.2D;  // double? |  (optional) 

            try
            {
                // 世界測地系座標変換（TKY2JGD）
                Object result = apiInstance.Tky2jgdTky2jgdPlGet(outputType, sokuti, place, latitude, longitude, zone, publicX, publicY);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Tky2jgdApi.Tky2jgdTky2jgdPlGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the Tky2jgdTky2jgdPlGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 世界測地系座標変換（TKY2JGD）
    ApiResponse<Object> response = apiInstance.Tky2jgdTky2jgdPlGetWithHttpInfo(outputType, sokuti, place, latitude, longitude, zone, publicX, publicY);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling Tky2jgdApi.Tky2jgdTky2jgdPlGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **outputType** | **string** |  |  |
| **sokuti** | **int** |  |  |
| **place** | **int** |  |  |
| **latitude** | **double** |  |  |
| **longitude** | **double** |  |  |
| **zone** | **int?** |  | [optional]  |
| **publicX** | **double?** |  | [optional]  |
| **publicY** | **double?** |  | [optional]  |

### Return type

**Object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/xml, application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | 成功 |  -  |
| **400** | リクエストパラメータが不正 |  -  |
| **500** | サーバー内部エラー |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

