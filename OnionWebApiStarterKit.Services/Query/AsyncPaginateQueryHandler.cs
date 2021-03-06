﻿using Mehdime.Entity;
using OnionWebApiStarterKit.Services.BaseQuery;
using OnionWebApiStarterKit.Data;
using OnionWebApiStarterKit.Core.Services;

namespace OnionWebApiStarterKit.Services.Query
{
    public class AsyncPaginateQueryHandler<TEntity> : BaseAsyncPaginateQueryHandler<TEntity, ISchoolDbContext>
        where TEntity : class
    {
        public AsyncPaginateQueryHandler(IDbContextScopeFactory dbContextScopeFactory)
            : base(dbContextScopeFactory) { }
    }
}
