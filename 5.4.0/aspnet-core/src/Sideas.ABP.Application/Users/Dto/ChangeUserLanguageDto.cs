using System.ComponentModel.DataAnnotations;

namespace Sideas.ABP.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}