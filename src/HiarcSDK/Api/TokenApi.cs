/* 
 * Hiarc API
 *
 * Welcome to the Hiarc API documentation.
 *
 * The version of the OpenAPI document: 0.1.0
 * 
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Net.Mime;
using HiarcSDK.Client;
using HiarcSDK.Model;

namespace HiarcSDK.Api
{

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ITokenApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Create a Token for a User
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HiarcSDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createUserTokenRequest">User information</param>
        /// <returns>UserCredentials</returns>
        UserCredentials CreateUserToken (CreateUserTokenRequest createUserTokenRequest);

        /// <summary>
        /// Create a Token for a User
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HiarcSDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createUserTokenRequest">User information</param>
        /// <returns>ApiResponse of UserCredentials</returns>
        ApiResponse<UserCredentials> CreateUserTokenWithHttpInfo (CreateUserTokenRequest createUserTokenRequest);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ITokenApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// Create a Token for a User
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HiarcSDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createUserTokenRequest">User information</param>
        /// <returns>Task of UserCredentials</returns>
        System.Threading.Tasks.Task<UserCredentials> CreateUserTokenAsync (CreateUserTokenRequest createUserTokenRequest);

        /// <summary>
        /// Create a Token for a User
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HiarcSDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createUserTokenRequest">User information</param>
        /// <returns>Task of ApiResponse (UserCredentials)</returns>
        System.Threading.Tasks.Task<ApiResponse<UserCredentials>> CreateUserTokenAsyncWithHttpInfo (CreateUserTokenRequest createUserTokenRequest);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ITokenApi : ITokenApiSync, ITokenApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class TokenApi : ITokenApi
    {
        private HiarcSDK.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="TokenApi"/> class.
        /// </summary>
        /// <returns></returns>
        public TokenApi() : this((string) null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TokenApi"/> class.
        /// </summary>
        /// <returns></returns>
        public TokenApi(String basePath)
        {
            this.Configuration = HiarcSDK.Client.Configuration.MergeConfigurations(
                HiarcSDK.Client.GlobalConfiguration.Instance,
                new HiarcSDK.Client.Configuration { BasePath = basePath }
            );
            this.Client = new HiarcSDK.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new HiarcSDK.Client.ApiClient(this.Configuration.BasePath);
            this.ExceptionFactory = HiarcSDK.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TokenApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public TokenApi(HiarcSDK.Client.Configuration configuration)
        {
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Configuration = HiarcSDK.Client.Configuration.MergeConfigurations(
                HiarcSDK.Client.GlobalConfiguration.Instance,
                configuration
            );
            this.Client = new HiarcSDK.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new HiarcSDK.Client.ApiClient(this.Configuration.BasePath);
            ExceptionFactory = HiarcSDK.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TokenApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public TokenApi(HiarcSDK.Client.ISynchronousClient client,HiarcSDK.Client.IAsynchronousClient asyncClient, HiarcSDK.Client.IReadableConfiguration configuration)
        {
            if(client == null) throw new ArgumentNullException("client");
            if(asyncClient == null) throw new ArgumentNullException("asyncClient");
            if(configuration == null) throw new ArgumentNullException("configuration");

            this.Client = client;
            this.AsynchronousClient = asyncClient;
            this.Configuration = configuration;
            this.ExceptionFactory = HiarcSDK.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// The client for accessing this underlying API asynchronously.
        /// </summary>
        public HiarcSDK.Client.IAsynchronousClient AsynchronousClient { get; set; }

        /// <summary>
        /// The client for accessing this underlying API synchronously.
        /// </summary>
        public HiarcSDK.Client.ISynchronousClient Client { get; set; }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.BasePath;
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public HiarcSDK.Client.IReadableConfiguration Configuration {get; set;}

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public HiarcSDK.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        /// Create a Token for a User 
        /// </summary>
        /// <exception cref="HiarcSDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createUserTokenRequest">User information</param>
        /// <returns>UserCredentials</returns>
        public UserCredentials CreateUserToken (CreateUserTokenRequest createUserTokenRequest)
        {
             HiarcSDK.Client.ApiResponse<UserCredentials> localVarResponse = CreateUserTokenWithHttpInfo(createUserTokenRequest);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create a Token for a User 
        /// </summary>
        /// <exception cref="HiarcSDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createUserTokenRequest">User information</param>
        /// <returns>ApiResponse of UserCredentials</returns>
        public HiarcSDK.Client.ApiResponse< UserCredentials > CreateUserTokenWithHttpInfo (CreateUserTokenRequest createUserTokenRequest)
        {
            // verify the required parameter 'createUserTokenRequest' is set
            if (createUserTokenRequest == null)
                throw new HiarcSDK.Client.ApiException(400, "Missing required parameter 'createUserTokenRequest' when calling TokenApi->CreateUserToken");

            HiarcSDK.Client.RequestOptions localVarRequestOptions = new HiarcSDK.Client.RequestOptions();

            String[] _contentTypes = new String[] {
                "application/json"
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "application/json"
            };

            var localVarContentType = HiarcSDK.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = HiarcSDK.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.Data = createUserTokenRequest;

            // authentication (AdminApiKeyAuth) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("X-Hiarc-Api-Key")))
            {
                localVarRequestOptions.HeaderParameters.Add("X-Hiarc-Api-Key", this.Configuration.GetApiKeyWithPrefix("X-Hiarc-Api-Key"));
            }

            // make the HTTP request
            var localVarResponse = this.Client.Post< UserCredentials >("/tokens/user", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("CreateUserToken", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Create a Token for a User 
        /// </summary>
        /// <exception cref="HiarcSDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createUserTokenRequest">User information</param>
        /// <returns>Task of UserCredentials</returns>
        public async System.Threading.Tasks.Task<UserCredentials> CreateUserTokenAsync (CreateUserTokenRequest createUserTokenRequest)
        {
             HiarcSDK.Client.ApiResponse<UserCredentials> localVarResponse = await CreateUserTokenAsyncWithHttpInfo(createUserTokenRequest);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create a Token for a User 
        /// </summary>
        /// <exception cref="HiarcSDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createUserTokenRequest">User information</param>
        /// <returns>Task of ApiResponse (UserCredentials)</returns>
        public async System.Threading.Tasks.Task<HiarcSDK.Client.ApiResponse<UserCredentials>> CreateUserTokenAsyncWithHttpInfo (CreateUserTokenRequest createUserTokenRequest)
        {
            // verify the required parameter 'createUserTokenRequest' is set
            if (createUserTokenRequest == null)
                throw new HiarcSDK.Client.ApiException(400, "Missing required parameter 'createUserTokenRequest' when calling TokenApi->CreateUserToken");


            HiarcSDK.Client.RequestOptions localVarRequestOptions = new HiarcSDK.Client.RequestOptions();

            String[] _contentTypes = new String[] {
                "application/json"
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "application/json"
            };
            
            foreach (var _contentType in _contentTypes)
                localVarRequestOptions.HeaderParameters.Add("Content-Type", _contentType);
            
            foreach (var _accept in _accepts)
                localVarRequestOptions.HeaderParameters.Add("Accept", _accept);
            
            localVarRequestOptions.Data = createUserTokenRequest;

            // authentication (AdminApiKeyAuth) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("X-Hiarc-Api-Key")))
            {
                localVarRequestOptions.HeaderParameters.Add("X-Hiarc-Api-Key", this.Configuration.GetApiKeyWithPrefix("X-Hiarc-Api-Key"));
            }

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.PostAsync<UserCredentials>("/tokens/user", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("CreateUserToken", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

    }
}
