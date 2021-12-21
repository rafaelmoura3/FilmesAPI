using System.ComponentModel.DataAnnotations;

namespace FilmesAPI.Data.Dtos
{
    public class UpdateFilmeDto
    { 
        [Required(ErrorMessage = "Campo Titulo é OBRIGATORIO!")]///notacao de validacao
        public string Titulo { get; set; }
        [Required(ErrorMessage = "Campo Diretor é OBRIGATORIO!")]
        public string Diretor { get; set; }
        [StringLength(30, ErrorMessage = "O genero nao pode passar de 30 char")]
        public string Genero { get; set; }
        [Range(1, 600, ErrorMessage = "Campo Titulo é OBRIGATORIO!")]
        public int Duracao { get; set; }
    }
}
