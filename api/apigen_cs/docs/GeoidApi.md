# GsiApi.Api.GeoidApi

All URIs are relative to *https://vldb.gsi.go.jp/sokuchi/surveycalc*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GeoidCalcghCgiGeoidcalcPlGet**](GeoidApi.md#geoidcalcghcgigeoidcalcplget) | **GET** /geoid/calcgh/cgi/geoidcalc.pl | ジオイド高 |

<a id="geoidcalcghcgigeoidcalcplget"></a>
# **GeoidCalcghCgiGeoidcalcPlGet**
> GeoidCalcghCgiGeoidcalcPlGet200Response GeoidCalcghCgiGeoidcalcPlGet (string outputType, double latitude, double longitude)

ジオイド高

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using GsiApi.Api;
using GsiApi.Client;
using GsiApi.Model;

namespace Example
{
    public class GeoidCalcghCgiGeoidcalcPlGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://vldb.gsi.go.jp/sokuchi/surveycalc";
            var apiInstance = new GeoidApi(config);
            var outputType = "xml";  // string | 
            var latitude = 1.2D;  // double | 
            var longitude = 1.2D;  // double | 

            try
            {
                // ジオイド高
                GeoidCalcghCgiGeoidcalcPlGet200Response result = apiInstance.GeoidCalcghCgiGeoidcalcPlGet(outputType, latitude, longitude);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GeoidApi.GeoidCalcghCgiGeoidcalcPlGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GeoidCalcghCgiGeoidcalcPlGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // ジオイド高
    ApiResponse<GeoidCalcghCgiGeoidcalcPlGet200Response> response = apiInstance.GeoidCalcghCgiGeoidcalcPlGetWithHttpInfo(outputType, latitude, longitude);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling GeoidApi.GeoidCalcghCgiGeoidcalcPlGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **outputType** | **string** |  |  |
| **latitude** | **double** |  |  |
| **longitude** | **double** |  |  |

### Return type

[**GeoidCalcghCgiGeoidcalcPlGet200Response**](GeoidCalcghCgiGeoidcalcPlGet200Response.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | 成功 |  -  |
| **400** | リクエストパラメータが不正 |  -  |
| **500** | サーバー内部エラー |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

