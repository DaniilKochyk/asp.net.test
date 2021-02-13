using System.ComponentModel.DataAnnotations;

namespace MyCompany.Domain.Entities
{
    public class TextField : EntityBase
    {
        [Required]
        public string CodeWord { get; set; }

        [Display(Name = "Nazwa strony")]
        public override string Title { get; set; } = "Info";

        [Display(Name = "strona")]
        public override string Text { get; set; } = "wypełnia się administratorem";
    }
}
