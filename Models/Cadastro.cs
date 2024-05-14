﻿using System.ComponentModel.DataAnnotations;

namespace CodeQuest.Models
{
    public class Cadastro
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required(ErrorMessage = "O nome é obrigatório")]
        public string Name { get; set; }
        [Required(ErrorMessage = "O email é obrigatório")]
        public string Email { get; set; }
        [Required(ErrorMessage = "A senha é obrigatória")]
        [MinLength(8, ErrorMessage = "O tamanho minímo é de caracteres é 8")]
        public string senha { get; set; }

    }
}
