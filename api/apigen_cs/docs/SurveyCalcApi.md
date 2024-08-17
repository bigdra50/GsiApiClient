# GsiApi.Api.SurveyCalcApi

All URIs are relative to *https://vldb.gsi.go.jp/sokuchi/surveycalc*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**SurveycalcBl2stCalcPlGet**](SurveyCalcApi.md#surveycalcbl2stcalcplget) | **GET** /surveycalc/bl2st_calc.pl | 距離と方位角の計算 |
| [**SurveycalcBl2xyPlGet**](SurveyCalcApi.md#surveycalcbl2xyplget) | **GET** /surveycalc/bl2xy.pl | 平面直角座標への換算 |
| [**SurveycalcTransPlGet**](SurveyCalcApi.md#surveycalctransplget) | **GET** /surveycalc/trans.pl | 緯度・経度と地心直交座標の相互換算 |
| [**SurveycalcXy2blPlGet**](SurveyCalcApi.md#surveycalcxy2blplget) | **GET** /surveycalc/xy2bl.pl | 緯度・経度への換算 |
| [**SurveycalcXy2stPlGet**](SurveyCalcApi.md#surveycalcxy2stplget) | **GET** /surveycalc/xy2st.pl | 距離と方向角の計算 |

<a id="surveycalcbl2stcalcplget"></a>
# **SurveycalcBl2stCalcPlGet**
> SurveycalcBl2stCalcPlGet200Response SurveycalcBl2stCalcPlGet (string outputType, string ellipsoid, double latitude1, double longitude1, double latitude2, double longitude2)

距離と方位角の計算

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using GsiApi.Api;
using GsiApi.Client;
using GsiApi.Model;

namespace Example
{
    public class SurveycalcBl2stCalcPlGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://vldb.gsi.go.jp/sokuchi/surveycalc";
            var apiInstance = new SurveyCalcApi(config);
            var outputType = "xml";  // string | 
            var ellipsoid = "GRS80";  // string | 
            var latitude1 = 1.2D;  // double | 
            var longitude1 = 1.2D;  // double | 
            var latitude2 = 1.2D;  // double | 
            var longitude2 = 1.2D;  // double | 

            try
            {
                // 距離と方位角の計算
                SurveycalcBl2stCalcPlGet200Response result = apiInstance.SurveycalcBl2stCalcPlGet(outputType, ellipsoid, latitude1, longitude1, latitude2, longitude2);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SurveyCalcApi.SurveycalcBl2stCalcPlGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SurveycalcBl2stCalcPlGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 距離と方位角の計算
    ApiResponse<SurveycalcBl2stCalcPlGet200Response> response = apiInstance.SurveycalcBl2stCalcPlGetWithHttpInfo(outputType, ellipsoid, latitude1, longitude1, latitude2, longitude2);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SurveyCalcApi.SurveycalcBl2stCalcPlGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **outputType** | **string** |  |  |
| **ellipsoid** | **string** |  |  |
| **latitude1** | **double** |  |  |
| **longitude1** | **double** |  |  |
| **latitude2** | **double** |  |  |
| **longitude2** | **double** |  |  |

### Return type

[**SurveycalcBl2stCalcPlGet200Response**](SurveycalcBl2stCalcPlGet200Response.md)

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

<a id="surveycalcbl2xyplget"></a>
# **SurveycalcBl2xyPlGet**
> SurveycalcBl2xyPlGet200Response SurveycalcBl2xyPlGet (string outputType, int refFrame, double latitude, double longitude, int? zone = null)

平面直角座標への換算

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using GsiApi.Api;
using GsiApi.Client;
using GsiApi.Model;

namespace Example
{
    public class SurveycalcBl2xyPlGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://vldb.gsi.go.jp/sokuchi/surveycalc";
            var apiInstance = new SurveyCalcApi(config);
            var outputType = "xml";  // string | 
            var refFrame = 1;  // int | 
            var latitude = 1.2D;  // double | 
            var longitude = 1.2D;  // double | 
            var zone = 56;  // int? |  (optional) 

            try
            {
                // 平面直角座標への換算
                SurveycalcBl2xyPlGet200Response result = apiInstance.SurveycalcBl2xyPlGet(outputType, refFrame, latitude, longitude, zone);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SurveyCalcApi.SurveycalcBl2xyPlGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SurveycalcBl2xyPlGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 平面直角座標への換算
    ApiResponse<SurveycalcBl2xyPlGet200Response> response = apiInstance.SurveycalcBl2xyPlGetWithHttpInfo(outputType, refFrame, latitude, longitude, zone);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SurveyCalcApi.SurveycalcBl2xyPlGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **outputType** | **string** |  |  |
| **refFrame** | **int** |  |  |
| **latitude** | **double** |  |  |
| **longitude** | **double** |  |  |
| **zone** | **int?** |  | [optional]  |

### Return type

[**SurveycalcBl2xyPlGet200Response**](SurveycalcBl2xyPlGet200Response.md)

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

<a id="surveycalctransplget"></a>
# **SurveycalcTransPlGet**
> SurveycalcTransPlGet200Response SurveycalcTransPlGet (string outputType, int cnvType, double latitude, double longitude, float? altitude = null, float? geoidHeight = null, double? geocentricX = null, double? geocentricY = null, double? geocentricZ = null)

緯度・経度と地心直交座標の相互換算

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using GsiApi.Api;
using GsiApi.Client;
using GsiApi.Model;

namespace Example
{
    public class SurveycalcTransPlGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://vldb.gsi.go.jp/sokuchi/surveycalc";
            var apiInstance = new SurveyCalcApi(config);
            var outputType = "xml";  // string | 
            var cnvType = 0;  // int | 
            var latitude = 1.2D;  // double | 
            var longitude = 1.2D;  // double | 
            var altitude = 3.4F;  // float? |  (optional) 
            var geoidHeight = 3.4F;  // float? |  (optional) 
            var geocentricX = 1.2D;  // double? |  (optional) 
            var geocentricY = 1.2D;  // double? |  (optional) 
            var geocentricZ = 1.2D;  // double? |  (optional) 

            try
            {
                // 緯度・経度と地心直交座標の相互換算
                SurveycalcTransPlGet200Response result = apiInstance.SurveycalcTransPlGet(outputType, cnvType, latitude, longitude, altitude, geoidHeight, geocentricX, geocentricY, geocentricZ);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SurveyCalcApi.SurveycalcTransPlGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SurveycalcTransPlGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 緯度・経度と地心直交座標の相互換算
    ApiResponse<SurveycalcTransPlGet200Response> response = apiInstance.SurveycalcTransPlGetWithHttpInfo(outputType, cnvType, latitude, longitude, altitude, geoidHeight, geocentricX, geocentricY, geocentricZ);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SurveyCalcApi.SurveycalcTransPlGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **outputType** | **string** |  |  |
| **cnvType** | **int** |  |  |
| **latitude** | **double** |  |  |
| **longitude** | **double** |  |  |
| **altitude** | **float?** |  | [optional]  |
| **geoidHeight** | **float?** |  | [optional]  |
| **geocentricX** | **double?** |  | [optional]  |
| **geocentricY** | **double?** |  | [optional]  |
| **geocentricZ** | **double?** |  | [optional]  |

### Return type

[**SurveycalcTransPlGet200Response**](SurveycalcTransPlGet200Response.md)

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

<a id="surveycalcxy2blplget"></a>
# **SurveycalcXy2blPlGet**
> SurveycalcXy2blPlGet200Response SurveycalcXy2blPlGet (string outputType, int refFrame, int? zone = null, double? publicX = null, double? publicY = null)

緯度・経度への換算

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using GsiApi.Api;
using GsiApi.Client;
using GsiApi.Model;

namespace Example
{
    public class SurveycalcXy2blPlGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://vldb.gsi.go.jp/sokuchi/surveycalc";
            var apiInstance = new SurveyCalcApi(config);
            var outputType = "xml";  // string | 
            var refFrame = 1;  // int | 
            var zone = 56;  // int? |  (optional) 
            var publicX = 1.2D;  // double? |  (optional) 
            var publicY = 1.2D;  // double? |  (optional) 

            try
            {
                // 緯度・経度への換算
                SurveycalcXy2blPlGet200Response result = apiInstance.SurveycalcXy2blPlGet(outputType, refFrame, zone, publicX, publicY);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SurveyCalcApi.SurveycalcXy2blPlGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SurveycalcXy2blPlGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 緯度・経度への換算
    ApiResponse<SurveycalcXy2blPlGet200Response> response = apiInstance.SurveycalcXy2blPlGetWithHttpInfo(outputType, refFrame, zone, publicX, publicY);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SurveyCalcApi.SurveycalcXy2blPlGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **outputType** | **string** |  |  |
| **refFrame** | **int** |  |  |
| **zone** | **int?** |  | [optional]  |
| **publicX** | **double?** |  | [optional]  |
| **publicY** | **double?** |  | [optional]  |

### Return type

[**SurveycalcXy2blPlGet200Response**](SurveycalcXy2blPlGet200Response.md)

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

<a id="surveycalcxy2stplget"></a>
# **SurveycalcXy2stPlGet**
> SurveycalcXy2stPlGet200Response SurveycalcXy2stPlGet (string outputType, int refFrame, double publicX1, double publicY1, double publicX2, double publicY2, int? zone = null)

距離と方向角の計算

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using GsiApi.Api;
using GsiApi.Client;
using GsiApi.Model;

namespace Example
{
    public class SurveycalcXy2stPlGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://vldb.gsi.go.jp/sokuchi/surveycalc";
            var apiInstance = new SurveyCalcApi(config);
            var outputType = "xml";  // string | 
            var refFrame = 1;  // int | 
            var publicX1 = 1.2D;  // double | 
            var publicY1 = 1.2D;  // double | 
            var publicX2 = 1.2D;  // double | 
            var publicY2 = 1.2D;  // double | 
            var zone = 56;  // int? |  (optional) 

            try
            {
                // 距離と方向角の計算
                SurveycalcXy2stPlGet200Response result = apiInstance.SurveycalcXy2stPlGet(outputType, refFrame, publicX1, publicY1, publicX2, publicY2, zone);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SurveyCalcApi.SurveycalcXy2stPlGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SurveycalcXy2stPlGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 距離と方向角の計算
    ApiResponse<SurveycalcXy2stPlGet200Response> response = apiInstance.SurveycalcXy2stPlGetWithHttpInfo(outputType, refFrame, publicX1, publicY1, publicX2, publicY2, zone);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SurveyCalcApi.SurveycalcXy2stPlGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **outputType** | **string** |  |  |
| **refFrame** | **int** |  |  |
| **publicX1** | **double** |  |  |
| **publicY1** | **double** |  |  |
| **publicX2** | **double** |  |  |
| **publicY2** | **double** |  |  |
| **zone** | **int?** |  | [optional]  |

### Return type

[**SurveycalcXy2stPlGet200Response**](SurveycalcXy2stPlGet200Response.md)

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

