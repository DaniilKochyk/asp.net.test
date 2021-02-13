using System;
using System.ComponentModel.DataAnnotations;

namespace MyCompany.Domain.Entities
{
    public abstract class EntityBase
    {
        protected EntityBase() => DateAdded = DateTime.UtcNow;

        [Required]
        public Guid Id { get;set; }

        [Required(ErrorMessage = "wypelnij")]
        [Display(Name = "Nazwa")]
        [StringLength(70, MinimumLength =2)]
        [RegularExpression(@"^[A-Za-zżźćńółęąśŻŹĆĄŚĘŁÓŃ0-9 ]*$", ErrorMessage = "Proszę używać tylko litery i liczby")]
        public virtual string Title { get; set; }

       
        [Display(Name = "Krótki opis")]  
        
        [StringLength(30, MinimumLength = 2)]
        [RegularExpression(@"^[A-Za-zżźćńółęąśŻŹĆĄŚĘŁÓŃ0-9 ]*$", ErrorMessage = "Proszę używać tylko litery i liczby")]
        public virtual string Subtitle { get; set; }

        [Display(Name = "opis")]
        [Required(ErrorMessage = "wypelnij")]
        public virtual string Text { get; set; }

        [Display(Name = "obrazek")]
        public virtual string TitleImagePath { get; set; }



        [DataType(DataType.Time)]
        public DateTime DateAdded { get; set; }
    }
}
