using Hotelier.Core.Models;
using Hotelier.Core.Services.Abstracts;
using Microsoft.AspNetCore.Mvc;

namespace Hotelier.WebApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class RoomsController : ControllerBase
{
    private readonly IRoomService _service;

    public RoomsController(IRoomService roomService)
    {
        _service = roomService;
    }

    [HttpGet]
    public IActionResult Get()
    {
        List<Room> rooms = _service.GetAll();
        return Ok(rooms);
    }

    [HttpGet("{id}")]
    public IActionResult Get(int id)
    {
        Room room = _service.GetById(id);
        if(room is not null)
            return Ok(room);
        return NoContent();
    }

    [HttpPost]
    public IActionResult Add(Room room)
    {
        _service.Add(room);
        return Ok("Yeni Oda Kaydı Başarı ile Oluşturuldu");
    }
    
    [HttpPut]
    public IActionResult Update(Room room)
    {
        _service.Update(room);
        return Ok("Oda Kaydı Güncellendi");
    }
    
    [HttpDelete]
    public IActionResult Delete(Room room)
    {
        _service.Delete(room);
        return Ok("Oda Kaydı Silindi");
    }
}
