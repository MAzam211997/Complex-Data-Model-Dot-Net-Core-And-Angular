using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace App.Entities.TaskEntities
{
    public class Tasks
    {
        [Key]
        [DisplayName("Task Id")]
        public int TaskId { get; set; }
        [DisplayName("Task Title")]
        public string TaskTitle { get; set; }
        [DisplayName("Task Description")]
        public string TaskDescription { get; set; }
        [DisplayName("Task Progress")]
        public string TaskProgress { get; set; }

        [DisplayName("Created Date")]
        public DateTime CreatedDate { get; set; }
        public DateTime Deadline { get; set; }
        [DisplayName("Manager")]
        public int? ManagerId { get; set; }
        [DisplayName("Progress")]
        public int? StatusId { get; set; }
        [DisplayName("Employee")]
        public int? EmployeeId { get; set; }
        public virtual Manager Manager{ get; set; }
        public virtual Employee Employee { get; set; }
        public virtual TasksStatus TasksStatus { get; set; }
    }
}