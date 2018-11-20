/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

/*
 * Do not modify this file. This file is generated from the cloudfront-2018-11-05.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CloudFront.Model
{
    /// <summary>
    /// This is the response object from the ListPublicKeys operation.
    /// </summary>
    public partial class ListPublicKeysResponse : AmazonWebServiceResponse
    {
        private PublicKeyList _publicKeyList;

        /// <summary>
        /// Gets and sets the property PublicKeyList. 
        /// <para>
        /// Returns a list of all public keys that have been added to CloudFront for this account.
        /// </para>
        /// </summary>
        public PublicKeyList PublicKeyList
        {
            get { return this._publicKeyList; }
            set { this._publicKeyList = value; }
        }

        // Check to see if PublicKeyList property is set
        internal bool IsSetPublicKeyList()
        {
            return this._publicKeyList != null;
        }

    }
}