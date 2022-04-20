namespace Masa.BuildingBlocks.SearchEngine.AutoComplete.Tests;

[TestClass]
public class TestAutoCompleteClient
{
    [TestMethod]
    public async Task TestDeleteMultiAsyncReturnThrowNotSupportedException()
    {
        var client = new CustomAutoCompleteClient();
        await Assert.ThrowsExceptionAsync<NotSupportedException>(() => client.DeleteMultiAsync(new List<AutoCompleteDocument<int>>()
        {
            new("2", 2),
            new("1", 1),
        }));
    }

    [TestMethod]
    public async Task TestDeleteMultiAsyncReturnSuccess()
    {
        var client = new CustomAutoCompleteClient();
        var response = await client.DeleteMultiAsync(new[] { 1, 2 });
        Assert.IsTrue(response.IsValid);

        response = await client.DeleteMultiAsync(new[] { "1", "2" });
        Assert.IsTrue(response.IsValid);

        response = await client.DeleteMultiAsync(new[] { 1d, 2d });
        Assert.IsTrue(response.IsValid);

        response = await client.DeleteMultiAsync(new[] { 1l, 2l });
        Assert.IsTrue(response.IsValid);

        response = await client.DeleteMultiAsync(new[] { Guid.NewGuid(), Guid.NewGuid() });
        Assert.IsTrue(response.IsValid);
    }
}
