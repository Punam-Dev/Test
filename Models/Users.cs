﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DotIndiaPvtLtd.Models
{
    public class Users
    {
        [Key]
        public string UserID { get; set; }
        public string UserName { get; set; }

        [DataType(DataType.Password)]
        public string Password { get; set; }

        public string UserRoles { get; set; }

        [Required, Display(Name = "First Name"), DataType(DataType.Text), StringLength(20, MinimumLength = 1)]
        public string FirstName { get; set; }

        [Required, Display(Name = "Last Name"), DataType(DataType.Text), StringLength(20, MinimumLength = 1)]
        public string LastName { get; set; }

        [Required, DataType(DataType.Text), StringLength(20, MinimumLength = 1)]
        public string Email { get; set; }

        [Required, DataType(DataType.Text), StringLength(15, MinimumLength = 1)]
        public string Phone { get; set; }

        [DataType(DataType.Text), StringLength(2048, MinimumLength = 0)]
        public string Address { get; set; }

        [Display(Name = "Date of Birth")]
        public DateTime DOB { get; set; }

        [Required, Display(Name = "Caller Name"), DataType(DataType.Text), StringLength(512, MinimumLength = 1)]
        public string CallerName { get; set; }
        public DateTime? ActivationDate { get; set; }
        public bool Status { get; set; }
        public bool WorkStatus { get; set; }
        public int? OTP { get; set; }
        public string UserCreatedByUserID { get; set; }
        public DateTime UserCreatedDate { get; set; }
        public string UserUpdatedByUserID { get; set; }
        public DateTime? UserUpdatedDate { get; set; }
    }
}
