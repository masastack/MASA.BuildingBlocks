// Copyright (c) MASA Stack All rights reserved.
// Licensed under the MIT License. See LICENSE.txt in the project root for license information.

namespace Masa.BuildingBlocks.Service.Contracts;

/// <summary>
/// Base class used by API responses
/// </summary>
public abstract class BaseResponse : BaseMessage
{
    public BaseResponse(Guid correlationId) : base()
    {
        base._correlationId = correlationId;
    }

    public BaseResponse()
    {
    }
}
