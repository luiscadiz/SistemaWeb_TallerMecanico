using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Web_System.Models
{
    public partial class Admins
    {
        [Key]
        public Guid ID {get; set;}

        [Required]
        [MaxLength(100)]
        public string Name {get; set;}
        [Required]
        [MaxLength(100)]
        public string Surname {get; set;}

        [Display(Name = "Birth Date")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime BirthDate {get; set;}

        [Required]
        [MaxLength(200)]
        public string Email {get; set;}

        [Required]
        [MaxLength(100)]
        public string Password {get; set;}

        public string Phone {get; set;}

        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime Created {get; set;}

        [NotMapped]
        public string FullName
        {
            get
            {
                return Surname + ", " + Name;
            }
        }
    }
}