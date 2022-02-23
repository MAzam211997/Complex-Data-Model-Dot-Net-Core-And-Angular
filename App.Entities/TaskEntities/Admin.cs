﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace App.Entities.TaskEntities
{
    public class Admin
    {
        [Key]
        public int AdminId { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}