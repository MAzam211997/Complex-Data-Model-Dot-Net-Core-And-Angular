using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace App.Entities.TaskEntities
{
    public class EmployeesTeams
    {
        [Key]
        [DisplayName("Id")]
        public int EmployeesTeamsId { get; set; }
        [DisplayName("Manager")]
        public int? ManagerId { get; set; }
        [DisplayName(" Employee")]
        public int? EmployeeId { get; set; }
        [DisplayName("Team")]
        public int? TeamId { get; set; }
        [DisplayName("Role")]
        public int EmployeeRole { get; set; }
        [DisplayName("Assigned Date")]
        public DateTime AssignedDate { get; set; }
        public virtual Manager Manager{ get; set; }
        public virtual Employee Employee { get; set; }
        public virtual Teams Teams { get; set; }
    }
}