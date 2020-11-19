# HiarcSDK.Api.ClassificationApi

All URIs are relative to *http://localhost:5000*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateClassification**](ClassificationApi.md#createclassification) | **POST** /classifications | Create a Classification
[**DeleteClassification**](ClassificationApi.md#deleteclassification) | **DELETE** /classifications/{key} | Delete a Classification
[**FindClassification**](ClassificationApi.md#findclassification) | **POST** /classifications/find | Find a Classification
[**GetAllClassifications**](ClassificationApi.md#getallclassifications) | **GET** /classifications | Get all Classifications
[**GetClassification**](ClassificationApi.md#getclassification) | **GET** /classifications/{key} | Get a Classification&#39;s Info
[**UpdateClassification**](ClassificationApi.md#updateclassification) | **PUT** /classifications/{key} | Update a Classification


<a name="createclassification"></a>
# **CreateClassification**
> Classification CreateClassification (CreateClassificationRequest createClassificationRequest, string xHiarcUserKey = null)

Create a Classification

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HiarcSDK.Api;
using HiarcSDK.Client;
using HiarcSDK.Model;

namespace Example
{
    public class CreateClassificationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:5000";
            // Configure API key authorization: AdminApiKeyAuth
            config.AddApiKey("X-Hiarc-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Hiarc-Api-Key", "Bearer");

            var apiInstance = new ClassificationApi(config);
            var createClassificationRequest = new CreateClassificationRequest(); // CreateClassificationRequest | Classification information
            var xHiarcUserKey = xHiarcUserKey_example;  // string | Optional key of user to impersonate (optional) 

            try
            {
                // Create a Classification
                Classification result = apiInstance.CreateClassification(createClassificationRequest, xHiarcUserKey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ClassificationApi.CreateClassification: " + e.Message );
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
 **createClassificationRequest** | [**CreateClassificationRequest**](CreateClassificationRequest.md)| Classification information | 
 **xHiarcUserKey** | **string**| Optional key of user to impersonate | [optional] 

### Return type

[**Classification**](Classification.md)

### Authorization

[AdminApiKeyAuth](../README.md#AdminApiKeyAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | A Classification object |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteclassification"></a>
# **DeleteClassification**
> Object DeleteClassification (string key, string xHiarcUserKey = null)

Delete a Classification

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HiarcSDK.Api;
using HiarcSDK.Client;
using HiarcSDK.Model;

namespace Example
{
    public class DeleteClassificationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:5000";
            // Configure API key authorization: AdminApiKeyAuth
            config.AddApiKey("X-Hiarc-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Hiarc-Api-Key", "Bearer");

            var apiInstance = new ClassificationApi(config);
            var key = key_example;  // string | Key of Classification to delete
            var xHiarcUserKey = xHiarcUserKey_example;  // string | Optional key of user to impersonate (optional) 

            try
            {
                // Delete a Classification
                Object result = apiInstance.DeleteClassification(key, xHiarcUserKey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ClassificationApi.DeleteClassification: " + e.Message );
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
 **key** | **string**| Key of Classification to delete | 
 **xHiarcUserKey** | **string**| Optional key of user to impersonate | [optional] 

### Return type

**Object**

### Authorization

[AdminApiKeyAuth](../README.md#AdminApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Empty response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="findclassification"></a>
# **FindClassification**
> List&lt;Classification&gt; FindClassification (FindClassificationsRequest findClassificationsRequest, string xHiarcUserKey = null)

Find a Classification

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HiarcSDK.Api;
using HiarcSDK.Client;
using HiarcSDK.Model;

namespace Example
{
    public class FindClassificationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:5000";
            // Configure API key authorization: AdminApiKeyAuth
            config.AddApiKey("X-Hiarc-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Hiarc-Api-Key", "Bearer");

            var apiInstance = new ClassificationApi(config);
            var findClassificationsRequest = new FindClassificationsRequest(); // FindClassificationsRequest | Classification query
            var xHiarcUserKey = xHiarcUserKey_example;  // string | Optional key of user to impersonate (optional) 

            try
            {
                // Find a Classification
                List<Classification> result = apiInstance.FindClassification(findClassificationsRequest, xHiarcUserKey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ClassificationApi.FindClassification: " + e.Message );
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
 **findClassificationsRequest** | [**FindClassificationsRequest**](FindClassificationsRequest.md)| Classification query | 
 **xHiarcUserKey** | **string**| Optional key of user to impersonate | [optional] 

### Return type

[**List&lt;Classification&gt;**](Classification.md)

### Authorization

[AdminApiKeyAuth](../README.md#AdminApiKeyAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A list of Classification objects |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getallclassifications"></a>
# **GetAllClassifications**
> List&lt;Classification&gt; GetAllClassifications (string xHiarcUserKey = null)

Get all Classifications

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HiarcSDK.Api;
using HiarcSDK.Client;
using HiarcSDK.Model;

namespace Example
{
    public class GetAllClassificationsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:5000";
            // Configure API key authorization: AdminApiKeyAuth
            config.AddApiKey("X-Hiarc-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Hiarc-Api-Key", "Bearer");

            var apiInstance = new ClassificationApi(config);
            var xHiarcUserKey = xHiarcUserKey_example;  // string | Optional key of user to impersonate (optional) 

            try
            {
                // Get all Classifications
                List<Classification> result = apiInstance.GetAllClassifications(xHiarcUserKey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ClassificationApi.GetAllClassifications: " + e.Message );
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
 **xHiarcUserKey** | **string**| Optional key of user to impersonate | [optional] 

### Return type

[**List&lt;Classification&gt;**](Classification.md)

### Authorization

[AdminApiKeyAuth](../README.md#AdminApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A list of Classification objects |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getclassification"></a>
# **GetClassification**
> Classification GetClassification (string key, string xHiarcUserKey = null)

Get a Classification's Info

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HiarcSDK.Api;
using HiarcSDK.Client;
using HiarcSDK.Model;

namespace Example
{
    public class GetClassificationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:5000";
            // Configure API key authorization: AdminApiKeyAuth
            config.AddApiKey("X-Hiarc-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Hiarc-Api-Key", "Bearer");

            var apiInstance = new ClassificationApi(config);
            var key = key_example;  // string | Key of Classification to get info
            var xHiarcUserKey = xHiarcUserKey_example;  // string | Optional key of user to impersonate (optional) 

            try
            {
                // Get a Classification's Info
                Classification result = apiInstance.GetClassification(key, xHiarcUserKey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ClassificationApi.GetClassification: " + e.Message );
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
 **key** | **string**| Key of Classification to get info | 
 **xHiarcUserKey** | **string**| Optional key of user to impersonate | [optional] 

### Return type

[**Classification**](Classification.md)

### Authorization

[AdminApiKeyAuth](../README.md#AdminApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A Classification object |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateclassification"></a>
# **UpdateClassification**
> Classification UpdateClassification (string key, UpdateClassificationRequest updateClassificationRequest, string xHiarcUserKey = null)

Update a Classification

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HiarcSDK.Api;
using HiarcSDK.Client;
using HiarcSDK.Model;

namespace Example
{
    public class UpdateClassificationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:5000";
            // Configure API key authorization: AdminApiKeyAuth
            config.AddApiKey("X-Hiarc-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Hiarc-Api-Key", "Bearer");

            var apiInstance = new ClassificationApi(config);
            var key = key_example;  // string | Key of Classification to get info
            var updateClassificationRequest = new UpdateClassificationRequest(); // UpdateClassificationRequest | Classification information
            var xHiarcUserKey = xHiarcUserKey_example;  // string | Optional key of user to impersonate (optional) 

            try
            {
                // Update a Classification
                Classification result = apiInstance.UpdateClassification(key, updateClassificationRequest, xHiarcUserKey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ClassificationApi.UpdateClassification: " + e.Message );
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
 **key** | **string**| Key of Classification to get info | 
 **updateClassificationRequest** | [**UpdateClassificationRequest**](UpdateClassificationRequest.md)| Classification information | 
 **xHiarcUserKey** | **string**| Optional key of user to impersonate | [optional] 

### Return type

[**Classification**](Classification.md)

### Authorization

[AdminApiKeyAuth](../README.md#AdminApiKeyAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A Classification object |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

