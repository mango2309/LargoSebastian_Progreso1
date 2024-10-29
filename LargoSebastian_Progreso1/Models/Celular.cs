using System.ComponentModel.DataAnnotations;

namespace LargoSebastian_Progreso1.Models
{
    public class Celular
    {
        [Key]
        public int IdCelular { get; set; }

        [Required(ErrorMessage ="El modelo es obligatorio")]
        public string Modelo { get; set; }

        [Range(2000, 2024, ErrorMessage = "El año debe estar entre 2000 y 2024.")]
        public int Anio { get; set; }

        [Range(0.01, double.MaxValue, ErrorMessage = "El precio debe ser mayor a cero.")]
        public decimal Precio { get; set; }

        public int LargoS {  get; set; }
        
    }
}
