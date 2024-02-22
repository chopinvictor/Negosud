using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Negosud.Class;
using Negosud.Context;

namespace NegosudSite.Controllers
{
    public class ProduitsController : Controller
    {
        private readonly NegosudContext _context;

        public ProduitsController(NegosudContext context)
        {
            _context = context;
        }

        // GET: Produits
        public async Task<IActionResult> Index()
        {
            var negosudContext = _context.Produits.Include(p => p.Domaine).Include(p => p.Type);
            return View(await negosudContext.ToListAsync());
        }

        // GET: Produits/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var produit = await _context.Produits
                .Include(p => p.Domaine)
                .Include(p => p.Type)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (produit == null)
            {
                return NotFound();
            }

            return View(produit);
        }

    }
}
