using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace App.Entities.TaskEntities
{
    public class Roles
    {
        [Key]
        [DisplayName("Role Id")]
        public int RoleId { get; set; }
        [DisplayName("Role Title")]
        public string RoleTitle { get; set; }
    }
}