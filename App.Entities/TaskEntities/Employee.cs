using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace App.Entities.TaskEntities
{
    public class Employee
    {
        [Key]
        [DisplayName("Employee Id")]
        public int EmployeeId { get; set; }
        [DisplayName("Employee Name")]
        public string EmployeeName { get; set; }
        [DisplayName("Address")]
        public string Address{ get; set; }
        [DisplayName("Contact No.")]
        public string Contact{ get; set; }
        [DisplayName("CNIC No.")]
        public string Cnic { get; set; }
        [DisplayName("Email Id")]
        public string Email { get; set; }
        [DisplayName("Username")]
        public string Username { get; set; }
        [DisplayName("Password")]
        public string Password { get; set; }
        public string Designation { get; set; }
        public string Department { get; set; }
        public string Qualification { get; set; }
        public string Experience { get; set; }
        public bool AccountStatus { get; set; }
       
    }
}