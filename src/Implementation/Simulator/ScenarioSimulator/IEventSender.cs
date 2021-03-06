﻿// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Threading.Tasks;

namespace Microsoft.Practices.IoTJourney.ScenarioSimulator
{
    public interface IEventSender
    {
        Task<bool> SendAsync(string partitionKey, object evt);
    }
}