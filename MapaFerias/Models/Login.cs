using System.ComponentModel.DataAnnotations;

namespace MapaFerias.Models
{
    public class Login
    {
        [Required(ErrorMessage = "A senha do usuário é obrigatória.", AllowEmptyStrings = false)]
        [MaxLength(10, ErrorMessage = "A senha deve possuir no máximo 10 caracteres")]
        [DataType(System.ComponentModel.DataAnnotations.DataType.Password)]
        public string Senha { get; set; }

        [Required(ErrorMessage = "O Login do usuario e obrigatório.", AllowEmptyStrings = false)]
        [MaxLength(10, ErrorMessage = "O Login deve possuir no máximo 10 caracteres")]
        [Display(Name ="Login")]
        public string LoginUsuario { get; set; }
    }
}