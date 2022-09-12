using AutoMapper;
using FluentValidation;
using Kodlama.io.Devs.Application.Features.GithubAddresses.Commands.DeleteGithubAddress;
using Kodlama.io.Devs.Application.Features.GithubAddresses.Commands.UpdateGithubAddress;
using Kodlama.io.Devs.Application.Features.GithubAddresses.Dtos;
using Kodlama.io.Devs.Application.Features.GithubAddresses.Rules;
using Kodlama.io.Devs.Application.Services.Repositories;
using Kodlama.io.Devs.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodlama.io.Devs.Application.Features.GithubAddresses.Commands.CreateGithubAddress
{
    public class UpdateGithubAddressCommandValidator : AbstractValidator<UpdateGithubAddressCommand>
    {
        public UpdateGithubAddressCommandValidator()
        {

        }
    }
}