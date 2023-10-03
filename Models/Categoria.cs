using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace waSEMANA077.Models
{
    public class Categoria
    {
       [Required] public int idCategoria {get; set;}

        [Required] public string NombreCategoria { get;set;}

        [Required]   public string Descripcion { get; set;}  

        public Categoria() { }
    }
}