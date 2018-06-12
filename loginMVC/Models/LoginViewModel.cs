using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace loginMVC.Models
{
    public class LoginViewModel
    {
        [Required]
        //Display Colocar o nome no 'label for' 
        [Display(Name ="Usuário")]
        public string Usuario { get; set; }

        [Required]
        //Display Colocar o nome no 'label for' 
        [Display(Name ="Senha")]
        public string  Senha { get; set; }

        [Required]
        //Display Colocar o nome no 'label for' 
        [Display(Name ="Lembrar Me")]
        public bool  LembrarMe { get; set; }
    }
}