using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace App.Entities.TaskEntities
{
    public class Teams
    {
        [Key]
        [DisplayName("Team Id")]
        public int TeamId { get; set; }
        [DisplayName("Team Title")]
        public string TeamTitle { get; set; }
        [DisplayName("Team Description")]
        public string TeamDescription { get; set; }

        [DisplayName("Created Date")]
        public DateTime CreatedDate { get; set; }
        [DisplayName("Manager")]
        public int? ManagerId { get; set; }
        [DisplayName("Employee")]
        public int? EmployeeId { get; set; }
        public int? RoleId { get; set; }
        public virtual Manager Manager{ get; set; }
        public virtual Employee Employee { get; set; }
        public virtual Roles Roles { get; set; }
    }
}