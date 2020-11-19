# HiarcSDK.Api.RetentionPolicyApi

All URIs are relative to *http://localhost:5000*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateRetentionPolicy**](RetentionPolicyApi.md#createretentionpolicy) | **POST** /retentionpolicies | Create a Retention Policy
[**FindRetentionPolicies**](RetentionPolicyApi.md#findretentionpolicies) | **POST** /retentionpolicies/find | Find a Retention Policy
[**GetAllRetentionPolicies**](RetentionPolicyApi.md#getallretentionpolicies) | **GET** /retentionpolicies | Get all Retention Policies
[**GetRetentionPolicy**](RetentionPolicyApi.md#getretentionpolicy) | **GET** /retentionpolicies/{key} | Get a Retention Policy&#39;s Info
[**UpdateRetentionPolicy**](RetentionPolicyApi.md#updateretentionpolicy) | **PUT** /retentionpolicies/{key} | Update a Retention Policy


<a name="createretentionpolicy"></a>
# **CreateRetentionPolicy**
> RetentionPolicy CreateRetentionPolicy (CreateRetentionPolicyRequest createRetentionPolicyRequest)

Create a Retention Policy

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HiarcSDK.Api;
using HiarcSDK.Client;
using HiarcSDK.Model;

namespace Example
{
    public class CreateRetentionPolicyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:5000";
            // Configure API key authorization: AdminApiKeyAuth
            config.AddApiKey("X-Hiarc-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Hiarc-Api-Key", "Bearer");

            var apiInstance = new RetentionPolicyApi(config);
            var createRetentionPolicyRequest = new CreateRetentionPolicyRequest(); // CreateRetentionPolicyRequest | Retention Policy information

            try
            {
                // Create a Retention Policy
                RetentionPolicy result = apiInstance.CreateRetentionPolicy(createRetentionPolicyRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RetentionPolicyApi.CreateRetentionPolicy: " + e.Message );
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
 **createRetentionPolicyRequest** | [**CreateRetentionPolicyRequest**](CreateRetentionPolicyRequest.md)| Retention Policy information | 

### Return type

[**RetentionPolicy**](RetentionPolicy.md)

### Authorization

[AdminApiKeyAuth](../README.md#AdminApiKeyAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | A Retention Policy object |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="findretentionpolicies"></a>
# **FindRetentionPolicies**
> List&lt;RetentionPolicy&gt; FindRetentionPolicies (FindRetentionPoliciesRequest findRetentionPoliciesRequest)

Find a Retention Policy

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HiarcSDK.Api;
using HiarcSDK.Client;
using HiarcSDK.Model;

namespace Example
{
    public class FindRetentionPoliciesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:5000";
            // Configure API key authorization: AdminApiKeyAuth
            config.AddApiKey("X-Hiarc-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Hiarc-Api-Key", "Bearer");

            var apiInstance = new RetentionPolicyApi(config);
            var findRetentionPoliciesRequest = new FindRetentionPoliciesRequest(); // FindRetentionPoliciesRequest | Retention Policy query

            try
            {
                // Find a Retention Policy
                List<RetentionPolicy> result = apiInstance.FindRetentionPolicies(findRetentionPoliciesRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RetentionPolicyApi.FindRetentionPolicies: " + e.Message );
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
 **findRetentionPoliciesRequest** | [**FindRetentionPoliciesRequest**](FindRetentionPoliciesRequest.md)| Retention Policy query | 

### Return type

[**List&lt;RetentionPolicy&gt;**](RetentionPolicy.md)

### Authorization

[AdminApiKeyAuth](../README.md#AdminApiKeyAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A list of Retention Policy objects |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getallretentionpolicies"></a>
# **GetAllRetentionPolicies**
> List&lt;RetentionPolicy&gt; GetAllRetentionPolicies ()

Get all Retention Policies

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HiarcSDK.Api;
using HiarcSDK.Client;
using HiarcSDK.Model;

namespace Example
{
    public class GetAllRetentionPoliciesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:5000";
            // Configure API key authorization: AdminApiKeyAuth
            config.AddApiKey("X-Hiarc-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Hiarc-Api-Key", "Bearer");

            var apiInstance = new RetentionPolicyApi(config);

            try
            {
                // Get all Retention Policies
                List<RetentionPolicy> result = apiInstance.GetAllRetentionPolicies();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RetentionPolicyApi.GetAllRetentionPolicies: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List&lt;RetentionPolicy&gt;**](RetentionPolicy.md)

### Authorization

[AdminApiKeyAuth](../README.md#AdminApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A list of Retention Policy objects |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getretentionpolicy"></a>
# **GetRetentionPolicy**
> RetentionPolicy GetRetentionPolicy (string key)

Get a Retention Policy's Info

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HiarcSDK.Api;
using HiarcSDK.Client;
using HiarcSDK.Model;

namespace Example
{
    public class GetRetentionPolicyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:5000";
            // Configure API key authorization: AdminApiKeyAuth
            config.AddApiKey("X-Hiarc-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Hiarc-Api-Key", "Bearer");

            var apiInstance = new RetentionPolicyApi(config);
            var key = key_example;  // string | Key of Retention Policy to get info

            try
            {
                // Get a Retention Policy's Info
                RetentionPolicy result = apiInstance.GetRetentionPolicy(key);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RetentionPolicyApi.GetRetentionPolicy: " + e.Message );
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
 **key** | **string**| Key of Retention Policy to get info | 

### Return type

[**RetentionPolicy**](RetentionPolicy.md)

### Authorization

[AdminApiKeyAuth](../README.md#AdminApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A Retention Policy object |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateretentionpolicy"></a>
# **UpdateRetentionPolicy**
> RetentionPolicy UpdateRetentionPolicy (string key, UpdateRetentionPolicyRequest updateRetentionPolicyRequest)

Update a Retention Policy

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HiarcSDK.Api;
using HiarcSDK.Client;
using HiarcSDK.Model;

namespace Example
{
    public class UpdateRetentionPolicyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:5000";
            // Configure API key authorization: AdminApiKeyAuth
            config.AddApiKey("X-Hiarc-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Hiarc-Api-Key", "Bearer");

            var apiInstance = new RetentionPolicyApi(config);
            var key = key_example;  // string | Key of Retention Policy to update
            var updateRetentionPolicyRequest = new UpdateRetentionPolicyRequest(); // UpdateRetentionPolicyRequest | RetentionPolicy information

            try
            {
                // Update a Retention Policy
                RetentionPolicy result = apiInstance.UpdateRetentionPolicy(key, updateRetentionPolicyRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RetentionPolicyApi.UpdateRetentionPolicy: " + e.Message );
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
 **key** | **string**| Key of Retention Policy to update | 
 **updateRetentionPolicyRequest** | [**UpdateRetentionPolicyRequest**](UpdateRetentionPolicyRequest.md)| RetentionPolicy information | 

### Return type

[**RetentionPolicy**](RetentionPolicy.md)

### Authorization

[AdminApiKeyAuth](../README.md#AdminApiKeyAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A Retention Policy object |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

