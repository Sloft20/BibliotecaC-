using Filmoteca.Models;
using Microsoft.EntityFrameworkCore;

namespace Filmoteca.Data;

public class FilmotecaContext : DbContext
{
 public FilmotecaContext(DbContextOptions<FilmotecaContext> options)
 : base(options) { }
 
 public DbSet<Filme> Filmes => Set<Filme>();
}
