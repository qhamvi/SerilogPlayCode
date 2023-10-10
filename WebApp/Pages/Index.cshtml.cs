using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApp.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            _logger.LogInformation("Information being logged");
            _logger.LogDebug("Debug being logged");
            _logger.LogError("Error being logged");
            _logger.LogWarning("Warning being logged");
            _logger.LogTrace("Trace being logged");
            _logger.LogCritical("Critical Information being logged");
        }
    }
}