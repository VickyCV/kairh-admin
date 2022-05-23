using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using kairh_admin.Models;
using FireSharp;
using FireSharp.Response;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using kairh_admin.Models.firebase;

namespace kairh_admin.Controllers
{
    public class negociosController : Controller
    {

        private readonly MyDbContext _context;
        public firebaseNegocio _firebase { get; set; }


        public negociosController(MyDbContext context)
        {
            _context = context;
            _firebase = new firebaseNegocio();
        }
        public async Task<IActionResult> Index()
        {
            // Consultar la nube
            var data = _firebase.list();
            foreach (var item in data)
            {
                MyFbContext.modelNegocio model = JsonConvert.DeserializeObject<MyFbContext.modelNegocio>(((JProperty)item).Value.ToString());
                string llave = item.Name.ToString();

                // Modelo real
                var m = new negocio
                {
                    idnegocio = llave,
                    Estatus = model.Estatus,
                    calificacion = model.calificacion,
                    calle = model.calle,
                    ciudad = model.ciudad,
                    colonia = model.colonia,
                    cp = model.cp,
                    descripcion = model.descripcion,
                    domingoFin = model.domingoFin,
                    domingoInicio = model.domingoInicio,
                    domingock = model.domingock,
                    email = model.email,
                    especialidad = model.especialidad,
                    estado = model.estado,
                    estrellas = model.estrellas,
                    juevesFin = model.juevesFin,
                    juevesInicio = model.juevesInicio,
                    latitud = model.latitud,
                    longitud = model.longitud,
                    lunesFin = model.lunesFin,
                    lunesInicio = model.lunesInicio,
                    lunesck = model.lunesck,
                    martesFin = model.martesFin,
                    martesInicio = model.martesInicio,
                    martesck = model.martesck,
                    miercolesFin = model.miercolesFin,
                    miercolesInicio = model.miercolesInicio,
                    miercolesck = model.miercolesck,
                    municipio = model.municipio,
                    nombreComercial = model.nombreComercial,
                    numext = model.numext,
                    numint = model.numint,
                    profileImage = model.profileImage,
                    razonSocial = model.razonSocial,
                    rfc = model.rfc,
                    sabadoFin = model.sabadoFin,
                    sabadoInicio = model.sabadoInicio,
                    sabadock = model.sabadock,
                    telefono = model.telefono,
                    tipo = model.tipo,
                    viajes = model.viajes,
                    viernesFin = model.viernesFin,
                    viernesInicio = model.viernesInicio,
                    viernesck = model.viernesck
                };

                if (negocioExists(m.idnegocio).Equals(true))
                {
                    var neg = await _context.Negocios.FirstOrDefaultAsync(o => o.idnegocio == m.idnegocio);
                    neg.idnegocio = llave;
                    neg.Estatus = model.Estatus;
                    neg.calificacion = model.calificacion;
                    neg.calle = model.calle;
                    neg.ciudad = model.ciudad;
                    neg.colonia = model.colonia;
                    neg.cp = model.cp;
                    neg.descripcion = model.descripcion;
                    neg.domingoFin = model.domingoFin;
                    neg.domingoInicio = model.domingoInicio;
                    neg.domingock = model.domingock;
                    neg.email = model.email;
                    neg.especialidad = model.especialidad;
                    neg.estado = model.estado;
                    neg.estrellas = model.estrellas;
                    neg.juevesFin = model.juevesFin;
                    neg.juevesInicio = model.juevesInicio;
                    neg.latitud = model.latitud;
                    neg.longitud = model.longitud;
                    neg.lunesFin = model.lunesFin;
                    neg.lunesInicio = model.lunesInicio;
                    neg.lunesck = model.lunesck;
                    neg.martesFin = model.martesFin;
                    neg.martesInicio = model.martesInicio;
                    neg.martesck = model.martesck;
                    neg.miercolesFin = model.miercolesFin;
                    neg.miercolesInicio = model.miercolesInicio;
                    neg.miercolesck = model.miercolesck;
                    neg.municipio = model.municipio;
                    neg.nombreComercial = model.nombreComercial;
                    neg.numext = model.numext;
                    neg.numint = model.numint;
                    neg.profileImage = model.profileImage;
                    neg.razonSocial = model.razonSocial;
                    neg.rfc = model.rfc;
                    neg.sabadoFin = model.sabadoFin;
                    neg.sabadoInicio = model.sabadoInicio;
                    neg.sabadock = model.sabadock;
                    neg.telefono = model.telefono;
                    neg.tipo = model.tipo;
                    neg.viajes = model.viajes;
                    neg.viernesFin = model.viernesFin;
                    neg.viernesInicio = model.viernesInicio;
                    neg.viernesck = model.viernesck;
                    _context.Update(neg);
                    await _context.SaveChangesAsync();
                }
                else
                {

                    _context.Add(m);
                    await _context.SaveChangesAsync();
                }

            }

            return View(await _context.Negocios.ToListAsync());
        }
        [HttpPost]
        public async Task<IActionResult> Index(string searchString, string campo)
        {
            var negocios = from m in _context.Negocios
                         select m;


            switch(campo)
            {
                case "Nombre":
                    if (!String.IsNullOrEmpty(searchString))
                    {
                        negocios = negocios.Where(s => s.nombreComercial!.Contains(searchString));
                    }
                    break;
                case "Telefono":
                    if (!String.IsNullOrEmpty(searchString))
                    {
                        negocios = negocios.Where(s => s.telefono!.Contains(searchString));
                    }
                    break;
                case "Estatus":
                    if (!String.IsNullOrEmpty(searchString))
                    {
                        negocios = negocios.Where(s => s.Estatus.Equals(searchString));
                    }
                    break;
            }

            return View(await negocios.ToListAsync());
        }
        public async Task<IActionResult> Edit(int id)
        {
            negocio model;

            if (negocioExists(id).Equals(false))
            {
                return NotFound();
            }
            else
            {
                model = await _context.Negocios.FindAsync(id);

                // Consultar firebase (mostrara la info mas actual)
                model = _firebase.details(model.idnegocio, model.id);
                if (model == null)
                {
                    return NotFound();
                }

                return PartialView(model);
            }

        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, string idnegocio, [Bind("id,idnegocio,Estatus,calificacion,calle,ciudad,colonia,cp,descripcion,domingoFin,domingoInicio,domingock,email,especialidad,estado,estrellas,juevesFin,juevesInicio,latitud,longitud,lunesFin,lunesInicio,lunesck,martesFin,martesInicio,martesck,miercolesFin,miercolesInicio,miercolesck,municipio,nombreComercial,numext,numint,profileImage,razonSocial,rfc,sabadoFin,sabadoInicio,sabadock,telefono,tipo,viajes,viernesFin,viernesInicio,viernesck")] negocio negocio)
        {
            if (id != negocio.id)
            {
                return NotFound();
            }
            if (idnegocio is null)
            {
                return NotFound();
            }

            // Consultar firebase
            var model = _firebase.details(idnegocio, id);
            model.Estatus = negocio.Estatus;

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(negocio);
                    await _context.SaveChangesAsync();

                    // Actualizar en Firebase
                    _firebase.update(model.idnegocio, model.Estatus);
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!negocioExists(negocio.idnegocio))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return PartialView(negocio);
        }
        private bool negocioExists(string idnegocio)
        {
            return _context.Negocios.Any(e => e.idnegocio == idnegocio);
        }
        private bool negocioExists(int id)
        {
            return _context.Negocios.Any(e => e.id == id);
        }














