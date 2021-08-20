using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace testef.odels{
    public class Category{
        [key]
        public int Id {get; set;}

        [Required(ErrorMessage = "Este campo é obrigatorio")]
        [MaxLength(60,ErrorMessage = "Este campo deve conter entre 3 e 60 caracteres")]
        [MinLength(3,ErrorMessage = "Este campo deve conter entre 3 e 60 caracteres")]

        public string Title {get;set;}
    }
}