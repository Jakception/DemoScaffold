using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DemoScaffold.Models
{
    public class Utilisateur
    {
        public int Id { get; set; }
        [Required]
        [Display(Name = "Prénom")]
        public string Prenom { get; set; }
        [Required]
        [Display(Name = "Mot de passe")]
        public string MotDePasse { get; set; }
        public int Age { get; set; }
    }
}