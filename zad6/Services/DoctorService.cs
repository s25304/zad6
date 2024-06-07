using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using zad6.Context;
using zad6.Models;

namespace zad6.Services;

public class DoctorService
{
    private readonly Zad6Context _context;
    
    public DoctorService(Zad6Context context)
    {
        _context = context;
    }
    
    
    public async Task<IEnumerable<Doctor>> getAllDoctors()
    {
        return await _context.Doctors.ToListAsync();
    }
    public async Task<Doctor> addDoctor(Doctor doctor)
    {
        _context.AddAsync(doctor);
        _context.SaveChangesAsync();
        return doctor;
    }
    public async Task<Doctor> update(int id, Doctor doctor)
    {
        doctor.IdDoctor = id;
        _context.Doctors.Update(doctor);
        _context.SaveChangesAsync();
        return doctor;
    }
    public async Task<int> delete(int id)
    {
        var doctor = await _context.Doctors.FindAsync(id);
        _context.Doctors.Remove(doctor);
        await _context.SaveChangesAsync();
        return id;
    }
}