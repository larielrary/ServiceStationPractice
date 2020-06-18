using Microsoft.AspNetCore.Hosting;

[assembly: HostingStartup(typeof(ServiceStationWebApp.Areas.Identity.IdentityHostingStartup))]
namespace ServiceStationWebApp.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
            });
        }
    }
}