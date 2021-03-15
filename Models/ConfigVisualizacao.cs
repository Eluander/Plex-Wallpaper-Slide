using MyPLEX.Enums;
using System.ComponentModel.DataAnnotations;

namespace MyPLEX.Models
{
    public class ConfigVisualizacao
    {
        public int Section { get; set; }

        [Display(Name = "Modo Visualização")]
        public EModoVisualizacao EModoVisualizacao { get; set; }
    }
}
