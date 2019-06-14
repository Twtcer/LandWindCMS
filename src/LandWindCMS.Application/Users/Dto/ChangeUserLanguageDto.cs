using System.ComponentModel.DataAnnotations;

namespace LandWindCMS.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}