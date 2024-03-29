﻿using System.ComponentModel.DataAnnotations;

namespace SocialClubApp.ViewModels
{
    public class EditUserViewModel
    {
        //To avoid NullReferenceExceptions at runtime,
        //initialise Claims and Roles with a new list in the constructor.
        public EditUserViewModel()
        {
            Claims = new List<string>();
            Roles = new List<string>();
        }

        public string Id { get; set; }
        [Required]
        public string UserName { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        public string? ProfileImageUrl { get; set; }
        public IFormFile? Image { get; set; }
        public string? City { get; set; }
        public string? State { get; set; }
        public List<string> Claims { get; set; }
        public IList<string> Roles { get; set; }
    }
}
