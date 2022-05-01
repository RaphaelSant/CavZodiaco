using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CavZodiaco.Core.Models;

public class Cavaleiros
{
    public int Id { get; set; }
    
    [StringLength(255)]
    [Required]
    public string? Name { get; set; }
    [StringLength(2000)]
    [Required]
    public string? Descricao { get; set; }
    [Required]
    public string? Imagem { get; set; }
}
