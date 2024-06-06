using Microsoft.EntityFrameworkCore;
using zad6.Models;

namespace zad6.Context;

public class Zad6Context : DbContext
{

    public Zad6Context()
    {
        
    }

    public Zad6Context(DbContextOptions<Zad6Context> options) : base(options)
    {
        
    }
    
    public DbSet<Medicament> Medicaments { get; set; }
}