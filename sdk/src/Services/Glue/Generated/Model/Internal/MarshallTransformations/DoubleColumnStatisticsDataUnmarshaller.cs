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
 * Do not modify this file. This file is generated from the glue-2017-03-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.Glue.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.Glue.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for DoubleColumnStatisticsData Object
    /// </summary>  
    public class DoubleColumnStatisticsDataUnmarshaller : IUnmarshaller<DoubleColumnStatisticsData, XmlUnmarshallerContext>, IUnmarshaller<DoubleColumnStatisticsData, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        DoubleColumnStatisticsData IUnmarshaller<DoubleColumnStatisticsData, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public DoubleColumnStatisticsData Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            DoubleColumnStatisticsData unmarshalledObject = new DoubleColumnStatisticsData();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("MaximumValue", targetDepth))
                {
                    var unmarshaller = DoubleUnmarshaller.Instance;
                    unmarshalledObject.MaximumValue = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("MinimumValue", targetDepth))
                {
                    var unmarshaller = DoubleUnmarshaller.Instance;
                    unmarshalledObject.MinimumValue = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("NumberOfDistinctValues", targetDepth))
                {
                    var unmarshaller = LongUnmarshaller.Instance;
                    unmarshalledObject.NumberOfDistinctValues = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("NumberOfNulls", targetDepth))
                {
                    var unmarshaller = LongUnmarshaller.Instance;
                    unmarshalledObject.NumberOfNulls = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static DoubleColumnStatisticsDataUnmarshaller _instance = new DoubleColumnStatisticsDataUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static DoubleColumnStatisticsDataUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}