        //    private readonly MyDbContext _context;
        //    private FirebaseClient _client;

        //    public negociosController(MyDbContext context, FirebaseClient client)
        //    {
        //        _context = context;
        //        _client = client;
        //    }

        //    // GET: negocios
        //    //public async Task<IActionResult> Index()
        //    //{
        //    //    return View(await _context.Negocios.ToListAsync());
        //    //}
        //    public async Task<IActionResult> Index()
        //    {
        //        // Consultar de firebase
        //        FirebaseResponse response = _client.Get("Users/");
        //        dynamic data = JsonConvert.DeserializeObject<dynamic>(response.Body);
        //        var list = new List<negocio>();
        //        foreach (var item in data)
        //        {
        //            firebaseNegocio oNeg = JsonConvert.DeserializeObject<firebaseNegocio>(((JProperty)item).Value.ToString());
        //            bool existencia = negocioExists(item.Name.ToString());
        //            if (existencia.Equals(false))
        //            {
        //                // Crear Modelo Válido y ejecutar create
        //                negocio negocioNuevo = new negocio()
        //                {
        //                    idnegocio = item.Name.ToString(),
        //                    //clave = oNeg.clave,
        //                    //correo = oNeg.correo,
        //                    //estatus = oNeg.estatus,
        //                    //nombre = oNeg.nombre,
        //                    //telefono = oNeg.telefono,
        //                };
        //                await this.Create(negocioNuevo);
        //            }
        //            else
        //            {
        //                // Crear modelo
        //                string idnegocio = item.Name.ToString();
        //                negocio negocioEditar = await _context.Negocios.FirstOrDefaultAsync(m => m.idnegocio == idnegocio);
        //                //negocioEditar.clave = oNeg.clave;
        //                //negocioEditar.correo = oNeg.correo;
        //                //negocioEditar.estatus = oNeg.estatus;
        //                //negocioEditar.nombre = oNeg.nombre;
        //                //negocioEditar.telefono = oNeg.telefono;
        //                //await this.Edit(negocioEditar);
        //            }
        //        }

