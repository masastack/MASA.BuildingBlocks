namespace Masa.BuildingBlocks.Storage.ObjectStorage.Response;
public class TemporaryCredentialsResponse
{
    public string AccessKeyId { get; }

    public string AccessKeySecret { get; }

    public string SessionToken { get; }

    public DateTime? Expiration { get; }

    public TemporaryCredentialsResponse(string accessKeyId, string accessKeySecret, string sessionToken, DateTime? expiration)
    {
        AccessKeyId = accessKeyId;
        AccessKeySecret = accessKeySecret;
        SessionToken = sessionToken;
        Expiration = expiration;
    }
}
