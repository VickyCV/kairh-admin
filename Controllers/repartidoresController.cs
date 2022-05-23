using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using kairh_admin.Models;
using kairh_admin.Models.firebase;
using FireSharp.Interfaces;
using FireSharp.Config;
using FireSharp.Response;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using FireSharp;

namespace kairh_admin.Controllers
{
    public class repartidoresController : Controller
    {
        private readonly MyDbContext _context;
        public firebaseRepartidor _firebase { get; set; }


        public repartidoresController(MyDbContext context)
        {
            _context = context;
            _firebase = new firebaseRepartidor();
        }
        public async Task<IActionResult> Index()
        {
            // Consultar la nube
            var data = _firebase.list();
            foreach (var item in data)
            {
                MyFbContext.modelRepartidor model = JsonConvert.DeserializeObject<MyFbContext.modelRepartidor>(((JProperty)item).Value.ToString());
                string llave = item.Name.ToString();
                var m = new repartidor
                {
                    idrepartidor = llave,
                    clave = model.clave,
                    correo = model.correo,
                    estatus = model.estatus,
                    nombre = model.nombre,
                    telefono = model.telefono,
                };

                if(repartidorExists(m.idrepartidor).Equals(true))
                {
                    var rep = await _context.Repartidores.FirstOrDefaultAsync(o => o.idrepartidor == m.idrepartidor);
                    rep.idrepartidor = llave;
                    rep.clave = model.clave;
                    rep.correo = model.correo;
                    rep.estatus = model.estatus;
                    rep.nombre = model.nombre;
                    rep.telefono = model.telefono;

                    _context.Update(rep);
                    await _context.SaveChangesAsync();
                }
                else
                {

                    _context.Add(m);
                    await _context.SaveChangesAsync();
                }

            }

            return View(await _context.Repartidores.ToListAsync());
        }
        [HttpPost]
        public async Task<IActionResult> Index(string searchString, string campo)
        {
            var repartidores = from m in _context.Repartidores
                           select m;


            switch (campo)
            {
                case "Nombre":
                    if (!String.IsNullOrEmpty(searchString))
                    {
                        repartidores = repartidores.Where(s => s.nombre!.Contains(searchString));
                    }
                    break;
                case "Telefono":
                    if (!String.IsNullOrEmpty(searchString))
                    {
                        repartidores = repartidores.Where(s => s.telefono!.Contains(searchString));
                    }
                    break;
                case "Estatus":
                    if (!String.IsNullOrEmpty(searchString))
                    {
                        repartidores = repartidores.Where(s => s.estatus.Equals(searchString));
                    }
                    break;
            }

            return View(await repartidores.ToListAsync());
        }
        public async Task<IActionResult> Edit(int id)
        {
            repartidor model;

            if (repartidorExists(id).Equals(false))
            {
                return NotFound();
            }
            else
            {
                model = await _context.Repartidores.FindAsync(id);

                // Consultar firebase (mostrara la info mas actual)
                model = _firebase.details(model.idrepartidor, model.id);
                if (model == null)
                {
                    return NotFound();
                }

                return PartialView(model);
            }

        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, string idrepartidor, [Bind("id,idrepartidor,clave,correo,estatus,nombre,telefono")] repartidor repartidor)
        {
            if (id != repartidor.id)
            {
                return NotFound();
            }
            if (idrepartidor is null)
            {
                return NotFound();
            }

            // Consultar firebase
            var model = _firebase.details(idrepartidor, id);
            model.estatus = repartidor.estatus;

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(repartidor);
                    await _context.SaveChangesAsync();

                    // Actualizar en Firebase
                    _firebase.update(model.idrepartidor, model.estatus);
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!repartidorExists(repartidor.idrepartidor))
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
            return PartialView(repartidor);
        }
        private bool repartidorExists(string idrepartidor)
        {
            return _context.Repartidores.Any(e => e.idrepartidor == idrepartidor);
        }
        private bool repartidorExists(int id)
        {
            return _context.Repartidores.Any(e => e.id == id);
        }

        //private bool repartidorExists(int id)
        //{
        //    return _context.Repartidores.Any(e => e.id == id);
        //}



        ////public async Task<IActionResult> CreateInt([Bind("id,idrepartidor,clave,correo,estatus,nombre,telefono")] repartidor repartidor)
        ////{
        ////    if (ModelState.IsValid)
        ////    {
        ////        _context.Add(repartidor);
        ////        await _context.SaveChangesAsync();
        ////        //return RedirectToAction(nameof(Index));
        ////    }
        ////    //return View(repartidor);
        ////    return RedirectToAction(nameof(Index));
        ////}
        //private async Task<IActionResult> EditInt(repartidor repartidor)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        try
        //        {
        //            // Consultar firebase
        //            //var model = _firebase.details(repartidor.idrepartidor, repartidor.id);

        //            _context.Update(repartidor);
        //            await _context.SaveChangesAsync();
        //        }
        //        catch (DbUpdateConcurrencyException)
        //        {
        //            if (!repartidorExists(repartidor.id))
        //            {
        //                return NotFound();
        //            }
        //            else
        //            {
        //                throw;
        //            }
        //        }
        //        return RedirectToAction(nameof(Index));
        //    }
        //    return RedirectToAction(nameof(Index));
        //}
        //// GET: repartidores
        ////public async Task<IActionResult> Index()
        //public async Task<IActionResult> Index()
        //{
        //    // Consultar de firebase
        //    ////_firebase._client = new FireSharp.FirebaseClient(config);
        //    //FirebaseResponse response = _firebase.client.Get("Repartidores");
        //    //dynamic data = JsonConvert.DeserializeObject<dynamic>(response.Body);
        //    var list = _firebase.list();
        //    //sincronizar(list);


