#region Copyright notice and license

// Copyright 2019 The gRPC Authors
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

#endregion

using Grpc.AspNetCore.Server;
using Grpc.AspNetCore.Server.Internal;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Abstractions;

namespace Grpc.Tests.Shared
{
    internal static class HttpContextServerCallContextHelper
    {
        public static HttpContextServerCallContext CreateServerCallContext(
            HttpContext httpContext = null,
            GrpcServiceOptions serviceOptions = null,
            ILogger logger = null)
        {
            var context = new HttpContextServerCallContext(
                httpContext ?? new DefaultHttpContext(),
                serviceOptions ?? new GrpcServiceOptions(),
                logger ?? NullLogger.Instance);
            context.Initialize();

            return context;
        }
    }
}
