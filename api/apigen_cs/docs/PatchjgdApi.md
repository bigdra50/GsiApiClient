# GsiApi.Api.PatchjgdApi

All URIs are relative to *https://vldb.gsi.go.jp/sokuchi/surveycalc*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**PatchjgdHPatchjgdPhpGet**](PatchjgdApi.md#patchjgdhpatchjgdphpget) | **GET** /patchjgd_h/patchjgd.php | PatchJGD（標高版） |
| [**PatchjgdPatchjgdPhpGet**](PatchjgdApi.md#patchjgdpatchjgdphpget) | **GET** /patchjgd/patchjgd.php | PatchJGD |

<a id="patchjgdhpatchjgdphpget"></a>
# **PatchjgdHPatchjgdPhpGet**
> Object PatchjgdHPatchjgdPhpGet (string outputType, string chiiki, int sokuchi, int place, double latitude, double longitude, float? altitude1 = null, int? zone = null, double? publicX = null, double? publicY = null, float? altitude2 = null)

PatchJGD（標高版）

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using GsiApi.Api;
using GsiApi.Client;
using GsiApi.Model;

namespace Example
{
    public class PatchjgdHPatchjgdPhpGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://vldb.gsi.go.jp/sokuchi/surveycalc";
            var apiInstance = new PatchjgdApi(config);
            var outputType = "xml";  // string | 
            var chiiki = "chiiki_example";  // string | 
            var sokuchi = 0;  // int | 
            var place = 0;  // int | 
            var latitude = 1.2D;  // double | 
            var longitude = 1.2D;  // double | 
            var altitude1 = 3.4F;  // float? |  (optional) 
            var zone = 56;  // int? |  (optional) 
            var publicX = 1.2D;  // double? |  (optional) 
            var publicY = 1.2D;  // double? |  (optional) 
            var altitude2 = 3.4F;  // float? |  (optional) 

            try
            {
                // PatchJGD（標高版）
                Object result = apiInstance.PatchjgdHPatchjgdPhpGet(outputType, chiiki, sokuchi, place, latitude, longitude, altitude1, zone, publicX, publicY, altitude2);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PatchjgdApi.PatchjgdHPatchjgdPhpGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PatchjgdHPatchjgdPhpGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // PatchJGD（標高版）
    ApiResponse<Object> response = apiInstance.PatchjgdHPatchjgdPhpGetWithHttpInfo(outputType, chiiki, sokuchi, place, latitude, longitude, altitude1, zone, publicX, publicY, altitude2);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PatchjgdApi.PatchjgdHPatchjgdPhpGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **outputType** | **string** |  |  |
| **chiiki** | **string** |  |  |
| **sokuchi** | **int** |  |  |
| **place** | **int** |  |  |
| **latitude** | **double** |  |  |
| **longitude** | **double** |  |  |
| **altitude1** | **float?** |  | [optional]  |
| **zone** | **int?** |  | [optional]  |
| **publicX** | **double?** |  | [optional]  |
| **publicY** | **double?** |  | [optional]  |
| **altitude2** | **float?** |  | [optional]  |

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

<a id="patchjgdpatchjgdphpget"></a>
# **PatchjgdPatchjgdPhpGet**
> Object PatchjgdPatchjgdPhpGet (string outputType, string chiiki, int sokuchi, int place, double latitude, double longitude, int? zone = null, double? publicX = null, double? publicY = null)

PatchJGD

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using GsiApi.Api;
using GsiApi.Client;
using GsiApi.Model;

namespace Example
{
    public class PatchjgdPatchjgdPhpGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://vldb.gsi.go.jp/sokuchi/surveycalc";
            var apiInstance = new PatchjgdApi(config);
            var outputType = "xml";  // string | 
            var chiiki = "chiiki_example";  // string | 
            var sokuchi = 0;  // int | 
            var place = 0;  // int | 
            var latitude = 1.2D;  // double | 
            var longitude = 1.2D;  // double | 
            var zone = 56;  // int? |  (optional) 
            var publicX = 1.2D;  // double? |  (optional) 
            var publicY = 1.2D;  // double? |  (optional) 

            try
            {
                // PatchJGD
                Object result = apiInstance.PatchjgdPatchjgdPhpGet(outputType, chiiki, sokuchi, place, latitude, longitude, zone, publicX, publicY);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PatchjgdApi.PatchjgdPatchjgdPhpGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PatchjgdPatchjgdPhpGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // PatchJGD
    ApiResponse<Object> response = apiInstance.PatchjgdPatchjgdPhpGetWithHttpInfo(outputType, chiiki, sokuchi, place, latitude, longitude, zone, publicX, publicY);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PatchjgdApi.PatchjgdPatchjgdPhpGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **outputType** | **string** |  |  |
| **chiiki** | **string** |  |  |
| **sokuchi** | **int** |  |  |
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

