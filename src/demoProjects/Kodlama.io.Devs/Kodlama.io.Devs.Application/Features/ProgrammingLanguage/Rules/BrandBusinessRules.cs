using Application.Services.Repositories;
using Core.CrossCuttingConcerns.Exceptions;
using Core.Persistence.Paging;
using Domain.Entities;
using Kodlama.io.Devs.Application.Services.Repositories;
using Kodlama.io.Devs.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.ProgrammingLanguage.Rules
{
    public class ProgrammingLanguageBusinessRules
    {
        private readonly IProgrammingLanguageRepository _ProgrammingLanguageRepository;

        public ProgrammingLanguageBusinessRules(IProgrammingLanguageRepository ProgrammingLanguageRepository)
        {
            _ProgrammingLanguageRepository = ProgrammingLanguageRepository;
        }

        public async Task ProgrammingLanguageNameCanNotBeDuplicatedWhenInserted(string name)
        {
            IPaginate<ProgrammingLanguage> result = await _ProgrammingLanguageRepository.GetListAsync(b => b.Name == name);
            if (result.Items.Any()) throw new BusinessException("ProgrammingLanguage name exists.");
        }

        public void ProgrammingLanguageShouldExistWhenRequested(ProgrammingLanguage ProgrammingLanguage)
        {
            if (ProgrammingLanguage == null) throw new BusinessException("Requested ProgrammingLanguage does not exist.");
        }
    }
}