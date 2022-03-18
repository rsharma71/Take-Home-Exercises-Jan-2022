using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TrainWatchSystem.BLL;
using TrainWatchSystem.Entities;

namespace TrainWebApp.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
      

       public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
            
        } 



       
    }
}