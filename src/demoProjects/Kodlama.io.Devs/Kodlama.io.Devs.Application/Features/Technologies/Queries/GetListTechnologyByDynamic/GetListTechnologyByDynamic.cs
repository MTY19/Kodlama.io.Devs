using AutoMapper;
using Core.Application.Requests;
using Core.Persistence.Paging;
using Kodlama.io.Devs.Application.Features.Technologies.Models;
using Kodlama.io.Devs.Application.Services.Repositories;
using Kodlama.io.Devs.Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using System.Threading.Tasks;
using Core.Persistence.Dynamic;

namespace Kodlama.io.Devs.Application.Features.Technologies.Queries.GetListTechnology
{
    public class GetListTechnologyByDynamic : IRequest<TechnologyListModel>
    {
        public Dynamic Dynamic { get; set; }
        private PageRequest PageRequest { get; set; }

        public class GetListTechnologyHandler : IRequestHandler<GetListTechnologyByDynamic, TechnologyListModel>
        {
            private readonly ITechnologyRepository _technologyRepository;
            private readonly IMapper _mapper;

            public GetListTechnologyHandler(ITechnologyRepository technologyRepository, IMapper mapper)
            {
                _technologyRepository = technologyRepository;
                _mapper = mapper;
            }

            public async Task<TechnologyListModel> Handle(GetListTechnologyByDynamic request, CancellationToken cancellationToken)
            {
                //repo dan liste al
                IPaginate<Technology> technologies =
                    await _technologyRepository.GetListByDynamicAsync(request.Dynamic, include:
                    m => m.Include(c => c.ProgrammingLanguage),
                    index: request.PageRequest.Page,
                    size: request.PageRequest.PageSize);
                    

                TechnologyListModel mappedTechnologyListModel = _mapper.Map<TechnologyListModel>(technologies);

                return mappedTechnologyListModel;
            }
        }
    }
}
