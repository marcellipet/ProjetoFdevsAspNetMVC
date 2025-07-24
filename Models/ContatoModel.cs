using System.ComponentModel.DataAnnotations;

namespace ProjetoFdevs.Models
{
    public class ContatoModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Esse campo não pode estar vazio!")]
        [StringLength(100, ErrorMessage = "O nome deve ter no máximo 100 caracteres.")]
        [MinLength(4, ErrorMessage = "O nome deve ter pelo menos 4 caracteres.")]
        [Display(Name = "Nome Completo")]
        [RegularExpression(@"^[a-zA-Z\s]+$", ErrorMessage = "O nome deve conter apenas letras e espaços.")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "Esse campo não pode estar vazio!")]
        [EmailAddress(ErrorMessage = "O e-mail deve ser válido.")]
        [Display(Name = "E-mail")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Esse campo não pode estar vazio!")]
        [StringLength(15, ErrorMessage = "O celular deve ter no máximo 15 caracteres.")]
        [Display(Name = "Celular")]
        [RegularExpression(@"^\+?[0-9\s]+$", ErrorMessage = "O celular deve conter apenas números e espaços, podendo iniciar com '+'.")]
        [DataType(DataType.PhoneNumber)]
        [DisplayFormat(DataFormatString = "{(00)00000-0000}", ApplyFormatInEditMode = true)]
        public string Celular { get; set; }
    }
}