        //        return View(await _context.Repartidores.ToListAsync());
        //    }
        //    private bool negocioExists(string idnegocio)
        //    {
        //        return _context.Negocios.Any(e => e.idnegocio == idnegocio);
        //    }
        //    private bool negocioExists(int id)
        //    {
        //        return _context.Negocios.Any(e => e.id == id);
        //    }


        //    // GET: negocios/Details/5
        //    public async Task<IActionResult> Details(int? id)
        //    {
        //        if (id == null)
        //        {
        //            return NotFound();
        //        }

        //        var negocio = await _context.Negocios
        //            .FirstOrDefaultAsync(m => m.id == id);
        //        if (negocio == null)
        //        {
        //            return NotFound();
        //        }

        //        return View(negocio);
        //    }
        //    private firebaseNegocio DetailsFirebase(string idFirebase)
        //    {
        //        FirebaseResponse response = _client.Get("Users/" + idFirebase);
        //        return JsonConvert.DeserializeObject<firebaseNegocio>(response.Body);
        //    }


        //    // GET: negocios/Create
        //    public IActionResult Create()
        //    {
        //        return View();
        //    }

        //    // POST: negocios/Create
        //    // To protect from overposting attacks, enable the specific properties you want to bind to.
        //    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        //    [HttpPost]
        //    [ValidateAntiForgeryToken]
        //    public async Task<IActionResult> Create([Bind("id,idnegocio,Estatus,calificacion,calle,ciudad,colonia,cp,descripcion,domingoFin,domingoInicio,domingock,email,especialidad,estado,estrellas,juevesFin,juevesInicio,latitud,longitud,lunesFin,lunesInicio,lunesck,martesFin,martesInicio,martesck,miercolesFin,miercolesInicio,miercolesck,municipio,nombreComercial,numext,numint,profileImage,razonSocial,rfc,sabadoFin,sabadoInicio,sabadock,telefono,tipo,viajes,viernesFin,viernesInicio,viernesck")] negocio negocio)
        //    {
        //        if (ModelState.IsValid)
        //        {
        //            _context.Add(negocio);
        //            await _context.SaveChangesAsync();
        //            return RedirectToAction(nameof(Index));
        //        }
        //        return View(negocio);
        //    }

