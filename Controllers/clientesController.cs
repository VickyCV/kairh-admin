using kairh_admin.Models;
using kairh_admin.Models.firebase;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace kairh_admin.Controllers
{
    public class clientesController : Controller
    {

        private readonly MyDbContext _context;
        public firebaseCliente _firebase { get; set; }


        public clientesController(MyDbContext context)
        {
            _context = context;
            _firebase = new firebaseCliente();
        }
        public async Task<IActionResult> Index()
        {
            // Consultar la nube
            var data = _firebase.list();
            foreach (var item in data)
            {
                MyFbContext.modelCliente model = JsonConvert.DeserializeObject<MyFbContext.modelCliente>(((JProperty)item).Value.ToString());
                string llave = item.Name.ToString();

                // Modelo real
                var m = new cliente
                {
                    idcliente = llave,
                    apellidos = model.apellidos,
                    callePred = model.callePred,
                    ciudadPred = model.ciudadPred,
                    clave = model.clave,
                    coloniaPred = model.coloniaPred,
                    correo = model.correo,
                    cpPred = model.cpPred,
                    estadoPred = model.estadoPred,
                    latPred = model.latPred,
                    lonPred = model.lonPred,
                    municipioPred = model.municipioPred,
                    noExtPred = model.noExtPred,
                    noIntPred = model.noIntPred,
                    nombres = model.nombres,
                    telefono = model.telefono,
                };

                if (clienteExists(m.idcliente).Equals(true))
                {
                    var cte = await _context.Clientes.FirstOrDefaultAsync(o => o.idcliente == m.idcliente);
                    cte.idcliente = llave;
                    cte.apellidos = model.apellidos;
                    cte.callePred = model.callePred;
                    cte.ciudadPred = model.ciudadPred;
                    cte.clave = model.clave;
                    cte.coloniaPred = model.coloniaPred;
                    cte.correo = model.correo;
                    cte.cpPred = model.cpPred;
                    cte.estadoPred = model.estadoPred;
                    cte.latPred = model.latPred;
                    cte.lonPred = model.lonPred;
                    cte.municipioPred = model.municipioPred;
                    cte.noExtPred = model.noExtPred;
                    cte.noIntPred = model.noIntPred;
                    cte.nombres = model.nombres;
                    cte.telefono = model.telefono;

                    _context.Update(cte);
                    await _context.SaveChangesAsync();
                }
                else
                {

                    _context.Add(m);
                    await _context.SaveChangesAsync();
                }

            }

            return View(await _context.Clientes.ToListAsync());
        }
        [HttpPost]
        public async Task<IActionResult> Index(string searchString, string campo)
        {
            var clientes = from m in _context.Clientes
                           select m;


            switch (campo)
            {
                case "Nombre":
                    if (!String.IsNullOrEmpty(searchString))
                    {
                        clientes = clientes.Where(s => (s.nombres+" "+s.apellidos)!.Contains(searchString));
                        //clientes = clientes.Where(s => s.apellidos!.Contains(searchString));
                    }
                    break;
                case "Telefono":
                    if (!String.IsNullOrEmpty(searchString))
                    {
                        clientes = clientes.Where(s => s.telefono!.Contains(searchString));
                    }
                    break;
                //case "Estatus":
                //    if (!String.IsNullOrEmpty(searchString))
                //    {
                //        clientes = clientes.Where(s => s.Estatus.Equals(searchString));
                //    }
                //    break;
            }

            return View(await clientes.ToListAsync());
        }
        private bool clienteExists(string idcliente)
        {
            return _context.Clientes.Any(e => e.idcliente == idcliente);
        }
        private bool clienteExists(int id)
        {
            return _context.Clientes.Any(e => e.id == id);
        }
    }
}
