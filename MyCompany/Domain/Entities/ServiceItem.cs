using System.ComponentModel.DataAnnotations;

namespace MyCompany.Domain.Entities
{
    public class ServiceItem : EntityBase
    {
        [Required(ErrorMessage = "wypelnij")]
        [Display(Name = "Nazwa")]
        public override string Title { get; set; }

        [Display(Name = "Krótki opis")]
        public override string Subtitle { get; set; }

        [Display(Name = "Opis")]
        public override string Text { get; set; }
    }
}
