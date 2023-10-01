using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;

namespace SerilogPlayCode.Pages
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
            _logger.LogInformation("You requested the Index page.");
            try
            {
                for(int i = 0; i <= 100; i++)
                {
                    if(i == 50)
                    {
                        throw new Exception("this is our demo exception. ");
                    }
                    else
                    {
                        _logger.LogInformation("The value of i is {value}", i);
                    }
                }
            }
            catch(Exception ex)
            {
                _logger.LogError(ex, "We caught exception in the Index Get call.");
            }
        }
    }
}
