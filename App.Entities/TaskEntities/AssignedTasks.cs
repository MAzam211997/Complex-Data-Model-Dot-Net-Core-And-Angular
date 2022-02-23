using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace App.Entities.TaskEntities
{
    public class AssignedTasks
    {
        [Key]
        [DisplayName("Id")]
        public int Id { get; set; }
        [DisplayName("Task")]
        public int? TaskId { get; set; }
        [DisplayName("Team")]
        public int? TeamId { get; set; }
        [DisplayName("Manager")]
        public int? ManagerId { get; set; }
        [DisplayName("Employee")]
        public int? EmployeeId { get; set; }
        
        [DisplayName("Status")]
        public int? StatusId { get; set; }
        public DateTime AssignedDate { get; set; }
        public virtual Manager Manager{ get; set; }
        public virtual Employee Employee { get; set; }
        public virtual Tasks Tasks { get; set; }
        public virtual Teams Teams  { get; set; }
        public virtual TasksStatus TasksStatus  { get; set; }
    }
}