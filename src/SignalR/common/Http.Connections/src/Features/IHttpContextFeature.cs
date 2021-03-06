// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Connections;
using Microsoft.AspNetCore.Http;

namespace Microsoft.AspNetCore.Http.Connections.Features
{
    /// <summary>
    /// Feature set on the <see cref="ConnectionContext"/> that provides access to the underlying <see cref="Http.HttpContext"/>
    /// associated with the connection if there is one.
    /// </summary>
    public interface IHttpContextFeature
    {
        /// <summary>
        /// The <see cref="Http.HttpContext"/> associated with the connection if available. 
        /// </summary>
        /// <remarks>
        /// Connections can run on top of HTTP transports like WebSockets or Long Polling, or other non-HTTP transports. As a result,
        /// this API can sometimes return <see langword="null"/> depending on the configuration of your application.
        /// </remarks>
        HttpContext HttpContext { get; set; }
    }
}
