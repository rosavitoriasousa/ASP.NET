using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ExemploRosaWillian.Models
{
    public class Usuario1
    {
        [Display(Name = "Digite seu Nome")]
        [Required(ErrorMessage =" O nome é obrigatório")]
        public string NomeUsuario { get; set; }

        [Display(Name = "Artes Marciais")] //ArtesMarciais
        [StringLength(20,MinimumLength =5, ErrorMessage ="Insira de 5 a 20 caracteres")]
        public string Observacao { get; set; }

        [Display(Name = "Anéis do Poder")] 
        [Range(1, 10, ErrorMessage = "Digite quando anéis do poder  voce possui 1 e 10")]
        public string Idade { get; set; }

        [Display(Name = "Digite seu email")]
        [RegularExpression(@"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*", ErrorMessage = "Email Invalido")]
        public string Email { get; set; }

        [Display(Name = "Digite seu personagem")]
        [RegularExpression(@"[a-zA-Z]{5,15}", ErrorMessage = "Somente letras e de 5 a 15 caracteres")]
        [Required(ErrorMessage = "Login Obrigatório")]

        public string Login { get; set; } //dataannottaion alguma coisa dos aneis

        [Display(Name = "Crie sua senha")]
        [Required(ErrorMessage = "Senha Obrigatória")]

        public string Senha { get; set; }

        [Display(Name = "Confirmar Senha")]
        [System.ComponentModel.DataAnnotations.Compare("Senha", ErrorMessage = "A senha não está certa")]

        public string Confsenha { get; set; }
    }
    
}