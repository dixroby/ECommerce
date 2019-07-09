using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ECommerce.Models
{
    public class Department
    {
        [Key]
        public int Departmentid { get; set; }

        [Required(ErrorMessage ="El campo {0} es requerido")]
        [MaxLength(50,ErrorMessage ="el campo {0} como maximo {1} logitud de caracteres ")]

        //interiomente se ve como name  pero el usuario lo vera como  departamentos
        [Display(Name ="Departamento")]
        public string Name { get; set; }
        
        // definiendo uno a muchos en entity framework
        public virtual ICollection<City> Cities { get; set; }
    }
}