// Copyright (c) MASA Stack All rights reserved.
// Licensed under the MIT License. See LICENSE.txt in the project root for license information.

namespace Masa.BuildingBlocks.Storage.ObjectStorage;

public class DefaultBucketNameProvider<TContainer> : DefaultBucketNameProvider, IBucketNameProvider<TContainer>
    where TContainer : class
{
    public DefaultBucketNameProvider() : base(BucketNameAttribute.GetBucketName<TContainer>())
    {
    }
}

public class DefaultBucketNameProvider : IBucketNameProvider
{
    public string BucketName { get; }

    public DefaultBucketNameProvider(string bucketName) => BucketName = bucketName;
}
