using System;
using Contracts;
using Entities;
using Entities.Models;
using System.Linq;
using System.Collections.Generic;

namespace Repository
{
    class UnitRepository : RepositoryBase<Unit>, IUnitRepository
    {
        public UnitRepository(RepositoryContext repositoryContext)
            :base(repositoryContext)
        {
            
        }

    }
}