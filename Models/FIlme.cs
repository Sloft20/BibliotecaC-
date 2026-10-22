using System.ComponentModel.DataAnnotations;
namespace Filmoteca.Models;
public class Filme
{
 public int Id { get; set; }

 [Required(ErrorMessage = "Informe o título.")]
 [StringLength(150)]
 [Display(Name = "Título")]
 public string Titulo { get; set; } = string.Empty;

 [Required(ErrorMessage = "Informe o gênero.")]
 [StringLength(50)]
 [Display(Name = "Gênero")]
 public string Genero { get; set; } = string.Empty;

 [Range(1900, 2100, ErrorMessage = "Ano entre 1900 e 2100.")]
 public int Ano { get; set; }
 
 [Range(1, 600, ErrorMessage = "Duração entre 1 e 600 minutos.")]
 [Display(Name = "Duração (min)")]
 public int Duracao { get; set; }

 [Required(ErrorMessage = "Informe o diretor.")]
 [StringLength(100)]
 public string Diretor { get; set; } = string.Empty;

}
