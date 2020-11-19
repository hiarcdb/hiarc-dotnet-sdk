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

namespace HiarcSDK.Api
{

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IAdminApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Init the Hiarc database
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HiarcSDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Object</returns>
        Object InitDB ();

        /// <summary>
        /// Init the Hiarc database
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HiarcSDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of Object</returns>
        ApiResponse<Object> InitDBWithHttpInfo ();
        /// <summary>
        /// Reset the Hiarc database
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HiarcSDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Object</returns>
        Object ResetDB ();

        /// <summary>
        /// Reset the Hiarc database
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HiarcSDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of Object</returns>
        ApiResponse<Object> ResetDBWithHttpInfo ();
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IAdminApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// Init the Hiarc database
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HiarcSDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of Object</returns>
        System.Threading.Tasks.Task<Object> InitDBAsync ();

        /// <summary>
        /// Init the Hiarc database
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HiarcSDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (Object)</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> InitDBAsyncWithHttpInfo ();
        /// <summary>
        /// Reset the Hiarc database
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HiarcSDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of Object</returns>
        System.Threading.Tasks.Task<Object> ResetDBAsync ();

        /// <summary>
        /// Reset the Hiarc database
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="HiarcSDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (Object)</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> ResetDBAsyncWithHttpInfo ();
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IAdminApi : IAdminApiSync, IAdminApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class AdminApi : IAdminApi
    {
        private HiarcSDK.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="AdminApi"/> class.
        /// </summary>
        /// <returns></returns>
        public AdminApi() : this((string) null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AdminApi"/> class.
        /// </summary>
        /// <returns></returns>
        public AdminApi(String basePath)
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
        /// Initializes a new instance of the <see cref="AdminApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public AdminApi(HiarcSDK.Client.Configuration configuration)
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
        /// Initializes a new instance of the <see cref="AdminApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public AdminApi(HiarcSDK.Client.ISynchronousClient client,HiarcSDK.Client.IAsynchronousClient asyncClient, HiarcSDK.Client.IReadableConfiguration configuration)
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
        /// Init the Hiarc database 
        /// </summary>
        /// <exception cref="HiarcSDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Object</returns>
        public Object InitDB ()
        {
             HiarcSDK.Client.ApiResponse<Object> localVarResponse = InitDBWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        /// Init the Hiarc database 
        /// </summary>
        /// <exception cref="HiarcSDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of Object</returns>
        public HiarcSDK.Client.ApiResponse< Object > InitDBWithHttpInfo ()
        {
            HiarcSDK.Client.RequestOptions localVarRequestOptions = new HiarcSDK.Client.RequestOptions();

            String[] _contentTypes = new String[] {
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "application/json"
            };

            var localVarContentType = HiarcSDK.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = HiarcSDK.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);


            // authentication (AdminApiKeyAuth) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("X-Hiarc-Api-Key")))
            {
                localVarRequestOptions.HeaderParameters.Add("X-Hiarc-Api-Key", this.Configuration.GetApiKeyWithPrefix("X-Hiarc-Api-Key"));
            }

            // make the HTTP request
            var localVarResponse = this.Client.Post< Object >("/admin/database/init", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("InitDB", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Init the Hiarc database 
        /// </summary>
        /// <exception cref="HiarcSDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of Object</returns>
        public async System.Threading.Tasks.Task<Object> InitDBAsync ()
        {
             HiarcSDK.Client.ApiResponse<Object> localVarResponse = await InitDBAsyncWithHttpInfo();
             return localVarResponse.Data;

        }

        /// <summary>
        /// Init the Hiarc database 
        /// </summary>
        /// <exception cref="HiarcSDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (Object)</returns>
        public async System.Threading.Tasks.Task<HiarcSDK.Client.ApiResponse<Object>> InitDBAsyncWithHttpInfo ()
        {

            HiarcSDK.Client.RequestOptions localVarRequestOptions = new HiarcSDK.Client.RequestOptions();

            String[] _contentTypes = new String[] {
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "application/json"
            };
            
            foreach (var _contentType in _contentTypes)
                localVarRequestOptions.HeaderParameters.Add("Content-Type", _contentType);
            
            foreach (var _accept in _accepts)
                localVarRequestOptions.HeaderParameters.Add("Accept", _accept);
            

            // authentication (AdminApiKeyAuth) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("X-Hiarc-Api-Key")))
            {
                localVarRequestOptions.HeaderParameters.Add("X-Hiarc-Api-Key", this.Configuration.GetApiKeyWithPrefix("X-Hiarc-Api-Key"));
            }

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.PostAsync<Object>("/admin/database/init", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("InitDB", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Reset the Hiarc database 
        /// </summary>
        /// <exception cref="HiarcSDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Object</returns>
        public Object ResetDB ()
        {
             HiarcSDK.Client.ApiResponse<Object> localVarResponse = ResetDBWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        /// Reset the Hiarc database 
        /// </summary>
        /// <exception cref="HiarcSDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of Object</returns>
        public HiarcSDK.Client.ApiResponse< Object > ResetDBWithHttpInfo ()
        {
            HiarcSDK.Client.RequestOptions localVarRequestOptions = new HiarcSDK.Client.RequestOptions();

            String[] _contentTypes = new String[] {
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "application/json"
            };

            var localVarContentType = HiarcSDK.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = HiarcSDK.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);


            // authentication (AdminApiKeyAuth) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("X-Hiarc-Api-Key")))
            {
                localVarRequestOptions.HeaderParameters.Add("X-Hiarc-Api-Key", this.Configuration.GetApiKeyWithPrefix("X-Hiarc-Api-Key"));
            }

            // make the HTTP request
            var localVarResponse = this.Client.Put< Object >("/admin/database/reset", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ResetDB", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Reset the Hiarc database 
        /// </summary>
        /// <exception cref="HiarcSDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of Object</returns>
        public async System.Threading.Tasks.Task<Object> ResetDBAsync ()
        {
             HiarcSDK.Client.ApiResponse<Object> localVarResponse = await ResetDBAsyncWithHttpInfo();
             return localVarResponse.Data;

        }

        /// <summary>
        /// Reset the Hiarc database 
        /// </summary>
        /// <exception cref="HiarcSDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (Object)</returns>
        public async System.Threading.Tasks.Task<HiarcSDK.Client.ApiResponse<Object>> ResetDBAsyncWithHttpInfo ()
        {

            HiarcSDK.Client.RequestOptions localVarRequestOptions = new HiarcSDK.Client.RequestOptions();

            String[] _contentTypes = new String[] {
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "application/json"
            };
            
            foreach (var _contentType in _contentTypes)
                localVarRequestOptions.HeaderParameters.Add("Content-Type", _contentType);
            
            foreach (var _accept in _accepts)
                localVarRequestOptions.HeaderParameters.Add("Accept", _accept);
            

            // authentication (AdminApiKeyAuth) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("X-Hiarc-Api-Key")))
            {
                localVarRequestOptions.HeaderParameters.Add("X-Hiarc-Api-Key", this.Configuration.GetApiKeyWithPrefix("X-Hiarc-Api-Key"));
            }

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.PutAsync<Object>("/admin/database/reset", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ResetDB", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

    }
}