        //    foreach (var item in list)
        //    {
        //        repartidor nuevo = new repartidor();
        //        nuevo = item;
        //        //bool existencia = repartidorExists(item.idrepartidor.ToString());
        //        item.id = _context.Repartidores.FirstOrDefault(m => m.idrepartidor == item.idrepartidor).id;

        //        if (item.id<=0)
        //        {
        //            _context.Add(item);
        //            await _context.SaveChangesAsync();
        //        }
        //        else
        //        {
        //            //item.id = clave(item.idrepartidor);
        //            //var nuevo = item;
        //            //nuevo.id = _context.Repartidores.FirstOrDefault(m => m.idrepartidor == item.idrepartidor).id;
        //            nuevo.id = item.id;

        //            _context.Update(nuevo);
        //            await _context.SaveChangesAsync();
        //        }
        //    }

        //    //foreach (var item in data)
        //    //{
        //    //    _firebase.fbRepartidor oRep = JsonConvert.DeserializeObject<_firebase.fbRepartidor>(((JProperty)item).Value.ToString());
        //    //    bool existencia = repartidorExists(item.Name.ToString());
        //    //    if (existencia.Equals(false))
        //    //    {
        //    //        // Crear Modelo Válido y ejecutar create
        //    //        repartidor repartidorNuevo = new repartidor()
        //    //        {
        //    //            idrepartidor = item.Name.ToString(),
        //    //            clave = oRep.clave,
        //    //            correo = oRep.correo,
        //    //            estatus = oRep.estatus,
        //    //            nombre = oRep.nombre,
        //    //            telefono = oRep.telefono,
        //    //        };
        //    //        await this.Create(repartidorNuevo);
        //    //    }
        //    //    else
        //    //    {
        //    //        // Crear modelo
        //    //        string idrepartidor = item.Name.ToString();
        //    //        repartidor repartidorEditar = await _context.Repartidores.FirstOrDefaultAsync(m => m.idrepartidor == idrepartidor);
        //    //        repartidorEditar.clave = oRep.clave;
        //    //        repartidorEditar.correo = oRep.correo;
        //    //        repartidorEditar.estatus = oRep.estatus;
        //    //        repartidorEditar.nombre = oRep.nombre;
        //    //        repartidorEditar.telefono = oRep.telefono;
        //    //        await this.Edit(repartidorEditar);
        //    //    }
        //    //}

        //    return View(await _context.Repartidores.ToListAsync());
        //}


        //// GET: repartidores/Details/5
        //public async Task<IActionResult> Details(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var repartidor = await _context.Repartidores
        //        .FirstOrDefaultAsync(m => m.id == id);
        //    if (repartidor == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(repartidor);
        //}

        //// GET: repartidores/Create
        //public IActionResult Create()
        //{
        //    return View();
        //}

        //// POST: repartidores/Create
        //// To protect from overposting attacks, enable the specific properties you want to bind to.
        //// For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Create([Bind("id,idrepartidor,clave,correo,estatus,nombre,telefono")] repartidor repartidor)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        _context.Add(repartidor);
        //        await _context.SaveChangesAsync();
        //        return RedirectToAction(nameof(Index));
        //    }
        //    return View(repartidor);
        //}

        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //// GET: repartidores/Edit/5
        //public async Task<IActionResult> Edit(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var model = await _context.Repartidores.FindAsync(id);

        //    if (model == null)
        //    {
        //        return NotFound();
        //    }
        //    else
        //    {
        //        // Consultar firebase y actualizar
        //        model = _firebase.details(model.idrepartidor, model.id);
        //        if (model == null)
        //        {
        //            return NotFound();
        //        }

        //        _context.Update(model);
        //        await _context.SaveChangesAsync();
        //    }
        //    return PartialView(model);
        //}

        //// Método interno para sincronizar catalogo desde index

        //// POST: repartidores/Edit/5
        //// To protect from overposting attacks, enable the specific properties you want to bind to.
        //// For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Edit(int id, string idrepartidor, [Bind("id,idrepartidor,clave,correo,estatus,nombre,telefono")] repartidor repartidor)
        //{
        //    if (id != repartidor.id)
        //    {
        //        return NotFound();
        //    }
        //    if (idrepartidor is null)
        //    {
        //        return NotFound();
        //    }

        //    // Consultar firebase
        //    var model = _firebase.details(idrepartidor, id);
        //    model.estatus = repartidor.estatus;

        //    if (ModelState.IsValid)
        //    {
        //        try
        //        {
        //            _context.Update(repartidor);
        //            await _context.SaveChangesAsync();

        //            // Actualizar en Firebase
        //            _firebase.update(model.idrepartidor, model.estatus);

        //            //client = new FireSharp.FirebaseClient(config);
        //            //FirebaseResponse response = client.Update("Repartidores/" + repartidor.idrepartidor, model);
        //        }
        //        catch (DbUpdateConcurrencyException)
        //        {
        //            if (!repartidorExists(repartidor.id))
        //            {
        //                return NotFound();
        //            }
        //            else
        //            {
        //                throw;
        //            }
        //        }
        //        return RedirectToAction(nameof(Index));
        //    }
        //    return PartialView(repartidor);
        //}




        //// GET: repartidores/Delete/5
        //public async Task<IActionResult> Delete(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var repartidor = await _context.Repartidores
        //        .FirstOrDefaultAsync(m => m.id == id);
        //    if (repartidor == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(repartidor);
        //}

        //// POST: repartidores/Delete/5
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> DeleteConfirmed(int id)
        //{
        //    var repartidor = await _context.Repartidores.FindAsync(id);
        //    _context.Repartidores.Remove(repartidor);
        //    await _context.SaveChangesAsync();
        //    return RedirectToAction(nameof(Index));
        //}

    }
}
