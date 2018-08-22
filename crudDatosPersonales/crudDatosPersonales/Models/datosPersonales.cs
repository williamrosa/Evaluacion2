using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace crudDatosPersonales.Models
{
    public class datosPersonales
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage ="Campo Obligatorio")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "Campo Obligatorio")]
        public string Apellido { get; set; }

        [Required(ErrorMessage = "Campo Obligatorio")]
        public string Direccion { get; set; }

        [Required(ErrorMessage = "Campo Obligatorio")]
        [DataType(DataType.EmailAddress, ErrorMessage = "Ingrese E-mail valido")]
        public string Email { get; set; }

        [DataType(DataType.PhoneNumber)]
        [MinLength(length: 8)]
        [MaxLength(length: 11)]
        [RegularExpression("^\\d+$", ErrorMessage = "El stock debe contener sólo números.")]
        [Required(ErrorMessage = "Campo Obligatorio")]
        [Phone]
        public string Telefono { get; set; }

    }
    public class datosPersonalesContext :DbContext
    {
        public DbSet<datosPersonales> datosPersonales { get; set; }
    }

}