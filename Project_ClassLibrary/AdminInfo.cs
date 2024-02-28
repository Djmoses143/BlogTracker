﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_ClassLibrary_DAL
{
    public class AdminInfo
    {
        [Key]
        public string EmailId { get; set; }

        [Required]
        public string Password { get; set; }
    }
}
