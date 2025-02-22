namespace KSTrans.Controllers;

public class HomeController : Controller
{
    private readonly IConfiguration _configuration;

    public HomeController(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    public IActionResult Index()
    {
        ViewBag.ApiBaseUrl = _configuration["URL:BaseApiUrl"];
        ViewBag.SocialMediaApi = $"{ViewBag.ApiBaseUrl}socialmediaaccounts";
        ViewBag.AboutApi = $"{ViewBag.ApiBaseUrl}about";
        ViewBag.WhyChoosingUsApi = $"{ViewBag.ApiBaseUrl}whyChoosingUs";
        ViewBag.LinksApi = $"{ViewBag.ApiBaseUrl}dblinks";
        return View();
    }

    public IActionResult About()
    {
        return View();
    }


}

