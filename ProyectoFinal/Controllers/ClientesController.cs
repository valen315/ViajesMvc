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
        EmpresaEntities db = new EmpresaEntities();
        public ActionResult Index()
        {
            return View(db.Clientes.Where(x=>x.CUIT==null && x.RSocial==null).ToList());
            /*
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
            */
        }
        public ActionResult New()
        {
            return View();
        }

        [HttpPost]
        public ActionResult New(ParticularFormModel model)
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
                    return Redirect("~/Clientes/Index");
                }
                return View(model);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        //CLIENTES CORPORATIVOS
        public ActionResult IndexCorp()
        {
            List<CorporativoViewModel> list;
            using (EmpresaEntities db = new EmpresaEntities())
            {
                list = (from d in db.Clientes
                        select new CorporativoViewModel
                        {
                            Id = d.Id,
                            Nacionalidad = d.Nacionalidad,
                            Provincia = d.Provincia,
                            Direccion = d.Direccion,
                            Telefono = d.Telefono,
                            DNI = d.DNI,
                            Nombre = d.Nombre,
                            Apellido = d.Apellido,
                            CUIT=d.CUIT,
                            RSocial=d.RSocial
                        }).Where(x=>x.CUIT!=null).ToList();
            }

            return View(list);
        }
        public ActionResult NewCorp()
        {
            return View();
        }
        [HttpPost]
        public ActionResult NewCorp(CorporativoFormModel model)
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
                        c.CUIT = model.CUIT;
                        c.RSocial = model.RSocial;
                        db.Clientes.Add(c);
                        db.SaveChanges();

                    }
                    return Redirect("~/Clientes/IndexCorp");
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