// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.TimeSeriesInsights
{
    using Microsoft.Rest;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// TimeSeriesTypes operations.
    /// </summary>
    public partial interface ITimeSeriesTypes
    {
        /// <summary>
        /// Gets time series types in pages.
        /// </summary>
        /// <param name='continuationToken'>
        /// Continuation token from previous page of results to retrieve the
        /// next page of the results in calls that support pagination. To get
        /// the first page results, specify null continuation token as
        /// parameter value. Returned continuation token is null if all results
        /// have been returned, and there is no next page of results.
        /// </param>
        /// <param name='clientRequestId'>
        /// Optional client request ID. Service records this value. Allows the
        /// service to trace operation across services, and allows the customer
        /// to contact support regarding a particular request.
        /// </param>
        /// <param name='clientSessionId'>
        /// Optional client session ID. Service records this value. Allows the
        /// service to trace a group of related operations across services, and
        /// allows the customer to contact support regarding a particular group
        /// of requests.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="TsiErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<HttpOperationResponse<GetTypesPage,TimeSeriesTypesListHeaders>> ListWithHttpMessagesAsync(string continuationToken = default(string), string clientRequestId = default(string), string clientSessionId = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Executes a batch get, create, update, delete operation on multiple
        /// time series types.
        /// </summary>
        /// <param name='parameters'>
        /// Time series types batch request body.
        /// </param>
        /// <param name='clientRequestId'>
        /// Optional client request ID. Service records this value. Allows the
        /// service to trace operation across services, and allows the customer
        /// to contact support regarding a particular request.
        /// </param>
        /// <param name='clientSessionId'>
        /// Optional client session ID. Service records this value. Allows the
        /// service to trace a group of related operations across services, and
        /// allows the customer to contact support regarding a particular group
        /// of requests.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="TsiErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<HttpOperationResponse<TypesBatchResponse,TimeSeriesTypesExecuteBatchHeaders>> ExecuteBatchWithHttpMessagesAsync(TypesBatchRequest parameters, string clientRequestId = default(string), string clientSessionId = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}
