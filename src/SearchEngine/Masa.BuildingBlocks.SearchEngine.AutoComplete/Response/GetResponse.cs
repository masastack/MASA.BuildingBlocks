﻿namespace Masa.BuildingBlocks.SearchEngine.AutoComplete.Response;
public class GetResponse<TDropdownBox, TValue> : ResponseBase
    where TDropdownBox : AutoCompleteDocument<TValue> where TValue : notnull
{
    public long Total { get; set; }

    public long TotalPages { get; set; }

    public List<TDropdownBox> Data { get; set; }

    public GetResponse(bool isValid, string message) : base(isValid, message)
    {
    }

    public GetResponse(bool isValid, string message, IEnumerable<TDropdownBox> data) : this(isValid, message)
    {
        ArgumentNullException.ThrowIfNull(data,nameof(data));

        Data = data.ToList();
    }
}
