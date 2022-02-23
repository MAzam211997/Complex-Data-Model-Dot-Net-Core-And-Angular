using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace App.Entities.TaskEntities
{
    public class SubTasks
    {
        [Key]
        [DisplayName("Sub Task Id")]
        public int SubTaskId { get; set; }
        [DisplayName("Sub Task Title")]
        public string SubTaskTitle { get; set; }
        [DisplayName("Sub Task Description")]
        public string SubTaskDescription { get; set; }
        [DisplayName("Sub Task Progress")]
        public string SubTaskProgress { get; set; }

        [DisplayName("Created Date")]
        public DateTime CreatedDate { get; set; }
        public DateTime Deadline { get; set; }
        [DisplayName("Manager")]
        public int? ManagerId { get; set; }
        [DisplayName("Employee")]
        public int? EmployeeId { get; set; }
        [DisplayName("Task")]
        public int? TaskId { get; set; }
        public virtual Manager Manager{ get; set; }
        public virtual Employee Employee { get; set; }
        public virtual Tasks Tasks { get; set; }
    }
}