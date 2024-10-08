﻿using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace HotelListing5._0.Models
{
    public class LoginUserDTO
    {
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required]
        [StringLength(15, ErrorMessage = "Your Password Is limited to {2} to {1} characters", MinimumLength = 8)]
        public string Password { get; set; }
    }
    public class UserDTO : LoginUserDTO
    {

        public string FirstName { get; set; }
        public string LastName { get; set; }

        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }

        public ICollection<string> Roles { get; set; }
        
    }
}
