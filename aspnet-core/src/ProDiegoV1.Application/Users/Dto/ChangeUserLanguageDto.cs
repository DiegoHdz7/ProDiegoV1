using System.ComponentModel.DataAnnotations;

namespace ProDiegoV1.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}