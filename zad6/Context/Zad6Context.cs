using Microsoft.EntityFrameworkCore;
using zad6.Migrations;
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
    
    public DbSet<Doctor> Doctors { get; set; }
    
    public DbSet<Patient> Patients { get; set; }
   
    public DbSet<Prescription> Prescriptions { get; set; }
    
    public DbSet<PrescriptionMedicament> PrescriptionMedicaments { get; set; }
}
