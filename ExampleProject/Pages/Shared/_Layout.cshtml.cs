using ExampleProject.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Diagnostics;

namespace ExampleProject.Pages.Shared
{
    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public class _Layout : PageModel
    {

        private readonly ILogger<ErrorModel> _logger;
        private readonly ApplicationDbContext _db;


        public _Layout(ILogger<ErrorModel> logger, ApplicationDbContext db)
        {
            _logger = logger;
            _db = db;
        }

        public void OnGet()
        {
            _logger.LogInformation("ad");
            // _logger.LogInformation(PageContext.HttpContext.GetEndpoint().DisplayName);
            
        }
    }
}
