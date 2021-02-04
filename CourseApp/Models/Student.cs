using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CourseApp.Models
{
    public class Student
    {
        [Required(ErrorMessage ="İsminizi giriniz")]
        public string Name { get; set; }
        [Required(ErrorMessage ="Email gir")]
        [EmailAddress(ErrorMessage ="Mail adresini düzgün gir")]
        public string Email { get; set; }
        [Required(ErrorMessage ="Telefon gir")]
        public string Phone { get; set; }
        [Required(ErrorMessage ="Katılacak mısın ?")]
        public bool? Confirm { get; set; } // true, false, null

    }
}
