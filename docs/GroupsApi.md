# HiarcSDK.Api.GroupsApi

All URIs are relative to *http://localhost:5000*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetGroupsForUser**](GroupsApi.md#getgroupsforuser) | **GET** /users/{key}/groups | Get Groups for a User


<a name="getgroupsforuser"></a>
# **GetGroupsForUser**
> List&lt;Group&gt; GetGroupsForUser (string key, string xHiarcUserKey = null)

Get Groups for a User

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HiarcSDK.Api;
using HiarcSDK.Client;
using HiarcSDK.Model;

namespace Example
{
    public class GetGroupsForUserExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:5000";
            // Configure API key authorization: AdminApiKeyAuth
            config.AddApiKey("X-Hiarc-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Hiarc-Api-Key", "Bearer");

            var apiInstance = new GroupsApi(config);
            var key = key_example;  // string | Key of user
            var xHiarcUserKey = xHiarcUserKey_example;  // string |  (optional) 

            try
            {
                // Get Groups for a User
                List<Group> result = apiInstance.GetGroupsForUser(key, xHiarcUserKey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GroupsApi.GetGroupsForUser: " + e.Message );
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
 **key** | **string**| Key of user | 
 **xHiarcUserKey** | **string**|  | [optional] 

### Return type

[**List&lt;Group&gt;**](Group.md)

### Authorization

[AdminApiKeyAuth](../README.md#AdminApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A list of Group objects |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

