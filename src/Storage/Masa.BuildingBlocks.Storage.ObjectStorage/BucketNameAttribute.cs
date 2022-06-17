// Copyright (c) MASA Stack All rights reserved.
// Licensed under the MIT License. See LICENSE.txt in the project root for license information.

namespace Masa.BuildingBlocks.Storage.ObjectStorage;

[AttributeUsage(AttributeTargets.Class)]
public class BucketNameAttribute : Attribute
{
    public string? BucketName { get; set; }

    public BucketNameAttribute(string? bucketName = null) => BucketName = bucketName;

    public static string GetBucketName<T>() => GetBucketName(typeof(T));

    public static string GetBucketName(Type type)
    {
        var nameAttribute = type.GetTypeInfo().GetCustomAttribute<BucketNameAttribute>();

        if (nameAttribute == null)
            throw new Exception("");

        return !string.IsNullOrWhiteSpace(nameAttribute.BucketName) ? nameAttribute.BucketName : type.Name;
    }
}
