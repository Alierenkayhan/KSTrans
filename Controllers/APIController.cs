using KSTrans.Services;
using KSTrans.Shared.Models;

namespace KSTrans.Controllers;

public interface ICrudController<T>
{
    Task<List<T>> GetListAsync();
}

[Route("api/[controller]")]
[ApiController]
public abstract class CrudControllerBase<T> : ControllerBase, ICrudController<T>
{
    private readonly IRepository<T> _service;

    protected CrudControllerBase(IRepository<T> service) => _service = service;

    [HttpGet]
    public async Task<List<T>> GetListAsync() => await _service.GetListAsync();
}

public class SocialMediaAccountsController : CrudControllerBase<SocialMediaAccounts>
{
    public SocialMediaAccountsController(IRepository<SocialMediaAccounts> socialMediaAccountsService) : base(socialMediaAccountsService) { }
}

public class AboutController : CrudControllerBase<About>
{
    public AboutController(IRepository<About> aboutService) : base(aboutService) { }
}
public class WhyChoosingUsController : CrudControllerBase<WhyChoosingUs>
{
    public WhyChoosingUsController(IRepository<WhyChoosingUs> whyChoosingUsService) : base(whyChoosingUsService) { }
}

public class DBLinksController : CrudControllerBase<Links>
{
    public DBLinksController(IRepository<Links> linksService) : base(linksService) { }
}