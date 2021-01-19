﻿namespace MyJobSite.Data.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;

    using MyJobSite.Data.Common.Models;

    public class UserInfo : BaseDeletableModel<string>
    {
        public UserInfo()
        {
            this.Id = Guid.NewGuid().ToString();
        }

        public virtual ApplicationUser User { get; set; }

        public string UserId { get; set; }

        public string Description { get; set; }

        [Required]
        public string ProfilePicture { get; set; }

        [Required]
        public string CV { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        public string Address { get; set; }

        public virtual City City { get; set; }

        [Required]
        public string CityId { get; set; }
    }
}
