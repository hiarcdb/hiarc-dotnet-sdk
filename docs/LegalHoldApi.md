# HiarcSDK.Api.LegalHoldApi

All URIs are relative to *http://localhost:5000*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateLegalHold**](LegalHoldApi.md#createlegalhold) | **POST** /legalholds | Create a Legal Hold
[**GetLegalHold**](LegalHoldApi.md#getlegalhold) | **GET** /legalholds/{key} | Get a Legal Hold&#39;s Info


<a name="createlegalhold"></a>
# **CreateLegalHold**
> LegalHold CreateLegalHold (CreateLegalHoldRequest createLegalHoldRequest)

Create a Legal Hold

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HiarcSDK.Api;
using HiarcSDK.Client;
using HiarcSDK.Model;

namespace Example
{
    public class CreateLegalHoldExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:5000";
            // Configure API key authorization: AdminApiKeyAuth
            config.AddApiKey("X-Hiarc-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Hiarc-Api-Key", "Bearer");

            var apiInstance = new LegalHoldApi(config);
            var createLegalHoldRequest = new CreateLegalHoldRequest(); // CreateLegalHoldRequest | Legal Hold information

            try
            {
                // Create a Legal Hold
                LegalHold result = apiInstance.CreateLegalHold(createLegalHoldRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LegalHoldApi.CreateLegalHold: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **createLegalHoldRequest** | [**CreateLegalHoldRequest**](CreateLegalHoldRequest.md)| Legal Hold information | 

### Return type

[**LegalHold**](LegalHold.md)

### Authorization

[AdminApiKeyAuth](../README.md#AdminApiKeyAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | A Legal Hold object |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getlegalhold"></a>
# **GetLegalHold**
> LegalHold GetLegalHold (string key)

Get a Legal Hold's Info

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HiarcSDK.Api;
using HiarcSDK.Client;
using HiarcSDK.Model;

namespace Example
{
    public class GetLegalHoldExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:5000";
            // Configure API key authorization: AdminApiKeyAuth
            config.AddApiKey("X-Hiarc-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Hiarc-Api-Key", "Bearer");

            var apiInstance = new LegalHoldApi(config);
            var key = key_example;  // string | Key of Legal Hold to get info

            try
            {
                // Get a Legal Hold's Info
                LegalHold result = apiInstance.GetLegalHold(key);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LegalHoldApi.GetLegalHold: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **key** | **string**| Key of Legal Hold to get info | 

### Return type

[**LegalHold**](LegalHold.md)

### Authorization

[AdminApiKeyAuth](../README.md#AdminApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A Legal Hold object |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

