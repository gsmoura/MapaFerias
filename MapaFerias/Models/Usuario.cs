using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MapaFerias.Models
{
    [System.ComponentModel.DataAnnotations.Schema.Table("Usuario")]
    public class Usuario
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "O nome do usuario e obrigatório.", AllowEmptyStrings = false)]
        [MaxLength(50, ErrorMessage = "O nome deve possuir no máximo 50 caracteres.")]
        public string Nome { get; set; }

        [Display(Name = "Login")]
        [Required(ErrorMessage = "O Login do usuario e obrigatório.", AllowEmptyStrings = false)]
        [MaxLength(10, ErrorMessage = "O Login deve possuir no máximo 10 caracteres")]
        public string LoginUsuario { get; set; }

        [Required(ErrorMessage = "A senha do usuário é obrigatória.", AllowEmptyStrings = false)]
        [MaxLength(10, ErrorMessage = "A senha deve possuir no máximo 10 caracteres")]
        [DataType(System.ComponentModel.DataAnnotations.DataType.Password)]
        public string Senha { get; set; }

        [Display(Name = "E-mail")]
        [Required(ErrorMessage = "Favor informar um e-mail válido.", AllowEmptyStrings = false)]
        [RegularExpression(@"^[A-Za-z0-9](([_\.\-]?[a-zA-Z0-9]+)*)@([A-Za-z0-9]+)(([\.\-‌​]?[a-zA-Z0-9]+)*)\.([A-Za-z]{2,})$", ErrorMessage = "Favor informar um e-mail válido")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Favor selecionar o perfil do usuário", AllowEmptyStrings = false)]
        public Perfil Pefil { get; set; }

        [Display(Name = "Data Contratação")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:MM-dd-yyyy}")]
        [Required(ErrorMessage = "Favor informar a data contratação")]
        public string DataContratacao { get; set; }
    }
}