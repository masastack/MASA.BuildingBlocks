// Copyright (c) MASA Stack All rights reserved.
// Licensed under the MIT License. See LICENSE.txt in the project root for license information.

namespace Masa.BuildingBlocks.IdentityModel;

public abstract class UserContext : IUserSetter, IUserContext
{
    private readonly AsyncLocal<IdentityUser?> _currentUser = new();

    public IdentityUser? User => _currentUser.Value ?? GetUser();

    public bool IsAuthenticated => User != null;

    public string? UserId => User?.Id;

    public string? UserName => User?.UserName;

    public string? TenantId => User?.TenantId;

    public string? Environment => User?.Environment;

    private readonly ITypeConvertProvider _typeConvertProvider;

    public UserContext(ITypeConvertProvider typeConvertProvider) => _typeConvertProvider = typeConvertProvider;

    protected abstract IdentityUser? GetUser();

    public TUserId? GetUserId<TUserId>()
    {
        var userId = UserId;
        if (userId == null)
            return default;

        return _typeConvertProvider.ConvertTo<TUserId>(userId);
    }

    public virtual TTenantId? GetTenantId<TTenantId>()
    {
        var tenantId = TenantId;
        if (tenantId == null)
            return default;

        return _typeConvertProvider.ConvertTo<TTenantId>(tenantId);
    }

    public IDisposable Change(IdentityUser identityUser)
    {
        var user = User;
        _currentUser.Value = identityUser;
        return new DisposeAction(() => _currentUser.Value = user);
    }
}
