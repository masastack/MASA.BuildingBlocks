namespace ObjectStorage;

public interface IClient
{
    Task GetObjectAsync(
        string bucketName,
        string objectName,
        Action<Stream> callback,
        CancellationToken cancellationToken = default(CancellationToken));

    //Task GetObjectAsync(
    //    string bucketName,
    //    string objectName,
    //    long offset,
    //    long length,
    //    Action<Stream> callback,
    //    CancellationToken cancellationToken = default(CancellationToken));

    Task PutObjectAsync(
        string bucketName,
        string objectName,
        Stream data,
        CancellationToken cancellationToken = default(CancellationToken));

    //Task<bool> ObjectExistsAsync(
    //    string bucketName,
    //    string objectName,
    //    CancellationToken cancellationToken = default(CancellationToken));

    Task DeleteObjectAsync(string bucketName, string objectName, CancellationToken cancellationToken = default(CancellationToken));

    Task DeleteObjectAsync(string bucketName, IEnumerable<string> objectNames, CancellationToken cancellationToken = default(CancellationToken));


}
