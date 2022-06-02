// Copyright (c) MASA Stack All rights reserved.
// Licensed under the MIT License. See LICENSE.txt in the project root for license information.

namespace Masa.BuildingBlocks.BasicAbility.Auth.Service;

public interface IPermissionService
{
    Task<List<MenuModel>> GetMenusAsync(string appId, Guid userId);

    Task<List<string>> GetElementPermissionsAsync(string appId, Guid userId);

    Task<bool> AuthorizedAsync(string appId, string code, Guid userId);
}
