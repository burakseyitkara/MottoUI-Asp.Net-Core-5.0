using System.ComponentModel.DataAnnotations;

namespace MottoUI.Models
{
    public class RoleViewModel
    {
        [Required(ErrorMessage = "Lütfen rol adı giriniz.")]
        public string name { get; set; }
    }
}
