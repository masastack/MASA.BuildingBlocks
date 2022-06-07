// Copyright (c) MASA Stack All rights reserved.
// Licensed under the MIT License. See LICENSE.txt in the project root for license information.

using Masa.BuildingBlocks.Oidc.Domain.Entities.Abstract;

namespace Masa.BuildingBlocks.Oidc.Domain.Entities
{
    public class IdentityResourceProperty : Property
    {
        public int IdentityResourceId { get; private set; }

        public IdentityResource IdentityResource { get; private set; } = null!;
    }
}
