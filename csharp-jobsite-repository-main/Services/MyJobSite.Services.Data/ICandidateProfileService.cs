﻿namespace MyJobSite.Services.Data
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    using MyJobSite.Web.ViewModels.ViewModels;

    public interface ICandidateProfileService
    {
        T GetCandidateProfileInformation<T>(string id);

        T GetCandidateProfileInformationByUserId<T>(string id);

        ICollection<T> GetCandidatesProfileInfoByUserIds<T>(ICollection<string> ids);

        bool CheckIfProfileDeleted(string userId);
    }
}
