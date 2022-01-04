using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace ProyectoFinal.Models
{
    public class CorporativoFormModel
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Nacionalidad es requerido")]
        [StringLength(30)]
        [Display(Name = "Nacionalidad")]
        public string Nacionalidad { get; set; }

        [Required(ErrorMessage = "Provincia es requerido")]
        [StringLength(50)]
        [Display(Name = "Provincia")]
        public string Provincia { get; set; }

        [Required(ErrorMessage = "Direccion es requerido")]
        [StringLength(50)]
        [Display(Name = "Direccion")]
        public string Direccion { get; set; }

        [Required(ErrorMessage = "Telefono es requerido")]
        [StringLength(30)]
        [Display(Name = "Telefono")]
        public string Telefono { get; set; }

        [Required(ErrorMessage = "DNI es requerido")]
        [StringLength(10)]
        [Display(Name = "DNI")]
        public string DNI { get; set; }

        [Required(ErrorMessage = "Apellido es requerido")]
        [StringLength(30)]
        [Display(Name = "Apellido")]
        public string Apellido { get; set; }

        [Required(ErrorMessage = "Nombre es requerido")]
        [StringLength(30)]
        [Display(Name = "Nombre")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "CUIT es requerido")]
        [StringLength(15)]
        [Display(Name = "CUIT")]
        public string CUIT { get; set; }

        [Required(ErrorMessage = "Razon Social es requerido")]
        [StringLength(50)]
        [Display(Name = "Razon social")]
        public string RSocial { get; set; }
    }
}