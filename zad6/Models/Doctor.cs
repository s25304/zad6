using System.ComponentModel.DataAnnotations;
using zad6.Migrations;

namespace zad6.Models;

public class Doctor
{
    [Key]
    public int IdDoctor { get; set; }
    
    [MaxLength(100)]
    [Required]
    public string FirstName { get; set; }
    
    [Required]
    [MaxLength(100)]
    public string LastName { get; set; }
    
    [Required]
    [MaxLength(100)]
    public string Email { get; set; }
    
    public ICollection<Prescription> Prescriptions { get; set; }
}