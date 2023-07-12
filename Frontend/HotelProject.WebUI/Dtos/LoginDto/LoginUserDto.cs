using System.ComponentModel.DataAnnotations;

namespace HotelProject.WebUI.Dtos.LoginDto
{
    public class LoginUserDto
    {
        [Required(ErrorMessage ="Boş Geçilemez !")]
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
