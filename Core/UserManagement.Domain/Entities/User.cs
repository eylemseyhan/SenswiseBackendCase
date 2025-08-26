using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserManagement.Domain.Entities
{
    public class User
    {
        public int UserId { get; set; }

        [Display(Name = "Ad")]
        [Required(ErrorMessage = "{0} alanı gereklidir.")]
        public string FirstName { get; set; }


        [Display(Name = "Soyad")]
        [Required(ErrorMessage = "{0} alanı gereklidir.")]
        public string LastName { get; set; }

        [Display(Name = "E-posta")]
        [Required(ErrorMessage = "{0} alanı gereklidir.")]
        public string Email { get; set; } 

        public string? Address { get; set; }
    }
}
