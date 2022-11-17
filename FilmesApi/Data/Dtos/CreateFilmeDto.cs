using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FilmesApi.Data.Dtos
{
    public class CreateFilmeDto
    {
        [Required(ErrorMessage = "O campo titulo é obrigatorio")]
        public string Titulo { get; set; }
        [Required(ErrorMessage = "O campo diretor é obrigatorio")]
        public string Diretor { get; set; }
        [StringLength(30, ErrorMessage = "O genero nao pode passar de 30 letras")]
        public string Genero { get; set; }
        [Range(1, 600, ErrorMessage = "O filme deve ter entre 1 a 600 min")]
        public int Duracao { get; set; }
    }
}
