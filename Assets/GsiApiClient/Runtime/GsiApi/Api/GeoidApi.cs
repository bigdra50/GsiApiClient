/*
 * 国土地理院測量計算API
 *
 * 国土地理院が提供する測量計算のためのREST API
 *
 * The version of the OpenAPI document: 1.0.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Net.Mime;
using GsiApi.Client;
using GsiApi.Model;

namespace GsiApi.Api
{

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IGeoidApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// ジオイド高
        /// </summary>
        /// <exception cref="GsiApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="outputType"></param>
        /// <param name="latitude"></param>
        /// <param name="longitude"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>GeoidCalcghCgiGeoidcalcPlGet200Response</returns>
        GeoidCalcghCgiGeoidcalcPlGet200Response GeoidCalcghCgiGeoidcalcPlGet(string outputType, double latitude, double longitude, int operationIndex = 0);

        /// <summary>
        /// ジオイド高
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="GsiApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="outputType"></param>
        /// <param name="latitude"></param>
        /// <param name="longitude"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of GeoidCalcghCgiGeoidcalcPlGet200Response</returns>
        ApiResponse<GeoidCalcghCgiGeoidcalcPlGet200Response> GeoidCalcghCgiGeoidcalcPlGetWithHttpInfo(string outputType, double latitude, double longitude, int operationIndex = 0);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IGeoidApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// ジオイド高
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="GsiApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="outputType"></param>
        /// <param name="latitude"></param>
        /// <param name="longitude"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of GeoidCalcghCgiGeoidcalcPlGet200Response</returns>
        System.Threading.Tasks.Task<GeoidCalcghCgiGeoidcalcPlGet200Response> GeoidCalcghCgiGeoidcalcPlGetAsync(string outputType, double latitude, double longitude, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// ジオイド高
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="GsiApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="outputType"></param>
        /// <param name="latitude"></param>
        /// <param name="longitude"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (GeoidCalcghCgiGeoidcalcPlGet200Response)</returns>
        System.Threading.Tasks.Task<ApiResponse<GeoidCalcghCgiGeoidcalcPlGet200Response>> GeoidCalcghCgiGeoidcalcPlGetWithHttpInfoAsync(string outputType, double latitude, double longitude, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IGeoidApi : IGeoidApiSync, IGeoidApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class GeoidApi : IGeoidApi
    {
        private GsiApi.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="GeoidApi"/> class.
        /// </summary>
        /// <returns></returns>
        public GeoidApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GeoidApi"/> class.
        /// </summary>
        /// <returns></returns>
        public GeoidApi(string basePath)
        {
            this.Configuration = GsiApi.Client.Configuration.MergeConfigurations(
                GsiApi.Client.GlobalConfiguration.Instance,
                new GsiApi.Client.Configuration { BasePath = basePath }
            );
            this.Client = new GsiApi.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new GsiApi.Client.ApiClient(this.Configuration.BasePath);
            this.ExceptionFactory = GsiApi.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GeoidApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public GeoidApi(GsiApi.Client.Configuration configuration)
        {
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Configuration = GsiApi.Client.Configuration.MergeConfigurations(
                GsiApi.Client.GlobalConfiguration.Instance,
                configuration
            );
            this.Client = new GsiApi.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new GsiApi.Client.ApiClient(this.Configuration.BasePath);
            ExceptionFactory = GsiApi.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GeoidApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public GeoidApi(GsiApi.Client.ISynchronousClient client, GsiApi.Client.IAsynchronousClient asyncClient, GsiApi.Client.IReadableConfiguration configuration)
        {
            if (client == null) throw new ArgumentNullException("client");
            if (asyncClient == null) throw new ArgumentNullException("asyncClient");
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Client = client;
            this.AsynchronousClient = asyncClient;
            this.Configuration = configuration;
            this.ExceptionFactory = GsiApi.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// The client for accessing this underlying API asynchronously.
        /// </summary>
        public GsiApi.Client.IAsynchronousClient AsynchronousClient { get; set; }

        /// <summary>
        /// The client for accessing this underlying API synchronously.
        /// </summary>
        public GsiApi.Client.ISynchronousClient Client { get; set; }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public string GetBasePath()
        {
            return this.Configuration.BasePath;
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public GsiApi.Client.IReadableConfiguration Configuration { get; set; }

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public GsiApi.Client.ExceptionFactory ExceptionFactory
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
        /// ジオイド高 
        /// </summary>
        /// <exception cref="GsiApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="outputType"></param>
        /// <param name="latitude"></param>
        /// <param name="longitude"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>GeoidCalcghCgiGeoidcalcPlGet200Response</returns>
        public GeoidCalcghCgiGeoidcalcPlGet200Response GeoidCalcghCgiGeoidcalcPlGet(string outputType, double latitude, double longitude, int operationIndex = 0)
        {
            GsiApi.Client.ApiResponse<GeoidCalcghCgiGeoidcalcPlGet200Response> localVarResponse = GeoidCalcghCgiGeoidcalcPlGetWithHttpInfo(outputType, latitude, longitude);
            return localVarResponse.Data;
        }

        /// <summary>
        /// ジオイド高 
        /// </summary>
        /// <exception cref="GsiApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="outputType"></param>
        /// <param name="latitude"></param>
        /// <param name="longitude"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of GeoidCalcghCgiGeoidcalcPlGet200Response</returns>
        public GsiApi.Client.ApiResponse<GeoidCalcghCgiGeoidcalcPlGet200Response> GeoidCalcghCgiGeoidcalcPlGetWithHttpInfo(string outputType, double latitude, double longitude, int operationIndex = 0)
        {
            // verify the required parameter 'outputType' is set
            if (outputType == null)
            {
                throw new GsiApi.Client.ApiException(400, "Missing required parameter 'outputType' when calling GeoidApi->GeoidCalcghCgiGeoidcalcPlGet");
            }

            GsiApi.Client.RequestOptions localVarRequestOptions = new GsiApi.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json",
                "application/xml"
            };

            var localVarContentType = GsiApi.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = GsiApi.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.QueryParameters.Add(GsiApi.Client.ClientUtils.ParameterToMultiMap("", "outputType", outputType));
            localVarRequestOptions.QueryParameters.Add(GsiApi.Client.ClientUtils.ParameterToMultiMap("", "latitude", latitude));
            localVarRequestOptions.QueryParameters.Add(GsiApi.Client.ClientUtils.ParameterToMultiMap("", "longitude", longitude));

            localVarRequestOptions.Operation = "GeoidApi.GeoidCalcghCgiGeoidcalcPlGet";
            localVarRequestOptions.OperationIndex = operationIndex;


            // make the HTTP request
            var localVarResponse = this.Client.Get<GeoidCalcghCgiGeoidcalcPlGet200Response>("/geoid/calcgh/cgi/geoidcalc.pl", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GeoidCalcghCgiGeoidcalcPlGet", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// ジオイド高 
        /// </summary>
        /// <exception cref="GsiApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="outputType"></param>
        /// <param name="latitude"></param>
        /// <param name="longitude"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of GeoidCalcghCgiGeoidcalcPlGet200Response</returns>
        public async System.Threading.Tasks.Task<GeoidCalcghCgiGeoidcalcPlGet200Response> GeoidCalcghCgiGeoidcalcPlGetAsync(string outputType, double latitude, double longitude, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            GsiApi.Client.ApiResponse<GeoidCalcghCgiGeoidcalcPlGet200Response> localVarResponse = await GeoidCalcghCgiGeoidcalcPlGetWithHttpInfoAsync(outputType, latitude, longitude, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// ジオイド高 
        /// </summary>
        /// <exception cref="GsiApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="outputType"></param>
        /// <param name="latitude"></param>
        /// <param name="longitude"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (GeoidCalcghCgiGeoidcalcPlGet200Response)</returns>
        public async System.Threading.Tasks.Task<GsiApi.Client.ApiResponse<GeoidCalcghCgiGeoidcalcPlGet200Response>> GeoidCalcghCgiGeoidcalcPlGetWithHttpInfoAsync(string outputType, double latitude, double longitude, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'outputType' is set
            if (outputType == null)
            {
                throw new GsiApi.Client.ApiException(400, "Missing required parameter 'outputType' when calling GeoidApi->GeoidCalcghCgiGeoidcalcPlGet");
            }


            GsiApi.Client.RequestOptions localVarRequestOptions = new GsiApi.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json",
                "application/xml"
            };

            var localVarContentType = GsiApi.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = GsiApi.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.QueryParameters.Add(GsiApi.Client.ClientUtils.ParameterToMultiMap("", "outputType", outputType));
            localVarRequestOptions.QueryParameters.Add(GsiApi.Client.ClientUtils.ParameterToMultiMap("", "latitude", latitude));
            localVarRequestOptions.QueryParameters.Add(GsiApi.Client.ClientUtils.ParameterToMultiMap("", "longitude", longitude));

            localVarRequestOptions.Operation = "GeoidApi.GeoidCalcghCgiGeoidcalcPlGet";
            localVarRequestOptions.OperationIndex = operationIndex;


            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.GetAsync<GeoidCalcghCgiGeoidcalcPlGet200Response>("/geoid/calcgh/cgi/geoidcalc.pl", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GeoidCalcghCgiGeoidcalcPlGet", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

    }
}
