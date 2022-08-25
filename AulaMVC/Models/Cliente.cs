using System.ComponentModel.DataAnnotations;

namespace AulaMVC.Models
{
    public class Cliente
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="O nome é obrigatório")]
        public string? Nome { get; set; }

        [Range(0,150,ErrorMessage ="A idade deve estar entre 0 e 150")]
        public int Idade { get; set; }
        [Required(ErrorMessage = "O salário é obritório")]
        public double Salario { get; set; }
        [EmailAddress(ErrorMessage ="O email inserido é inválido")]
        public string? Email { get; set; }

    }
}
