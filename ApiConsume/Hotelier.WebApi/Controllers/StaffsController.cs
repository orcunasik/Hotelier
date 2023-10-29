using Hotelier.Core.Models;
using Hotelier.Core.Services.Abstracts;
using Microsoft.AspNetCore.Mvc;

namespace Hotelier.WebApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class StaffsController : ControllerBase
{
    private readonly IStaffService _service;

    public StaffsController(IStaffService staffService)
    {
        _service = staffService;
    }

    [HttpGet]
    public IActionResult Get()
    {
        List<Staff> staffs = _service.GetAll();
        return Ok(staffs);
    }

    [HttpGet("{id}")]
    public IActionResult Get(int id)
    {
        Staff staff = _service.GetById(id);
        if(staff is not null)
            return Ok(staff);
        return NoContent();
    }

    [HttpPost]
    public IActionResult Add(Staff staff)
    {
        _service.Add(staff);
        return Ok("Yeni Personel Kaydı Başarı ile Eklendi");
    }

    [HttpPut]
    public IActionResult Update(Staff staff)
    {
        _service.Update(staff);
        return Ok("Personel Kaydı Başarı ile Güncellendi");
    }

    [HttpDelete]
    public IActionResult Delete(Staff staff)
    {
        _service.Delete(staff);
        return Ok("Personel Kaydı Başarı ile Silindi");
    }
}
