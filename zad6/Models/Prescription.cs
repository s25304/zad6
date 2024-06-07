using System.ComponentModel.DataAnnotations;
using zad6.Models;

namespace zad6.Migrations;

public class Prescription
{
    [Key]
    public int IdPrescription { get; set; }
    
    [MaxLength(100)]
    [Required]
    public DateTime Date { get; set; }
    
    [MaxLength(100)]
    [Required]
    public DateTime DueDate { get; set; }
    
    public Doctor Doctor { get; set; }
    
    public Patient Patient { get; set; }
    
    public ICollection<PrescriptionMedicament> PrescriptionMedicaments { get; set; }

}