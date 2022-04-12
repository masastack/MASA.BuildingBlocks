namespace Masa.BuildingBlocks.Storage.ObjectStorage.Response;
public class TemporaryCredentialsResponse
{
    public string AccessKeyId { get; }

    public string SecretAccessKey { get; }

    public string SessionToken { get; }

    public string Expiration { get; }

    public TemporaryCredentialsResponse(string accessKeyId, string secretAccessKey, string sessionToken, string expiration)
    {
        AccessKeyId = accessKeyId;
        SecretAccessKey = secretAccessKey;
        SessionToken = sessionToken;
        Expiration = expiration;
    }
}
