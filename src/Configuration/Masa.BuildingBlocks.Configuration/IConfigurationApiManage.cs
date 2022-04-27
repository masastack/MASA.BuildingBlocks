// Copyright (c) MASA Stack All rights reserved.
// Licensed under the MIT License. See LICENSE.txt in the project root for license information.

namespace Masa.BuildingBlocks.Configuration;
public interface IConfigurationApiManage
{
    Task UpdateAsync(string environment, string cluster, string appId, string configObject, object value);
}
