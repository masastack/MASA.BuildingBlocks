namespace Masa.BuildingBlocks.SearchEngine.AutoComplete.Tests;
public class CustomAutoCompleteClient : BaseAutoCompleteClient
{
    public override Task<GetResponse<TAudoCompleteDocument, TValue>> GetAsync<TAudoCompleteDocument, TValue>(string keyword,
        AutoCompleteOptions? options = null,
        CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public override Task<SetResponse> SetMultiAsync<TAudoCompleteDocument, TValue>(IEnumerable<TAudoCompleteDocument> documents,
        SetOptions? options = null,
        CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public override Task<DeleteResponse> DeleteAsync(string id)
    {
        throw new NotImplementedException();
    }

    public override Task<DeleteMultiResponse> DeleteMultiAsync(IEnumerable<string> ids)
        => Task.FromResult(new DeleteMultiResponse(true, ""));
}
