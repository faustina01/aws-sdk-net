/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;


namespace Amazon.S3.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteBucketMetricsConfiguration operation.
    /// <para>Deletes a metrics configuration (specified by the metrics configuration ID) from the bucket.</para>
    /// </summary>
    public partial class DeleteBucketMetricsConfigurationRequest : AmazonWebServiceRequest
    {
        private string bucketName;
        private string metricsId;

        /// <summary>
        /// The name of the bucket on which Inventory configuration is to be removed.
        /// </summary>
        public string BucketName
        {
            get { return this.bucketName; }
            set { this.bucketName = value; }
        }

        // Check to see if BucketName property is set
        internal bool IsSetBucketName()
        {
            return !(string.IsNullOrEmpty(this.bucketName));
        }

        /// <summary>
        /// The ID used to identify the metrics configuration.
        /// </summary>
        public string MetricsId
        {
            get { return this.metricsId; }
            set { this.metricsId = value; }
        }

        // Check to see if MetricsId property is set
        internal bool IsSetMetricsId()
        {
            return !(string.IsNullOrEmpty(this.MetricsId));
        }
    }
}
