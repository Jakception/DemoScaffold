﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace DemoScaffold.Models
{
    [Table("Restos")]
    public class Resto
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Le nom du restaurant doit être saisi")]
        [StringLength(80)]
        public string Nom { get; set; }
        [Display(Name ="Téléphone")]
        [RegularExpression(@"^0[0-9]{9}$", ErrorMessage = "Le numéro de téléphone est incorrect")]
        public string Telephone { get; set; }
        public string Email { get; set; }
    }
}