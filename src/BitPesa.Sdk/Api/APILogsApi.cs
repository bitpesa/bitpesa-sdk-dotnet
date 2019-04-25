/* 
 * BitPesa API
 *
 * Reference documentation for the BitPesa API V1
 *
 * OpenAPI spec version: 1.0
 * 
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp;
using BitPesa.Sdk.Client;
using BitPesa.Sdk.Model;

namespace BitPesa.Sdk.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IAPILogsApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Fetch an individual API log
        /// </summary>
        /// <remarks>
        /// Returns a single API log based on the API log ID.
        /// </remarks>
        /// <exception cref="BitPesa.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aPILogID">ID of the API log to retrieve  Example: &#x60;/v1/api_logs/00485ce9-532b-45e7-8518-7e5582242407&#x60;</param>
        /// <returns>ApiLogResponse</returns>
        ApiLogResponse GetApiLog (Guid? aPILogID);

        /// <summary>
        /// Fetch an individual API log
        /// </summary>
        /// <remarks>
        /// Returns a single API log based on the API log ID.
        /// </remarks>
        /// <exception cref="BitPesa.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aPILogID">ID of the API log to retrieve  Example: &#x60;/v1/api_logs/00485ce9-532b-45e7-8518-7e5582242407&#x60;</param>
        /// <returns>ApiResponse of ApiLogResponse</returns>
        ApiResponse<ApiLogResponse> GetApiLogWithHttpInfo (Guid? aPILogID);
        /// <summary>
        /// Fetch a list of API logs
        /// </summary>
        /// <remarks>
        /// Returns a list of API logs. Also includes information relating to the original request.
        /// </remarks>
        /// <exception cref="BitPesa.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">The page number to request (defaults to 1) (optional)</param>
        /// <param name="per">The number of results to load per page (defaults to 10) (optional)</param>
        /// <param name="createdAtFrom">Start date to filter recipients by created_at range Allows filtering results by the specified &#x60;created_at&#x60; timeframe.  Example: &#x60;/v1/recipients?created_at_from&#x3D;2018-06-06&amp;created_at_to&#x3D;2018-06-08&#x60; (optional)</param>
        /// <param name="createdAtTo">End date to filter recipients by created_at range Allows filtering results by the specified &#x60;created_at&#x60; timeframe.  Example: &#x60;/v1/recipients?created_at_from&#x3D;2018-06-06&amp;created_at_to&#x3D;2018-06-08&#x60; (optional)</param>
        /// <returns>ApiLogListResponse</returns>
        ApiLogListResponse GetApiLogs (int? page = null, int? per = null, string createdAtFrom = null, string createdAtTo = null);

        /// <summary>
        /// Fetch a list of API logs
        /// </summary>
        /// <remarks>
        /// Returns a list of API logs. Also includes information relating to the original request.
        /// </remarks>
        /// <exception cref="BitPesa.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">The page number to request (defaults to 1) (optional)</param>
        /// <param name="per">The number of results to load per page (defaults to 10) (optional)</param>
        /// <param name="createdAtFrom">Start date to filter recipients by created_at range Allows filtering results by the specified &#x60;created_at&#x60; timeframe.  Example: &#x60;/v1/recipients?created_at_from&#x3D;2018-06-06&amp;created_at_to&#x3D;2018-06-08&#x60; (optional)</param>
        /// <param name="createdAtTo">End date to filter recipients by created_at range Allows filtering results by the specified &#x60;created_at&#x60; timeframe.  Example: &#x60;/v1/recipients?created_at_from&#x3D;2018-06-06&amp;created_at_to&#x3D;2018-06-08&#x60; (optional)</param>
        /// <returns>ApiResponse of ApiLogListResponse</returns>
        ApiResponse<ApiLogListResponse> GetApiLogsWithHttpInfo (int? page = null, int? per = null, string createdAtFrom = null, string createdAtTo = null);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Fetch an individual API log
        /// </summary>
        /// <remarks>
        /// Returns a single API log based on the API log ID.
        /// </remarks>
        /// <exception cref="BitPesa.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aPILogID">ID of the API log to retrieve  Example: &#x60;/v1/api_logs/00485ce9-532b-45e7-8518-7e5582242407&#x60;</param>
        /// <returns>Task of ApiLogResponse</returns>
        System.Threading.Tasks.Task<ApiLogResponse> GetApiLogAsync (Guid? aPILogID);

        /// <summary>
        /// Fetch an individual API log
        /// </summary>
        /// <remarks>
        /// Returns a single API log based on the API log ID.
        /// </remarks>
        /// <exception cref="BitPesa.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aPILogID">ID of the API log to retrieve  Example: &#x60;/v1/api_logs/00485ce9-532b-45e7-8518-7e5582242407&#x60;</param>
        /// <returns>Task of ApiResponse (ApiLogResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ApiLogResponse>> GetApiLogAsyncWithHttpInfo (Guid? aPILogID);
        /// <summary>
        /// Fetch a list of API logs
        /// </summary>
        /// <remarks>
        /// Returns a list of API logs. Also includes information relating to the original request.
        /// </remarks>
        /// <exception cref="BitPesa.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">The page number to request (defaults to 1) (optional)</param>
        /// <param name="per">The number of results to load per page (defaults to 10) (optional)</param>
        /// <param name="createdAtFrom">Start date to filter recipients by created_at range Allows filtering results by the specified &#x60;created_at&#x60; timeframe.  Example: &#x60;/v1/recipients?created_at_from&#x3D;2018-06-06&amp;created_at_to&#x3D;2018-06-08&#x60; (optional)</param>
        /// <param name="createdAtTo">End date to filter recipients by created_at range Allows filtering results by the specified &#x60;created_at&#x60; timeframe.  Example: &#x60;/v1/recipients?created_at_from&#x3D;2018-06-06&amp;created_at_to&#x3D;2018-06-08&#x60; (optional)</param>
        /// <returns>Task of ApiLogListResponse</returns>
        System.Threading.Tasks.Task<ApiLogListResponse> GetApiLogsAsync (int? page = null, int? per = null, string createdAtFrom = null, string createdAtTo = null);

        /// <summary>
        /// Fetch a list of API logs
        /// </summary>
        /// <remarks>
        /// Returns a list of API logs. Also includes information relating to the original request.
        /// </remarks>
        /// <exception cref="BitPesa.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">The page number to request (defaults to 1) (optional)</param>
        /// <param name="per">The number of results to load per page (defaults to 10) (optional)</param>
        /// <param name="createdAtFrom">Start date to filter recipients by created_at range Allows filtering results by the specified &#x60;created_at&#x60; timeframe.  Example: &#x60;/v1/recipients?created_at_from&#x3D;2018-06-06&amp;created_at_to&#x3D;2018-06-08&#x60; (optional)</param>
        /// <param name="createdAtTo">End date to filter recipients by created_at range Allows filtering results by the specified &#x60;created_at&#x60; timeframe.  Example: &#x60;/v1/recipients?created_at_from&#x3D;2018-06-06&amp;created_at_to&#x3D;2018-06-08&#x60; (optional)</param>
        /// <returns>Task of ApiResponse (ApiLogListResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ApiLogListResponse>> GetApiLogsAsyncWithHttpInfo (int? page = null, int? per = null, string createdAtFrom = null, string createdAtTo = null);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class APILogsApi : IAPILogsApi
    {
        private BitPesa.Sdk.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="APILogsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public APILogsApi(String basePath)
        {
            this.Configuration = new BitPesa.Sdk.Client.Configuration { BasePath = basePath };

            ExceptionFactory = BitPesa.Sdk.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="APILogsApi"/> class
        /// </summary>
        /// <returns></returns>
        public APILogsApi()
        {
            this.Configuration = BitPesa.Sdk.Client.Configuration.Default;

            ExceptionFactory = BitPesa.Sdk.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="APILogsApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public APILogsApi(BitPesa.Sdk.Client.Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = BitPesa.Sdk.Client.Configuration.Default;
            else
                this.Configuration = configuration;

            ExceptionFactory = BitPesa.Sdk.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.ApiClient.RestClient.BaseUrl.ToString();
        }

        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        [Obsolete("SetBasePath is deprecated, please do 'Configuration.ApiClient = new ApiClient(\"http://new-path\")' instead.")]
        public void SetBasePath(String basePath)
        {
            // do nothing
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public BitPesa.Sdk.Client.Configuration Configuration {get; set;}

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public BitPesa.Sdk.Client.ExceptionFactory ExceptionFactory
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
        /// Gets the default header.
        /// </summary>
        /// <returns>Dictionary of HTTP header</returns>
        [Obsolete("DefaultHeader is deprecated, please use Configuration.DefaultHeader instead.")]
        public IDictionary<String, String> DefaultHeader()
        {
            return new ReadOnlyDictionary<string, string>(this.Configuration.DefaultHeader);
        }

        /// <summary>
        /// Add default header.
        /// </summary>
        /// <param name="key">Header field name.</param>
        /// <param name="value">Header field value.</param>
        /// <returns></returns>
        [Obsolete("AddDefaultHeader is deprecated, please use Configuration.AddDefaultHeader instead.")]
        public void AddDefaultHeader(string key, string value)
        {
            this.Configuration.AddDefaultHeader(key, value);
        }

        /// <summary>
        /// Fetch an individual API log Returns a single API log based on the API log ID.
        /// </summary>
        /// <exception cref="BitPesa.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aPILogID">ID of the API log to retrieve  Example: &#x60;/v1/api_logs/00485ce9-532b-45e7-8518-7e5582242407&#x60;</param>
        /// <returns>ApiLogResponse</returns>
        public ApiLogResponse GetApiLog (Guid? aPILogID)
        {
             ApiResponse<ApiLogResponse> localVarResponse = GetApiLogWithHttpInfo(aPILogID);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Fetch an individual API log Returns a single API log based on the API log ID.
        /// </summary>
        /// <exception cref="BitPesa.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aPILogID">ID of the API log to retrieve  Example: &#x60;/v1/api_logs/00485ce9-532b-45e7-8518-7e5582242407&#x60;</param>
        /// <returns>ApiResponse of ApiLogResponse</returns>
        public ApiResponse< ApiLogResponse > GetApiLogWithHttpInfo (Guid? aPILogID)
        {
            // verify the required parameter 'aPILogID' is set
            if (aPILogID == null)
                throw new ApiException(400, "Missing required parameter 'aPILogID' when calling APILogsApi->GetApiLog");

            var localVarPath = "/api_logs/{API Log ID}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (aPILogID != null) localVarPathParams.Add("API Log ID", this.Configuration.ApiClient.ParameterToString(aPILogID)); // path parameter

            var request = new RestRequest(localVarPath, Method.GET);

            // add path and query parameter, if any
            foreach (var param in localVarPathParams)
                request.AddParameter(param.Key, param.Value, ParameterType.UrlSegment);

            foreach (var param in localVarQueryParams)
                request.AddQueryParameter(param.Key, param.Value);

            // generate full URL
            string fullUri = this.Configuration.ApiClient.RestClient.BuildUri(request).AbsoluteUri;

			string nonce = System.Guid.NewGuid().ToString();
            string authSignature = this.Configuration.GetSignature(nonce, fullUri, "GET", localVarPostBody == null ? "" : localVarPostBody.ToString());
			localVarHeaderParams.Add("Authorization-Key", this.Configuration.ApiKey);
            localVarHeaderParams.Add("Authorization-Nonce", nonce);
			localVarHeaderParams.Add("Authorization-Signature", authSignature);

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetApiLog", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiLogResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (ApiLogResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiLogResponse)));
        }

        /// <summary>
        /// Fetch an individual API log Returns a single API log based on the API log ID.
        /// </summary>
        /// <exception cref="BitPesa.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aPILogID">ID of the API log to retrieve  Example: &#x60;/v1/api_logs/00485ce9-532b-45e7-8518-7e5582242407&#x60;</param>
        /// <returns>Task of ApiLogResponse</returns>
        public async System.Threading.Tasks.Task<ApiLogResponse> GetApiLogAsync (Guid? aPILogID)
        {
             ApiResponse<ApiLogResponse> localVarResponse = await GetApiLogAsyncWithHttpInfo(aPILogID);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Fetch an individual API log Returns a single API log based on the API log ID.
        /// </summary>
        /// <exception cref="BitPesa.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aPILogID">ID of the API log to retrieve  Example: &#x60;/v1/api_logs/00485ce9-532b-45e7-8518-7e5582242407&#x60;</param>
        /// <returns>Task of ApiResponse (ApiLogResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ApiLogResponse>> GetApiLogAsyncWithHttpInfo (Guid? aPILogID)
        {
            // verify the required parameter 'aPILogID' is set
            if (aPILogID == null)
                throw new ApiException(400, "Missing required parameter 'aPILogID' when calling APILogsApi->GetApiLog");

            var localVarPath = "/api_logs/{API Log ID}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (aPILogID != null) localVarPathParams.Add("API Log ID", this.Configuration.ApiClient.ParameterToString(aPILogID)); // path parameter

            var request = new RestRequest(localVarPath, Method.GET);

            // add path parameter, if any
            foreach (var param in localVarPathParams)
                request.AddParameter(param.Key, param.Value, ParameterType.UrlSegment);

            foreach (var param in localVarQueryParams)
                request.AddQueryParameter(param.Key, param.Value);

            // generate full URL
            string fullUri = this.Configuration.ApiClient.RestClient.BuildUri(request).AbsoluteUri;

			string nonce = System.Guid.NewGuid().ToString();
            string authSignature = this.Configuration.GetSignature(nonce, fullUri, "GET", localVarPostBody == null ? "" : localVarPostBody.ToString());
			localVarHeaderParams.Add("Authorization-Key", this.Configuration.ApiKey);
            localVarHeaderParams.Add("Authorization-Nonce", nonce);
			localVarHeaderParams.Add("Authorization-Signature", authSignature);

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetApiLog", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiLogResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (ApiLogResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiLogResponse)));
        }

        /// <summary>
        /// Fetch a list of API logs Returns a list of API logs. Also includes information relating to the original request.
        /// </summary>
        /// <exception cref="BitPesa.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">The page number to request (defaults to 1) (optional)</param>
        /// <param name="per">The number of results to load per page (defaults to 10) (optional)</param>
        /// <param name="createdAtFrom">Start date to filter recipients by created_at range Allows filtering results by the specified &#x60;created_at&#x60; timeframe.  Example: &#x60;/v1/recipients?created_at_from&#x3D;2018-06-06&amp;created_at_to&#x3D;2018-06-08&#x60; (optional)</param>
        /// <param name="createdAtTo">End date to filter recipients by created_at range Allows filtering results by the specified &#x60;created_at&#x60; timeframe.  Example: &#x60;/v1/recipients?created_at_from&#x3D;2018-06-06&amp;created_at_to&#x3D;2018-06-08&#x60; (optional)</param>
        /// <returns>ApiLogListResponse</returns>
        public ApiLogListResponse GetApiLogs (int? page = null, int? per = null, string createdAtFrom = null, string createdAtTo = null)
        {
             ApiResponse<ApiLogListResponse> localVarResponse = GetApiLogsWithHttpInfo(page, per, createdAtFrom, createdAtTo);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Fetch a list of API logs Returns a list of API logs. Also includes information relating to the original request.
        /// </summary>
        /// <exception cref="BitPesa.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">The page number to request (defaults to 1) (optional)</param>
        /// <param name="per">The number of results to load per page (defaults to 10) (optional)</param>
        /// <param name="createdAtFrom">Start date to filter recipients by created_at range Allows filtering results by the specified &#x60;created_at&#x60; timeframe.  Example: &#x60;/v1/recipients?created_at_from&#x3D;2018-06-06&amp;created_at_to&#x3D;2018-06-08&#x60; (optional)</param>
        /// <param name="createdAtTo">End date to filter recipients by created_at range Allows filtering results by the specified &#x60;created_at&#x60; timeframe.  Example: &#x60;/v1/recipients?created_at_from&#x3D;2018-06-06&amp;created_at_to&#x3D;2018-06-08&#x60; (optional)</param>
        /// <returns>ApiResponse of ApiLogListResponse</returns>
        public ApiResponse< ApiLogListResponse > GetApiLogsWithHttpInfo (int? page = null, int? per = null, string createdAtFrom = null, string createdAtTo = null)
        {

            var localVarPath = "/api_logs";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (page != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "page", page)); // query parameter
            if (per != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "per", per)); // query parameter
            if (createdAtFrom != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "created_at_from", createdAtFrom)); // query parameter
            if (createdAtTo != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "created_at_to", createdAtTo)); // query parameter

            var request = new RestRequest(localVarPath, Method.GET);

            // add path and query parameter, if any
            foreach (var param in localVarPathParams)
                request.AddParameter(param.Key, param.Value, ParameterType.UrlSegment);

            foreach (var param in localVarQueryParams)
                request.AddQueryParameter(param.Key, param.Value);

            // generate full URL
            string fullUri = this.Configuration.ApiClient.RestClient.BuildUri(request).AbsoluteUri;

			string nonce = System.Guid.NewGuid().ToString();
            string authSignature = this.Configuration.GetSignature(nonce, fullUri, "GET", localVarPostBody == null ? "" : localVarPostBody.ToString());
			localVarHeaderParams.Add("Authorization-Key", this.Configuration.ApiKey);
            localVarHeaderParams.Add("Authorization-Nonce", nonce);
			localVarHeaderParams.Add("Authorization-Signature", authSignature);

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetApiLogs", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiLogListResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (ApiLogListResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiLogListResponse)));
        }

        /// <summary>
        /// Fetch a list of API logs Returns a list of API logs. Also includes information relating to the original request.
        /// </summary>
        /// <exception cref="BitPesa.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">The page number to request (defaults to 1) (optional)</param>
        /// <param name="per">The number of results to load per page (defaults to 10) (optional)</param>
        /// <param name="createdAtFrom">Start date to filter recipients by created_at range Allows filtering results by the specified &#x60;created_at&#x60; timeframe.  Example: &#x60;/v1/recipients?created_at_from&#x3D;2018-06-06&amp;created_at_to&#x3D;2018-06-08&#x60; (optional)</param>
        /// <param name="createdAtTo">End date to filter recipients by created_at range Allows filtering results by the specified &#x60;created_at&#x60; timeframe.  Example: &#x60;/v1/recipients?created_at_from&#x3D;2018-06-06&amp;created_at_to&#x3D;2018-06-08&#x60; (optional)</param>
        /// <returns>Task of ApiLogListResponse</returns>
        public async System.Threading.Tasks.Task<ApiLogListResponse> GetApiLogsAsync (int? page = null, int? per = null, string createdAtFrom = null, string createdAtTo = null)
        {
             ApiResponse<ApiLogListResponse> localVarResponse = await GetApiLogsAsyncWithHttpInfo(page, per, createdAtFrom, createdAtTo);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Fetch a list of API logs Returns a list of API logs. Also includes information relating to the original request.
        /// </summary>
        /// <exception cref="BitPesa.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">The page number to request (defaults to 1) (optional)</param>
        /// <param name="per">The number of results to load per page (defaults to 10) (optional)</param>
        /// <param name="createdAtFrom">Start date to filter recipients by created_at range Allows filtering results by the specified &#x60;created_at&#x60; timeframe.  Example: &#x60;/v1/recipients?created_at_from&#x3D;2018-06-06&amp;created_at_to&#x3D;2018-06-08&#x60; (optional)</param>
        /// <param name="createdAtTo">End date to filter recipients by created_at range Allows filtering results by the specified &#x60;created_at&#x60; timeframe.  Example: &#x60;/v1/recipients?created_at_from&#x3D;2018-06-06&amp;created_at_to&#x3D;2018-06-08&#x60; (optional)</param>
        /// <returns>Task of ApiResponse (ApiLogListResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ApiLogListResponse>> GetApiLogsAsyncWithHttpInfo (int? page = null, int? per = null, string createdAtFrom = null, string createdAtTo = null)
        {

            var localVarPath = "/api_logs";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (page != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "page", page)); // query parameter
            if (per != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "per", per)); // query parameter
            if (createdAtFrom != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "created_at_from", createdAtFrom)); // query parameter
            if (createdAtTo != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "created_at_to", createdAtTo)); // query parameter

            var request = new RestRequest(localVarPath, Method.GET);

            // add path parameter, if any
            foreach (var param in localVarPathParams)
                request.AddParameter(param.Key, param.Value, ParameterType.UrlSegment);

            foreach (var param in localVarQueryParams)
                request.AddQueryParameter(param.Key, param.Value);

            // generate full URL
            string fullUri = this.Configuration.ApiClient.RestClient.BuildUri(request).AbsoluteUri;

			string nonce = System.Guid.NewGuid().ToString();
            string authSignature = this.Configuration.GetSignature(nonce, fullUri, "GET", localVarPostBody == null ? "" : localVarPostBody.ToString());
			localVarHeaderParams.Add("Authorization-Key", this.Configuration.ApiKey);
            localVarHeaderParams.Add("Authorization-Nonce", nonce);
			localVarHeaderParams.Add("Authorization-Signature", authSignature);

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetApiLogs", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiLogListResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (ApiLogListResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiLogListResponse)));
        }

    }
}
