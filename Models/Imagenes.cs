using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace practica04.Models
{
    [Table("imagenes")]
    public class Imagenes
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int id { get; set; }

        [Display(Name="nombre de usuario: ")]
        [Column("nombreUsuario")]
        [Required(ErrorMessage="Porfavor ingrese un nombre de usuario")]
        public string nombreUsuario { get; set; }

        [Display(Name="imagen: ")]
        [Column("imagen")]
        [Required(ErrorMessage="Porfavor ingrese una imagen")]
        public string imagen { get; set; }

        [Display(Name="fecha: ")]
        [Required(ErrorMessage="Porfavor ingrese una fecha")]
        public DateTime date { get; set; }
        
    }
}
