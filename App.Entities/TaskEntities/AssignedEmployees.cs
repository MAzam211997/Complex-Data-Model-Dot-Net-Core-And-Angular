using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace App.Entities.TaskEntities
{
    public class AssignedEmployees
    {
        [Key]
        [DisplayName("Assigned Employees Id")]
        public int AssignedEmployeesId { get; set; }
        public int? ManagerId { get; set; }
        public int? EmployeeId { get; set; }
        public DateTime AssignedDate { get; set; }
        public virtual Manager Manager{ get; set; }
        public virtual Employee Employee { get; set; }
    }
}