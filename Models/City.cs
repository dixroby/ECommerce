using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ECommerce.Models
{
    public class City
    {
        [Key]
        public int CityId { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        [MaxLength(50, ErrorMessage = "el campo {0} como maximo {1} logitud de caracteres ")]

        //interiomente se ve como name  pero el usuario lo vera como  Ciudad
        [Display(Name = "Ciudad")]
        public string Name { get; set; }
        [Required(ErrorMessage = "El campo {0} es requerido")]
        public int Departmentid { get; set; }

        //para hacer la llave
        public virtual Department Department { get; set; }
    }
}