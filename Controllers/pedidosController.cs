using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using kairh_admin.Models;

namespace kairh_admin.Controllers
{
    public class pedidosController : Controller
    {
        private readonly MyDbContext _context;

        public pedidosController(MyDbContext context)
        {
            _context = context;
        }

        // GET: pedidos
        public async Task<IActionResult> Index()
        {
            // AQUI
            return View(await _context.Pedidos.ToListAsync());
        }

        //// GET: pedidos/Details/5
        //public async Task<IActionResult> Details(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var pedido = await _context.Pedidos
        //        .FirstOrDefaultAsync(m => m.id == id);
        //    if (pedido == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(pedido);
        //}

        //// GET: pedidos/Create
        //public IActionResult Create()
        //{
        //    return View();
        //}

        //// POST: pedidos/Create
        //// To protect from overposting attacks, enable the specific properties you want to bind to.
        //// For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Create([Bind("id,idpedido,fecha,fechaentregado,fecharecibido,flagRecolecta,flagprop,folio,hora,horaentregado,horarecibido,idcliente,idnegocio,idrepartidor,latentrega,lonentrega,metodopago,montoEnvio,nombreNegocio,nombrerepartidor,propina,subtotal,tarifa,telrepartidor,total,urlnegocio")] pedido pedido)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        _context.Add(pedido);
        //        await _context.SaveChangesAsync();
        //        return RedirectToAction(nameof(Index));
        //    }
        //    return View(pedido);
        //}

        //// GET: pedidos/Edit/5
        //public async Task<IActionResult> Edit(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var pedido = await _context.Pedidos.FindAsync(id);
        //    if (pedido == null)
        //    {
        //        return NotFound();
        //    }
        //    return View(pedido);
        //}

        //// POST: pedidos/Edit/5
        //// To protect from overposting attacks, enable the specific properties you want to bind to.
        //// For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Edit(int id, [Bind("id,idpedido,fecha,fechaentregado,fecharecibido,flagRecolecta,flagprop,folio,hora,horaentregado,horarecibido,idcliente,idnegocio,idrepartidor,latentrega,lonentrega,metodopago,montoEnvio,nombreNegocio,nombrerepartidor,propina,subtotal,tarifa,telrepartidor,total,urlnegocio")] pedido pedido)
        //{
        //    if (id != pedido.id)
        //    {
        //        return NotFound();
        //    }

        //    if (ModelState.IsValid)
        //    {
        //        try
        //        {
        //            _context.Update(pedido);
        //            await _context.SaveChangesAsync();
        //        }
        //        catch (DbUpdateConcurrencyException)
        //        {
        //            if (!pedidoExists(pedido.id))
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
        //    return View(pedido);
        //}

        //// GET: pedidos/Delete/5
        //public async Task<IActionResult> Delete(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var pedido = await _context.Pedidos
        //        .FirstOrDefaultAsync(m => m.id == id);
        //    if (pedido == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(pedido);
        //}

        //// POST: pedidos/Delete/5
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> DeleteConfirmed(int id)
        //{
        //    var pedido = await _context.Pedidos.FindAsync(id);
        //    _context.Pedidos.Remove(pedido);
        //    await _context.SaveChangesAsync();
        //    return RedirectToAction(nameof(Index));
        //}

        //private bool pedidoExists(int id)
        //{
        //    return _context.Pedidos.Any(e => e.id == id);
        //}
    }
}
