using Hotelier.Core.Models;
using Hotelier.Core.Services.Abstracts;
using Microsoft.AspNetCore.Mvc;

namespace Hotelier.WebApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class HotelServicesController : ControllerBase
{
    private readonly IHotelServiceService _service;

    public HotelServicesController(IHotelServiceService hotelServiceService)
    {
        _service = hotelServiceService;
    }

    [HttpGet]
    public IActionResult Get()
    {
        List<HotelService> datas = _service.GetAll();
        return Ok(datas);
    }

    [HttpGet("{id}")]
    public IActionResult Get(int id)
    {
        HotelService hotelService = _service.GetById(id);
        if (hotelService is not null)
            return Ok(hotelService);
        return NoContent();
    }

    [HttpPost]
    public IActionResult Add(HotelService hotelService)
    {
        _service.Add(hotelService);
        return Ok("Yeni Hotel Servis Kaydı Başarı ile Oluşturuldu");
    }

    [HttpPut]
    public IActionResult Update(HotelService hotelService)
    {
        _service.Update(hotelService);
        return Ok("Hotel Servis Kaydı Güncellendi");
    }

    [HttpDelete]
    public IActionResult Delete(HotelService hotelService)
    {
        _service.Delete(hotelService);
        return Ok("Hotel Servis Kaydı Silindi");
    }
}
