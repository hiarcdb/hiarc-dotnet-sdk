# HiarcSDK.Api.TokenApi

All URIs are relative to *http://localhost:5000*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateUserToken**](TokenApi.md#createusertoken) | **POST** /tokens/user | Create a Token for a User


<a name="createusertoken"></a>
# **CreateUserToken**
> UserCredentials CreateUserToken (CreateUserTokenRequest createUserTokenRequest)

Create a Token for a User

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HiarcSDK.Api;
using HiarcSDK.Client;
using HiarcSDK.Model;

namespace Example
{
    public class CreateUserTokenExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:5000";
            // Configure API key authorization: AdminApiKeyAuth
            config.AddApiKey("X-Hiarc-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Hiarc-Api-Key", "Bearer");

            var apiInstance = new TokenApi(config);
            var createUserTokenRequest = new CreateUserTokenRequest(); // CreateUserTokenRequest | User information

            try
            {
                // Create a Token for a User
                UserCredentials result = apiInstance.CreateUserToken(createUserTokenRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TokenApi.CreateUserToken: " + e.Message );
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
 **createUserTokenRequest** | [**CreateUserTokenRequest**](CreateUserTokenRequest.md)| User information | 

### Return type

[**UserCredentials**](UserCredentials.md)

### Authorization

[AdminApiKeyAuth](../README.md#AdminApiKeyAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A User Token object |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

