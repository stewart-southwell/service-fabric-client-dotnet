// ------------------------------------------------------------
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License (MIT). See License.txt in the repo root for license information.
// ------------------------------------------------------------

namespace Microsoft.ServiceFabric.Common
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Application Created event.
    /// </summary>
    public partial class ApplicationCreatedEvent : ApplicationEvent
    {
        /// <summary>
        /// Initializes a new instance of the ApplicationCreatedEvent class.
        /// </summary>
        /// <param name="eventInstanceId">The identifier for the FabricEvent instance.</param>
        /// <param name="timeStamp">The time event was logged.</param>
        /// <param name="applicationId">The identity of the application. This is an encoded representation of the application
        /// name. This is used in the REST APIs to identify the application resource.
        /// Starting in version 6.0, hierarchical names are delimited with the "\~" character. For example, if the application
        /// name is "fabric:/myapp/app1",
        /// the application identity would be "myapp\~app1" in 6.0+ and "myapp/app1" in previous versions.
        /// </param>
        /// <param name="applicationTypeName">Application type name.</param>
        /// <param name="applicationTypeVersion">Application type version.</param>
        /// <param name="applicationDefinitionKind">Application definition kind.</param>
        /// <param name="category">The category of event.</param>
        /// <param name="hasCorrelatedEvents">Shows there is existing related events available.</param>
        public ApplicationCreatedEvent(
            Guid? eventInstanceId,
            DateTime? timeStamp,
            string applicationId,
            string applicationTypeName,
            string applicationTypeVersion,
            string applicationDefinitionKind,
            string category = default(string),
            bool? hasCorrelatedEvents = default(bool?))
            : base(
                eventInstanceId,
                timeStamp,
                Common.FabricEventKind.ApplicationCreated,
                applicationId,
                category,
                hasCorrelatedEvents)
        {
            applicationTypeName.ThrowIfNull(nameof(applicationTypeName));
            applicationTypeVersion.ThrowIfNull(nameof(applicationTypeVersion));
            applicationDefinitionKind.ThrowIfNull(nameof(applicationDefinitionKind));
            this.ApplicationTypeName = applicationTypeName;
            this.ApplicationTypeVersion = applicationTypeVersion;
            this.ApplicationDefinitionKind = applicationDefinitionKind;
        }

        /// <summary>
        /// Gets application type name.
        /// </summary>
        public string ApplicationTypeName { get; }

        /// <summary>
        /// Gets application type version.
        /// </summary>
        public string ApplicationTypeVersion { get; }

        /// <summary>
        /// Gets application definition kind.
        /// </summary>
        public string ApplicationDefinitionKind { get; }
    }
}
