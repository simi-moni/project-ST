﻿namespace MyJobSite.Services.Data
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using CloudinaryDotNet;
    using CloudinaryDotNet.Actions;
    using MyJobSite.Data.Common.Repositories;
    using MyJobSite.Data.Models;
    using MyJobSite.Web.ViewModels.InputModels;

    public class UserInfoService : IUserInfoService
    {
        private readonly IDeletableEntityRepository<UserInfo> userInfoRepository;

        public UserInfoService(IDeletableEntityRepository<UserInfo> userInfoRepository)
        {
            this.userInfoRepository = userInfoRepository;
        }

        public async Task PostUserInfoAsync(UserInfoInputModel input)
        {
            var userInfo = new UserInfo
            {
                FirstName = input.FirstName,
                LastName = input.LastName,
                UserId = input.UserId,
                Description = input.Description,
                ProfilePicture = this.UploadImageToCloudinary(input.ProfilePicture.OpenReadStream()),
                CV = this.UploadCvFileToCloudinary(input.Cv.OpenReadStream()),
                Address = input.Address,
                CityId = input.CityId,
            };

            await this.userInfoRepository.AddAsync(userInfo);
            await this.userInfoRepository.SaveChangesAsync();
        }

        public string UploadImageToCloudinary(Stream imageFileStream)
        {
            Account account = new Account
            {
                Cloud = "dbtzqb6py",
                ApiKey = "276848394448911",
                ApiSecret = "ymMC-yDsSc2BGAtvUYWrOcDLaTg",
            };

            Cloudinary cloudinary = new Cloudinary(account);
            var uploadParams = new ImageUploadParams()
            {
                File = new FileDescription("thrumbnail", imageFileStream),
            };
            var uploadResult = cloudinary.Upload(uploadParams);
            return uploadResult.SecureUri.AbsoluteUri;
        }

        public string UploadCvFileToCloudinary(Stream cvFileStream)
        {
            Account account = new Account
            {
                Cloud = "alekskn99",
                ApiKey = "217256488653521",
                ApiSecret = "JNv29i2PKDHUT8hI_861sL8tQ0s",
            };

            Cloudinary cloudinary = new Cloudinary(account);
            var uploadParams = new RawUploadParams()
            {
                File = new FileDescription("thrumbnail", cvFileStream),
            };
            var uploadResult = cloudinary.Upload(uploadParams);
            return uploadResult.SecureUri.AbsoluteUri;
        }

        public string GetUserInfoUserId(string id)
        {
            var user = this.userInfoRepository.All().Where(u => u.UserId == id).FirstOrDefault();
            var userId = user.UserId;

            return userId;
        }

        public bool CheckIfHasInformation(string userId)
        {
            var userInfo = this.userInfoRepository.All().Where(u => u.UserId == userId).FirstOrDefault();

            if (userInfo == null)
            {
                return false;
            }

            return true;
        }

        public async Task MarkUserInfoAsDeleted(string userId)
        {
            var userInfo = this.userInfoRepository.All().Where(u => u.UserId == userId).FirstOrDefault();

            this.userInfoRepository.Delete(userInfo);

            await this.userInfoRepository.SaveChangesAsync();
        }
    }
}
