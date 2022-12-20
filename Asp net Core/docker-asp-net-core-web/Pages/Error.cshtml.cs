using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Diagnostics;

namespace docker_asp_net_core_web.Pages
    {
    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    [IgnoreAntiforgeryToken]
    public class ErrorModel : PageModel
        {
        public string? RequestId
            {
            get; set;
            }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);

        private readonly ILogger<ErrorModel> _logger;

        public ErrorModel (ILogger<ErrorModel> logger)
            {
            _logger = logger;
            }

        public void OnGet ()
            {
            RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier;
            }
        }
    }