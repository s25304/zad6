using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using zad6.Context;
using zad6.Migrations;
using zad6.Models;
using zad6.Services;

namespace zad6.Controllers;


[ApiController]
[Route("[controller]")]
public class DoctorController : ControllerBase
{
    private readonly DoctorService _doctorService;

    public DoctorController(DoctorService doctorService)
    {
        _doctorService = doctorService;
    }
    
   

    [HttpGet(Name = "doctors")]
    public async Task<IActionResult> Get()
    {
       return Ok(await _doctorService.getAllDoctors());
    }
    
    [HttpPost(Name = "doctors")]
    public async Task<IActionResult> Post([FromBody] Doctor doctor)
    {
        return Ok(await _doctorService.addDoctor(doctor));
    }
    
    [HttpPut(Name = "doctors/{id}")]
    public async Task<IActionResult> Post(int id, [FromBody] Doctor doctor)
    {
        return Ok(await _doctorService.update(id, doctor));
    }
    
    [HttpDelete(Name = "doctors/{id}")]
    public async Task<IActionResult> Delete(int id)
    {
        return Ok(await _doctorService.delete(id));
    }
}