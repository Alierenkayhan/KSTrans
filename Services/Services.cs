using KSTrans.DATA.DatabaseSettings;
using KSTrans.Services;
using KSTrans.Shared.Models;

public class AboutService : GenericRepository<About> { public AboutService(IOptions<DatabaseSettings> settings) : base(settings) { } }
public class LinksService : GenericRepository<Links> { public LinksService(IOptions<DatabaseSettings> settings) : base(settings) { } }
public class OurServicesService : GenericRepository<OurServices> { public OurServicesService(IOptions<DatabaseSettings> settings) : base(settings) { } }
public class SocialMediaAccountsService : GenericRepository<SocialMediaAccounts> { public SocialMediaAccountsService(IOptions<DatabaseSettings> settings) : base(settings) { } }
public class TestimonialService : GenericRepository<Testimonial> { public TestimonialService(IOptions<DatabaseSettings> settings) : base(settings) { } }
public class WhyChoosingUsService : GenericRepository<WhyChoosingUs> { public WhyChoosingUsService(IOptions<DatabaseSettings> settings) : base(settings) { } }
