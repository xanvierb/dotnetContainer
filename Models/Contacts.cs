using System;
using System.ComponentModel.DataAnnotations;

namespace StartProject.Models
{
    public class Contacts
    {        
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string IsFamilyMember { get; set; }        
        public string Company { get; set; }
        public string JobTitle { get; set; }
        public string Email { get; set; }
        [Key]
        public string MobilePhone { get; set; }
        public string DateOfBirth { get; set; }
        public string AnniversaryDate { get; set; }
    }
}