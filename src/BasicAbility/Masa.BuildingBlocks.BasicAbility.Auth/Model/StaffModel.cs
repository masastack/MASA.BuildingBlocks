// Copyright (c) MASA Stack All rights reserved.
// Licensed under the MIT License. See LICENSE.txt in the project root for license information.

namespace Masa.BuildingBlocks.BasicAbility.Auth.Model;

public class StaffModel
{
    public Guid Id { get; set; }

    public string? Department { get; set; }

    public string? Position { get; set; }

    public string JobNumber { get; set; }

    public StaffTypes StaffType { get; set; }

    public UserModel User { get; set; }

    public StaffModel(string jobNumber, StaffTypes staffType, UserModel user)
    {
        JobNumber = jobNumber;
        StaffType = staffType;
        User = user;
    }
}

