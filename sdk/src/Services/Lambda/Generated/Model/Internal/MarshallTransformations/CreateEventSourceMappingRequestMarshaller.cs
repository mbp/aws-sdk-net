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
 * Do not modify this file. This file is generated from the lambda-2015-03-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Lambda.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.Lambda.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateEventSourceMapping Request Marshaller
    /// </summary>       
    public class CreateEventSourceMappingRequestMarshaller : IMarshaller<IRequest, CreateEventSourceMappingRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateEventSourceMappingRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateEventSourceMappingRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Lambda");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2015-03-31";            
            request.HttpMethod = "POST";

            request.ResourcePath = "/2015-03-31/event-source-mappings/";
            request.MarshallerVersion = 2;
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetBatchSize())
                {
                    context.Writer.WritePropertyName("BatchSize");
                    context.Writer.Write(publicRequest.BatchSize);
                }

                if(publicRequest.IsSetEnabled())
                {
                    context.Writer.WritePropertyName("Enabled");
                    context.Writer.Write(publicRequest.Enabled);
                }

                if(publicRequest.IsSetEventSourceArn())
                {
                    context.Writer.WritePropertyName("EventSourceArn");
                    context.Writer.Write(publicRequest.EventSourceArn);
                }

                if(publicRequest.IsSetFunctionName())
                {
                    context.Writer.WritePropertyName("FunctionName");
                    context.Writer.Write(publicRequest.FunctionName);
                }

                if(publicRequest.IsSetStartingPosition())
                {
                    context.Writer.WritePropertyName("StartingPosition");
                    context.Writer.Write(publicRequest.StartingPosition);
                }

                if(publicRequest.IsSetStartingPositionTimestamp())
                {
                    context.Writer.WritePropertyName("StartingPositionTimestamp");
                    context.Writer.Write(publicRequest.StartingPositionTimestamp);
                }

        
                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static CreateEventSourceMappingRequestMarshaller _instance = new CreateEventSourceMappingRequestMarshaller();        

        internal static CreateEventSourceMappingRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateEventSourceMappingRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}