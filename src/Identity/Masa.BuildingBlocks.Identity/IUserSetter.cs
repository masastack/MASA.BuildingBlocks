﻿// Copyright (c) MASA Stack All rights reserved.
// Licensed under the MIT License. See LICENSE.txt in the project root for license information.

namespace Masa.BuildingBlocks.Identity;

public interface IUserSetter<in TUserId> where TUserId : IComparable
{
    void SetUserId(TUserId id);
}