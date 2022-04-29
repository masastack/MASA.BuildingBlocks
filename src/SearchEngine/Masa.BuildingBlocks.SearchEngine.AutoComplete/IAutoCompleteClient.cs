// Copyright (c) MASA Stack All rights reserved.
// Licensed under the MIT License. See LICENSE.txt in the project root for license information.

namespace Masa.BuildingBlocks.SearchEngine.AutoComplete;

public interface IAutoCompleteClient
{
    Task<GetResponse<AutoCompleteDocument<Guid>, Guid>> GetAsync(
        string keyword,
        AutoCompleteOptions? options = null,
        CancellationToken cancellationToken = default);

    Task<GetResponse<AutoCompleteDocument<TValue>, TValue>> GetAsync<TValue>(
        string keyword,
        AutoCompleteOptions? options = null,
        CancellationToken cancellationToken = default) where TValue : notnull;

    Task<GetResponse<TAudoCompleteDocument, TValue>> GetAsync<TAudoCompleteDocument, TValue>(
        string keyword,
        AutoCompleteOptions? options = null,
        CancellationToken cancellationToken = default)
        where TAudoCompleteDocument : AutoCompleteDocument<TValue> where TValue : notnull;

    Task<SetResponse> SetAsync(
        AutoCompleteDocument<Guid> document,
        SetOptions? options = null,
        CancellationToken cancellationToken = default);

    Task<SetResponse> SetAsync(
        IEnumerable<AutoCompleteDocument<Guid>> documents,
        SetOptions? options = null,
        CancellationToken cancellationToken = default);

    Task<SetResponse> SetAsync<TValue>(
        AutoCompleteDocument<TValue> document,
        SetOptions? options = null,
        CancellationToken cancellationToken = default) where TValue : notnull;

    Task<SetResponse> SetAsync<TValue>(
        IEnumerable<AutoCompleteDocument<TValue>> documents,
        SetOptions? options = null,
        CancellationToken cancellationToken = default) where TValue : notnull;

    Task<SetResponse> SetAsync<TAudoCompleteDocument, TValue>(
        TAudoCompleteDocument document,
        SetOptions? options = null,
        CancellationToken cancellationToken = default) where TAudoCompleteDocument : AutoCompleteDocument<TValue> where TValue : notnull;

    Task<SetResponse> SetAsync<TAudoCompleteDocument, TValue>(
        IEnumerable<TAudoCompleteDocument> documents,
        SetOptions? options = null,
        CancellationToken cancellationToken = default) where TAudoCompleteDocument : AutoCompleteDocument<TValue> where TValue : notnull;

    Task<DeleteResponse> DeleteAsync(string id, CancellationToken cancellationToken = default);

    Task<DeleteResponse> DeleteAsync<T>(T id, CancellationToken cancellationToken = default) where T : IComparable;

    Task<DeleteMultiResponse> DeleteAsync(IEnumerable<string> ids, CancellationToken cancellationToken = default);

    Task<DeleteMultiResponse> DeleteAsync<T>(IEnumerable<T> ids, CancellationToken cancellationToken = default) where T : IComparable;
}
