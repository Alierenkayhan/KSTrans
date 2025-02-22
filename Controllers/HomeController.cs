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
        ViewData["ActivePage"] = "Home";
        ViewBag.ApiBaseUrl = _configuration["URL:BaseApiUrl"];
        ViewBag.SocialMediaApi = $"{ViewBag.ApiBaseUrl}socialmediaaccounts";
        ViewBag.AboutApi = $"{ViewBag.ApiBaseUrl}about";
        ViewBag.WhyChoosingUsApi = $"{ViewBag.ApiBaseUrl}whyChoosingUs";
        ViewBag.LinksApi = $"{ViewBag.ApiBaseUrl}dblinks";
        return View();
    }

    public IActionResult About()
    {
        ViewData["ActivePage"] = "About";
        ViewData["PageTitle"] = "About Us";
        ViewData["Breadcrumbs"] = new List<(string Text, string? Url)>
    {
        ("Home", "/"),
        ("Pages", null),
        ("About Us", null)
    };
        ViewBag.ApiBaseUrl = _configuration["URL:BaseApiUrl"];
        ViewBag.SocialMediaApi = $"{ViewBag.ApiBaseUrl}socialmediaaccounts";
        ViewBag.AboutApi = $"{ViewBag.ApiBaseUrl}about";
        ViewBag.WhyChoosingUsApi = $"{ViewBag.ApiBaseUrl}whyChoosingUs";
        ViewBag.LinksApi = $"{ViewBag.ApiBaseUrl}dblinks";
        return View();
    }
    public IActionResult Services()
    {
        ViewData["ActivePage"] = "Services";
        ViewData["PageTitle"] = "Our Services";
        ViewData["Breadcrumbs"] = new List<(string Text, string? Url)>
    {
        ("Home", "/"),
        ("Pages", null),
        ("Our Services", null)
    };
        ViewBag.ApiBaseUrl = _configuration["URL:BaseApiUrl"];
        ViewBag.SocialMediaApi = $"{ViewBag.ApiBaseUrl}socialmediaaccounts";
        ViewBag.AboutApi = $"{ViewBag.ApiBaseUrl}about";
        ViewBag.WhyChoosingUsApi = $"{ViewBag.ApiBaseUrl}whyChoosingUs";
        ViewBag.LinksApi = $"{ViewBag.ApiBaseUrl}dblinks";
        return View();
    }

    public IActionResult Contact()
    {
        ViewData["ActivePage"] = "Contact";
        ViewData["PageTitle"] = "Contact";
        ViewData["Breadcrumbs"] = new List<(string Text, string? Url)>
    {
        ("Home", "/"),
        ("Pages", null),
        ("Contact", null)
    };
        ViewBag.ApiBaseUrl = _configuration["URL:BaseApiUrl"];
        ViewBag.SocialMediaApi = $"{ViewBag.ApiBaseUrl}socialmediaaccounts";
        ViewBag.AboutApi = $"{ViewBag.ApiBaseUrl}about";
        ViewBag.WhyChoosingUsApi = $"{ViewBag.ApiBaseUrl}whyChoosingUs";
        ViewBag.LinksApi = $"{ViewBag.ApiBaseUrl}dblinks";
        return View();
    }

    public IActionResult NotFound()
    {
        ViewData["ActivePage"] = "Services";
        ViewBag.ApiBaseUrl = _configuration["URL:BaseApiUrl"];
        ViewBag.SocialMediaApi = $"{ViewBag.ApiBaseUrl}socialmediaaccounts";
        ViewBag.AboutApi = $"{ViewBag.ApiBaseUrl}about";
        ViewBag.WhyChoosingUsApi = $"{ViewBag.ApiBaseUrl}whyChoosingUs";
        ViewBag.LinksApi = $"{ViewBag.ApiBaseUrl}dblinks";
        return View();
    }

}

