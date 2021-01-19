﻿namespace MyJobSite.Services.Data
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Threading.Tasks;

    using MyJobSite.Web.ViewModels.InputModels;

    public interface ICandidatesService
    {
        Task CreateNewCandidateForJobPostingAsync(string userId, string jobPostingId);

        bool CheckIfCandidateAlreadyApplied(string userId, string jobPostingId);

        ICollection<string> GetAllUsersIdOfJobPosting(string jobPostingId);

        ICollection<string> GetAllJobPostingsIds(string userId); //// userId = candidateId

        Task MarkAllApplyingsAsDeleted(string userId);

        Task MarkAllApplyingsAsDeletedByJobPostingId(string jobPostingId);

        Task MarkApplyingAsDeleted(string userId, string jobPostingId);
    }
}
