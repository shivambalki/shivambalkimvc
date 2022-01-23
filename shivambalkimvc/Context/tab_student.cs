//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace shivambalkimvc.Context
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class tab_student
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="Name cannot be empty")]
        public string Name { get; set; }
      //   [Required(ErrorMessage = "Date of Birth cannot be empty")]
        public Nullable<System.DateTime> Dob { get; set; }
        [Required(ErrorMessage = "Email cannot be empty")]
        [EmailAddress]
        public string Email { get; set; }
        [Required(ErrorMessage = "Phone Number cannot be empty")]
        [MinLength(10,ErrorMessage ="Number shoud be 10 Digit"),MaxLength(10, ErrorMessage = "Number shoud be 10 Digit")]
        public string Phone { get; set; }
        [Required(ErrorMessage = "City cannot be empty")]
        public string City { get; set; }
    }
}
