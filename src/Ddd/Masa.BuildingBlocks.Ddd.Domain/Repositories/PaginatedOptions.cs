﻿namespace Masa.BuildingBlocks.Ddd.Domain.Repositories;
public class PaginatedOptions
{
    public int Page { get; set; }

    public int PageSize { get; set; }

    public Dictionary<string,bool>? Sorting { get; set; }
}