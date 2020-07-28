﻿using Fur.DatabaseAccessor.Models.Entities;

namespace Fur.DatabaseAccessor.Repositories.Providers
{
    public class FurFakeDeleteProvider : IFakeDeleteProvider
    {
        public string Property => nameof(DbEntity.IsDeleted);

        public object FlagValue => 1;
    }
}