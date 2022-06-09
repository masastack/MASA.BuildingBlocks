// Copyright (c) MASA Stack All rights reserved.
// Licensed under the MIT License. See LICENSE.txt in the project root for license information.

namespace Masa.BuildingBlocks.Oidc.Domain.Repositories;

public interface IRepositoryBase<TEntity> where TEntity : class, IEntity
{
    Task<PaginatedList<TEntity>> GetPaginatedListAsync(int page, int pageSize);

    Task<TEntity?> GetDetailAsync(int id);

    Task<List<TEntity>> GetListAsync();

    ValueTask<TEntity> AddAsync(TEntity entity);

    Task<TEntity> UpdateAsync(TEntity entity);

    Task RemoveAsync(TEntity entity);
}

