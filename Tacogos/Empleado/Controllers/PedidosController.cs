using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Empleado.Models;

namespace Empleado.Controllers
{
    public class PedidosController : Controller
    {
        private readonly TacogoBdContext _context;

        public PedidosController(TacogoBdContext context)
        {
            _context = context;
        }

        // GET: Pedidos
        public async Task<IActionResult> Index()
        {
            var tacogoBdContext = _context.Pedidos.Include(p => p.IdClienteNavigation).Include(p => p.IdEmpleadoNavigation).Include(p => p.IdEstadoNavigation);
            return View(await tacogoBdContext.ToListAsync());
        }

        // GET: Pedidos/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pedido = await _context.Pedidos
                .Include(p => p.IdClienteNavigation)
                .Include(p => p.IdEmpleadoNavigation)
                .Include(p => p.IdEstadoNavigation)
                .FirstOrDefaultAsync(m => m.IdPedido == id);
            if (pedido == null)
            {
                return NotFound();
            }

            return View(pedido);
        }

        // GET: Pedidos/Create
        public IActionResult Create()
        {
            ViewData["IdCliente"] = new SelectList(_context.Clientes, "IdCliente", "IdCliente");
            ViewData["IdEmpleado"] = new SelectList(_context.Empleados, "IdEmpleado", "IdEmpleado");
            ViewData["IdEstado"] = new SelectList(_context.Estados, "IdEstado", "IdEstado");
            return View();
        }

        // POST: Pedidos/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdPedido,FechaPedido,IdCliente,IdEmpleado,IdEstado")] Pedido pedido)
        {
            pedido.IdClienteNavigation= (from c in _context.Clientes where c.IdCliente== pedido.IdCliente select c).First();
            pedido.IdEmpleadoNavigation=(from e in _context.Empleados where e.IdEmpleado == pedido.IdEmpleado select e).First();
            pedido.IdEstadoNavigation= (from es in _context.Estados where es.IdEstado == pedido.IdEstado select es).First();

                Console.WriteLine("hola");
                _context.Add(pedido);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
        }

        // GET: Pedidos/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pedido = await _context.Pedidos.FindAsync(id);
            if (pedido == null)
            {
                return NotFound();
            }
            ViewData["IdCliente"] = new SelectList(_context.Clientes, "IdCliente", "IdCliente", pedido.IdCliente);
            ViewData["IdEmpleado"] = new SelectList(_context.Empleados, "IdEmpleado", "IdEmpleado", pedido.IdEmpleado);
            ViewData["IdEstado"] = new SelectList(_context.Estados, "IdEstado", "IdEstado", pedido.IdEstado);
            return View(pedido);
        }

        // POST: Pedidos/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdPedido,FechaPedido,IdCliente,IdEmpleado,IdEstado")] Pedido pedido)
        {
            if (id != pedido.IdPedido)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(pedido);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PedidoExists(pedido.IdPedido))
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
            ViewData["IdCliente"] = new SelectList(_context.Clientes, "IdCliente", "IdCliente", pedido.IdCliente);
            ViewData["IdEmpleado"] = new SelectList(_context.Empleados, "IdEmpleado", "IdEmpleado", pedido.IdEmpleado);
            ViewData["IdEstado"] = new SelectList(_context.Estados, "IdEstado", "IdEstado", pedido.IdEstado);
            return View(pedido);
        }

        // GET: Pedidos/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pedido = await _context.Pedidos
                .Include(p => p.IdClienteNavigation)
                .Include(p => p.IdEmpleadoNavigation)
                .Include(p => p.IdEstadoNavigation)
                .FirstOrDefaultAsync(m => m.IdPedido == id);
            if (pedido == null)
            {
                return NotFound();
            }

            return View(pedido);
        }

        // POST: Pedidos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var pedido = await _context.Pedidos.FindAsync(id);
            if (pedido != null)
            {
                _context.Pedidos.Remove(pedido);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PedidoExists(int id)
        {
            return _context.Pedidos.Any(e => e.IdPedido == id);
        }
    }
}
