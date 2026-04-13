using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace BTTuan005_StudentPortal.Models
{
    [Table("Users")]
    public class User
    {
        [Key]
        [Column("UserID")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UserID { get; set; }

        // Personal Information
        public string FirstName { get; set; } = "";
        public string LastName { get; set; } = "";
        public string ContactEmail { get; set; } = "";
        public int Gender { get; set; } // 1: Male, 2: Female,  3: Other

        // Academic Details
        public string Major { get; set; } = "";

        // Login Credential 
        public string Username { get; set; } = "";
        public string Password { get; set; } = "";
    }
}
