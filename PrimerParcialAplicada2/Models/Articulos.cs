using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PrimerParcialAplicada2.Models
{
    public class Articulos
    {
        [Key]
        
        public int ArtiiculoId { get; set; }
        [Required(ErrorMessage ="Este campo no puede Estar vacio")]
     //   [MinLength(6,ErrorMessage ="Deben ser mas de 6 Caracteres")]
        public string Descripcion { get; set; }
        [Required(ErrorMessage = "Este campo no puede Estar vacio")]
        [Range(0, 100000000, ErrorMessage = "La Existencia Debe Ser Mayor Que cero y menor 100000000")]
        public decimal Existencia { get; set; }
        [Required(ErrorMessage = "Este campo no puede Estar vacio")]
        [Range(0, 100000000, ErrorMessage = "El Costo Debe Ser Mayor Que cero y menor 100000000")]
        public decimal Costo { get; set; }
        [Required(ErrorMessage = "Este campo no puede Estar vacio")]
        [Range(0, 100000000, ErrorMessage = "El Inventario Debe Ser Mayor Que cero y menor 100000000")]
        public decimal Inventario { get; set; }
        public Articulos()
        {
            ArtiiculoId = 0;
            Descripcion = string.Empty;
            Existencia = 0;
            Costo = 0;
            Inventario = 0;
        }
    }
}
