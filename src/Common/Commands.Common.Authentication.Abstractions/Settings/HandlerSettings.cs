﻿// ----------------------------------------------------------------------------------
//
// Copyright Microsoft Corporation
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// http://www.apache.org/licenses/LICENSE-2.0
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// ----------------------------------------------------------------------------------

using System;
using System.Collections.Generic;

namespace Microsoft.Azure.Commands.Common.Authentication.Abstractions
{
    /// <summary>
    /// Serializable settings for a delegating handler used in http clients
    /// </summary>
    public class HandlerSettings : IExtensibleSettings
    {
        /// <summary>
        /// The name of the delegating handler
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The type of the delegating handler
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// The particular state of the delegating handler
        /// </summary>
        public IDictionary<string, string> Settings { get; } = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);

    }
}