        //    // GET: negocios/Edit/5
        //    public async Task<IActionResult> Edit(int? id)
        //    {
        //        if (id == null)
        //        {
        //            return NotFound();
        //        }

        //        var negocio = await _context.Negocios.FindAsync(id);

        //        if (negocio == null)
        //        {
        //            return NotFound();
        //        }
        //        else
        //        {
        //            // Consultar firebase y actualizar
        //            var negocioFirebase = DetailsFirebase(negocio.idnegocio);
        //            //negocio.clave = negocioFirebase.clave;
        //            //negocio.correo = negocioFirebase.correo;
        //            //negocio.estatus = negocioFirebase.estatus;
        //            //negocio.nombre = negocioFirebase.nombre;
        //            //negocio.telefono = negocioFirebase.telefono;
        //            //await this.Edit(negocio);
        //        }
        //        return PartialView(negocio);
        //    }

        //    // POST: negocios/Edit/5
        //    // To protect from overposting attacks, enable the specific properties you want to bind to.
        //    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        //    [HttpPost]
        //    [ValidateAntiForgeryToken]
        //    public async Task<IActionResult> Edit(int id, string idnegocio, [Bind("id,idnegocio,Estatus,calificacion,calle,ciudad,colonia,cp,descripcion,domingoFin,domingoInicio,domingock,email,especialidad,estado,estrellas,juevesFin,juevesInicio,latitud,longitud,lunesFin,lunesInicio,lunesck,martesFin,martesInicio,martesck,miercolesFin,miercolesInicio,miercolesck,municipio,nombreComercial,numext,numint,profileImage,razonSocial,rfc,sabadoFin,sabadoInicio,sabadock,telefono,tipo,viajes,viernesFin,viernesInicio,viernesck")] negocio negocio)
        //    {
        //        if (id != negocio.id)
        //        {
        //            return NotFound();
        //        }
        //        if (idnegocio is null)
        //        {
        //            return NotFound();
        //        }


        //        // Consultar firebase
        //        var model = DetailsFirebase(idnegocio);
        //        //model.estatus = negocio.estatus;
        //        //negocio.clave = model.clave;
        //        //negocio.correo = model.correo;
        //        //negocio.nombre = model.nombre;
        //        //negocio.telefono = model.telefono;

        //        if (ModelState.IsValid)
        //        {
        //            try
        //            {
        //                _context.Update(negocio);
        //                await _context.SaveChangesAsync();

        //                // Actualizar en Firebase
        //                FirebaseResponse response = _client.Update("Repartidores/" + negocio.idnegocio, model.Estatus);
        //            }
        //            catch (DbUpdateConcurrencyException)
        //            {
        //                if (!negocioExists(negocio.id))
        //                {
        //                    return NotFound();
        //                }
        //                else
        //                {
        //                    throw;
        //                }
        //            }
        //            return RedirectToAction(nameof(Index));
        //        }
        //        return View(negocio);
        //    }

        //    // GET: negocios/Delete/5
        //    public async Task<IActionResult> Delete(int? id)
        //    {
        //        if (id == null)
        //        {
        //            return NotFound();
        //        }

        //        var negocio = await _context.Negocios
        //            .FirstOrDefaultAsync(m => m.id == id);
        //        if (negocio == null)
        //        {
        //            return NotFound();
        //        }

        //        return View(negocio);
        //    }

        //    // POST: negocios/Delete/5
        //    [HttpPost, ActionName("Delete")]
        //    [ValidateAntiForgeryToken]
        //    public async Task<IActionResult> DeleteConfirmed(int id)
        //    {
        //        var negocio = await _context.Negocios.FindAsync(id);
        //        _context.Negocios.Remove(negocio);
        //        await _context.SaveChangesAsync();
        //        return RedirectToAction(nameof(Index));
        //    }

    }
}
