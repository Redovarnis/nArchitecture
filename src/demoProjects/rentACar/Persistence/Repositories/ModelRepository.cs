using Application.Services.Repositories;
using Core.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities;
using Persistence.Contexts;

namespace Persistence.Repositories
{
    public class ModelRepository : EfRepositoryBase<Model, BaseDbContext>, IModelRepository
    {
        public ModelRepository(BaseDbContext context) : base(context)
        {

        }
    }
}
