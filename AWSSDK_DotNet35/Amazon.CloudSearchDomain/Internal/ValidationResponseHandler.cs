﻿using Amazon.CloudSearchDomain.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Amazon.CloudSearchDomain.Internal
{
    public class ValidationResponseHandler : GenericHandler
    {
#if BCL
        protected override void PostInvoke(IExecutionContext executionContext)
        {
            var uploadDocumentsRequest = executionContext.RequestContext.OriginalRequest as UploadDocumentsRequest;

            if (uploadDocumentsRequest != null)
            {
                // If Documents property is set as the underlying stream for FilePath, dispose it.
                if (uploadDocumentsRequest.Documents != null && !string.IsNullOrEmpty(uploadDocumentsRequest.FilePath))
                {
                    uploadDocumentsRequest.Documents.Dispose();
                    uploadDocumentsRequest.Documents = null;
                }
            }
        }
#endif
    }
}
