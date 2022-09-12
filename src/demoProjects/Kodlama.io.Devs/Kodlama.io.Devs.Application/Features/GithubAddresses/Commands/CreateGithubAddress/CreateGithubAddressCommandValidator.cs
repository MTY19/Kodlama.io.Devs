using AutoMapper;
using FluentValidation;
using Kodlama.io.Devs.Application.Features.GithubAddresses.Commands.CreateGithubAddress;
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

namespace Kodlama.io.Devs.Application.Features.Technologies.Commands.CreateTechnology
{
    public class CreateGithubAddressCommandValidator : AbstractValidator<CreateGithubAddressCommand>
    {
        public CreateGithubAddressCommandValidator()
        {
            RuleFor(c => c.GithubUrl).NotEmpty();
            RuleFor(c => c.GithubUrl).Must(x => x.Contains("github.com/"));
            RuleFor(c => c.GithubUrl).MinimumLength(2);
        }
    }
}