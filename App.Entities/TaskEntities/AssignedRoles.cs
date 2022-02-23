using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace App.Entities.TaskEntities
{
    public class AssignedRoles
    {
        [Key]
        [DisplayName("Id")]
        public int Id { get; set; }
        [DisplayName("Manager")]
        public int? ManagerId { get; set; }
        [DisplayName(" Employee")]
        public int? EmployeeId { get; set; }
        [DisplayName("Team")]
        public int? TeamId { get; set; }
        
        [DisplayName("Role")]
        public int? RoleId { get; set; }
        [DisplayName("Assigned Date")]
        public DateTime AssignedDate { get; set; }
        public virtual Manager Manager{ get; set; }
        public virtual Employee Employee { get; set; }
        public virtual Teams Teams { get; set; }
        public virtual Roles Roles  { get; set; }
    }
}