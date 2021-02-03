using System.ComponentModel.DataAnnotations;

namespace CourseApp.Models
{
    public class Student
    {
        [Required(ErrorMessage ="İsim Giriniz")]
        public string Name { get; set; }
        [Required(ErrorMessage = "E-mail Giriniz")]
        [EmailAddress(ErrorMessage ="Mail Adresinizi Düzgün Giriniz")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Soyisim Giriniz")]
        public string Surname { get; set; }
        [Required(ErrorMessage = "Telefon Giriniz")]
        public string Phone { get; set; }
        [Required(ErrorMessage = "Seçim Yapınız")]
        public bool? Confirm { get; set; } //true,false,null
    }
}
