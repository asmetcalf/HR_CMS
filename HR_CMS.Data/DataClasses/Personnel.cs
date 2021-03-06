﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_CMS.Data
{
    public class Personnel
    {
        [Key]
        public int PersonnelId { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        [Required]
        public string SSN { get; set; }
        [Required]
        public DateTimeOffset DOB { get; set; } //Date Of Birth
        [Required]
        public DateTimeOffset DOH { get; set; } //Date Of Hire
        public DateTimeOffset? DOT { get; set; } //Date Of Termination
    }
}
