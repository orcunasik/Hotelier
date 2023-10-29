using Hotelier.Core.Models;
using Hotelier.Core.Repositories.Abstracts;
using Hotelier.Core.Services.Abstracts;

namespace Hotelier.Service.Managers;

public class TestimonialManager : ITestimonialService
{
    private readonly ITestimonialRepository _repository;

    public TestimonialManager(ITestimonialRepository testimonialRepository)
    {
        _repository = testimonialRepository;
    }

    public void Add(Testimonial entity)
    {
        _repository.Insert(entity);
    }

    public void Delete(Testimonial entity)
    {
        _repository.Delete(entity);
    }

    public List<Testimonial> GetAll()
    {
        return _repository.GetList();
    }

    public Testimonial GetById(int id)
    {
        return _repository.GetById(id);
    }

    public void Update(Testimonial entity)
    {
        _repository.Update(entity);
    }
}
