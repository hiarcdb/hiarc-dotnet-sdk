# HiarcSDK.Api.FilesApi

All URIs are relative to *http://localhost:5000*

Method | HTTP request | Description
------------- | ------------- | -------------
[**FilterAllowedFiles**](FilesApi.md#filterallowedfiles) | **POST** /files/allowed | Filter a list of File keys that a User can access


<a name="filterallowedfiles"></a>
# **FilterAllowedFiles**
> List&lt;string&gt; FilterAllowedFiles (AllowedFilesRequest allowedFilesRequest, string xHiarcUserKey = null)

Filter a list of File keys that a User can access

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HiarcSDK.Api;
using HiarcSDK.Client;
using HiarcSDK.Model;

namespace Example
{
    public class FilterAllowedFilesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:5000";
            // Configure API key authorization: AdminApiKeyAuth
            config.AddApiKey("X-Hiarc-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Hiarc-Api-Key", "Bearer");

            var apiInstance = new FilesApi(config);
            var allowedFilesRequest = new AllowedFilesRequest(); // AllowedFilesRequest | File key list
            var xHiarcUserKey = xHiarcUserKey_example;  // string | Optional key of user to impersonate (optional) 

            try
            {
                // Filter a list of File keys that a User can access
                List<string> result = apiInstance.FilterAllowedFiles(allowedFilesRequest, xHiarcUserKey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FilesApi.FilterAllowedFiles: " + e.Message );
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
 **allowedFilesRequest** | [**AllowedFilesRequest**](AllowedFilesRequest.md)| File key list | 
 **xHiarcUserKey** | **string**| Optional key of user to impersonate | [optional] 

### Return type

**List<string>**

### Authorization

[AdminApiKeyAuth](../README.md#AdminApiKeyAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A list of File keys |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

