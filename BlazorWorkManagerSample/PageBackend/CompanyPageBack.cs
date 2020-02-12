using BussinessLayer.Entities;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
using ServiceLayer.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorWorkManagerSample.PageBackend
{
    public class CompanyPageBack:ComponentBase
    {
        [Inject]
        AuthenticationStateProvider AuthenticationStateProvider { get; set; }
        [Inject]
        IUserService UserService { get; set; }
        [Inject]
        ICompanyService CompanyService { get; set; }
        protected bool IsInCompany { get; set; } = false;
        protected Company Company { get; set; } = new Company();
        protected ApplicationUser CurrentUser { get; set; }

        protected async void CreateCompany()
        {
            Company.Creator = CurrentUser;
            var result = await CompanyService.CreateCompany(Company);
            CurrentUser.Company = result;
            Company = new Company();
            IsInCompany = true;
            StateHasChanged();

        }
        protected override async Task OnInitializedAsync()
        {
            var authState = await AuthenticationStateProvider.GetAuthenticationStateAsync();
            CurrentUser = await UserService.FindUserByUserName(authState.User.Identity.Name);
            IsInCompany = CurrentUser.Company is { };
        }
    }
}
