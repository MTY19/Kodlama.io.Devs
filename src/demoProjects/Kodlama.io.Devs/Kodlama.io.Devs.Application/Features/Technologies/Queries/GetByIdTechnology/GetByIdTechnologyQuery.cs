using AutoMapper;
using Kodlama.io.Devs.Application.Features.Technologies.Dtos;
using Kodlama.io.Devs.Application.Features.Technologies.Rules;
using Kodlama.io.Devs.Application.Services.Repositories;
using Kodlama.io.Devs.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodlama.io.Devs.Application.Features.Technologies.Queries.GetByIdTechnology
{
    public class GetByIdTechnologyQuery : IRequest<TechnologyGetByIdDto>
    {
        public int Id { get; set; }
        public class GetByIdTechnologyQueryHandler : IRequestHandler<GetByIdTechnologyQuery, TechnologyGetByIdDto>
        {
            private readonly ITechnologyRepository _TechnologyRepository;
            private readonly IMapper _mapper;
            private readonly TechnologyBusinessRules _TechnologyBusinessRules;
            public GetByIdTechnologyQueryHandler(ITechnologyRepository TechnologyRepository, IMapper mapper, TechnologyBusinessRules TechnologyBusinessRules)
            {
                _TechnologyRepository = TechnologyRepository;
                _mapper = mapper;
                _TechnologyBusinessRules = TechnologyBusinessRules;
            }

            public async Task<TechnologyGetByIdDto> Handle(GetByIdTechnologyQuery request, CancellationToken cancellationToken)
            {
                //Request'ten gelen id ye göre Repository den Nesneyi Al
                Technology? Technology = await _TechnologyRepository.GetAsync(c => c.Id == request.Id);

                //Nesnenin Varlığını Business Rules dan Kontrol Et 
                await _TechnologyBusinessRules.TechnologyShouldExistWhenRequested(Technology);

                //Technology => TechnologyGetByIdDto
                TechnologyGetByIdDto mappedTechnology = _mapper.Map<TechnologyGetByIdDto>(Technology);
                return mappedTechnology;
            }
        }
    }
}