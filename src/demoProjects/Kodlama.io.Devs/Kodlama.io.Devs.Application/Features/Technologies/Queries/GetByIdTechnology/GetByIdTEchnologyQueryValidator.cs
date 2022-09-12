using FluentValidation;
using Kodlama.io.Devs.Application.Features.Technologies.Queries.GetByIdTechnology;
using Kodlama.io.Devs.Application.Features.Technologies.Queries.GetByIdTechnology;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodlama.io.Devs.Application.Features.Technologies.Queries
{
    public class GetByIdTEchnologyQueryValidator : AbstractValidator<GetByIdTechnologyQuery>
    {
        public GetByIdTEchnologyQueryValidator()
        {
            RuleFor(c => c.Id).NotNull();
            RuleFor(c => c.Id).GreaterThan(0);
        }
    }
}
