using Filmoteca.Data;
using Filmoteca.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Filmoteca.Controllers;

public class FilmesController : Controller

{
    private readonly FilmotecaContext _context;

    public FilmesController(FilmotecaContext context)
    {
        _context = context;
    }

    // GET /Filmes
    public async Task<IActionResult> Index()
    {
        var filmes = await _context.Filmes
            .OrderBy(f => f.Titulo)
            .ToListAsync();
        return View(filmes);
    }

    // GET /Filmes/Create
    public IActionResult Create()
    {
        return View();
    }

    // POST /Filmes/Create
    [HttpPost]
    [ValidateAntiForgeryToken]

    public async Task<IActionResult> Create(Filme filme)
    {
    if (!ModelState.IsValid)
    {
         return View(filme);
    }

    _context.Filmes.Add(filme);
    await _context.SaveChangesAsync();
    return RedirectToAction(nameof(Index));
    
    }
}
