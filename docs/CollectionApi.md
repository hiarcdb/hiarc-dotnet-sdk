# HiarcSDK.Api.CollectionApi

All URIs are relative to *http://localhost:5000*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddChildToCollection**](CollectionApi.md#addchildtocollection) | **PUT** /collections/{key}/children/{childKey} | Add a child item to a Collection
[**AddFileToCollection**](CollectionApi.md#addfiletocollection) | **PUT** /collections/{key}/files | Add a File to a Collection
[**AddGroupToCollection**](CollectionApi.md#addgrouptocollection) | **PUT** /collections/{key}/groups | Add a Group to a Collection
[**AddUserToCollection**](CollectionApi.md#addusertocollection) | **PUT** /collections/{key}/users | Add a User to a Collection
[**CreateCollection**](CollectionApi.md#createcollection) | **POST** /collections | Create a Collection
[**DeleteCollection**](CollectionApi.md#deletecollection) | **DELETE** /collections/{key} | Delete a Collection
[**FindCollection**](CollectionApi.md#findcollection) | **POST** /collections/find | Find a Collection
[**GetAllCollections**](CollectionApi.md#getallcollections) | **GET** /collections | Get all Collections
[**GetCollection**](CollectionApi.md#getcollection) | **GET** /collections/{key} | Get a Collection&#39;s Info
[**GetCollectionChildren**](CollectionApi.md#getcollectionchildren) | **GET** /collections/{key}/children | Get a Collection&#39;s child Collections
[**GetCollectionFiles**](CollectionApi.md#getcollectionfiles) | **GET** /collections/{key}/files | Get a Collection&#39;s Files
[**GetCollectionItems**](CollectionApi.md#getcollectionitems) | **GET** /collections/{key}/items | Get a Collection&#39;s child items, including Collections and Files
[**RemoveFileFromCollection**](CollectionApi.md#removefilefromcollection) | **DELETE** /collections/{key}/files/{fileKey} | Remove a File from a Collection
[**UpdateCollection**](CollectionApi.md#updatecollection) | **PUT** /collections/{key} | Update a Collection


<a name="addchildtocollection"></a>
# **AddChildToCollection**
> Object AddChildToCollection (string key, string childKey, string xHiarcUserKey = null)

Add a child item to a Collection

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HiarcSDK.Api;
using HiarcSDK.Client;
using HiarcSDK.Model;

namespace Example
{
    public class AddChildToCollectionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:5000";
            // Configure API key authorization: AdminApiKeyAuth
            config.AddApiKey("X-Hiarc-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Hiarc-Api-Key", "Bearer");
            // Configure Bearer token for authorization: JWTBearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new CollectionApi(config);
            var key = key_example;  // string | Key of Collection
            var childKey = childKey_example;  // string | Key of item to add as child to Collection
            var xHiarcUserKey = xHiarcUserKey_example;  // string | Optional key of user to impersonate (optional) 

            try
            {
                // Add a child item to a Collection
                Object result = apiInstance.AddChildToCollection(key, childKey, xHiarcUserKey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CollectionApi.AddChildToCollection: " + e.Message );
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
 **key** | **string**| Key of Collection | 
 **childKey** | **string**| Key of item to add as child to Collection | 
 **xHiarcUserKey** | **string**| Optional key of user to impersonate | [optional] 

### Return type

**Object**

### Authorization

[AdminApiKeyAuth](../README.md#AdminApiKeyAuth), [JWTBearerAuth](../README.md#JWTBearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Empty response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addfiletocollection"></a>
# **AddFileToCollection**
> Object AddFileToCollection (string key, AddFileToCollectionRequest addFileToCollectionRequest, string xHiarcUserKey = null)

Add a File to a Collection

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HiarcSDK.Api;
using HiarcSDK.Client;
using HiarcSDK.Model;

namespace Example
{
    public class AddFileToCollectionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:5000";
            // Configure API key authorization: AdminApiKeyAuth
            config.AddApiKey("X-Hiarc-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Hiarc-Api-Key", "Bearer");
            // Configure Bearer token for authorization: JWTBearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new CollectionApi(config);
            var key = key_example;  // string | Key of Collection
            var addFileToCollectionRequest = new AddFileToCollectionRequest(); // AddFileToCollectionRequest | Add File request
            var xHiarcUserKey = xHiarcUserKey_example;  // string | Optional key of user to impersonate (optional) 

            try
            {
                // Add a File to a Collection
                Object result = apiInstance.AddFileToCollection(key, addFileToCollectionRequest, xHiarcUserKey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CollectionApi.AddFileToCollection: " + e.Message );
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
 **key** | **string**| Key of Collection | 
 **addFileToCollectionRequest** | [**AddFileToCollectionRequest**](AddFileToCollectionRequest.md)| Add File request | 
 **xHiarcUserKey** | **string**| Optional key of user to impersonate | [optional] 

### Return type

**Object**

### Authorization

[AdminApiKeyAuth](../README.md#AdminApiKeyAuth), [JWTBearerAuth](../README.md#JWTBearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Empty response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addgrouptocollection"></a>
# **AddGroupToCollection**
> Object AddGroupToCollection (string key, AddGroupToCollectionRequest addGroupToCollectionRequest, string xHiarcUserKey = null)

Add a Group to a Collection

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HiarcSDK.Api;
using HiarcSDK.Client;
using HiarcSDK.Model;

namespace Example
{
    public class AddGroupToCollectionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:5000";
            // Configure API key authorization: AdminApiKeyAuth
            config.AddApiKey("X-Hiarc-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Hiarc-Api-Key", "Bearer");
            // Configure Bearer token for authorization: JWTBearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new CollectionApi(config);
            var key = key_example;  // string | Key of Collection
            var addGroupToCollectionRequest = new AddGroupToCollectionRequest(); // AddGroupToCollectionRequest | Add Group request
            var xHiarcUserKey = xHiarcUserKey_example;  // string | Optional key of user to impersonate (optional) 

            try
            {
                // Add a Group to a Collection
                Object result = apiInstance.AddGroupToCollection(key, addGroupToCollectionRequest, xHiarcUserKey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CollectionApi.AddGroupToCollection: " + e.Message );
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
 **key** | **string**| Key of Collection | 
 **addGroupToCollectionRequest** | [**AddGroupToCollectionRequest**](AddGroupToCollectionRequest.md)| Add Group request | 
 **xHiarcUserKey** | **string**| Optional key of user to impersonate | [optional] 

### Return type

**Object**

### Authorization

[AdminApiKeyAuth](../README.md#AdminApiKeyAuth), [JWTBearerAuth](../README.md#JWTBearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Empty response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addusertocollection"></a>
# **AddUserToCollection**
> Object AddUserToCollection (string key, AddUserToCollectionRequest addUserToCollectionRequest, string xHiarcUserKey = null)

Add a User to a Collection

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HiarcSDK.Api;
using HiarcSDK.Client;
using HiarcSDK.Model;

namespace Example
{
    public class AddUserToCollectionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:5000";
            // Configure API key authorization: AdminApiKeyAuth
            config.AddApiKey("X-Hiarc-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Hiarc-Api-Key", "Bearer");
            // Configure Bearer token for authorization: JWTBearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new CollectionApi(config);
            var key = key_example;  // string | Key of Collection
            var addUserToCollectionRequest = new AddUserToCollectionRequest(); // AddUserToCollectionRequest | Add User request
            var xHiarcUserKey = xHiarcUserKey_example;  // string | Optional key of user to impersonate (optional) 

            try
            {
                // Add a User to a Collection
                Object result = apiInstance.AddUserToCollection(key, addUserToCollectionRequest, xHiarcUserKey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CollectionApi.AddUserToCollection: " + e.Message );
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
 **key** | **string**| Key of Collection | 
 **addUserToCollectionRequest** | [**AddUserToCollectionRequest**](AddUserToCollectionRequest.md)| Add User request | 
 **xHiarcUserKey** | **string**| Optional key of user to impersonate | [optional] 

### Return type

**Object**

### Authorization

[AdminApiKeyAuth](../README.md#AdminApiKeyAuth), [JWTBearerAuth](../README.md#JWTBearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Empty response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createcollection"></a>
# **CreateCollection**
> Collection CreateCollection (CreateCollectionRequest createCollectionRequest, string xHiarcUserKey = null)

Create a Collection

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HiarcSDK.Api;
using HiarcSDK.Client;
using HiarcSDK.Model;

namespace Example
{
    public class CreateCollectionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:5000";
            // Configure API key authorization: AdminApiKeyAuth
            config.AddApiKey("X-Hiarc-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Hiarc-Api-Key", "Bearer");

            var apiInstance = new CollectionApi(config);
            var createCollectionRequest = new CreateCollectionRequest(); // CreateCollectionRequest | Collection information
            var xHiarcUserKey = xHiarcUserKey_example;  // string | Optional key of user to impersonate (optional) 

            try
            {
                // Create a Collection
                Collection result = apiInstance.CreateCollection(createCollectionRequest, xHiarcUserKey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CollectionApi.CreateCollection: " + e.Message );
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
 **createCollectionRequest** | [**CreateCollectionRequest**](CreateCollectionRequest.md)| Collection information | 
 **xHiarcUserKey** | **string**| Optional key of user to impersonate | [optional] 

### Return type

**Collection**

### Authorization

[AdminApiKeyAuth](../README.md#AdminApiKeyAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | A Collection object |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletecollection"></a>
# **DeleteCollection**
> Object DeleteCollection (string key, string xHiarcUserKey = null)

Delete a Collection

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HiarcSDK.Api;
using HiarcSDK.Client;
using HiarcSDK.Model;

namespace Example
{
    public class DeleteCollectionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:5000";
            // Configure API key authorization: AdminApiKeyAuth
            config.AddApiKey("X-Hiarc-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Hiarc-Api-Key", "Bearer");
            // Configure Bearer token for authorization: JWTBearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new CollectionApi(config);
            var key = key_example;  // string | Key of Collection to delete
            var xHiarcUserKey = xHiarcUserKey_example;  // string | Optional key of user to impersonate (optional) 

            try
            {
                // Delete a Collection
                Object result = apiInstance.DeleteCollection(key, xHiarcUserKey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CollectionApi.DeleteCollection: " + e.Message );
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
 **key** | **string**| Key of Collection to delete | 
 **xHiarcUserKey** | **string**| Optional key of user to impersonate | [optional] 

### Return type

**Object**

### Authorization

[AdminApiKeyAuth](../README.md#AdminApiKeyAuth), [JWTBearerAuth](../README.md#JWTBearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Empty response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="findcollection"></a>
# **FindCollection**
> List&lt;Collection&gt; FindCollection (FindCollectionsRequest findCollectionsRequest, string xHiarcUserKey = null)

Find a Collection

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HiarcSDK.Api;
using HiarcSDK.Client;
using HiarcSDK.Model;

namespace Example
{
    public class FindCollectionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:5000";
            // Configure API key authorization: AdminApiKeyAuth
            config.AddApiKey("X-Hiarc-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Hiarc-Api-Key", "Bearer");
            // Configure Bearer token for authorization: JWTBearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new CollectionApi(config);
            var findCollectionsRequest = new FindCollectionsRequest(); // FindCollectionsRequest | Collection query
            var xHiarcUserKey = xHiarcUserKey_example;  // string | Optional key of user to impersonate (optional) 

            try
            {
                // Find a Collection
                List<Collection> result = apiInstance.FindCollection(findCollectionsRequest, xHiarcUserKey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CollectionApi.FindCollection: " + e.Message );
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
 **findCollectionsRequest** | [**FindCollectionsRequest**](FindCollectionsRequest.md)| Collection query | 
 **xHiarcUserKey** | **string**| Optional key of user to impersonate | [optional] 

### Return type

**List<Collection>**

### Authorization

[AdminApiKeyAuth](../README.md#AdminApiKeyAuth), [JWTBearerAuth](../README.md#JWTBearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A list of Collection objects |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getallcollections"></a>
# **GetAllCollections**
> List&lt;Collection&gt; GetAllCollections (string xHiarcUserKey = null)

Get all Collections

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HiarcSDK.Api;
using HiarcSDK.Client;
using HiarcSDK.Model;

namespace Example
{
    public class GetAllCollectionsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:5000";
            // Configure API key authorization: AdminApiKeyAuth
            config.AddApiKey("X-Hiarc-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Hiarc-Api-Key", "Bearer");

            var apiInstance = new CollectionApi(config);
            var xHiarcUserKey = xHiarcUserKey_example;  // string | Optional key of user to impersonate (optional) 

            try
            {
                // Get all Collections
                List<Collection> result = apiInstance.GetAllCollections(xHiarcUserKey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CollectionApi.GetAllCollections: " + e.Message );
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

**List<Collection>**

### Authorization

[AdminApiKeyAuth](../README.md#AdminApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A list of Collection objects |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcollection"></a>
# **GetCollection**
> Collection GetCollection (string key, string xHiarcUserKey = null)

Get a Collection's Info

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HiarcSDK.Api;
using HiarcSDK.Client;
using HiarcSDK.Model;

namespace Example
{
    public class GetCollectionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:5000";
            // Configure API key authorization: AdminApiKeyAuth
            config.AddApiKey("X-Hiarc-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Hiarc-Api-Key", "Bearer");
            // Configure Bearer token for authorization: JWTBearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new CollectionApi(config);
            var key = key_example;  // string | Key of collection to get info
            var xHiarcUserKey = xHiarcUserKey_example;  // string | Optional key of user to impersonate (optional) 

            try
            {
                // Get a Collection's Info
                Collection result = apiInstance.GetCollection(key, xHiarcUserKey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CollectionApi.GetCollection: " + e.Message );
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
 **key** | **string**| Key of collection to get info | 
 **xHiarcUserKey** | **string**| Optional key of user to impersonate | [optional] 

### Return type

**Collection**

### Authorization

[AdminApiKeyAuth](../README.md#AdminApiKeyAuth), [JWTBearerAuth](../README.md#JWTBearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A Collection object |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcollectionchildren"></a>
# **GetCollectionChildren**
> List&lt;Collection&gt; GetCollectionChildren (string key, string xHiarcUserKey = null)

Get a Collection's child Collections

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HiarcSDK.Api;
using HiarcSDK.Client;
using HiarcSDK.Model;

namespace Example
{
    public class GetCollectionChildrenExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:5000";
            // Configure API key authorization: AdminApiKeyAuth
            config.AddApiKey("X-Hiarc-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Hiarc-Api-Key", "Bearer");
            // Configure Bearer token for authorization: JWTBearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new CollectionApi(config);
            var key = key_example;  // string | Key of collection
            var xHiarcUserKey = xHiarcUserKey_example;  // string | Optional key of user to impersonate (optional) 

            try
            {
                // Get a Collection's child Collections
                List<Collection> result = apiInstance.GetCollectionChildren(key, xHiarcUserKey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CollectionApi.GetCollectionChildren: " + e.Message );
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
 **key** | **string**| Key of collection | 
 **xHiarcUserKey** | **string**| Optional key of user to impersonate | [optional] 

### Return type

**List<Collection>**

### Authorization

[AdminApiKeyAuth](../README.md#AdminApiKeyAuth), [JWTBearerAuth](../README.md#JWTBearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A List of Collection objects |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcollectionfiles"></a>
# **GetCollectionFiles**
> List&lt;File&gt; GetCollectionFiles (string key, string xHiarcUserKey = null)

Get a Collection's Files

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HiarcSDK.Api;
using HiarcSDK.Client;
using HiarcSDK.Model;

namespace Example
{
    public class GetCollectionFilesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:5000";
            // Configure API key authorization: AdminApiKeyAuth
            config.AddApiKey("X-Hiarc-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Hiarc-Api-Key", "Bearer");
            // Configure Bearer token for authorization: JWTBearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new CollectionApi(config);
            var key = key_example;  // string | Key of collection
            var xHiarcUserKey = xHiarcUserKey_example;  // string | Optional key of user to impersonate (optional) 

            try
            {
                // Get a Collection's Files
                List<File> result = apiInstance.GetCollectionFiles(key, xHiarcUserKey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CollectionApi.GetCollectionFiles: " + e.Message );
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
 **key** | **string**| Key of collection | 
 **xHiarcUserKey** | **string**| Optional key of user to impersonate | [optional] 

### Return type

[**List&lt;File&gt;**](File.md)

### Authorization

[AdminApiKeyAuth](../README.md#AdminApiKeyAuth), [JWTBearerAuth](../README.md#JWTBearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A List of File objects |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcollectionitems"></a>
# **GetCollectionItems**
> CollectionItems GetCollectionItems (string key, string xHiarcUserKey = null)

Get a Collection's child items, including Collections and Files

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HiarcSDK.Api;
using HiarcSDK.Client;
using HiarcSDK.Model;

namespace Example
{
    public class GetCollectionItemsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:5000";
            // Configure API key authorization: AdminApiKeyAuth
            config.AddApiKey("X-Hiarc-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Hiarc-Api-Key", "Bearer");
            // Configure Bearer token for authorization: JWTBearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new CollectionApi(config);
            var key = key_example;  // string | Key of collection
            var xHiarcUserKey = xHiarcUserKey_example;  // string | Optional key of user to impersonate (optional) 

            try
            {
                // Get a Collection's child items, including Collections and Files
                CollectionItems result = apiInstance.GetCollectionItems(key, xHiarcUserKey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CollectionApi.GetCollectionItems: " + e.Message );
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
 **key** | **string**| Key of collection | 
 **xHiarcUserKey** | **string**| Optional key of user to impersonate | [optional] 

### Return type

[**CollectionItems**](CollectionItems.md)

### Authorization

[AdminApiKeyAuth](../README.md#AdminApiKeyAuth), [JWTBearerAuth](../README.md#JWTBearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Collection Item objects |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="removefilefromcollection"></a>
# **RemoveFileFromCollection**
> Object RemoveFileFromCollection (string key, string fileKey, string xHiarcUserKey = null)

Remove a File from a Collection

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HiarcSDK.Api;
using HiarcSDK.Client;
using HiarcSDK.Model;

namespace Example
{
    public class RemoveFileFromCollectionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:5000";
            // Configure API key authorization: AdminApiKeyAuth
            config.AddApiKey("X-Hiarc-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Hiarc-Api-Key", "Bearer");
            // Configure Bearer token for authorization: JWTBearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new CollectionApi(config);
            var key = key_example;  // string | Key of Collection
            var fileKey = fileKey_example;  // string | Key of File to remove from Collection
            var xHiarcUserKey = xHiarcUserKey_example;  // string | Optional key of user to impersonate (optional) 

            try
            {
                // Remove a File from a Collection
                Object result = apiInstance.RemoveFileFromCollection(key, fileKey, xHiarcUserKey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CollectionApi.RemoveFileFromCollection: " + e.Message );
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
 **key** | **string**| Key of Collection | 
 **fileKey** | **string**| Key of File to remove from Collection | 
 **xHiarcUserKey** | **string**| Optional key of user to impersonate | [optional] 

### Return type

**Object**

### Authorization

[AdminApiKeyAuth](../README.md#AdminApiKeyAuth), [JWTBearerAuth](../README.md#JWTBearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Empty response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatecollection"></a>
# **UpdateCollection**
> Collection UpdateCollection (string key, UpdateCollectionRequest updateCollectionRequest, string xHiarcUserKey = null)

Update a Collection

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HiarcSDK.Api;
using HiarcSDK.Client;
using HiarcSDK.Model;

namespace Example
{
    public class UpdateCollectionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:5000";
            // Configure API key authorization: AdminApiKeyAuth
            config.AddApiKey("X-Hiarc-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Hiarc-Api-Key", "Bearer");
            // Configure Bearer token for authorization: JWTBearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new CollectionApi(config);
            var key = key_example;  // string | Key of collection to get info
            var updateCollectionRequest = new UpdateCollectionRequest(); // UpdateCollectionRequest | Collection information
            var xHiarcUserKey = xHiarcUserKey_example;  // string | Optional key of user to impersonate (optional) 

            try
            {
                // Update a Collection
                Collection result = apiInstance.UpdateCollection(key, updateCollectionRequest, xHiarcUserKey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CollectionApi.UpdateCollection: " + e.Message );
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
 **key** | **string**| Key of collection to get info | 
 **updateCollectionRequest** | [**UpdateCollectionRequest**](UpdateCollectionRequest.md)| Collection information | 
 **xHiarcUserKey** | **string**| Optional key of user to impersonate | [optional] 

### Return type

**Collection**

### Authorization

[AdminApiKeyAuth](../README.md#AdminApiKeyAuth), [JWTBearerAuth](../README.md#JWTBearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A Collection object |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

