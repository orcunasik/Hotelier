using Hotelier.Core.Models;
using Hotelier.Core.Services.Abstracts;
using Microsoft.AspNetCore.Mvc;

namespace Hotelier.WebApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class TestimonialsController : ControllerBase
{
    private readonly ITestimonialService _service;

    public TestimonialsController(ITestimonialService testimonialService)
    {
        _service = testimonialService;
    }

    [HttpGet]
    public IActionResult Get()
    {
        List<Testimonial> testimonials = _service.GetAll();
        return Ok(testimonials);
    }

    [HttpGet("{id}")]
    public IActionResult Get(int id)
    {
        Testimonial testimonial = _service.GetById(id);
        if (testimonial is not null)
            return Ok(testimonial);
        return NoContent();
    }

    [HttpPost]
    public IActionResult Add(Testimonial testimonial)
    {
        _service.Add(testimonial);
        return Ok("Yeni Referans Kaydı Başarı ile Oluşturuldu");
    }

    [HttpPut]
    public IActionResult Update(Testimonial testimonial)
    {
        _service.Update(testimonial);
        return Ok("Referans Kaydı Güncellendi");
    }

    [HttpDelete]
    public IActionResult Delete(int id)
    {
        Testimonial testimonial = _service.GetById(id);
        _service.Delete(testimonial);
        return Ok("Referans Kaydı Silindi");
    }
}
