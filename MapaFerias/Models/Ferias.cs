using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MapaFerias.Models
{
    [System.ComponentModel.DataAnnotations.Schema.Table("Ferias")]
    public class Ferias
    {
        public int Id { get; set; }

        [Required]
        [ForeignKey("Usuario")]
        public int IdUsuario { get; set; }

        [Display(Name = "Data Inicio")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:MM-dd-yyyy}")]
        [Required(ErrorMessage = "Favor informar a data de inicio das férias.")]
        public string DataInicio { get; set; }

        [Display(Name = "Data Fim")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:MM-dd-yyyy}")]
        [Required(ErrorMessage = "Favor informar a data do fim das férias.")]
        public string DataFim { get; set; }

        [DefaultValue(30)]
        [Display(Name = "Dias disponiveis")]
        public string DiasDisponveis { get; set; }

        [DefaultValue(0)]
        [Display(Name = "Dias tirados")]
        public int DiasTirados { get; set; }

        [MaxLength(15, ErrorMessage = "")]
        public string Status { get; set; }

        [MaxLength(100, ErrorMessage = "A justificativa de possuir no máximo 100 carácteres")]
        public string Justificativa { get; set; }

        public virtual Usuario Usuario { get; set; }
    }
}