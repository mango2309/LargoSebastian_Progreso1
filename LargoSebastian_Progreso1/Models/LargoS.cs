using System.ComponentModel.DataAnnotations;

namespace LargoSebastian_Progreso1.Models
{
    public class LargoS
    {
        [Key]
        public int IdNombre { get; set; }

        [Range(0, int.MaxValue, ErrorMessage = "El valor debe ser positivo.")]
        public int Entero { get; set; }

        [Range(0.01, double.MaxValue, ErrorMessage = "El precio debe ser mayor a cero.")]
        public decimal Decimal { get; set; }

        [StringLength(100, ErrorMessage = "El campo no puede exceder los 100 caracteres.")]
        public string Palabra { get; set; }

        [Required(ErrorMessage = "Debe escoger verdadero o falso")]
        public bool VerdaderoFalso { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Fecha de creación")]
        public DateTime Fecha { get; set; }

        public virtual ICollection<Celular> Celulares { get; set; }
    }
}
