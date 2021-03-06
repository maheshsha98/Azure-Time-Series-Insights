// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.TimeSeriesInsights.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Partial list of time series instances returned in a single request.
    /// </summary>
    public partial class GetInstancesPage : PagedResponse
    {
        /// <summary>
        /// Initializes a new instance of the GetInstancesPage class.
        /// </summary>
        public GetInstancesPage()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the GetInstancesPage class.
        /// </summary>
        /// <param name="continuationToken">If returned, this means that
        /// current results represent a partial result. Continuation token
        /// allows to get the next page of results. To get the next page of
        /// query results, send the same request with continuation token
        /// parameter in "x-ms-continuation" HTTP header.</param>
        /// <param name="instances">Partial list of time series instances
        /// returned in a single request. Can be empty if server was unable to
        /// fill the page in this request, or there is no more objects when
        /// continuation token is null.</param>
        public GetInstancesPage(string continuationToken = default(string), IList<TimeSeriesInstance> instances = default(IList<TimeSeriesInstance>))
            : base(continuationToken)
        {
            Instances = instances;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets partial list of time series instances returned in a single
        /// request. Can be empty if server was unable to fill the page in this
        /// request, or there is no more objects when continuation token is
        /// null.
        /// </summary>
        [JsonProperty(PropertyName = "instances")]
        public IList<TimeSeriesInstance> Instances { get; private set; }

    }
}
