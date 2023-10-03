using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace waSEMANA077.Models
{
    public class Obrero
    {
        [DisplayName("CODIGO")][Required] public int id_obrero {  get; set; }
        [DisplayName("NOMBRE")][Required] public string nombre { get; set; }
        [DisplayName("APELLIDOS")][Required] public string apellido { get; set; }
        [DisplayName("DNI")][Required] public int dni { get; set; }
        [DisplayName("GENERO")][Required] public string genero { get; set; }
        [DisplayName("SUELDO")][Required] public decimal sueldo { get; set; }
        [DisplayName("FECHA DE NACIMIENTO")][Required] public DateTime fecha_naci {get; set; }

        
        public Obrero()
        {
            fecha_naci = new DateTime(1753, 1, 1);
        }

    }
}