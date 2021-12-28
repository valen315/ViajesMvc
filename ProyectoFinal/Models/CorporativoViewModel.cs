using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoFinal.Models
{
    public class CorporativoViewModel: ClientePadreModel
    {
        public string CUIT { get; set; }
        public string RSocial { get; set; }
    }
}