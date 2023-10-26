using Hotelier.Core.Models;
using Hotelier.Core.Repositories.Abstracts.Base;
using Hotelier.Core.Services.Abstracts;
using Hotelier.Service.Managers.Base;

namespace Hotelier.Service.Managers;

public class TestimonialManager : EntityService<Testimonial>, ITestimonialService
{
    public TestimonialManager(IEntityRepository<Testimonial> repository) : base(repository)
    {
    }
}
