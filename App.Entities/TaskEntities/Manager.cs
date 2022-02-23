using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace App.Entities.TaskEntities
{
    public class Manager
    {
        [Key]
        [DisplayName("Manager Id")]
        public int ManagerId { get; set; }
        [DisplayName("Manager Name")]
        public string ManagerName { get; set; }
        [DisplayName("Address")]
        public string Address{ get; set; }
        [DisplayName("Contact No.")]
        public string Contact { get; set; }
        [DisplayName("CNIC No.")]
        public string Cnic { get; set; }
        [DisplayName("Email Id")]
        public string Email { get; set; }
        [DisplayName("Username")]
        public string Username { get; set; }
        [DisplayName("Password")]
        public string Password { get; set; }
        public float Salary { get; set; }
        [DisplayName("Bank Name")]
        public string BankName { get; set; }
        [DisplayName("Account No")]
        public string AccountNo { get; set; }
        public bool AccountStatus { get; set; }
    }
}