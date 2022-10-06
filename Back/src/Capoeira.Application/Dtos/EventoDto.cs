using System.ComponentModel.DataAnnotations;

namespace Capoeira.Application.Dtos
{
    public class EventoDto
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "O campo {0} é obrigatório."),
        StringLength(50, MinimumLength = 3, ErrorMessage = "Insira de 3 a 50 caracteres.")]
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public string Local { get; set; }
        public string DataEvento { get; set; }
        [Display(Name = "Qtd Pessoas"),
        Range(1, 120000, ErrorMessage = "{0} não pode ser menor que 1 e maior que 120.000,00")]
        public int QtdPessoas { get; set; }
        [RegularExpression(@".*\.(jpe?g|png)$", ErrorMessage = "Imagem inválida. Experimente formatos: jpg, jpeg ou png.")]
        public string ImagemUrl { get; set; }
        [Required(ErrorMessage = "O campo {0} é obrigatório."),
        Phone(ErrorMessage = "O campo {0} está com número inválido.")]
        public string Telefone { get; set; }
        [Display(Name = "e-mail"),
        Required(ErrorMessage = "O campo {0} é obrigatório."),
        EmailAddress(ErrorMessage = "Campo {0} inválido.")]
        public string Email { get; set; }
        public int UserId { get; set; }
        public UserDto UserDto { get; set; }
    }
}