using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using zad6.Migrations;

namespace zad6.Models;

[PrimaryKey(nameof(IdMedicament), nameof(IdPrescription))]
public class PrescriptionMedicament
{
    [Key, Column(Order = 0)] public int IdMedicament { get; set; }
    [Key, Column(Order = 1)] public int IdPrescription { get; set; }
    
    public Medicament Medicament { get; set; }
    
    public Prescription Prescription { get; set; }

    [Required] public DateTime Date { get; set; }

    [Required] public DateTime DueDate { get; set; }

}