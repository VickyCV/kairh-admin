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
    public class pedido_detallesController : Controller
    {
        private readonly MyDbContext _context;

        public pedido_detallesController(MyDbContext context)
        {
            _context = context;
        }

        // GET: pedido_detalles
        public async Task<IActionResult> Index()
        {
            return View(await _context.PedidosDetalle.ToListAsync());
        }

        // GET: pedido_detalles/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pedido_detalle = await _context.PedidosDetalle
                .FirstOrDefaultAsync(m => m.id == id);
            if (pedido_detalle == null)
            {
                return NotFound();
            }

            return View(pedido_detalle);
        }

        // GET: pedido_detalles/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: pedido_detalles/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("idpedido,iddetalle,cantidad,complementos,costosAdicionales,flagcomplementos,flagoptions,folioPedido,id,nombreProd,observacion,option,precioUnit,urlProd")] pedido_detalle pedido_detalle)
        {
            if (ModelState.IsValid)
            {
                _context.Add(pedido_detalle);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(pedido_detalle);
        }

        // GET: pedido_detalles/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pedido_detalle = await _context.PedidosDetalle.FindAsync(id);
            if (pedido_detalle == null)
            {
                return NotFound();
            }
            return View(pedido_detalle);
        }

        // POST: pedido_detalles/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("idpedido,iddetalle,cantidad,complementos,costosAdicionales,flagcomplementos,flagoptions,folioPedido,id,nombreProd,observacion,option,precioUnit,urlProd")] pedido_detalle pedido_detalle)
        {
            if (id != pedido_detalle.id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(pedido_detalle);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!pedido_detalleExists(pedido_detalle.id))
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
            return View(pedido_detalle);
        }

        // GET: pedido_detalles/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pedido_detalle = await _context.PedidosDetalle
                .FirstOrDefaultAsync(m => m.id == id);
            if (pedido_detalle == null)
            {
                return NotFound();
            }

            return View(pedido_detalle);
        }

        // POST: pedido_detalles/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var pedido_detalle = await _context.PedidosDetalle.FindAsync(id);
            _context.PedidosDetalle.Remove(pedido_detalle);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool pedido_detalleExists(string id)
        {
            return _context.PedidosDetalle.Any(e => e.id == id);
        }
    }
}
