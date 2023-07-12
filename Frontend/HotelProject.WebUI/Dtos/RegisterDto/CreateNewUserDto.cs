using System.ComponentModel.DataAnnotations;

namespace HotelProject.WebUI.Dtos.RegisterDto
{
    public class CreateNewUserDto
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Username { get; set; }
        public string Mail { get; set; }
        public string Password { get; set; }
        [Required(ErrorMessage ="Şifre tekrarı gereklidir.")]
        [Compare("Password",ErrorMessage ="Şifreler aynı değil !")]
        public string ConfirmPassword { get; set; }
    }
}
