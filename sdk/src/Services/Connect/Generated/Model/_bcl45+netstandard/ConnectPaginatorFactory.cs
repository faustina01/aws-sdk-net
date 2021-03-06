#if !NETSTANDARD13
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

/*
 * Do not modify this file. This file is generated from the connect-2017-08-08.normal.json service model.
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace Amazon.Connect.Model
{
    /// <summary>
    /// Paginators for the Connect service
    ///</summary>
    public class ConnectPaginatorFactory : IConnectPaginatorFactory
    {
        private readonly IAmazonConnect client;

        internal ConnectPaginatorFactory(IAmazonConnect client) 
        {
            this.client = client;
        }

        /// <summary>
        /// Paginator for GetCurrentMetricData operation
        ///</summary>
        public IGetCurrentMetricDataPaginator GetCurrentMetricData(GetCurrentMetricDataRequest request) 
        {
            return new GetCurrentMetricDataPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for GetMetricData operation
        ///</summary>
        public IGetMetricDataPaginator GetMetricData(GetMetricDataRequest request) 
        {
            return new GetMetricDataPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListContactFlows operation
        ///</summary>
        public IListContactFlowsPaginator ListContactFlows(ListContactFlowsRequest request) 
        {
            return new ListContactFlowsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListHoursOfOperations operation
        ///</summary>
        public IListHoursOfOperationsPaginator ListHoursOfOperations(ListHoursOfOperationsRequest request) 
        {
            return new ListHoursOfOperationsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListPhoneNumbers operation
        ///</summary>
        public IListPhoneNumbersPaginator ListPhoneNumbers(ListPhoneNumbersRequest request) 
        {
            return new ListPhoneNumbersPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListQueues operation
        ///</summary>
        public IListQueuesPaginator ListQueues(ListQueuesRequest request) 
        {
            return new ListQueuesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListRoutingProfiles operation
        ///</summary>
        public IListRoutingProfilesPaginator ListRoutingProfiles(ListRoutingProfilesRequest request) 
        {
            return new ListRoutingProfilesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListSecurityProfiles operation
        ///</summary>
        public IListSecurityProfilesPaginator ListSecurityProfiles(ListSecurityProfilesRequest request) 
        {
            return new ListSecurityProfilesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListUserHierarchyGroups operation
        ///</summary>
        public IListUserHierarchyGroupsPaginator ListUserHierarchyGroups(ListUserHierarchyGroupsRequest request) 
        {
            return new ListUserHierarchyGroupsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListUsers operation
        ///</summary>
        public IListUsersPaginator ListUsers(ListUsersRequest request) 
        {
            return new ListUsersPaginator(this.client, request);
        }
    }
}
#endif