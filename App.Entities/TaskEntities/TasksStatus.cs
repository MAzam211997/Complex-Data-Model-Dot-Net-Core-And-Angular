using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace App.Entities.TaskEntities
{
    public class TasksStatus
    {
        [Key]
        [DisplayName(" Id")]
        public int StatusId { get; set; }
        [DisplayName("Task Title")]
        public string StatusTitle { get; set; }
        [DisplayName("Task Description")]
        public string StatusDescription { get; set; }
    }
}