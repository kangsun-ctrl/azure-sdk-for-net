// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.WorkloadMonitor.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Information about the monitor’s current health status.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class HealthMonitor : Resource
    {
        /// <summary>
        /// Initializes a new instance of the HealthMonitor class.
        /// </summary>
        public HealthMonitor()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the HealthMonitor class.
        /// </summary>
        /// <param name="id">The resource Id.</param>
        /// <param name="name">The resource name.</param>
        /// <param name="type">The resource type.</param>
        /// <param name="monitorName">Human-readable name of the
        /// monitor.</param>
        /// <param name="monitorType">Type of the monitor.</param>
        /// <param name="monitoredObject">Dynamic monitored object of the
        /// monitor.</param>
        /// <param name="parentMonitorName">Name of the parent monitor.</param>
        /// <param name="previousMonitorState">Previous health state of the
        /// monitor. Possible values include: 'Healthy', 'Critical', 'Warning',
        /// 'Unknown', 'Disabled', 'None'</param>
        /// <param name="currentMonitorState">Current health state of the
        /// monitor. Possible values include: 'Healthy', 'Critical', 'Warning',
        /// 'Unknown', 'Disabled', 'None'</param>
        /// <param name="evaluationTimestamp">Timestamp of the monitor's last
        /// health evaluation.</param>
        /// <param name="currentStateFirstObservedTimestamp">Timestamp of the
        /// monitor's last health state change.</param>
        /// <param name="lastReportedTimestamp">Timestamp of the monitor's last
        /// reported health state.</param>
        /// <param name="evidence">Evidence validating the monitor's current
        /// health state.</param>
        /// <param name="monitorConfiguration">The configuration settings at
        /// the time of the monitor's health evaluation.</param>
        public HealthMonitor(string id = default(string), string name = default(string), string type = default(string), string monitorName = default(string), string monitorType = default(string), string monitoredObject = default(string), string parentMonitorName = default(string), string previousMonitorState = default(string), string currentMonitorState = default(string), string evaluationTimestamp = default(string), string currentStateFirstObservedTimestamp = default(string), string lastReportedTimestamp = default(string), object evidence = default(object), object monitorConfiguration = default(object))
            : base(id, name, type)
        {
            MonitorName = monitorName;
            MonitorType = monitorType;
            MonitoredObject = monitoredObject;
            ParentMonitorName = parentMonitorName;
            PreviousMonitorState = previousMonitorState;
            CurrentMonitorState = currentMonitorState;
            EvaluationTimestamp = evaluationTimestamp;
            CurrentStateFirstObservedTimestamp = currentStateFirstObservedTimestamp;
            LastReportedTimestamp = lastReportedTimestamp;
            Evidence = evidence;
            MonitorConfiguration = monitorConfiguration;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets human-readable name of the monitor.
        /// </summary>
        [JsonProperty(PropertyName = "properties.monitorName")]
        public string MonitorName { get; set; }

        /// <summary>
        /// Gets or sets type of the monitor.
        /// </summary>
        [JsonProperty(PropertyName = "properties.monitorType")]
        public string MonitorType { get; set; }

        /// <summary>
        /// Gets or sets dynamic monitored object of the monitor.
        /// </summary>
        [JsonProperty(PropertyName = "properties.monitoredObject")]
        public string MonitoredObject { get; set; }

        /// <summary>
        /// Gets or sets name of the parent monitor.
        /// </summary>
        [JsonProperty(PropertyName = "properties.parentMonitorName")]
        public string ParentMonitorName { get; set; }

        /// <summary>
        /// Gets or sets previous health state of the monitor. Possible values
        /// include: 'Healthy', 'Critical', 'Warning', 'Unknown', 'Disabled',
        /// 'None'
        /// </summary>
        [JsonProperty(PropertyName = "properties.previousMonitorState")]
        public string PreviousMonitorState { get; set; }

        /// <summary>
        /// Gets or sets current health state of the monitor. Possible values
        /// include: 'Healthy', 'Critical', 'Warning', 'Unknown', 'Disabled',
        /// 'None'
        /// </summary>
        [JsonProperty(PropertyName = "properties.currentMonitorState")]
        public string CurrentMonitorState { get; set; }

        /// <summary>
        /// Gets or sets timestamp of the monitor's last health evaluation.
        /// </summary>
        [JsonProperty(PropertyName = "properties.evaluationTimestamp")]
        public string EvaluationTimestamp { get; set; }

        /// <summary>
        /// Gets or sets timestamp of the monitor's last health state change.
        /// </summary>
        [JsonProperty(PropertyName = "properties.currentStateFirstObservedTimestamp")]
        public string CurrentStateFirstObservedTimestamp { get; set; }

        /// <summary>
        /// Gets or sets timestamp of the monitor's last reported health state.
        /// </summary>
        [JsonProperty(PropertyName = "properties.lastReportedTimestamp")]
        public string LastReportedTimestamp { get; set; }

        /// <summary>
        /// Gets or sets evidence validating the monitor's current health
        /// state.
        /// </summary>
        [JsonProperty(PropertyName = "properties.evidence")]
        public object Evidence { get; set; }

        /// <summary>
        /// Gets or sets the configuration settings at the time of the
        /// monitor's health evaluation.
        /// </summary>
        [JsonProperty(PropertyName = "properties.monitorConfiguration")]
        public object MonitorConfiguration { get; set; }

    }
}
