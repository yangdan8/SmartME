using System.ComponentModel.DataAnnotations;

namespace SmartME.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}