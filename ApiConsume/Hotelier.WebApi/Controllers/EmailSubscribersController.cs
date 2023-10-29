using Hotelier.Core.Models;
using Hotelier.Core.Services.Abstracts;
using Microsoft.AspNetCore.Mvc;

namespace Hotelier.WebApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class EmailSubscribersController : ControllerBase
{
    private readonly IEmailSubscribeService _service;

    public EmailSubscribersController(IEmailSubscribeService emailSubscribeService)
    {
        _service = emailSubscribeService;
    }

    [HttpGet]
    public IActionResult Get()
    {
        List<EmailSubscribe> emailSubscribes = _service.GetAll();
        return Ok(emailSubscribes);
    }

    [HttpGet("{id}")]
    public IActionResult Get(int id)
    {
        EmailSubscribe emailSubscribe = _service.GetById(id);
        if (emailSubscribe is not null)
            return Ok(emailSubscribe);
        return NoContent();
    }

    [HttpPost]
    public IActionResult Add(EmailSubscribe emailSubscribe)
    {
        _service.Add(emailSubscribe);
        return Ok("Yeni Eposta Bülten Kaydı Başarı ile Eklendi");
    }

    [HttpPut]
    public IActionResult Update(EmailSubscribe emailSubscribe)
    {
        _service.Update(emailSubscribe);
        return Ok("Eposta Bülten Kaydı Başarı ile Güncellendi");
    }

    [HttpDelete]
    public IActionResult Delete(EmailSubscribe emailSubscribe)
    {
        _service.Delete(emailSubscribe);
        return Ok("Eposta Bülten Kaydı Başarı ile Silindi");
    }
}
