﻿using System.Threading.Tasks;
using Abp.Application.Services;
using ProDiegoV1.Authorization.Accounts.Dto;

namespace ProDiegoV1.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
