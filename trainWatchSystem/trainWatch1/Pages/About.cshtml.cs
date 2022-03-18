using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TrainWatchSystem.BLL;
using TrainWatchSystem.Entities;

namespace trainWatch1.Pages
{
    public class AboutModel : PageModel
    {
        private readonly TrainWatchServices _dbVersionServices;
        public AboutModel( TrainWatchServices dbVersionServices)
        {
           
            _dbVersionServices = dbVersionServices;
        }

        public DbVersion DbVersionInfo { get; set; }

        public void OnGet()
        {
            DbVersionInfo = _dbVersionServices.GetDbVersion();
        }
    }
}
