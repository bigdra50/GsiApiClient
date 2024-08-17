# GsiApi.Api.GravityApi

All URIs are relative to *https://vldb.gsi.go.jp/sokuchi/surveycalc*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GsigraCalcApiGravityCalculationGet**](GravityApi.md#gsigracalcapigravitycalculationget) | **GET** /gsigra/calc/api/gravityCalculation | 重力値推定計算 |

<a id="gsigracalcapigravitycalculationget"></a>
# **GsigraCalcApiGravityCalculationGet**
> GsigraCalcApiGravityCalculationGet200Response GsigraCalcApiGravityCalculationGet (string unit, double lat, double lon, float dH)

重力値推定計算

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using GsiApi.Api;
using GsiApi.Client;
using GsiApi.Model;

namespace Example
{
    public class GsigraCalcApiGravityCalculationGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://vldb.gsi.go.jp/sokuchi/surveycalc";
            var apiInstance = new GravityApi(config);
            var unit = "DMS";  // string | 
            var lat = 1.2D;  // double | 
            var lon = 1.2D;  // double | 
            var dH = 3.4F;  // float | 

            try
            {
                // 重力値推定計算
                GsigraCalcApiGravityCalculationGet200Response result = apiInstance.GsigraCalcApiGravityCalculationGet(unit, lat, lon, dH);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GravityApi.GsigraCalcApiGravityCalculationGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GsigraCalcApiGravityCalculationGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 重力値推定計算
    ApiResponse<GsigraCalcApiGravityCalculationGet200Response> response = apiInstance.GsigraCalcApiGravityCalculationGetWithHttpInfo(unit, lat, lon, dH);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling GravityApi.GsigraCalcApiGravityCalculationGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **unit** | **string** |  |  |
| **lat** | **double** |  |  |
| **lon** | **double** |  |  |
| **dH** | **float** |  |  |

### Return type

[**GsigraCalcApiGravityCalculationGet200Response**](GsigraCalcApiGravityCalculationGet200Response.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | 成功 |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

