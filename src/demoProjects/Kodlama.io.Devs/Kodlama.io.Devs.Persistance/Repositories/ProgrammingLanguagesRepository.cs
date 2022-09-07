using Core.Persistence.Repositories;
using Kodlama.io.Devs.Application.Services;
using Kodlama.io.Devs.Domain.Entities;
using Kodlama.io.Devs.Persistance.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodlama.io.Devs.Persistance.Repositories
{
    public class ProgrammingLanguagesRepository : EfRepositoryBase<ProgrammingLanguages, BaseDbContext>, IProgrammingLanguagesRepository
    {
        public ProgrammingLanguagesRepository(BaseDbContext context) : base(context)
        {
        }
    }
}
