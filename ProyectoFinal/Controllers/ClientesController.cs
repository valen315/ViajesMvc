using ProyectoFinal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProyectoFinal.Controllers
{
    public class ClientesController : Controller
    {
        // GET: Clientes
        public ActionResult Index()
        {
            List<ParticularViewModel> list;
            using (EmpresaEntities db = new EmpresaEntities())
            {
                list = (from d in db.Clientes
                        select new ParticularViewModel
                        {
                            Id = d.Id,
                            Nacionalidad = d.Nacionalidad,
                            Provincia = d.Provincia,
                            Direccion = d.Direccion,
                            Telefono = d.Telefono,
                            DNI = d.DNI,
                            Nombre = d.Nombre,
                            Apellido = d.Apellido
                        }).ToList();
            }

            return View(list);
        }
        public ActionResult New()
        {
            return View();
        }

        [HttpPost]
        public ActionResult New(ParticularForm model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    using (EmpresaEntities db = new EmpresaEntities())
                    {
                        var c = new Clientes();
                        c.Nacionalidad = model.Nacionalidad;
                        c.Nombre = model.Nombre;
                        c.Provincia = model.Provincia;
                        c.Direccion = model.Direccion;
                        c.Telefono = model.Telefono;
                        c.DNI = model.DNI;
                        c.Nombre = model.Nombre;
                        c.Apellido = model.Apellido;
                        db.Clientes.Add(c);
                        db.SaveChanges();
                        
                    }
                    return Redirect("/");
                }
                return View(model);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}