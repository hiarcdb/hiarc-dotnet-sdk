# HiarcSDK.Api.FileApi

All URIs are relative to *http://localhost:5000*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddClassificationToFile**](FileApi.md#addclassificationtofile) | **PUT** /files/{key}/classifications | Add a Classification to a File
[**AddGroupToFile**](FileApi.md#addgrouptofile) | **PUT** /files/{key}/groups | Give a group access to a File
[**AddRetentionPolicyToFile**](FileApi.md#addretentionpolicytofile) | **PUT** /files/{key}/retentionpolicies | Add a Retention Policy to a File
[**AddUserToFile**](FileApi.md#addusertofile) | **PUT** /files/{key}/users | Give a user access to a File
[**AddVersion**](FileApi.md#addversion) | **PUT** /files/{key}/versions | Add a new File Version
[**AttachToExisitingFile**](FileApi.md#attachtoexisitingfile) | **PUT** /files/{key}/attach | Attach to an existing File
[**CopyFile**](FileApi.md#copyfile) | **PUT** /files/{key}/copy | Copy a File
[**CreateDirectUploadUrl**](FileApi.md#createdirectuploadurl) | **POST** /files/directuploadurl | Create a direct upload url to a storage service
[**CreateFile**](FileApi.md#createfile) | **POST** /files | Create a File
[**DeleteFile**](FileApi.md#deletefile) | **DELETE** /files/{key} | Delete a File
[**DownloadFile**](FileApi.md#downloadfile) | **GET** /files/{key}/download | Download a File
[**GetCollectionsForFile**](FileApi.md#getcollectionsforfile) | **GET** /files/{key}/collections | Get a list of Collections for a File
[**GetDirectDownloadUrl**](FileApi.md#getdirectdownloadurl) | **GET** /files/{key}/directdownloadurl | Get a direct download URL to a File
[**GetFile**](FileApi.md#getfile) | **GET** /files/{key} | Get a File&#39;s Info
[**GetRetentionPolicies**](FileApi.md#getretentionpolicies) | **GET** /files/{key}/retentionpolicies | Get a list of Retention Policies on a File
[**GetVersions**](FileApi.md#getversions) | **GET** /files/{key}/versions | Get a list of File Versions
[**UpdateFile**](FileApi.md#updatefile) | **PUT** /files/{key} | Update a File


<a name="addclassificationtofile"></a>
# **AddClassificationToFile**
> Object AddClassificationToFile (string key, AddClassificationToFileRequest addClassificationToFileRequest, string xHiarcUserKey = null)

Add a Classification to a File

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HiarcSDK.Api;
using HiarcSDK.Client;
using HiarcSDK.Model;

namespace Example
{
    public class AddClassificationToFileExample
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

            var apiInstance = new FileApi(config);
            var key = key_example;  // string | Key of file
            var addClassificationToFileRequest = new AddClassificationToFileRequest(); // AddClassificationToFileRequest | Classification information
            var xHiarcUserKey = xHiarcUserKey_example;  // string |  (optional) 

            try
            {
                // Add a Classification to a File
                Object result = apiInstance.AddClassificationToFile(key, addClassificationToFileRequest, xHiarcUserKey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FileApi.AddClassificationToFile: " + e.Message );
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
 **key** | **string**| Key of file | 
 **addClassificationToFileRequest** | [**AddClassificationToFileRequest**](AddClassificationToFileRequest.md)| Classification information | 
 **xHiarcUserKey** | **string**|  | [optional] 

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

<a name="addgrouptofile"></a>
# **AddGroupToFile**
> Object AddGroupToFile (string key, AddGroupToFileRequest addGroupToFileRequest, string xHiarcUserKey = null)

Give a group access to a File

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HiarcSDK.Api;
using HiarcSDK.Client;
using HiarcSDK.Model;

namespace Example
{
    public class AddGroupToFileExample
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

            var apiInstance = new FileApi(config);
            var key = key_example;  // string | Key of file
            var addGroupToFileRequest = new AddGroupToFileRequest(); // AddGroupToFileRequest | Group information
            var xHiarcUserKey = xHiarcUserKey_example;  // string |  (optional) 

            try
            {
                // Give a group access to a File
                Object result = apiInstance.AddGroupToFile(key, addGroupToFileRequest, xHiarcUserKey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FileApi.AddGroupToFile: " + e.Message );
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
 **key** | **string**| Key of file | 
 **addGroupToFileRequest** | [**AddGroupToFileRequest**](AddGroupToFileRequest.md)| Group information | 
 **xHiarcUserKey** | **string**|  | [optional] 

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

<a name="addretentionpolicytofile"></a>
# **AddRetentionPolicyToFile**
> Object AddRetentionPolicyToFile (string key, AddRetentionPolicyToFileRequest addRetentionPolicyToFileRequest, string xHiarcUserKey = null)

Add a Retention Policy to a File

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HiarcSDK.Api;
using HiarcSDK.Client;
using HiarcSDK.Model;

namespace Example
{
    public class AddRetentionPolicyToFileExample
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

            var apiInstance = new FileApi(config);
            var key = key_example;  // string | Key of file
            var addRetentionPolicyToFileRequest = new AddRetentionPolicyToFileRequest(); // AddRetentionPolicyToFileRequest | Retention Policy information
            var xHiarcUserKey = xHiarcUserKey_example;  // string |  (optional) 

            try
            {
                // Add a Retention Policy to a File
                Object result = apiInstance.AddRetentionPolicyToFile(key, addRetentionPolicyToFileRequest, xHiarcUserKey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FileApi.AddRetentionPolicyToFile: " + e.Message );
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
 **key** | **string**| Key of file | 
 **addRetentionPolicyToFileRequest** | [**AddRetentionPolicyToFileRequest**](AddRetentionPolicyToFileRequest.md)| Retention Policy information | 
 **xHiarcUserKey** | **string**|  | [optional] 

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

<a name="addusertofile"></a>
# **AddUserToFile**
> Object AddUserToFile (string key, AddUserToFileRequest addUserToFileRequest, string xHiarcUserKey = null)

Give a user access to a File

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HiarcSDK.Api;
using HiarcSDK.Client;
using HiarcSDK.Model;

namespace Example
{
    public class AddUserToFileExample
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

            var apiInstance = new FileApi(config);
            var key = key_example;  // string | Key of file
            var addUserToFileRequest = new AddUserToFileRequest(); // AddUserToFileRequest | User information
            var xHiarcUserKey = xHiarcUserKey_example;  // string |  (optional) 

            try
            {
                // Give a user access to a File
                Object result = apiInstance.AddUserToFile(key, addUserToFileRequest, xHiarcUserKey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FileApi.AddUserToFile: " + e.Message );
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
 **key** | **string**| Key of file | 
 **addUserToFileRequest** | [**AddUserToFileRequest**](AddUserToFileRequest.md)| User information | 
 **xHiarcUserKey** | **string**|  | [optional] 

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

<a name="addversion"></a>
# **AddVersion**
> File AddVersion (string key, string xHiarcUserKey = null, string request = null, System.IO.Stream file = null)

Add a new File Version

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HiarcSDK.Api;
using HiarcSDK.Client;
using HiarcSDK.Model;

namespace Example
{
    public class AddVersionExample
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

            var apiInstance = new FileApi(config);
            var key = key_example;  // string | Key of file to add a version
            var xHiarcUserKey = xHiarcUserKey_example;  // string |  (optional) 
            var request = request_example;  // string |  (optional) 
            var file = BINARY_DATA_HERE;  // System.IO.Stream |  (optional) 

            try
            {
                // Add a new File Version
                File result = apiInstance.AddVersion(key, xHiarcUserKey, request, file);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FileApi.AddVersion: " + e.Message );
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
 **key** | **string**| Key of file to add a version | 
 **xHiarcUserKey** | **string**|  | [optional] 
 **request** | **string**|  | [optional] 
 **file** | **System.IO.Stream****System.IO.Stream**|  | [optional] 

### Return type

[**File**](File.md)

### Authorization

[AdminApiKeyAuth](../README.md#AdminApiKeyAuth), [JWTBearerAuth](../README.md#JWTBearerAuth)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | A File object |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="attachtoexisitingfile"></a>
# **AttachToExisitingFile**
> File AttachToExisitingFile (string key, AttachToExistingFileRequest attachToExistingFileRequest, string xHiarcUserKey = null)

Attach to an existing File

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HiarcSDK.Api;
using HiarcSDK.Client;
using HiarcSDK.Model;

namespace Example
{
    public class AttachToExisitingFileExample
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

            var apiInstance = new FileApi(config);
            var key = key_example;  // string | Key of file to attach to
            var attachToExistingFileRequest = new AttachToExistingFileRequest(); // AttachToExistingFileRequest | File information
            var xHiarcUserKey = xHiarcUserKey_example;  // string |  (optional) 

            try
            {
                // Attach to an existing File
                File result = apiInstance.AttachToExisitingFile(key, attachToExistingFileRequest, xHiarcUserKey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FileApi.AttachToExisitingFile: " + e.Message );
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
 **key** | **string**| Key of file to attach to | 
 **attachToExistingFileRequest** | [**AttachToExistingFileRequest**](AttachToExistingFileRequest.md)| File information | 
 **xHiarcUserKey** | **string**|  | [optional] 

### Return type

[**File**](File.md)

### Authorization

[AdminApiKeyAuth](../README.md#AdminApiKeyAuth), [JWTBearerAuth](../README.md#JWTBearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | A File object |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="copyfile"></a>
# **CopyFile**
> File CopyFile (string key, CopyFileRequest copyFileRequest, string xHiarcUserKey = null)

Copy a File

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HiarcSDK.Api;
using HiarcSDK.Client;
using HiarcSDK.Model;

namespace Example
{
    public class CopyFileExample
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

            var apiInstance = new FileApi(config);
            var key = key_example;  // string | Key of file to attach to
            var copyFileRequest = new CopyFileRequest(); // CopyFileRequest | File information
            var xHiarcUserKey = xHiarcUserKey_example;  // string |  (optional) 

            try
            {
                // Copy a File
                File result = apiInstance.CopyFile(key, copyFileRequest, xHiarcUserKey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FileApi.CopyFile: " + e.Message );
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
 **key** | **string**| Key of file to attach to | 
 **copyFileRequest** | [**CopyFileRequest**](CopyFileRequest.md)| File information | 
 **xHiarcUserKey** | **string**|  | [optional] 

### Return type

[**File**](File.md)

### Authorization

[AdminApiKeyAuth](../README.md#AdminApiKeyAuth), [JWTBearerAuth](../README.md#JWTBearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | A File object |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createdirectuploadurl"></a>
# **CreateDirectUploadUrl**
> FileDirectUpload CreateDirectUploadUrl (CreateDirectUploadUrlRequest createDirectUploadUrlRequest, string xHiarcUserKey = null, int? expiresInSeconds = null)

Create a direct upload url to a storage service

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HiarcSDK.Api;
using HiarcSDK.Client;
using HiarcSDK.Model;

namespace Example
{
    public class CreateDirectUploadUrlExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:5000";
            // Configure API key authorization: AdminApiKeyAuth
            config.AddApiKey("X-Hiarc-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Hiarc-Api-Key", "Bearer");

            var apiInstance = new FileApi(config);
            var createDirectUploadUrlRequest = new CreateDirectUploadUrlRequest(); // CreateDirectUploadUrlRequest | Storage service information
            var xHiarcUserKey = xHiarcUserKey_example;  // string | Optional key of user to impersonate (optional) 
            var expiresInSeconds = 56;  // int? | When access to the url should expire (optional) 

            try
            {
                // Create a direct upload url to a storage service
                FileDirectUpload result = apiInstance.CreateDirectUploadUrl(createDirectUploadUrlRequest, xHiarcUserKey, expiresInSeconds);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FileApi.CreateDirectUploadUrl: " + e.Message );
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
 **createDirectUploadUrlRequest** | [**CreateDirectUploadUrlRequest**](CreateDirectUploadUrlRequest.md)| Storage service information | 
 **xHiarcUserKey** | **string**| Optional key of user to impersonate | [optional] 
 **expiresInSeconds** | **int?**| When access to the url should expire | [optional] 

### Return type

[**FileDirectUpload**](FileDirectUpload.md)

### Authorization

[AdminApiKeyAuth](../README.md#AdminApiKeyAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A direct upload object |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createfile"></a>
# **CreateFile**
> File CreateFile (string xHiarcUserKey = null, string request = null, System.IO.Stream file = null)

Create a File

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HiarcSDK.Api;
using HiarcSDK.Client;
using HiarcSDK.Model;

namespace Example
{
    public class CreateFileExample
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

            var apiInstance = new FileApi(config);
            var xHiarcUserKey = xHiarcUserKey_example;  // string |  (optional) 
            var request = request_example;  // string |  (optional) 
            var file = BINARY_DATA_HERE;  // System.IO.Stream |  (optional) 

            try
            {
                // Create a File
                File result = apiInstance.CreateFile(xHiarcUserKey, request, file);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FileApi.CreateFile: " + e.Message );
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
 **xHiarcUserKey** | **string**|  | [optional] 
 **request** | **string**|  | [optional] 
 **file** | **System.IO.Stream****System.IO.Stream**|  | [optional] 

### Return type

[**File**](File.md)

### Authorization

[AdminApiKeyAuth](../README.md#AdminApiKeyAuth), [JWTBearerAuth](../README.md#JWTBearerAuth)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | A File object |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletefile"></a>
# **DeleteFile**
> Object DeleteFile (string key, string xHiarcUserKey = null)

Delete a File

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HiarcSDK.Api;
using HiarcSDK.Client;
using HiarcSDK.Model;

namespace Example
{
    public class DeleteFileExample
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

            var apiInstance = new FileApi(config);
            var key = key_example;  // string | Key of file to delete
            var xHiarcUserKey = xHiarcUserKey_example;  // string | Optional key of user to impersonate (optional) 

            try
            {
                // Delete a File
                Object result = apiInstance.DeleteFile(key, xHiarcUserKey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FileApi.DeleteFile: " + e.Message );
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
 **key** | **string**| Key of file to delete | 
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

<a name="downloadfile"></a>
# **DownloadFile**
> System.IO.Stream DownloadFile (string key, string xHiarcUserKey = null)

Download a File

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HiarcSDK.Api;
using HiarcSDK.Client;
using HiarcSDK.Model;

namespace Example
{
    public class DownloadFileExample
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

            var apiInstance = new FileApi(config);
            var key = key_example;  // string | Key of file to download
            var xHiarcUserKey = xHiarcUserKey_example;  // string | Optional key of user to impersonate (optional) 

            try
            {
                // Download a File
                System.IO.Stream result = apiInstance.DownloadFile(key, xHiarcUserKey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FileApi.DownloadFile: " + e.Message );
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
 **key** | **string**| Key of file to download | 
 **xHiarcUserKey** | **string**| Optional key of user to impersonate | [optional] 

### Return type

**System.IO.Stream**

### Authorization

[AdminApiKeyAuth](../README.md#AdminApiKeyAuth), [JWTBearerAuth](../README.md#JWTBearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/octet-stream

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A binary file |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcollectionsforfile"></a>
# **GetCollectionsForFile**
> List&lt;Collection&gt; GetCollectionsForFile (string key, string xHiarcUserKey = null)

Get a list of Collections for a File

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HiarcSDK.Api;
using HiarcSDK.Client;
using HiarcSDK.Model;

namespace Example
{
    public class GetCollectionsForFileExample
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

            var apiInstance = new FileApi(config);
            var key = key_example;  // string | Key of file to get all collections
            var xHiarcUserKey = xHiarcUserKey_example;  // string | Optional key of user to impersonate (optional) 

            try
            {
                // Get a list of Collections for a File
                List<Collection> result = apiInstance.GetCollectionsForFile(key, xHiarcUserKey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FileApi.GetCollectionsForFile: " + e.Message );
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
 **key** | **string**| Key of file to get all collections | 
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
| **200** | A list of Collections |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getdirectdownloadurl"></a>
# **GetDirectDownloadUrl**
> FileDirectDownload GetDirectDownloadUrl (string key, string xHiarcUserKey = null, int? expiresInSeconds = null)

Get a direct download URL to a File

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HiarcSDK.Api;
using HiarcSDK.Client;
using HiarcSDK.Model;

namespace Example
{
    public class GetDirectDownloadUrlExample
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

            var apiInstance = new FileApi(config);
            var key = key_example;  // string | Key of file to get download URL
            var xHiarcUserKey = xHiarcUserKey_example;  // string | Optional key of user to impersonate (optional) 
            var expiresInSeconds = 56;  // int? | When access to the url should expire (optional) 

            try
            {
                // Get a direct download URL to a File
                FileDirectDownload result = apiInstance.GetDirectDownloadUrl(key, xHiarcUserKey, expiresInSeconds);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FileApi.GetDirectDownloadUrl: " + e.Message );
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
 **key** | **string**| Key of file to get download URL | 
 **xHiarcUserKey** | **string**| Optional key of user to impersonate | [optional] 
 **expiresInSeconds** | **int?**| When access to the url should expire | [optional] 

### Return type

[**FileDirectDownload**](FileDirectDownload.md)

### Authorization

[AdminApiKeyAuth](../README.md#AdminApiKeyAuth), [JWTBearerAuth](../README.md#JWTBearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A direct download URL object |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getfile"></a>
# **GetFile**
> File GetFile (string key, string xHiarcUserKey = null)

Get a File's Info

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HiarcSDK.Api;
using HiarcSDK.Client;
using HiarcSDK.Model;

namespace Example
{
    public class GetFileExample
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

            var apiInstance = new FileApi(config);
            var key = key_example;  // string | Key of file to get info
            var xHiarcUserKey = xHiarcUserKey_example;  // string | Optional key of user to impersonate (optional) 

            try
            {
                // Get a File's Info
                File result = apiInstance.GetFile(key, xHiarcUserKey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FileApi.GetFile: " + e.Message );
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
 **key** | **string**| Key of file to get info | 
 **xHiarcUserKey** | **string**| Optional key of user to impersonate | [optional] 

### Return type

[**File**](File.md)

### Authorization

[AdminApiKeyAuth](../README.md#AdminApiKeyAuth), [JWTBearerAuth](../README.md#JWTBearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A File object |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getretentionpolicies"></a>
# **GetRetentionPolicies**
> List&lt;RetentionPolicyApplication&gt; GetRetentionPolicies (string key, string xHiarcUserKey = null)

Get a list of Retention Policies on a File

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HiarcSDK.Api;
using HiarcSDK.Client;
using HiarcSDK.Model;

namespace Example
{
    public class GetRetentionPoliciesExample
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

            var apiInstance = new FileApi(config);
            var key = key_example;  // string | Key of file to get all retention policies
            var xHiarcUserKey = xHiarcUserKey_example;  // string | Optional key of user to impersonate (optional) 

            try
            {
                // Get a list of Retention Policies on a File
                List<RetentionPolicyApplication> result = apiInstance.GetRetentionPolicies(key, xHiarcUserKey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FileApi.GetRetentionPolicies: " + e.Message );
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
 **key** | **string**| Key of file to get all retention policies | 
 **xHiarcUserKey** | **string**| Optional key of user to impersonate | [optional] 

### Return type

[**List&lt;RetentionPolicyApplication&gt;**](RetentionPolicyApplication.md)

### Authorization

[AdminApiKeyAuth](../README.md#AdminApiKeyAuth), [JWTBearerAuth](../README.md#JWTBearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A list of Retention Policies |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getversions"></a>
# **GetVersions**
> List&lt;FileVersion&gt; GetVersions (string key, string xHiarcUserKey = null)

Get a list of File Versions

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HiarcSDK.Api;
using HiarcSDK.Client;
using HiarcSDK.Model;

namespace Example
{
    public class GetVersionsExample
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

            var apiInstance = new FileApi(config);
            var key = key_example;  // string | Key of file to get all versions
            var xHiarcUserKey = xHiarcUserKey_example;  // string | Optional key of user to impersonate (optional) 

            try
            {
                // Get a list of File Versions
                List<FileVersion> result = apiInstance.GetVersions(key, xHiarcUserKey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FileApi.GetVersions: " + e.Message );
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
 **key** | **string**| Key of file to get all versions | 
 **xHiarcUserKey** | **string**| Optional key of user to impersonate | [optional] 

### Return type

[**List&lt;FileVersion&gt;**](FileVersion.md)

### Authorization

[AdminApiKeyAuth](../README.md#AdminApiKeyAuth), [JWTBearerAuth](../README.md#JWTBearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A list of File Versions |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatefile"></a>
# **UpdateFile**
> File UpdateFile (string key, UpdateFileRequest updateFileRequest)

Update a File

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HiarcSDK.Api;
using HiarcSDK.Client;
using HiarcSDK.Model;

namespace Example
{
    public class UpdateFileExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:5000";
            // Configure API key authorization: AdminApiKeyAuth
            config.AddApiKey("X-Hiarc-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Hiarc-Api-Key", "Bearer");

            var apiInstance = new FileApi(config);
            var key = key_example;  // string | Key of file to update
            var updateFileRequest = new UpdateFileRequest(); // UpdateFileRequest | File information

            try
            {
                // Update a File
                File result = apiInstance.UpdateFile(key, updateFileRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FileApi.UpdateFile: " + e.Message );
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
 **key** | **string**| Key of file to update | 
 **updateFileRequest** | [**UpdateFileRequest**](UpdateFileRequest.md)| File information | 

### Return type

[**File**](File.md)

### Authorization

[AdminApiKeyAuth](../README.md#AdminApiKeyAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A File object |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

